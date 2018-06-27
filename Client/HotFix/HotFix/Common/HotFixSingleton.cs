using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.HotFix.Common
{
    /************************* 
	* 作者： wenyueyun 
	* 时间： 2018/6/26 14:18:46 
	* 描述： HotFixSingleton 
	*************************/
    public class HotFixSingleton<T> where T:new ()
    {
        private static T _instance;
        private static readonly object synclock = new object();
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (synclock)
                    {
                        _instance = (default(T) == null) ? Activator.CreateInstance<T>() : default(T);
                    }
                }
                return _instance;
            }
        }
    }
}
}
