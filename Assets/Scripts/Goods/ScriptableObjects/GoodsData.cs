using System.Collections.Generic;
using UnityEngine;

namespace Goods.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Goods Data")]
    public class GoodsData : ScriptableObject
    {
        [field : SerializeField]
        public int Id { get; private set; }
        
        [field : SerializeField]
        public string Name { get; private set; }
        
        [field : SerializeField]
        public int Cost { get; private set; }
        
        [field : SerializeField]
        public int UpgradesClick { get; private set; }
    }
}