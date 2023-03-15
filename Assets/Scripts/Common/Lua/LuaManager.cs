using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

namespace DG
{
    public class LuaManager : ManagerBase
    {
        static LuaManager instance;
        LuaManager() { }
        public static LuaManager Create(object caller)
        {
            Debug.Assert(caller.GetType() == typeof(Main), "Only Main can call this method once!");
            instance = new LuaManager();
            return instance;
        }
        /// <summary>
        ///  Lua文件根目录
        /// </summary>
        public const string LUA_PATH_NAME = "LuaSources";
        /// <summary>
        /// Lua文件缓存
        /// </summary>
        private Dictionary<string, byte[]> LuaScriptsDict = new Dictionary<string, byte[]>();
        /// <summary>
        /// lua Start委托
        /// </summary>
        [CSharpCallLua]
        public delegate void LuaStartAction(LuaTable luaTable);
        /// <summary>
        /// lua Update委托
        /// </summary>
        [CSharpCallLua]
        public delegate void LuaUpdateAction(LuaTable luaTable, float time);
        //public delegate void LuaUpdateAction(LuaTable luaTable, float time, float deltaTime, float realTime, int frameCount);

        public LuaEnv Env;

        public override void Init()
        {
            Env = new LuaEnv();
            Env.AddLoader(OnLoader);
            InitScripts();
        }

        public void LuaStart()
        {
            var table = Env.DoString("return require 'GameStart'")[0] as LuaTable;
            LuaStartAction luaStartAction = table.Get<LuaStartAction>("Start");
            LuaUpdateAction luaUpdateAction = table.Get<LuaUpdateAction>("Update");
            luaStartAction(table);
            luaUpdateAction(table, 0f);
            //luaUpdateAction(table, Time.time, Time.deltaTime, Time.realtimeSinceStartup, Time.frameCount);
        }

        void InitScripts()
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

        public override void Update()
        {
            //LuaUpdateAction(Time.time, Time.deltaTime, Time.realtimeSinceStartup, Time.frameCount);
        }

        private byte[] OnLoader(ref string filepath)
        {
            LuaScriptsDict.TryGetValue(filepath, out byte[] scriptBytes);
            return scriptBytes;
        }
    }
}


