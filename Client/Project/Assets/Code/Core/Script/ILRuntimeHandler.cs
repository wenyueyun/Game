using Game.Core.Interface;
using ILRuntime.Runtime.Enviorment;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Core.Script
{
    /************************* 
	* 作者： wenyueyun 
	* 时间： 2018/6/26 15:30:14 
	* 描述： ILRuntimeHandler 
	*************************/
    public class ILRuntimeHandler : IScriptHandler
    {
        private AppDomain appDomain;
   
        //加载本地程序集
        public void LoadAssembly(string path, UnityAction assemblyLoad)
        {
            Debug.Log("ILRuntimeHandler LoadAssembly-->" + path);
            //-----------加载程序集-------------
            appDomain = new AppDomain();
            appDomain.LoadAssemblyFile(path);

            //注册ILRuntime
            RegisterILRuntime();

            //-----------开始执行程序进入游戏-------------

            //Invoke();

            //-----------执行回调方法-------------
            if (assemblyLoad != null)
            {
                assemblyLoad();
            }
        }

        //加载服务器更新下来的程序集
        public void LoadAssembly(byte[] data, UnityAction assemblyLoad)
        {
            Debug.Log("ILRuntimeHandler LoadAssembly-->" + "data");
            //-----------加载程序集-------------
            using (MemoryStream ms = new MemoryStream(data))
            {
                appDomain = new AppDomain();
                appDomain.LoadAssembly(ms);

                //注册ILRuntime
                RegisterILRuntime();

                //-----------开始执行程序进入游戏-------------

                //Invoke();
            }

            //-----------执行回调方法-------------
            if (assemblyLoad != null)
            {
                assemblyLoad();
            }
        }

        //实例化某个类
        public T Instantiate<T>(string type, object[] args = null) where T : class
        {
            return appDomain.Instantiate<T>(type, args);
        }

        //执行某个方法
        public object Invoke(string type, string method, object instance, params object[] args)
        {
            return appDomain.Invoke(type, method, instance, args);
        }

        public void Initialize()
        {
        }

        public void Uninitialize()
        {
            if (appDomain != null)
            {
                appDomain = null;
            }
        }

        //注册ILRuntime
        private void RegisterILRuntime()
        {

        }

    }
}
