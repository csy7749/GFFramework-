using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework.Map
{
    /// <summary>
    /// ��ͼ�ӿ�
    /// </summary>
    public interface IMapBaseObject
    {
        /// <summary>
        /// ��ͼ����
        /// </summary>
        string Name { get; }
        /// <summary>
        /// ��ͼ�Ŀ���
        /// </summary>
        int Count { get; }

        /// <summary>
        /// ��ȡ��ͼ�������ӿ�
        /// </summary>
        IMapBaseObjectHelper Helper { get; }

        /// <summary>
        /// �Ƴ���ͼ��
        /// </summary>
        /// <param name="index"></param>
        void RemoveTile(int index);

        /// <summary>
        /// ���ɵ�ͼ
        /// </summary>
        void CreatMap();

        /// <summary>
        /// ɾ����ͼ
        /// </summary>
        void DestroyMap();
    }
}

