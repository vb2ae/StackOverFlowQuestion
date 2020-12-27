using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Caliburn.Micro;

namespace StackOverFlowQuestion.ViewModels
{
    public class ShellViewModel : Screen
    {
        private readonly SimpleContainer container;
        private INavigationService navigationService;
        private ILog log;

        public ShellViewModel(SimpleContainer container)
        {
            this.container = container;
            log = LogManager.GetLog(this.GetType());
            log.Info("ShellViewModel constructor");
        }

        public void RegisterFrame(Frame frame)
        {
            navigationService = new FrameAdapter(frame);

            container.Instance(navigationService);

            navigationService.NavigateToViewModel(typeof(HomeViewModel));
        }
    }
}
