using BMIdemo.MVVM.ViewModels;

namespace BMIdemo.MVVM.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		this.BindingContext = new BMIViewModel(); 
	}
}