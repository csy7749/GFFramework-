using GameFramework.Sound;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework.Map
{
    internal sealed partial class MapManager : GameFrameworkModule, IMapManager
    {
        /// <summary>
        /// ��ͼ�����
        /// </summary>
        public sealed class TileAgent : IReference, ITileAgent
        {
            private readonly MapBaseObject m_MapObject;
            private readonly ITileAgentHelper m_TileAgentHelper;
            private Vector2 m_V2;
            private int m_Serialid;
            private object m_TileAsset;

            public TileAgent(MapBaseObject mapObject, ITileAgentHelper tileAgentHelper) 
            {
                if (mapObject == null)
                {
                    throw new GameFrameworkException("mapObject is invalid.");
                }

                if (tileAgentHelper == null)
                {
                    throw new GameFrameworkException("tileAgentHelper is invalid.");
                }

                m_MapObject = mapObject;      
                m_TileAgentHelper = tileAgentHelper;
                m_Serialid = 0;
                m_TileAsset = null;
            }

            public IMapBaseObject mapBaseObject 
            {
                get { return m_MapObject; }
            }

            public Vector2 V2
            {   set { m_V2 = value; }
                get { return m_V2; }
            }

            /// <summary>
            /// ��ȡ�����õ�ͼ�����б�š�
            /// </summary>
            public int SerialId
            {
                set { m_Serialid = value; }
                get { return m_Serialid; }
            }

            /// <summary>
            /// ��ȡ��ͼ��������
            /// </summary>
            public ITileAgentHelper Helper
            {
                get { return m_TileAgentHelper; }
            }

            /// <summary>
            /// �������á�
            /// </summary>
            public void Clear() { }
        }
    }

}
