using System.Collections.Generic;
using GameFramework.Resource;
using GameFramework.Sound;
using UnityEngine;

namespace GameFramework.Map
{
    internal sealed partial class MapManager : GameFrameworkModule, IMapManager
    {
        private readonly Dictionary<string, MapBaseObject> m_Maps;
        private IResourceManager m_ResourceManager;
        private int m_Serial;

        public MapManager()
        {
            m_Maps = new Dictionary<string, MapBaseObject>();
            m_Serial = 0;
            m_ResourceManager = null;
        }

        /// <summary>
        /// ��ȡ��ͼ����
        /// </summary>
        public int MapCount
        {
            get { return m_Maps.Count; }
        }

        /// <summary>
        /// ������Դ��������
        /// </summary>
        /// <param name="resourceManager">��Դ��������</param>
        public void SetResourceManager(IResourceManager resourceManager)
        {
            if (resourceManager == null)
            {
                throw new GameFrameworkException("Resource manager is invalid.");
            }

            m_ResourceManager = resourceManager;
        }

        /// <summary>
        /// �Ƿ����ָ����ͼ��
        /// </summary>
        /// <param name="mapObjectName">��ͼ����</param>
        /// <returns></returns>
        public bool HasMapObject(string mapObjectName)
        {
            if (string.IsNullOrEmpty(mapObjectName))
            {
                throw new GameFrameworkException("mapObjectName is invalid.");
            }

            return m_Maps.ContainsKey(mapObjectName);
        }

        /// <summary>
        /// ��ȡָ����ͼ�顣
        /// </summary>
        /// <param name="mapObjectName">��ͼ����</param>
        /// <returns></returns>
        public IMapBaseObject GetMapObject(string mapObjectName)
        {
            if (string.IsNullOrEmpty(mapObjectName))
            {
                throw new GameFrameworkException("mapObjectName is invalid.");
            }
            MapBaseObject mapObject = null;
            if (m_Maps.TryGetValue(mapObjectName, out mapObject))
            {
                return mapObject;
            }
           
            return null;
        }

        /// <summary>
        /// ��ȡ���е�ͼ�顣
        /// </summary>
        /// <returns>���е�ͼ�顣</returns>
        public IMapBaseObject[] GetMapObjects() 
        {
            int index = 0;
            IMapBaseObject[] results = new IMapBaseObject[m_Maps.Count];
            foreach (KeyValuePair<string, MapBaseObject> mapObject in m_Maps)
            {
                results[index++] = mapObject.Value;
            }

            return results;
        }

        /// <summary>
        /// ��ӵ�ͼ
        /// </summary>
        /// <param name="mapObjectName"></param>
        /// <param name="mapBaseObjectHelper"></param>
        /// <exception cref="GameFrameworkException"></exception>
        public void CreatMapObject(string mapObjectName,IMapBaseObjectHelper mapBaseObjectHelper)
        {
            if (string.IsNullOrEmpty(mapObjectName))
            {
                throw new GameFrameworkException("mapObjectName is invalid.");
            }
            if (mapBaseObjectHelper == null)
            {
                throw new GameFrameworkException("mapBaseObjectHelper is invalid.");
            }
            if (HasMapObject(mapObjectName))
            {
                return;
            }
            MapBaseObject mapBaseObject = new MapBaseObject(mapObjectName, mapBaseObjectHelper);
            m_Maps.Add(mapObjectName, mapBaseObject);
        }

        public void CreatTileAgent(string mapObjectName,Vector2 vector2, ITileAgentHelper tileAgentHelper)
        {
            if (string.IsNullOrEmpty(mapObjectName))
            {
                throw new GameFrameworkException("tileAgentName is invalid.");
            }
            MapBaseObject mapBaseObject = (MapBaseObject)GetMapObject(mapObjectName);
            if (mapBaseObject == null)
            {
                throw new GameFrameworkException("mapBaseObject is invalid.");
            }
            mapBaseObject.CreatMap(vector2, tileAgentHelper);
        }

        public void RemoveMap()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// �رղ������ͼ��������
        /// </summary>
        internal override void Shutdown()
        {
            m_Maps.Clear();
        }

        /// <summary>
        /// ��ͼ��������ѯ��
        /// </summary>
        /// <param name="elapseSeconds">�߼�����ʱ�䣬����Ϊ��λ��</param>
        /// <param name="realElapseSeconds">��ʵ����ʱ�䣬����Ϊ��λ��</param>
        internal override void Update(float elapseSeconds, float realElapseSeconds)
        {

        }
    }
}

