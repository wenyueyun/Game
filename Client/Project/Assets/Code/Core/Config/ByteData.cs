using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Game.Core.Config
{
    /********************************
	* 作者：wenyueyun
	* 时间：2018/4/16 23:47:24
	* 描述：暂未添加描述 
	*********************************/
    public class ByteData
    {
        private static byte b;
        private static byte[] byte16 = new byte[2];
        //private static byte[] byte32 = new byte[4];
        //private static byte[] byte64 = new byte[8];
        //private static byte[] bytes = new byte[2048];

        ////读写byte
        //public static void WriteByte(MemoryStream ms, byte b)
        //{
        //    ms.WriteByte(b);
        //}

        //public static byte ReadByte(MemoryStream ms)
        //{
        //    b = (byte)ms.ReadByte();
        //    if ((b >> 7) > 0)
        //    {
        //        return (byte)(b - 0x100);
        //    }
        //    return b;
        //}

        ////读写bool
        //public static void WriteBool(MemoryStream ms, bool i)
        //{
        //    ms.WriteByte(i ? ((byte)1) : ((byte)0));
        //}

        //public static bool ReadBool(MemoryStream ms)
        //{
        //    return (ms.ReadByte() == 1);
        //}

        ////读写uint
        //public static void WriteUInt16(MemoryStream ms, uint val)
        //{
        //    byte16 = BitConverter.GetBytes((ushort)val);
        //    if (BitConverter.IsLittleEndian)
        //    {
        //        Byte2Reverse(byte16);
        //    }
        //    ms.Write(byte16, 0, 2);
        //}

        //public static uint ReadUInt16(MemoryStream ms)
        //{
        //    ms.Read(byte16, 0, byte16.Length);
        //    if (BitConverter.IsLittleEndian)
        //    {
        //        Byte2Reverse(byte16);
        //    }
        //    return BitConverter.ToUInt16(byte16, 0);
        //}

        ////读写int
        //public static void WriteInt16(MemoryStream ms, int val)
        //{
        //    byte16 = BitConverter.GetBytes((short)val);
        //    if (BitConverter.IsLittleEndian)
        //    {
        //        Byte2Reverse(byte16);
        //    }
        //    ms.Write(byte16, 0, 2);
        //}

        //public static int ReadInt16(MemoryStream ms)
        //{
        //    ms.Read(byte16, 0, byte16.Length);
        //    if (BitConverter.IsLittleEndian)
        //    {
        //        Byte2Reverse(byte16);
        //    }
        //    return BitConverter.ToInt16(byte16, 0);
        //}

        ////读写int32
        //public static void WriteInt32(MemoryStream ms, int val)
        //{
        //    byte32 = BitConverter.GetBytes(val);
        //    if (BitConverter.IsLittleEndian)
        //    {
        //        Byte4Reverse(byte32);
        //    }
        //    ms.Write(byte32, 0, 4);
        //}

        //public static int ReadInt32(MemoryStream ms)
        //{
        //    ms.Read(byte32, 0, byte32.Length);
        //    if (BitConverter.IsLittleEndian)
        //    {
        //        Byte4Reverse(byte32);
        //    }
        //    return BitConverter.ToInt32(byte32, 0);
        //}

        ////读写long
        //public static void WriteLong(MemoryStream ms, long i)
        //{
        //    byte64 = BitConverter.GetBytes(i);
        //    if (BitConverter.IsLittleEndian)
        //    {
        //        Byte8Reverse(byte64);
        //    }
        //    ms.Write(byte64, 0, 8);
        //}

        //public static long ReadLong(MemoryStream ms)
        //{
        //    ms.Read(byte64, 0, byte64.Length);
        //    if (BitConverter.IsLittleEndian)
        //    {
        //        Byte8Reverse(byte64);
        //    }
        //    return BitConverter.ToInt64(byte64, 0);
        //}

        ////读写float32
        //public static void WriteFloat32(MemoryStream ms, float i)
        //{
        //    byte32 = BitConverter.GetBytes(i);
        //    if (BitConverter.IsLittleEndian)
        //    {
        //        Byte4Reverse(byte32);
        //    }
        //    ms.Write(byte32, 0, 4);
        //}

        //public static float ReadFloat32(MemoryStream ms)
        //{
        //    ms.Read(byte32, 0, 4);
        //    if (BitConverter.IsLittleEndian)
        //    {
        //        Byte4Reverse(byte32);
        //    }
        //    return BitConverter.ToSingle(byte32, 0);
        //}

        ////读写string
        //public static void WriteString(MemoryStream ms, string s)
        //{
        //    if (string.IsNullOrEmpty(s))
        //    {
        //        WriteUInt16(ms, 0);
        //    }
        //    else
        //    {
        //        byte[] bytes = Encoding.UTF8.GetBytes(s);
        //        WriteUInt16(ms, (uint)bytes.Length);
        //        ms.Write(bytes, 0, bytes.Length);
        //    }
        //}

        //public static string ReadString(MemoryStream ms)
        //{
        //    int len = ReadInt16(ms);
        //    if (len == 0)
        //    {
        //        return "";
        //    }
        //    ms.Read(bytes, 0, len);
        //    return Encoding.UTF8.GetString(bytes, 0, len);
        //}

        ////读写byte[] array
        //public static void WriteArray(MemoryStream ms, byte[] array)
        //{
        //    if (array == null)
        //    {
        //        WriteUInt16(ms, 0);
        //        return;
        //    }
        //    WriteUInt16(ms, (uint)array.Length);
        //    foreach (byte i in array)
        //    {
        //        WriteByte(ms, i);
        //    }
        //}

        //public static byte[] ReadByteArray(MemoryStream ms)
        //{
        //    uint len = ReadUInt16(ms);
        //    if (len == 0) return null;
        //    byte[] numArray = new byte[len];
        //    for (int i = 0; i < len; ++i)
        //    {
        //        numArray[i] = ReadByte(ms);
        //    }
        //    return numArray;
        //}

        ////读写 int[] array
        //public static void WriteArray(MemoryStream ms, int[] array)
        //{
        //    if (array == null)
        //    {
        //        WriteUInt16(ms, 0);
        //        return;
        //    }
        //    WriteUInt16(ms, (uint)array.Length);
        //    foreach (int i in array)
        //    {
        //        WriteInt32(ms, i);
        //    }
        //}


        //public static int[] ReadInt32Array(MemoryStream ms)
        //{
        //    uint len = ReadUInt16(ms);
        //    if (len == 0) return null;
        //    int[] numArray = new int[len];
        //    for (int i = 0; i < len; ++i)
        //    {
        //        numArray[i] = ReadInt32(ms);
        //    }
        //    return numArray;
        //}

        //public static void WriteArray(MemoryStream ms, string[] array)
        //{
        //    if (array == null)
        //    {
        //        WriteUInt16(ms, 0);
        //        return;
        //    }
        //    WriteUInt16(ms, (uint)array.Length);
        //    foreach (string str in array)
        //    {
        //        WriteString(ms, str);
        //    }
        //}

        //public static string[] ReadStringArray(MemoryStream ms)
        //{
        //    uint len = ReadUInt16(ms);
        //    if (len == 0) return null;
        //    string[] strArray = new string[len];
        //    for (int i = 0; i < len; ++i)
        //    {
        //        strArray[i] = ReadString(ms);
        //    }
        //    return strArray;
        //}

        //public static void WriteList(MemoryStream ms, List<int> list)
        //{
        //    if (list == null)
        //    {
        //        WriteUInt16(ms, 0);
        //        return;
        //    }
        //    WriteUInt16(ms, (uint)list.Count);
        //    foreach (int num in list)
        //    {
        //        WriteInt32(ms, num);
        //    }
        //}

        //public static List<int> ReadInt32List(MemoryStream ms)
        //{
        //    uint len = ReadUInt16(ms);
        //    List<int> list = new List<int>();
        //    for (int i = 0; i < len; ++i)
        //    {
        //        list.Add(ReadInt32(ms));
        //    }
        //    return list;
        //}

        //public static void WriteList(MemoryStream ms, List<string> list)
        //{
        //    if (list == null)
        //    {
        //        WriteUInt16(ms, 0);
        //        return;
        //    }
        //    WriteUInt16(ms, (uint)list.Count);
        //    foreach (string val in list)
        //    {
        //        WriteString(ms, val);
        //    }
        //}

        //public static List<string> ReadStringList(MemoryStream ms)
        //{
        //    uint len = ReadUInt16(ms);
        //    List<string> list = new List<string>();
        //    for (int i = 0; i < len; ++i)
        //    {
        //        list.Add(ReadString(ms));
        //    }
        //    return list;
        //}



        public byte[] Pack()
        {
            MemoryStream ms = new MemoryStream();
            DoPack(ms);
            byte[] bytes = ms.ToArray();
            ms.Close();
            return bytes;
        }

        // 打包过程
        protected virtual void DoPack(MemoryStream ms)
        {

        }

        protected virtual void UnPack(MemoryStream ms)
        {

        }

        public static void WriteList<T>(MemoryStream ms, List<T> list) where T : ByteData
        {
            WriteInt16(ms, list.Count);
            foreach (ByteData i in list)
                i.DoPack(ms);
        }

        public List<T> readList<T>(MemoryStream ms) where T : ByteData, new()
        {
            int len = ReadInt16(ms);
            List<T> list = new List<T>();
            for (int i = 0; i < len; i++)
            {
                T item = new T();
                item.UnPack(ms);
                list.Add(item);
            }
            return list;
        }

        //读写int
        public static void WriteInt16(MemoryStream ms, int val)
        {
            byte16 = BitConverter.GetBytes((short)val);
            if (BitConverter.IsLittleEndian)
            {
                Byte2Reverse(byte16);
            }
            ms.Write(byte16, 0, 2);
        }

        public static int ReadInt16(MemoryStream ms)
        {
            ms.Read(byte16, 0, byte16.Length);
            if (BitConverter.IsLittleEndian)
            {
                Byte2Reverse(byte16);
            }
            return BitConverter.ToInt16(byte16, 0);
        }

        //大小字节转换
        public static void Byte2Reverse(byte[] bytes)
        {
            b = bytes[0];
            bytes[0] = bytes[1];
            bytes[1] = b;
        }

        public static void Byte4Reverse(byte[] bytes)
        {
            b = bytes[0];
            bytes[0] = bytes[3];
            bytes[3] = b;
            b = bytes[1];
            bytes[1] = bytes[2];
            bytes[2] = b;
        }

        public static void Byte8Reverse(byte[] bytes)
        {
            b = bytes[0];
            bytes[0] = bytes[7];
            bytes[7] = b;
            b = bytes[1];
            bytes[1] = bytes[6];
            bytes[6] = b;
            b = bytes[2];
            bytes[2] = bytes[5];
            bytes[5] = b;
            b = bytes[3];
            bytes[3] = bytes[4];
            bytes[4] = b;
        }
    }
}