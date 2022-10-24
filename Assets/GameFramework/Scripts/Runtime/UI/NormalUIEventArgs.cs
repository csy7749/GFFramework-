using GameFramework;
using GameFramework.Event;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI普通的事件
/// </summary>
public class NormalUIEventArgs : GameEventArgs
{
    public static readonly int EventId = typeof(NormalUIEventArgs).GetHashCode();

    /// <summary>
    /// 初始化打开界面时加载依赖资源事件的新实例。
    /// </summary>
    public NormalUIEventArgs()
    {
        EventName = "";
        UserData = null;
    }

    /// <summary>
    /// 获取打开界面时加载依赖资源事件编号。
    /// </summary>
    public override int Id
    {
        get
        {
            return EventId;
        }
    }

    /// <summary>
    /// 获取事件名称。
    /// </summary>
    public string EventName
    {
        get;
        private set;
    }

    /// <summary>
    /// 获取用户自定义数据。
    /// </summary>
    public object UserData
    {
        get;
        private set;
    }

    /// <summary>
    /// 创建打开界面时加载依赖资源事件。
    /// </summary>
    /// <param name="e">内部事件。</param>
    /// <returns>创建的打开界面时加载依赖资源事件。</returns>
    public static NormalUIEventArgs Create(string eventName,object userData = null)
    {
        NormalUIEventArgs normalUIEventArgs = ReferencePool.Acquire<NormalUIEventArgs>();
        normalUIEventArgs.EventName = eventName;
        normalUIEventArgs.UserData = userData;

        return normalUIEventArgs;
    }

    public override void Clear()
    {
        EventName = "";
    }
}
