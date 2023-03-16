using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

namespace DG
{
    public class LuaManager : ManagerBase<LuaManager>
    {
        /// <summary>
        ///  Lua文件根目录
        /// </summary>
        public const string LUA_PATH_NAME = "LuaSources";
        /// <summary>
        /// Lua文件缓存
        /// </summary>
        private Dictionary<string, byte[]> LuaScriptsDict = new Dictionary<string, byte[]>();
        /// <summary>
        /// lua Update委托
        /// </summary>
        [CSharpCallLua]
        public Action LuaUpdateAction;

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
            table.Get("Update", out LuaUpdateAction);
            LuaUpdateAction();
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
            LuaUpdateAction();
        }

        private byte[] OnLoader(ref string filepath)
        {
            LuaScriptsDict.TryGetValue(filepath, out byte[] scriptBytes);
            return scriptBytes;
        }
    }
}


