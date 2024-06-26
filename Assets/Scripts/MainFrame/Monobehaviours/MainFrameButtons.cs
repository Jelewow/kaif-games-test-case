using System.Collections.Generic;
using UnityEngine;

namespace MainFrame.Monobehaviours
{
    public class MainFrameButtons : MonoBehaviour
    {
        [SerializeField] private List<Frame> _frames;

        private void OnEnable()
        {
            _frames.ForEach(frame => frame.FrameSelected += OnFrameSelected);
        }

        private void OnDisable()
        {
            _frames.ForEach(frame => frame.FrameSelected -= OnFrameSelected);
        }
        
        public void SetFrame(Frame frame)
        {
            OnFrameSelected(frame);
        }
        
        private void OnFrameSelected(Frame frame)
        {
            foreach (var otherFrame in _frames)
            {
                if (frame == otherFrame)
                    otherFrame.Select();
                else
                    otherFrame.Deselect();
            }
        }
    }
}