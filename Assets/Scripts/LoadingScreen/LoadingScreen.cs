using DG.Tweening;
using UnityEngine;

namespace KaifGames
{
    public class LoadingScreen : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _canvasGroup;
        
        [SerializeField] private float _durationToHide;
        [SerializeField] private float _durationToShow;

        private void Awake()
        {
            gameObject.SetActive(false);
            _canvasGroup.alpha = 0;
            
            DontDestroyOnLoad(this);
        }

        public void Show()
        {
            gameObject.SetActive(true);
            _canvasGroup.DOFade(1, _durationToShow);
        }

        public void Hide()
        {
            _canvasGroup.DOFade(0, _durationToHide).OnComplete(() => gameObject.SetActive(false));
        }
    }
}