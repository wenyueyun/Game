using UnityEngine;

namespace Game.Core.Manager
{
    /************************* 
	* 作者： wenyueyun 
	* 时间： 2018/6/26 13:55:47 
	* 描述： UpdateManager 
	*************************/
    public class Update : MonoBehaviour
    {
        private string app_version;
        private string res_version;

        public void Initialize()
        {
            LoadLocalConfig();
            LoadServerConfig();
        }

        public void UnInitialize()
        {

        }

        //加载本地配置
        public void LoadLocalConfig()
        {

        }

        //加载服务器配置
        public void LoadServerConfig()
        {

        }
    }

    public class AssetInfo
    {
        public string path;
        public string md5;
        public long size;
    }
}
