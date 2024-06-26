using ClickButton;
using FloatingPopup;
using FloatingPopup.Monobehaviours;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace KaifGames.FloatingPopup.Installers
{
    public class FloatingPopupLifeTimeScope : LifetimeScope
    {
        [SerializeField] private FloatingNumberSettings _numberSettings;
        
        [SerializeField] private FloatingNumber _floatingNumberPrefab;
        [SerializeField] private FloatingPopup _floatingPopup;
        
        [SerializeField] private ButtonClicker _buttonClicker;
        [SerializeField] private PlayerInfo _playerInfo;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(_numberSettings);
            
            builder.Register<FloatingPopupService>(Lifetime.Singleton);

            builder.RegisterComponent(_floatingNumberPrefab);
            builder.RegisterComponent(_floatingPopup);
            builder.RegisterComponent(_buttonClicker);
            builder.RegisterComponent(_playerInfo);
        }
    }
}