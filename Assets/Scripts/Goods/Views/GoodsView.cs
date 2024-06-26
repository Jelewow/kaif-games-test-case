using Goods.ScriptableObjects;
using KaifGames;
using SaveLoadSystem.Interfaces;
using SaveLoadSystem.ScriptableObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace Goods.Views
{
    public class GoodsView : MonoBehaviour
    {
        [Inject] private GameDataProvider _gameDataProvider;
        [Inject] private PlayerInfo _playerInfo;
        [Inject] private ISaveSystem _saveSystem;
        
        private GoodsData _goodsData;

        [SerializeField] private TMP_Text _name;
        [SerializeField] private TMP_Text _cost;
        [SerializeField] private TMP_Text _upgradesClick;
        [SerializeField] private Button _buyButton;

        private void OnEnable()
        {
            _buyButton.onClick.AddListener(OnButtonClick);
        }

        private void OnDisable()
        {
            if (!_buyButton.interactable)
                return;
            
            _buyButton.onClick.RemoveListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            if (_gameDataProvider.GameData.AllClicks < _goodsData.Cost)
                return;
            
            _buyButton.onClick.RemoveListener(OnButtonClick);
            
            _gameDataProvider.GameData.Buy(_goodsData.Id);
            _gameDataProvider.GameData.ClickUp(_goodsData.UpgradesClick, _goodsData.Cost);
            _playerInfo.Setup();
            _buyButton.interactable = false;
            
            _saveSystem.Save(_gameDataProvider.GameData);
        }

        public void Setup(GoodsData goodsData)
        {
            _goodsData = goodsData;
            _name.text = goodsData.Name;
            _cost.text = goodsData.Cost.ToString();
            _upgradesClick.text = goodsData.UpgradesClick.ToString();
            _buyButton.interactable = !_gameDataProvider.GameData.BoughtGoods.Contains(_goodsData.Id);
        }
    }
}