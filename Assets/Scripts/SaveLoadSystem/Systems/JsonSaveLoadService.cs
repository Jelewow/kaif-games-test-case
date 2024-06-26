using System.IO;
using Newtonsoft.Json;
using SaveLoadSystem.Interfaces;
using SaveLoadSystem.ScriptableObjects;
using UnityEngine;

namespace SaveLoadSystem.Systems
{
    public class JsonSaveLoadService : ISaveSystem
    {
        private readonly string _filePath = Application.persistentDataPath + "/Save.json";

        public void Save(GameData gameData)
        {
            
            var json = JsonConvert.SerializeObject(gameData);

            using var writer = new StreamWriter(_filePath);
            writer.WriteLine(json);
        }

        public GameData Load()
        {
            var json = "";

            if (!File.Exists(_filePath))
            {
                return new GameData();
            }
            
            using (var reader = new StreamReader(_filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    json += line;
            }

            return string.IsNullOrEmpty(json) ? new GameData() : JsonConvert.DeserializeObject<GameData>(json);
        }
    }
}