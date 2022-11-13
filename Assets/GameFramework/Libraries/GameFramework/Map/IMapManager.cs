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
        /// ��ȡ��ͼ������
        /// </summary>
        int MapCount
        {
            get;
        }

        /// <summary>
        /// �Ƿ����ָ����ͼ��
        /// </summary>
        /// <param name="mapObjectName">��ͼ����</param>
        /// <returns></returns>
        bool HasMapObject(string mapObjectName);

        /// <summary>
        /// ��ȡָ����ͼ�顣
        /// </summary>
        /// <param name="mapObjectName">��ͼ����</param>
        /// <returns></returns>
        IMapBaseObject GetMapObject(string mapObjectName);

        /// <summary>
        /// ��ȡ���е�ͼ�顣
        /// </summary>
        /// <returns>���е�ͼ�顣</returns>
        IMapBaseObject[] GetMapObjects();

        /// <summary>
        /// ������Դ��������
        /// </summary>
        /// <param name="resourceManager">��Դ��������</param>
        void SetResourceManager(IResourceManager resourceManager);

        /// <summary>
        /// ���ɵ�ͼ
        /// </summary>
        void CreatMapObject(string mapObjectName, IMapBaseObjectHelper mapBaseObjectHelper);

        /// <summary>
        /// ���ٵ�ͼ
        /// </summary>
        void RemoveMap();
    }
}
