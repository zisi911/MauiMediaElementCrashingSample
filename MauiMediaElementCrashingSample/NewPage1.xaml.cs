namespace MauiMediaElementCrashingSample;

public partial class NewPage1 : ContentPage
{

    public NewPage1()
	{
        InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
    }

    protected override void OnDisappearing()
    {
        VideoPlayer.Handler?.DisconnectHandler();

        base.OnDisappearing();

    }

}