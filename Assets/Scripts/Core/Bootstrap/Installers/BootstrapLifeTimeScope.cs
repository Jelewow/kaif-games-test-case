using Bootstrap;
using Bootstrap.Utils;
using KaifGames;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using IInitializable = VContainer.Unity.IInitializable;

public class BootstrapLifeTimeScope : LifetimeScope
{
    [SerializeField] private CoroutineRunner _coroutineRunnerPrefab;
    [SerializeField] private LoadingScreen _loadingScreenPrefab;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<BootstrapService>(Lifetime.Singleton).As<IInitializable>();
        
        builder.RegisterComponentInNewPrefab(_coroutineRunnerPrefab, Lifetime.Scoped).As<ICoroutineRunner>();

        builder.RegisterComponentInNewPrefab(_loadingScreenPrefab, Lifetime.Scoped);
    }
}
