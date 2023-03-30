require ("Global.GlobalDefine")
local GameStart = {}

function GameStart:Start()
    self:InitModules()
    self:StartLogin()
end

function GameStart:Update()
    GameTime.Time = CS.UnityEngine.Time.time
    GameTime.DeltaTime = CS.UnityEngine.Time.deltaTime
    GameTime.RealTime = CS.UnityEngine.Time.realtimeSinceStartup
    GameTime.FrameCount = CS.UnityEngine.Time.frameCount
    TimeManager:Update()
end

function GameStart:InitModules()
    
end

function GameStart:StartLogin()
    
end

GameStart:Start()

return GameStart