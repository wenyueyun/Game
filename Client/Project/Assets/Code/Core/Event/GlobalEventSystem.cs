using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Core.Event
{
    /************************* 
	* 作者： wenyueyun 
	* 时间： 2018/4/26 15:57:07 
	* 描述： GlobalEventSystem 
	*************************/
    public class GlobalEventSystem: EventDispatcher
    {
        private static GlobalEventSystem instance;
        public static GlobalEventSystem Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new GlobalEventSystem();
                }
                return instance;
            }
        }
    }
}
