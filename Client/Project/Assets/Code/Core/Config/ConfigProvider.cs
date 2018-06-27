using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Game.Core.Config
{
    /************************* 
	* 作者： wenyueyun 
	* 时间： 2018/4/26 21:32:22 
	* 描述： ConfigProvider 
	*************************/
    public class ConfigProvider<T>:BaseInfo where T: BaseInfo, new()
    {
        public List<T> list = new List<T>();

        protected override void DoPack(MemoryStream ms)
        {
            base.DoPack(ms);
        }

        protected override void UnPack(MemoryStream ms)
        {
            base.UnPack(ms);
        }
    }
}
