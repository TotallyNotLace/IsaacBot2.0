This mod will capture chat input, and then output it to the game! It uses some external files that are all included in the mod folder to determine the commands that it processes.

To get the bot to work, you need 3 things:

A target Twitch channel: this is the channel you are likely streaming from

A Twitch username: You'll need to stream somewhere.

The next step, you need to right click on isaac in steam, and add this to your launch options: "--luadebug" without the quotes. This allows the game to access the queue of commands from Twitch.

After this, place the entire Twitch folder into your Isaac mod folder.
This is located in different places depending on your Isaac version. You can get to the Repentance location by browsing local files from within steam.

Location: \SteamLibrary\steamapps\common\The Binding of Isaac Rebirth\mods\


****STEAM WORKSHOP USERS****
If you are downloading this from the steam workshop, you will have to acquire the chatbot.exe separately. Steam is not a fan of uploading .exe files (with good reason).
I recommend getting it from either the support discord, or the Modding of Isaac website. The link to the mod there is https://moddingofisaac.com/mod/3608/twitch-vs-isaac. It contains the full package, to include all required files. Add the rest of the mod files from that 7z file to your twitch mod folder.
****STEAM WORKSHOP USERS****

Then, inside of that Twitch folder, is an EXE Labeled IsaacChatBot.exe. Launch this. Paste the twitch data you gathered into the fields, and then hit connect.

Launch Isaac, and then enable the mod if its not. You will now the mod is working, if the text "Twitch Chat bot is live!" is at the bottom left corner.

Chat commands:
Chat commands are located in Chatpoll.txt. If you have Isaac Lua scripting knowledge, you can add more commands! or remove some. if you are adding/removing, all three files need the same number of lines. Reach out in the support channel for help with this if you need.

Command Queue:
If there are a lot of unexecuted commands, and your run ends (ie you die, you win, you lose power and your computer turns off), the commands will carry over into the next run.

Known Bugs:
3 letter commands do not work. If you use the default command list, this will not come up, but if you go about modifying it, then it will.

Multiplier:
The multiplier allows for viewers to use commands like "99x dipman", to put up to 99 commands into the queue. Don't try 0x dipman. It knows....

Spam Control Update:
1.5 adds a new way of controlling having the same commands spammed over and over. Every single item has their own individual cooldown.


The Multiplier has been causing strange crashes on larger numbers. The bot.exe crashes, but the game will continue to run. to fix this, close and re-open the bot.exe. Multiplier is toggle-able. Use at your own risk.

https://discord.gg/Yrgs4a5wwq is our community discord. Come by! Say Hello!
