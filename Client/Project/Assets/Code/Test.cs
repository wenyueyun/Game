using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Core.Util;
using Game.Core.Event;

public class Test : MonoBehaviour
{

    void Start()
    {
        Debug.Log(TimeUtil.TimeFormatSecond(110));
        Debug.Log(TimeUtil.TimeFormatMilliseconds(1100));

        GlobalEventSystem.Instance.AddListener("T0", oNT0);
        GlobalEventSystem.Instance.AddListener("T1", oNT1);
        GlobalEventSystem.Instance.AddListener("T2", oNT2);
        GlobalEventSystem.Instance.AddListener("T3", oNT3);
        GlobalEventSystem.Instance.AddListener("T4", oNT4);
        //GlobalEventSystem.Instance.AddEventListener<string>("T0", oNT0);
    }

    void Update()
    {
        UnityEngine.Profiling.Profiler.BeginSample("[GlobalEventSystem] Update");
        //GlobalEventSystem.Instance.FireEvent<string>("T0", "T0");
        GlobalEventSystem.Instance.Dispatch("T0", "T0");
        GlobalEventSystem.Instance.Dispatch("T1", "T1");
        GlobalEventSystem.Instance.Dispatch("T2", "T2");
        GlobalEventSystem.Instance.Dispatch("T3", "T3");
        GlobalEventSystem.Instance.Dispatch("T4", "T4");
        UnityEngine.Profiling.Profiler.EndSample();
    }

    void oNT0(string a)
    {
        Debug.Log((string)a);
    }

    void oNT0(string eventName,object obj)
    {
        Debug.Log((string)obj);
    }

    void oNT1(string eventName, object obj)
    {
        Debug.Log((string)obj);
    }

    void oNT2(string eventName, object obj)
    {
        Debug.Log((string)obj);
    }

    void oNT3(string eventName, object obj)
    {
        Debug.Log((string)obj);
    }

    void oNT4(string eventName, object obj)
    {
        Debug.Log("GlobalEventSystem------->" + (string)obj);
    }
}

