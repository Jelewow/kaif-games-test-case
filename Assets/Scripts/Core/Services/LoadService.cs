using SaveLoadSystem.Interfaces;
using SaveLoadSystem.ScriptableObjects;
using VContainer;
using VContainer.Unity;

namespace Core.Services
{
    public class LoadService : IInitializable
    {
        [Inject] private ISaveSystem _saveSystem;
        [Inject] private GameDataProvider _gameDataProvider;
        [Inject] private IObjectResolver _objectResolver;
        
        public void Initialize()
        {
            _gameDataProvider.GameData = _saveSystem.Load();
        }
    }
}