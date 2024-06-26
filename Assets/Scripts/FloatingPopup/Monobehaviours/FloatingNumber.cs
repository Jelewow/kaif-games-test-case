using DG.Tweening;
using TMPro;
using UnityEngine;
using VContainer;

namespace FloatingPopup.Monobehaviours
{
    public class FloatingNumber : MonoBehaviour
    {
        [Inject] private FloatingNumberSettings _settings;

        [SerializeField] private TMP_Text _text;
        
        public void Animate(int scorePerClick)
        {
            _text.text = "+" + scorePerClick;
            transform.DOMove(transform.position + Vector3.up * _settings.FloatingSpeed, _settings.FloatingDuration);
            _text.DOFade(0f, _settings.FadeDuration).OnComplete(() => gameObject.SetActive(false));
        }
    }
}