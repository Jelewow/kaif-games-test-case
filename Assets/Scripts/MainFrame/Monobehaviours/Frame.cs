using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MainFrame.Monobehaviours
{
    public class Frame : MonoBehaviour
    {
        [SerializeField] private TMP_Text _buttonText;
        [SerializeField] private Button _button;
        [SerializeField] private GameObject _container;
        
        public event Action<Frame> FrameSelected;

        private void OnEnable()
        {
            _button.onClick.AddListener(OnFrameSelected);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnFrameSelected);
        }

        private void OnFrameSelected()
        {
            FrameSelected?.Invoke(this);
        }

        public void Select()
        {
            _button.interactable = false;
            _buttonText.color = Color.white;
            _container.SetActive(true);
        }

        public void Deselect()
        {
            _button.interactable = true;
            _buttonText.color = Color.black;
            _container.SetActive(false);
        }
    }
}