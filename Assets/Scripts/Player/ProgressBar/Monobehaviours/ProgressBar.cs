using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace KaifGames.Monobehaviours
{
    public class ProgressBar : MonoBehaviour
    {
        [SerializeField] private Slider _progressBar;
        [SerializeField] private float _duration;

        private int _maxValue;

        public void AddValue(float value)
        {
            _progressBar.DOValue(value, _duration);
        }

        public void Clear()
        {
            _progressBar.DOValue(0, _duration);
        }
    }
}