using Goods.Services;
using Goods.Views;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Goods.Installers
{
    public class GoodsLifeTimeScoped : LifetimeScope
    {
        [SerializeField] private GoodsView _goodsViewPrefab;

        [SerializeField] private Transform _goodsViewParent;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(_goodsViewPrefab);

            builder.Register<GoodsService>(Lifetime.Singleton).AsImplementedInterfaces().WithParameter(_goodsViewParent);
        }
    }
}