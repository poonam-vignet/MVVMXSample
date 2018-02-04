using MvvmCross.Core.ViewModels;
using MvvmXSample.Core.ViewModels;

namespace MvvmXSample.Core
{
	public class LoginViewModel : MvxViewModel
	{
		public LoginViewModel()
		{
		}
		public override void Start()
		{
			base.Start();

		}

		string _userName = "";
		public string UserName
		{
			get
			{
				return _userName;
			}
			set
			{
				SetProperty(ref _userName, value);
				RaisePropertyChanged();
			}
		}


		string _password = "";
		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				SetProperty(ref _password, value);
				RaisePropertyChanged();
			}
		}

		private IMvxCommand _loginCommand;

		public IMvxCommand LoginCommand
		{
			get
			{

				_loginCommand = new MvxCommand(AttemptLogin, CanExecuteFun);
				return _loginCommand;
			}

		}
		bool canExecute = true;

		private void AttemptLogin()
		{
			if ((UserName == ProjectConstants.validUserName) &&
				(Password == ProjectConstants.validPassword))
			{
				canExecute = true;
				ShowViewModel<MainViewModel>();

			}

		}
		public bool CanExecuteLogin
		{
			get
			{
				return canExecute;
			}
		}
		public bool CanExecuteFun()
		{
			return canExecute;
		}

	}
}
