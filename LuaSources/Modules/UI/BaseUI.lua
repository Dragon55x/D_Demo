local BaseUI = {}

-- 创建对象时调用
function BaseUI:ctor()
end

-- 界面初始化时调用
function BaseUI:init()
end

-- 界面关闭时调用
function BaseUI:OnClose()
end

function BaseUI:_OnDestroy()
    if self.Root then
        self.Root:Destroy()
    end
end

-- 界面关闭
function BaseUI:CloseUI()
    UIManager:CloseUI(self)
end

return BaseUI