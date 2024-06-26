using System.Collections;
using System.Collections.Generic;
using SaveLoadSystem.ScriptableObjects;
using UnityEngine;

namespace Goods.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Goods Database")]
    public class GoodsDatabase : ScriptableObject
    {
        [SerializeField] private List<GoodsData> _datas;

        public IReadOnlyList<GoodsData> Database => _datas;
        public int Count => _datas.Count;
        
        public GoodsData this[int index] => _datas[index];
    }
}