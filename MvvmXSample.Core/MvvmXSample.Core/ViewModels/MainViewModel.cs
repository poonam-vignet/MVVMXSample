using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace MvvmXSample.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel()
        {
        }
        
        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }
        
        public IMvxCommand NavigateToLoginCommand => new MvxCommand(NavigateToLogin);
        private void NavigateToLogin()
        {
            Text = "Hello MvvmCross";
			ShowViewModel<LoginViewModel>();

        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}