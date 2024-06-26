using Core.Services;
using Goods.ScriptableObjects;
using KaifGames;
using KaifGames.Monobehaviours;
using KaifGames.Services;
using SaveLoadSystem.ScriptableObjects;
using SaveLoadSystem.Systems;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Core
{
    public class MainLifeTimeScope : LifetimeScope
    {
        [SerializeField] private ProgressBar _progressBar;
        
        [SerializeField] private GoodsDatabase _goodsDatabase;

        [SerializeField] private PlayerInfo _playerInfo;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<GameDataProvider>(Lifetime.Singleton);
            
            builder.Register<LoadService>(Lifetime.Singleton).AsImplementedInterfaces();
            
            builder.RegisterInstance(_goodsDatabase);

            builder.RegisterComponent(_playerInfo);
            
            builder.Register<ProgressBarService>(Lifetime.Singleton).AsImplementedInterfaces().AsSelf();
            builder.Register<JsonSaveLoadService>(Lifetime.Singleton).AsImplementedInterfaces();
            
            builder.RegisterComponent(_progressBar);
        }
    }
}