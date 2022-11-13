using GameFramework.Sound;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework.Map
{
    public interface ITileAgent
    {
        /// <summary>
        /// 地图块所在地图
        /// </summary>
        IMapBaseObject mapBaseObject { get; }

        /// <summary>
        /// 获取地图代理辅助器。
        /// </summary>
        ITileAgentHelper Helper
        {
            get;
        }

        /// <summary>
        /// 获取地图块的序列编号。
        /// </summary>
        int SerialId
        {
            get;
        }
    }
}

