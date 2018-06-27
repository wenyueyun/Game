using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Game.Core.Config
{
    /************************* 
	* 作者： wenyueyun 
	* 时间： 2018/5/8 17:20:11 
	* 描述： BaseInfo 
	*************************/
    public class BaseInfo
    {
        // 打包过程
        protected virtual void DoPack(MemoryStream ms)
        {

        }

        protected virtual void UnPack(MemoryStream ms)
        {

        }

    }
}
