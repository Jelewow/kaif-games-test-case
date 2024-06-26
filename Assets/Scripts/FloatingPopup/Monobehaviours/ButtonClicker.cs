using KaifGames;
using KaifGames.FloatingPopup;
using KaifGames.Services;
using SaveLoadSystem.Interfaces;
using SaveLoadSystem.ScriptableObjects;
using UnityEngine;
using UnityEngine.EventSystems;
using VContainer;

namespace ClickButton
{
    public class ButtonClicker : MonoBehaviour, IPointerDownHandler
    {
        [Inject] private FloatingPopupService _floatingPopupService;
        [Inject] private ProgressBarService _progressBarService;
        [Inject] private PlayerInfo _playerInfo;
        
        [Inject] private ISaveSystem _saveSystem;
        [Inject] private GameDataProvider _gameDataProvider;
        
        public void OnPointerDown(PointerEventData eventData)
        {
            OnButtonClick();
        }
        
        private void OnButtonClick()
        {
            _floatingPopupService.CreateFloatingNumber();
            _progressBarService.Add();
            _playerInfo.Setup();
            _saveSystem.Save(_gameDataProvider.GameData);
        }
    }
}