using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using UnityEditor;
using UnityEngine;

/************************* 
* 作者： wenyueyun 
* 时间： 2018/6/26 17:26:51 
* 描述： SwitchServer 
*************************/
public class SwitchServer
{
    [MenuItem("工具/3、服务器/本地服")]
    public static void SwitchLocal()
    {
        Debug.Log("本地服");
        string ip = "";
        //获取计算机IP
        IPHostEntry computerIp = Dns.GetHostEntry(Dns.GetHostName());
        for (int i = 0; i < computerIp.AddressList.Length; i++)
        {
            if (computerIp.AddressList[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                ip = computerIp.AddressList[i].ToString();
            }
        }
        SwitchServer.ModifyConfig(ip);
    }

    [MenuItem("工具/3、服务器/内网")]
    public static void SwitchIntranet()
    {
        Debug.Log("内网");
        SwitchServer.ModifyConfig("192.168.50.247");
    }

    [MenuItem("工具/3、服务器/外网")]
    public static void SwitchInternet()
    {
        Debug.Log("外网");
        SwitchServer.ModifyConfig("120.77.209.15");
    }

    //切换服务器
    public static void ModifyConfig(string ip)
    {
        string path = Path.Combine(EditorUtil.resources_path, "config.json");
        if (File.Exists(path))
        {
            JsonData json;
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string str = sr.ReadToEnd();
                    json = JsonMapper.ToObject(str);
                    json["res_url"] = string.Format("http://{0}:4141/Resources/{1}", ip, EditorUtil.Platform);
                }
                File.WriteAllText(path, EditorUtil.JsonFormat(json.ToJson()), Encoding.UTF8);
            }
        }
    }
}
