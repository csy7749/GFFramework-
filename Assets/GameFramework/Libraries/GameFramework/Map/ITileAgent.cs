using GameFramework.Sound;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework.Map
{
    public interface ITileAgent
    {
        /// <summary>
        /// ��ͼ�����ڵ�ͼ
        /// </summary>
        IMapBaseObject mapBaseObject { get; }

        /// <summary>
        /// ��ȡ��ͼ����������
        /// </summary>
        ITileAgentHelper Helper
        {
            get;
        }

        /// <summary>
        /// ��ȡ��ͼ������б�š�
        /// </summary>
        int SerialId
        {
            get;
        }
    }
}

