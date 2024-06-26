using System;
using System.Collections.Generic;
using KaifGames.ScriptableObjects;

namespace SaveLoadSystem.ScriptableObjects
{
    [Serializable]
    public class GameData
    {
        public int AllClicks;
        public int ClicksInCurrentLevel;
        public int ScorePerClick;
        public LevelData CurrentLevel;
        
        public HashSet<int> BoughtGoods;

        public GameData()
        {
            BoughtGoods = new HashSet<int>();
            AllClicks = 0;
            ClicksInCurrentLevel = 0;
            ScorePerClick = 1;
            CurrentLevel = new LevelData
            {
                ClickToNextLvl = 5,
                Level = 0
            };
        }
        
        public void AddClick(int scorePerClick)
        {
            ClicksInCurrentLevel += scorePerClick;
            AllClicks += scorePerClick;
        }
        
        public void ClickUp(int scorePerClick, int cost)
        {
            ScorePerClick = scorePerClick;
            AllClicks -= cost;
        }
        
        public void AddLevel()
        {
            var data = CurrentLevel;
            data.Level++;
            data.ClickToNextLvl *= 2;
            CurrentLevel = data;

            ClicksInCurrentLevel = 0;
        }

        public void Buy(int goodsId)
        {
            BoughtGoods.Add(goodsId);
        }
    }
}