using Game.Core.Common;
using Game.Core.Config;
using Game.Core.Util;
using System.IO;
using UnityEditor;
using UnityEngine;

/************************* 
* 作者： wenyueyun 
* 时间： 2018/4/26 19:07:50 
* 描述： ConfigBuilder 
*************************/
public class XmlBuilder
{
    //private static readonly string path ="Assets/Res/Config/";

    [MenuItem("工具/1、配置表/构建配置表")]
    public static void Builder()
    {
        //string xmlPath = path + "SexConfig.xml";
        //string bytePath = path + "SexConfig.bytes";
        //Pack<SexInfo>(xmlPath, bytePath);
    }

    private static void Pack<T>(string xmlPath,string bytePath) where T:BaseInfo
    {
        //Debug.Log("XmlPath:" + xmlPath);
        //TextAsset ta = AssetDatabase.LoadAssetAtPath<TextAsset>(xmlPath);
        //ByteData bd = XmlUtil.Deserialize<T>(ta.bytes);
        //File.WriteAllBytes(bytePath, bd.Pack());
        //Debug.Log("PackPath:" + bytePath + "   --  Success!");
    }
}
