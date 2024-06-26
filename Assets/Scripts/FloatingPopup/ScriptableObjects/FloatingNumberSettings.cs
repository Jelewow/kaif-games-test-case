using UnityEngine;

namespace FloatingPopup
{
    [CreateAssetMenu(menuName = "Number Settings")]
    public class FloatingNumberSettings : ScriptableObject
    {
        [field: SerializeField] public float FloatingSpeed { get; private set; }
        [field: SerializeField] public float FloatingDuration { get; private set; }
        [field: SerializeField] public float FadeDuration { get; private set; }
    }
}