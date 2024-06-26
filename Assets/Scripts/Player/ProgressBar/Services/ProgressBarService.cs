using KaifGames.Monobehaviours;
using SaveLoadSystem.ScriptableObjects;
using VContainer;

namespace KaifGames.Services
{
    public class ProgressBarService
    {
        [Inject] private ProgressBar _progressBar;
        [Inject] private GameDataProvider _gameDataProvider;

        public void Load()
        {
            UpdateProgressBar();
        }
        
        public void Add()
        {
            _gameDataProvider.GameData.AddClick(_gameDataProvider.GameData.ScorePerClick);
            UpdateProgressBar();
            
            if (!(_gameDataProvider.GameData.ClicksInCurrentLevel >= _gameDataProvider.GameData.CurrentLevel.ClickToNextLvl))
                return;

            _gameDataProvider.GameData.AddLevel();
            _progressBar.Clear();
        }

        private void UpdateProgressBar()
        {
            _progressBar.AddValue( (float)_gameDataProvider.GameData.ClicksInCurrentLevel / _gameDataProvider.GameData.CurrentLevel.ClickToNextLvl);
        }
    }
}