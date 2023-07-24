using BMIdemo.MVVM.Views;

namespace BMIdemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();

		MainPage = new BMIView();
	}
}
