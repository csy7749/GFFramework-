using GameFramework.Resource;
using GameFramework.Sound;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework.Map
{
    public interface IMapManager
    {
        /// <summary>
        /// 获取地图数量。
        /// </summary>
        int MapCount
        {
            get;
        }

        /// <summary>
        /// 是否存在指定地图。
        /// </summary>
        /// <param name="mapObjectName">地图名字</param>
        /// <returns></returns>
        bool HasMapObject(string mapObjectName);

        /// <summary>
        /// 获取指定地图组。
        /// </summary>
        /// <param name="mapObjectName">地图名字</param>
        /// <returns></returns>
        IMapBaseObject GetMapObject(string mapObjectName);

        /// <summary>
        /// 获取所有地图组。
        /// </summary>
        /// <returns>所有地图组。</returns>
        IMapBaseObject[] GetMapObjects();

        /// <summary>
        /// 设置资源管理器。
        /// </summary>
        /// <param name="resourceManager">资源管理器。</param>
        void SetResourceManager(IResourceManager resourceManager);

        /// <summary>
        /// 生成地图
        /// </summary>
        void CreatMapObject(string mapObjectName, IMapBaseObjectHelper mapBaseObjectHelper);

        /// <summary>
        /// 销毁地图
        /// </summary>
        void RemoveMap();
    }
}
