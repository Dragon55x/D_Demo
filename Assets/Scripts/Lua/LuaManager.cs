using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

public static class LuaManager
{
    public const string LUA_PATH_NAME = "LuaSources";

    public static LuaEnv Env;

    private static Dictionary<string, byte[]> LuaScriptsDict = new Dictionary<string, byte[]>();

    
    public static void Initialize()
    {
        Env = new LuaEnv();
        //Env.AddLoader(OnLoader);
    }

    //private static byte[] OnLoader(ref string fileName)
    //{
        
    //}
}
