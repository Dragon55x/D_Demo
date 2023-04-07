GameTime = require("Global.GameTime")
TimeManager = require("Common.TimeManager")
UIMnager = require("Common.UIManager")

function Class(className ,baseClass)
    local cls = {className = className}

    if baseClass then
        local baseType = type(baseClass)
        assert(baseType == "table",
            string.format("className: \"%s\" | class create Error because baseClass \"%s\" is not table", className, baseClass))

        cls.base = baseClass
        setmetatable(cls, {__index = baseClass})
    end

    cls.New = function (...)
        local instance = setmetatable({}, {__index = cls})
        
        local create
        create = function (c, ...)
            if c.base then
                create(c.base, ...)
            end
            
            if c.ctor then
                c.ctor(instance, ...)
            end
        end
        create(instance, ...)
        
        return instance
    end

    return cls
end