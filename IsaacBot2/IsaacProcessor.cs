using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using TwitchLib.Api.Helix.Models.Streams.GetStreamMarkers;

namespace IsaacBot2
{
    public class IsaacProcessor
    {

        //stop event for errors found.
        public event Action stopCalled;

        //console event
        public event Action<string> CallConsole;

        //this is the list that holds the loaded command objects
        private List<UserCommand> _activeCommands = new List<UserCommand>();

        //this bool is set on contruction to control spam
        private bool _cooldownsAreEnabled = true;

        //this is the oven.bake file
        private string ovenFile;

        //function to load list from CSV
        public List<UserCommand> LoadCommands(string filePath)
        {
            var commands = new List<UserCommand>();

            try
            {
                using (var reader = new StreamReader(filePath))
                using (var parser = new TextFieldParser(reader))
                {
                    parser.SetDelimiters(","); // Set delimiter as comma
                    parser.HasFieldsEnclosedInQuotes = true;

                    bool isHeader = true;

                    while (!parser.EndOfData)
                    {
                        var values = parser.ReadFields(); // Reads a full row, respecting quotes
                        if (isHeader) // Skip the header row
                        {
                            isHeader = false;
                            continue;
                        }

                        if (values != null && values.Length == 3 && int.TryParse(values[1], out int cooldown))
                        {
                            commands.Add(new UserCommand(values[0], cooldown, values[2]));
                        }
                        else
                        {
                            Console.WriteLine($"Skipping invalid row: {string.Join(",", values ?? new string[0])}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV: {ex.Message}");
                stopCalled?.Invoke();
            }

            return commands;
        }

        //contructor (duh). Here we will set our configuration from the forms app and initialize some of our hard vars.

        public void ActivateProcessor(Action<string> consoleEvent)
        {
            //first we define the oven.bake file. This file should exist in the same folder as the main.lua and the exe for the bot
            ovenFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "oven.bake");

            //load commands into a list. This will look for a commands.csv in the same directory as the exe. 
            _activeCommands = LoadCommands(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "commands.csv"));

            //handling for if the commands file is empty. This will call an event that safely stops the bot. 
            if (_activeCommands.Count == 0)
            {
                stopCalled?.Invoke();
            }

            CallConsole = consoleEvent;
            CallConsole.Invoke("Isaac Processor is now online.");
        }

        public void CheckCommand(string inputCommand)
        {
            //check command against our active command list
            foreach (var command in _activeCommands) 
            {
                if(inputCommand.Contains(command.Text))
                {
                    Console.WriteLine("Command is valid");
                    if(command.UseTime <  DateTime.Now || _cooldownsAreEnabled)
                    {
                        Console.WriteLine("command is off of cooldown");
                        CallConsole.Invoke("Command incoming!");
                        command.UseTime = DateTime.UtcNow.AddSeconds(command.Cooldown);
                        BakeCommand(command.Code);
                    }
                }
            }
        }

        public void BakeCommand(string scriptToBake)
        {
            using (StreamWriter writer = new StreamWriter(ovenFile, append: true))
            {
                writer.WriteLine(scriptToBake);
            }
        }

    }

    public class UserCommand
    {
        public string Text { get; set; }
        public int Cooldown { get; set; }
        public string Code { get; set; }
        public DateTime UseTime { get; set; }

        public UserCommand(string text, int cooldown, string code)
        {
            Text = text;
            Cooldown = cooldown;
            Code = code;
            UseTime = DateTime.UtcNow;
        }
    }

}
