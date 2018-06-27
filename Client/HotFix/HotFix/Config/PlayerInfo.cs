
using System;
using System.Collections.Generic;
using System.IO;
using Game.Core.Config;

/// <summary>
/// 自动生成，禁止修改
/// </summary>
[Serializable]
public class PlayerInfo :BaseInfo
{
    
	/// <summary>
	///ID
	/// </summary>
	public int id;

	/// <summary>
	///名字
	/// </summary>
	public string name;

	/// <summary>
	///年龄
	/// </summary>
	public string age;


    public void  DoPack(MemoryStream ms)
    {
    // %WRITE%
    }

    public void UnPack(MemoryStream ms)
    {
    //%READ%  
    }
}