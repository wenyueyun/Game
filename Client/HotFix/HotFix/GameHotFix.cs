using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.HotFix.Manager;

namespace Game.HotFix
{
    /************************* 
	* 作者： wenyueyun 
	* 时间： 2018/6/26 15:10:57 
	* 描述： Game 
	*************************/
    public class GameHotFix
    {
        public void Start()
        {
            SceneManager.Instance.Initialize();
        }

        public void Update()
        {
            SceneManager.Instance.Update();
        }

        public void LateUpdate()
        {
            SceneManager.Instance.LateUpdate();
        }
    }
}
