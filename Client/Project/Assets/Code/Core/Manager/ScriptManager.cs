using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Core.Common;
using Game.Core.Interface;

namespace Game.Core.Manager
{
    /************************* 
	* 作者： wenyueyun 
	* 时间： 2018/6/26 15:22:05 
	* 描述： ScriptManager 
	*************************/
    public class ScriptManager : Singleton<ScriptManager>
    {
        private IScriptHandler script;
        private readonly string assemblyName = "HotFix";

        public void Initialize()
        {
            if (script != null)
            {
                script.Initialize();
            }
        }

        public void UnInitialize()
        {
            if (script != null)
            {
                script.Uninitialize();
            }
        }

        public void Update()
        {

        }

        public void LateUpdate()
        {

        }

        private void LoadDll()
        {

        }
    }
}
