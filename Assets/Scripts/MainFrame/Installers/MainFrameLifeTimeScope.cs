using MainFrame.Monobehaviours;
using MainFrame.Services;
using SaveLoadSystem.Systems;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace MainFrame.Installers
{
    public class MainFrameLifeTimeScope : LifetimeScope
    {
        [SerializeField] private Frame _mainFrame;
        [SerializeField] private MainFrameButtons _mainFrameButtons;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<MainFrameWindowService>(Lifetime.Singleton).AsImplementedInterfaces();
            
            builder.RegisterComponent(_mainFrame);
            builder.RegisterComponent(_mainFrameButtons);
        }
    }
}