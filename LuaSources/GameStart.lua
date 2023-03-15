local GameStart = {}

function GameStart:Start()
    print("Hello World!!")
end

-- function GameStart:Update(time, deltaTime, realTime, frameCount)
--     print(time.." "..deltaTime.." "..realTime.." "..frameCount)
-- end

function GameStart:Update(time)
    print("Update")
end

return GameStart