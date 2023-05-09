using CommunityToolkit.Mvvm.Input;

namespace MauiMediaElementCrashingSample;
public partial class MainPageViewModel
{
	public MainPageViewModel()
	{

	}

	[RelayCommand]
	async Task GoToVideoPage()
	{
		await Shell.Current.GoToAsync(nameof(NewPage1));
	}
}
