
using System;
using System.Collections.Generic;
using System.IO;
using Game.Core.Config;

/// <summary>
/// 自动生成，禁止修改
/// </summary>
[Serializable]
public class SexInfo : BaseInfo
{

    /// <summary>
    ///ID
    /// </summary>
    public int id;

    /// <summary>
    ///描述
    /// </summary>
    public string desc;


    public void DoPack(MemoryStream ms)
    {
        // %WRITE%
    }

    public void UnPack(MemoryStream ms)
    {
        //%READ%  
    }
}