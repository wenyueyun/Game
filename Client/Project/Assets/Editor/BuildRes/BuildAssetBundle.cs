using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

/************************* 
* 作者： wenyueyun 
* 时间： 2018/6/27 11:05:30 
* 描述： BuildAssetBundle 
*************************/
public class BuildAssetBundle
{
    [MenuItem("工具/2、构建资源")]
    public static void BuildRes()
    {
    
        Build();
    }

    [MenuItem("工具/3、构建配置")]
    public static void BuildXml()
    {
        Debug.Log("开始构建配置------------->");
    }

    [MenuItem("工具/4、资源/ABName_All")]
    public static void UpdateAllAssetBundleName()
    {
        UpdateAtlasAssetBundleName();
        UpdateConfigAssetBundleName();
        UpdateAudioAssetBundleName();
        UpdateModelAssetBundleName();
        UpdateUIAssetBundleName();
        UpdateMapAssetBundleName();
    }

    [MenuItem("工具/4、资源/ABName_Atlas")]
    public static void UpdateAtlasAssetBundleName()
    {
        Debug.Log("开始设置Atlas名字------------->");
        string path = "Assets/AssetBundle/Atlas";
        DirectoryInfo directory = new DirectoryInfo(path);
        FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            if (file.Extension == ".meta") continue;
            string assetPath = EditorUtil.FullPathToAssetPath(file.FullName);
            string abName = "Atlas/" + file.Directory.Name;
            TextureImporter importer = AssetImporter.GetAtPath(assetPath) as TextureImporter;
            if (importer.textureType != TextureImporterType.Sprite)
            {
                importer.textureType = TextureImporterType.Sprite;
            }
            if (!importer.spritePackingTag.Equals(file.Directory.Name))
            {
                importer.spritePackingTag = file.Directory.Name;
            }
            importer.assetBundleName = abName.ToLower();
            importer.SaveAndReimport();
        }
        AssetDatabase.Refresh();
        Debug.Log("Atlas名字设置完成");
    }

    [MenuItem("工具/4、资源/ABName_Config")]
    public static void UpdateConfigAssetBundleName()
    {
        Debug.Log("开始设置Config名字------------->");
        string path = "Assets/AssetBundle/Config";
        DirectoryInfo directory = new DirectoryInfo(path);
        FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            if (file.Extension == ".meta") continue;
            string assetPath = EditorUtil.FullPathToAssetPath(file.FullName);
            string abName = "Config/Data";
            AssetImporter importer = AssetImporter.GetAtPath(assetPath);
            importer.assetBundleName = abName.ToLower();
        }
        AssetDatabase.Refresh();
        Debug.Log("Config名字设置完成");
    }

    [MenuItem("工具/4、资源/ABName_Audio")]
    public static void UpdateAudioAssetBundleName()
    {
        Debug.Log("开始设置Audio名字------------->");
        string path = "Assets/AssetBundle/Audio";
        DirectoryInfo directory = new DirectoryInfo(path);
        FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            if (file.Extension == ".meta") continue;
            string assetPath = EditorUtil.FullPathToAssetPath(file.FullName);
            string abName = assetPath.Replace("Assets/AssetBundle/", "").Split('.')[0];
            AssetImporter importer = AssetImporter.GetAtPath(assetPath);
            importer.assetBundleName = abName.ToLower();
        }
        AssetDatabase.Refresh();
        Debug.Log("Audio名字设置完成");
    }

    [MenuItem("工具/4、资源/ABName_Model")]
    public static void UpdateModelAssetBundleName()
    {
        Debug.Log("开始设置Model名字------------->");
        string path = "Assets/AssetBundle/Model";
        DirectoryInfo directory = new DirectoryInfo(path);
        FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            if (file.Extension == ".meta") continue;
            string assetPath = EditorUtil.FullPathToAssetPath(file.FullName);
            string abName = assetPath.Replace("Assets/AssetBundle/", "").Split('.')[0];
            AssetImporter importer = AssetImporter.GetAtPath(assetPath);
            importer.assetBundleName = abName.ToLower();
        }
        AssetDatabase.Refresh();
        Debug.Log("Model名字设置完成");
    }

    [MenuItem("工具/4、资源/ABName_UI")]
    public static void UpdateUIAssetBundleName()
    {
        Debug.Log("开始设置UI名字------------->");
        string path = "Assets/AssetBundle/UI";
        DirectoryInfo directory = new DirectoryInfo(path);
        FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            if (file.Extension == ".meta") continue;
            string assetPath = EditorUtil.FullPathToAssetPath(file.FullName);
            string abName = assetPath.Replace("Assets/AssetBundle/", "").Split('.')[0];
            AssetImporter importer = AssetImporter.GetAtPath(assetPath);
            importer.assetBundleName = abName.ToLower();
        }
        AssetDatabase.Refresh();
        Debug.Log("UI名字设置完成");
    }

    [MenuItem("工具/4、资源/ABName_Map")]
    public static void UpdateMapAssetBundleName()
    {
        Debug.Log("开始设置Map名字------------->");
        string path = "Assets/AssetBundle/Map";
        DirectoryInfo directory = new DirectoryInfo(path);
        FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            if (file.Extension == ".meta") continue;
            string assetPath = EditorUtil.FullPathToAssetPath(file.FullName);
            string abName = assetPath.Replace("Assets/AssetBundle/", "").Split('.')[0];
            AssetImporter importer = AssetImporter.GetAtPath(assetPath);
            importer.assetBundleName = abName.ToLower();
        }
        AssetDatabase.Refresh();
        Debug.Log("Map名字设置完成");
    }

    [MenuItem("工具/5、MD5")]
    public static void MD5()
    {
        EditorUtil.MD5(Application.dataPath + "/StreamingAssets/");
    }
    //构建资源
    public static void Build()
    {
        Debug.Log("开始构建资源------------->");
        BuildAssetBundleOptions options = BuildAssetBundleOptions.DeterministicAssetBundle;
        BuildPipeline.BuildAssetBundles(Application.dataPath + "/StreamingAssets/", options, EditorUserBuildSettings.activeBuildTarget);

        EditorUtility.UnloadUnusedAssetsImmediate();
        AssetDatabase.Refresh();
        Debug.Log("资源构建完毕");

        EditorUtil.MD5(Application.dataPath + "/StreamingAssets/");
    }
}
