local mod = RegisterMod("Twitch", 1) 

function startthemodfiles()
player = Isaac.GetPlayer(0)
screenpos = Isaac.WorldToScreen(player.Position)
end

commandrecievedtext = "The Chat has spoken..."
awaitingcommandtext = "Twitch Chat bot is live!"
emptycommandtext = "Twitch Chat bot is live!"
nocommandsinqueue = "print(emptycommandtext)"
themaintimerbool = 0
thetimercounter = 0
thetimermax = 30
commandtxt = "oven.bake"
thedebugstring = emptycommandtext
commandtoexecute = "print(emptycommandtext)"

function script_path()
   local str = debug.getinfo(2, "S").source:sub(2)
   return str:match("(.*/)")
end

function readthetopline(lineno)
local n=0
for l in io.lines(script_path() .. commandtxt) do
   n=n+1
   if n==lineno then 
   	commandtoexecute = l; 
   	   	if commandtoexecute == nil then
   		thedebugstring =awaitingcommandtext
   		else
   		thedebugstring = commandrecievedtext
   		end
   	end
   	break end
end
function executethecommand()
	local room = Game():GetRoom()
	arandomspot = room:GetRandomPosition(0)

	load(commandtoexecute)()
	commandtoexecute = nocommandsinqueue

	
end


function remove( filename, starting_line, num_lines )
    local fp = io.open( filename, "r" )

    if fp == nil then return nil end
 
    content = {}
    i = 1;
    for line in fp:lines() do
        if i < starting_line or i >= starting_line + num_lines then
	    content[#content+1] = line
	   
	    
	end
	i = i + 1
    end
 
    if i > starting_line and i < starting_line + num_lines then

    end
 
    fp:close()
    fp = io.open( filename, "w+" )
 
    for i = 1, #content do
	fp:write( string.format( "%s\n", content[i] ) )
    end
 
    fp:close()
end




local function processtimerevents()
		thetimercounter = thetimercounter + 1

		if (thetimercounter > thetimermax) then
			thedebugstring = awaitingcommandtext
			themaintimerbool = 0
			thetimercounter = 0
		end
	end


local function debugtextdisplay(_mod)
Isaac.RenderText(thedebugstring, 10, 250, 0, 255, 255, 255)

end

function mod:Twitch()
	
	if (themaintimerbool == 1) then
		processtimerevents()
	else 
		
		readthetopline(1)
		executethecommand()
		remove(script_path() .. commandtxt,1,1)
		themaintimerbool=1

		
	end

end

mod:AddCallback(ModCallbacks.MC_POST_PLAYER_INIT, startthemodfiles)
mod:AddCallback(ModCallbacks.MC_POST_UPDATE, mod.Twitch)
mod:AddCallback(ModCallbacks.MC_POST_RENDER, debugtextdisplay)
