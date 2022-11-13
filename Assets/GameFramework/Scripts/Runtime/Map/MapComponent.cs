using GameFramework;
using GameFramework.Map;
using GameFramework.Resource;
using GameFramework.Sound;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// ��ͼ�����
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Game Framework/Map")]
    public sealed partial class MapComponent : GameFrameworkComponent
    {
        private IMapManager m_MapManager = null;
        [SerializeField]
        private string m_MapObjectHelperTypeName = "UnityGameFramework.Runtime.MapObjectHelper";
        [SerializeField]
        private MapBaseObjectHelper m_CustomMapObjectHelper = null;
        [SerializeField]
        private MapBaseObjectHelper m_CustomTileAgentHelper = null;


        public int MapObjectCount
        {
            get { return m_MapManager.MapCount; }
        }

        protected override void Awake()
        {
            base.Awake();
            m_MapManager = GameFrameworkEntry.GetModule<IMapManager>();
        }

        private void Start()
        {
            BaseComponent baseComponent = GameEntry.GetComponent<BaseComponent>();
            if (baseComponent == null)
            {
                Log.Fatal("Base component is invalid.");
                return;
            }
            if (baseComponent.EditorResourceMode)
            {
                m_MapManager.SetResourceManager(baseComponent.EditorResourceHelper);
            }
            else
            {
                m_MapManager.SetResourceManager(GameFrameworkEntry.GetModule<IResourceManager>());
            }
        }

        /// <summary>
        /// �Ƿ����ָ����ͼ��
        /// </summary>
        /// <param name="mapObjectName">��ͼ����</param>
        /// <returns></returns>
        public bool HasMapObject(string mapObjectName)
        {
            return m_MapManager.HasMapObject(mapObjectName);
        }

        /// <summary>
        /// ��ȡָ����ͼ�顣
        /// </summary>
        /// <param name="mapObjectName">��ͼ����</param>
        /// <returns></returns>
        public IMapBaseObject GetMapObject(string mapObjectName)
        {
            return m_MapManager.GetMapObject(mapObjectName);
        }

        /// <summary>
        /// ��ȡ���е�ͼ�顣
        /// </summary>
        /// <returns>���е�ͼ�顣</returns>
        public IMapBaseObject[] GetMapObjects()
        {
            return m_MapManager.GetMapObjects();
        }

        /// <summary>
        /// ��ӵ�ͼ
        /// </summary>
        /// <param name="mapObjectName"></param>
        /// <param name="mapBaseObjectHelper"></param>
        /// <exception cref="GameFrameworkException"></exception>
        public void CreatMapObject(string mapObjectName)
        {
            if (m_MapManager.HasMapObject(mapObjectName))
            {
                return;
            }
            MapBaseObjectHelper mapBaseObjectHelper = Helper.CreateHelper(m_MapObjectHelperTypeName,m_CustomMapObjectHelper);
            if (mapBaseObjectHelper == null)
            {
                Log.Error("Can not create mapBaseObjectHelper.");
                return;
            }
            m_MapManager.CreatMapObject(mapObjectName, mapBaseObjectHelper);
        }

        private void CreatTileAgent(string tileAgentName, MapBaseObjectHelper mapBaseObjectHelper)
        {

        }
    }
}
