namespace MauiMediaElementCrashingSample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();	
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		//this.Navigation.PushAsync(new NewPage1());
		 //Shell.Current.GoToAsync(nameof(NewPage1));
    }
}

