using Goods.ScriptableObjects;
using Goods.Views;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Goods.Services
{
    public class GoodsService : IInitializable
    {
        [Inject] private IObjectResolver _objectResolver;
        [Inject] private GoodsDatabase _goodsDatabase;
        [Inject] private GoodsView _goodsView;

        [Inject] private Transform _parent;
        
        public void Initialize()
        {
            for (int i = 0; i < _goodsDatabase.Count; i++)
            {
                var goods = _objectResolver.Instantiate(_goodsView, _parent);
                goods.Setup(_goodsDatabase[i]);
            }
        }
    }
}