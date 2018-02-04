using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmXSample.Core;

namespace MvvmXSample.iOS
{
	public partial class LoginViewController : MvxViewController<LoginViewModel>
	{
		public LoginViewController() : base("LoginViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			NavigationController.NavigationBarHidden = true;
			SetBindings();

		}

		void SetBindings()
		{
			var set = this.CreateBindingSet<LoginViewController, LoginViewModel>();
			set.Bind(UName).To(vm => vm.UserName);
			set.Bind(Pass).To(vm => vm.Password);
			set.Bind(LoginBtn).To(vm => vm.LoginCommand);
			set.Apply();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}
	}
}

