using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.HotFix.Enum;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.HotFix.Module.Scene
{
    /************************* 
	* 作者： wenyueyun 
	* 时间： 2018/6/26 14:01:26 
	* 描述： BaseScene 
	*************************/
    public class BaseScene
    {
        protected AsyncOperation sceneAsync;
        protected ESceneType sceneType;
        protected string sceneName;
        protected bool sceneLoaded;
        public BaseScene()
        {
            this.sceneType = ESceneType.None;
        }

        public virtual void Update()
        {
            if(!this.sceneLoaded)
            {
                if (this.sceneAsync == null) return;

                if(this.sceneAsync.isDone)
                {
                    this.SceneLoaded();
                }
            }
        }

        public virtual void LateUpdate()
        {

        }

        public virtual void Begin()
        {
            this.sceneAsync = SceneManager.LoadSceneAsync(sceneName);
        }

        protected virtual void SceneLoaded()
        {

        }


        public virtual void End()
        {
            this.sceneAsync = null;
            this.sceneLoaded = false;
        }

        public virtual void LoadRes()
        {

        }
    }
}
