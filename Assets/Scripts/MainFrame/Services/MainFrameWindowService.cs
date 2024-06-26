using MainFrame.Monobehaviours;
using VContainer;
using VContainer.Unity;

namespace MainFrame.Services
{
    public class MainFrameWindowService : IInitializable
    {
        [Inject] private MainFrameButtons _mainFrameButtons;
        [Inject] private Frame _mainFrame;
        
        public void Initialize()
        {
            _mainFrameButtons.SetFrame(_mainFrame);
        }
    }
}