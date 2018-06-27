using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.HotFix.Module.Scene;
using Game.HotFix.Enum;
using Game.HotFix.Common;
namespace Game.HotFix.Manager
{
    /************************* 
	* 作者： wenyueyun 
	* 时间： 2018/6/26 14:00:40 
	* 描述： SceneManager 
	*************************/
    public class SceneManager:HotFixSingleton<SceneManager>
    {
        private ESceneType curSceneType;
        private BaseScene curScene;
        private StartScene starScene;
        private LoginScene loginScene;
        private MainScene mainScene;
        private BattleScene battleScene;

        public void Initialize()
        {
            starScene = new StartScene();
            loginScene = new LoginScene();
            mainScene = new MainScene();
            battleScene = new BattleScene();
        }

        public void Update()
        {
            if(this.curScene != null)
            {
                this.curScene.Update();
            }
        }

        public void LateUpdate()
        {
            if(this.curScene != null)
            {
                this.curScene.LateUpdate();
            }
        }

        public void Change(ESceneType type)
        {
            if (curSceneType == type) return;
            if(this.curScene != null)
            {
                this.curScene.End();
                this.curScene = null;
                this.curSceneType = ESceneType.None;
            }

            switch(type)
            {
                case ESceneType.Star:
                    this.curScene = this.starScene;
                    break;
                case ESceneType.Login:
                    this.curScene = this.loginScene;
                    break;
                case ESceneType.Main:
                    this.curScene = this.mainScene;
                    break;
                case ESceneType.Battle:
                    this.curScene = this.battleScene;
                    break;
            }

            if(this.curScene != null)
            {
                this.curScene.Begin();
                this.curSceneType = type;
            }
        }

        public BaseScene CurScene
        {
            get
            {
                return this.curScene;
            }
        }

        public ESceneType CurSceneType
        {
            get
            {
                return this.curSceneType;
            }
        }
    }
}
