using GameFramework.Sound;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework.Map
{
    internal sealed partial class MapManager : GameFrameworkModule, IMapManager
    {        
        /// <summary>
        /// µØÍ¼»ùÀà
        /// </summary>
        public sealed class MapBaseObject : IMapBaseObject
        {
            private readonly string m_Name;
            private readonly IMapBaseObjectHelper m_MapBaseObjectHelper;  
            private readonly Dictionary<Vector2, TileAgent> m_Tiles;

            public MapBaseObject(string name, IMapBaseObjectHelper mapBaseObjectHelper)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new GameFrameworkException("Sound group name is invalid.");
                }

                if (mapBaseObjectHelper == null)
                {
                    throw new GameFrameworkException("mapBaseObjectHelper is invalid.");
                }
                m_Name = name;
                m_MapBaseObjectHelper = mapBaseObjectHelper;
                m_Tiles = new Dictionary<Vector2, TileAgent>();
            }

            public string Name
            {
                get
                {
                    return m_Name;
                }
            }

            public int Count
            {
                get { return m_Tiles.Count; }
            }

            public IMapBaseObjectHelper Helper 
            {
                get { return m_MapBaseObjectHelper; }
            }

            public void CreatMap()
            {
                throw new System.NotImplementedException();
            }

            public void DestroyMap()
            {
                throw new System.NotImplementedException();
            }

            public void RemoveTile(int index)
            {
                throw new System.NotImplementedException();
            }
        }
    }

}
