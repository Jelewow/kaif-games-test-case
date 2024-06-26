using FloatingPopup.Monobehaviours;
using SaveLoadSystem.ScriptableObjects;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace KaifGames.FloatingPopup
{
    public class FloatingPopupService 
    {
        [Inject] private FloatingNumber _floatingNumberPrefab;
        [Inject] private FloatingPopup _floatingPopup;
        [Inject] private IObjectResolver _objectResolver;

        [Inject] private GameDataProvider _gameDataProvider;
        
        public void CreateFloatingNumber()
        {
            var clickPosition = Input.mousePosition;
            var number = _objectResolver.Instantiate(_floatingNumberPrefab, clickPosition, Quaternion.identity,
                _floatingPopup.Canvas.transform);
            
            number.Animate(_gameDataProvider.GameData.ScorePerClick);
        }
    }
}