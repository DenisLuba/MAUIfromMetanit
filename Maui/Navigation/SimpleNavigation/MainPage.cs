
namespace MetanitLessons.Maui.Navigation.SimpleNavigation;

public class MainPage : ContentPage
{
	public MainPage()
	{
		Title = "Main";
		Button toCommonPageButton = new Button
		{
			Text = "Common",
			HorizontalOptions = LayoutOptions.Start
		};
		toCommonPageButton.Clicked += ToCommonPage;

		Button toModalPageButton = new Button
		{
			Text = "Modal",
			HorizontalOptions = LayoutOptions.Start
		};
		toModalPageButton.Clicked += ToModalPage;

		Content = new StackLayout { Children = { toCommonPageButton, toModalPageButton } };
	}

	private async void ToModalPage(object? sender, EventArgs e)
		=> await Navigation.PushModalAsync(page: new ModalPage(), animated: true);
	
	private async void ToCommonPage(object? sender, EventArgs e)
		=> await Navigation.PushAsync(page: new CommonPage(), animated: true);
}