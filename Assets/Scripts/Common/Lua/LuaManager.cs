using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

namespace DG
{
    public static class LuaManager
    {
        /// <summary>
        ///  Lua文件根目录
        /// </summary>
        public const string LUA_PATH_NAME = "LuaSources";
        /// <summary>
        /// Lua文件缓存
        /// </summary>
        private static Dictionary<string, byte[]> LuaScriptsDict = new Dictionary<string, byte[]>();
        /// <summary>
        /// lua Update委托
        /// </summary>
        [CSharpCallLua]
        public static Action luaUpdateAction;

        public static LuaEnv Env;

        public static void Init()
        {
            Env = new LuaEnv();
            Env.AddLoader(OnLoader);
            InitScripts();
        }

        public static void LuaStart()
        {
            var table = Env.DoString("return require 'GameStart'")[0] as LuaTable;
            table.Get("Update", out luaUpdateAction);
            luaUpdateAction();
        }

        static void InitScripts()
        {
#if !USE_AB
            var trimCount = LUA_PATH_NAME.Length + 1;
            foreach (var item in Directory.GetFiles(LUA_PATH_NAME, "*.lua", SearchOption.AllDirectories))
            {
                LuaScriptsDict.Add(item.Substring(trimCount, item.Length - (trimCount + 4)).Replace(Path.DirectorySeparatorChar, '.'), File.ReadAllBytes(item));   
            }
#else
           
#endif
        }

        public static void Update()
        {
            luaUpdateAction();
        }

        private static byte[] OnLoader(ref string filepath)
        {
            LuaScriptsDict.TryGetValue(filepath, out byte[] scriptBytes);
            return scriptBytes;
        }

        public static void Print()
        {
            Debug.Log("Print");
        }
    }
}


