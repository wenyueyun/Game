using Excel;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;
using UnityEditor;
using UnityEngine;

public class ExcelAnalyze
{
    private static readonly string xml_path = "E:/Unity/Game/Client/Project/Assets/Resource/Config/";
    private static readonly string class_path = "E:/Unity/Game/Client/HotFix/Code/Config/";

    private static List<string> desc_list = new List<string>();
    private static List<string> key_list = new List<string>();
    private static List<string> type_list = new List<string>();
    private static Dictionary<string, List<ConfigData>> data_dic = new Dictionary<string, List<ConfigData>>();

    [MenuItem("工具/1、配置表/解析配置表")]
    private static void GenerateXml()
    {
        string path = EditorUtility.OpenFilePanel("Select xlsx file", "E:/Unity/Game/Config", "xlsx");
        if (string.IsNullOrEmpty(path) == false)
        {
            using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                DataSet result = excelReader.AsDataSet();
                DataTableCollection tables = result.Tables;
                foreach (DataTable item in tables)
                {
                    AnalysisExcelData(item);
                }
            }
            AssetDatabase.Refresh();
        }
    }

    /// <summary>
    /// 解析配置表数据
    /// </summary>
    /// <param name="table">单个表数据</param>
    private static void AnalysisExcelData(DataTable table)
    {
        desc_list.Clear();
        key_list.Clear();
        type_list.Clear();
        data_dic.Clear();
        for (int i = 0; i < table.Rows.Count; i++)
        {
            object[] objs = table.Rows[i].ItemArray;
            List<ConfigData> row_list = new List<ConfigData>();

            for (int j = 0; j < objs.Length; j++)
            {
                if (i == 0)
                {
                    desc_list.Add(objs[j].ToString());
                }
                else if (i == 1)
                {
                    key_list.Add(objs[j].ToString());
                }
                else if (i == 2)
                {
                    type_list.Add(objs[j].ToString());
                }
                else
                {
                    ConfigData data = new ConfigData();
                    data.type = type_list[j];
                    data.key = key_list[j];
                    data.value = objs[j].ToString();
                    row_list.Add(data);
                }
            }
            if (row_list.Count > 0)
            {
                data_dic.Add(row_list[0].value, row_list);
            }
        }
        GenerateParseClass(table.TableName);
        GenerateXML(table.TableName);
    }

    /// <summary>
    /// 生成配置表读取文件
    /// </summary>
    /// <param name="tableName">表名</param>
    private static void GenerateParseClass(string tableName)
    {
        string className = tableName + "Info";
        StringBuilder classsb = new StringBuilder();
        classsb.Append(classTemplate);

        StringBuilder proerty = new StringBuilder();
        proerty.Append("\n");
        for (int i = 0; i < desc_list.Count; i++)
        {
            proerty.Append("\t" + "/// <summary>\n");
            proerty.AppendFormat("\t" + "///{0}\n", desc_list[i]);
            proerty.Append("\t" + "/// </summary>\n");
            proerty.AppendFormat("\t" + "public {0} {1};\n\n", type_list[i], key_list[i]);
        };

        classsb.Replace("%CLASSNAME%", className);
        classsb.Replace("%PROERTY&", proerty.ToString());

        string file_path = string.Format("{0}{1}.cs", class_path, className);
        if (File.Exists(file_path))
        {
            File.Delete(file_path);
        }
        File.WriteAllText(file_path, classsb.ToString(), Encoding.UTF8);
    }

    /// <summary>
    /// 生成配置表对应的XML文件
    /// </summary>
    /// <param name="tableName">表名</param>
    private static void GenerateXML(string tableName)
    {
        string xmlName = tableName + "Config";
        XmlDocument xml = new XmlDocument();

        XmlDeclaration dec = xml.CreateXmlDeclaration("1.0", "utf-8", "yes");//设置声明  
        xml.AppendChild(dec);

        XmlElement root = xml.CreateElement("root");

        Dictionary<string, List<ConfigData>>.Enumerator iter = data_dic.GetEnumerator();
        while(iter.MoveNext())
        {
            XmlElement element = xml.CreateElement(tableName);

            List<ConfigData> list = iter.Current.Value;
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement elementChild = xml.CreateElement(list[i].key);
                elementChild.InnerText = list[i].value;
                element.AppendChild(elementChild);
            }

            root.AppendChild(element);
        }
        xml.AppendChild(root);

        string file_path = string.Format("{0}{1}.xml", xml_path, xmlName);
        if (File.Exists(file_path))
        {
            File.Delete(file_path);
        }
        xml.Save(file_path);
    }

    #region classTemplate
    private static string classTemplate =
  @"
using System;
using System.Collections.Generic;
using System.IO;
using Game.Core.Config;

/// <summary>
/// 自动生成，禁止修改
/// </summary>
[Serializable]
public class %CLASSNAME% :BaseInfo
{
    %PROERTY&
    public void  DoPack(MemoryStream ms)
    {
    // %WRITE%
    }

    public void UnPack(MemoryStream ms)
    {
    //%READ%  
    }
}";
    #endregion
}



public class ConfigData
{
    public string type;
    public string key;
    public string value;
}



