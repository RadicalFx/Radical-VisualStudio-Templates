using System.Windows;
using Topics.Radical.Windows.Presentation.Boot;

namespace RadicalTemplate
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public App()
		{
			var bootstrapper = new WindsorApplicationBootstrapper<Presentation.MainView>();
		}
	}
}
