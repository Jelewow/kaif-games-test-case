using KaifGames.Services;
using SaveLoadSystem.ScriptableObjects;
using TMPro;
using UnityEngine;
using VContainer;

namespace KaifGames
{
    public class PlayerInfo : MonoBehaviour
    {
        [Inject] private GameDataProvider _gameDataProvider;
        [Inject] private ProgressBarService _progressBarService;
        
        [SerializeField] private TMP_Text _clickLeft;
        [SerializeField] private TMP_Text _allClicks;
        [SerializeField] private TMP_Text _level;
        [SerializeField] private TMP_Text _scorePerClick;

        private void Awake()
        {
            Setup();
            _progressBarService.Load();
        }

        public void Setup()
        {
            _level.text = "Level " + _gameDataProvider.GameData.CurrentLevel.Level;
            _scorePerClick.text = _gameDataProvider.GameData.ScorePerClick + "/per click";
            _clickLeft.text = _gameDataProvider.GameData.CurrentLevel.ClickToNextLvl - _gameDataProvider.GameData.ClicksInCurrentLevel + " click left";
            _allClicks.text = "all clicks " + _gameDataProvider.GameData.AllClicks;
        }
    }
}