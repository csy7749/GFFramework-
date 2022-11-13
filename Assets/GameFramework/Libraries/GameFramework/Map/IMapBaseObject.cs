using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework.Map
{
    /// <summary>
    /// 地图接口
    /// </summary>
    public interface IMapBaseObject
    {
        /// <summary>
        /// 地图名称
        /// </summary>
        string Name { get; }
        /// <summary>
        /// 地图的块数
        /// </summary>
        int Count { get; }

        /// <summary>
        /// 获取地图辅助器接口
        /// </summary>
        IMapBaseObjectHelper Helper { get; }

        /// <summary>
        /// 移除地图块
        /// </summary>
        /// <param name="index"></param>
        void RemoveTile(int index);

        /// <summary>
        /// 生成地图
        /// </summary>
        void CreatMap();

        /// <summary>
        /// 删除地图
        /// </summary>
        void DestroyMap();
    }
}

