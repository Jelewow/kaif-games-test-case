using SaveLoadSystem.ScriptableObjects;

namespace SaveLoadSystem.Interfaces
{
    public interface ISaveSystem
    {
        void Save(GameData gameData);
        GameData Load();
    }
}