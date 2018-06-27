using Game.Core.Manager;
using Game.Core.Util;
using UnityEngine;

/************************* 
* 作者： wenyueyun 
* 时间： 2018/4/18 9:11:54 
* 描述： 游戏启动 
*************************/
public class Client : MonoBehaviour
{
    private static Client Instance = null;
    private void Awake()
    {
        LogUtil.LogGreen(string.Format("Application.dataPath:{0}", Application.dataPath));
        LogUtil.LogGreen(string.Format("Application.persistentDataPath:{0}", Application.persistentDataPath));
        LogUtil.LogGreen(string.Format("Application.streamingAssetsPath:{0}", Application.streamingAssetsPath));
        LogUtil.LogGreen(PathUtil.CutFilePath(Application.dataPath,2));
    }

    private void Start()
    {
        Instance = this;

        //检测更新
        gameObject.AddComponent<Update>();
    }

    private void Update()
    {
        
    }

    private void LateUpdate()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void OnApplicationFocus(bool focus)
    {
        
    }

    private void OnApplicationPause(bool pause)
    {
        
    }

    private void OnApplicationQuit()
    {
        
    }
}
