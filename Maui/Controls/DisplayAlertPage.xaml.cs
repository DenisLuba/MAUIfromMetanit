
namespace MetanitLessons.Maui.Controls;

/**
 * Для создания всплывающих окон в .NET MAUI используются специальные методы, 
 * которые определены у объекта Page, а поэтому есть у любой страницы:

Task DisplayAlert (string title, string message, string cancel) 

Task<bool> DisplayAlert (string title, string message, string accept, string cancel) 

Task<bool> DisplayAlert (string title, string message, string accept, string cancel, FlowDirection flowDirection) 

Task<string> DisplayActionSheet (string title, string cancel, 
                            string destruction, params string[] buttons)

Task<string> DisplayPromptAsync(string title, string message, string accept = "OK", 
                            string cancel = "Cancel", string placeholder = null, int maxLength = -1, 
                            Keyboard keyboard = null, string initialValue = "");
 */

public partial class DisplayAlertPage : ContentPage
{
	public DisplayAlertPage()
	{
		Button alertButton = new Button
		{
			Text = "Alert",
			VerticalOptions = LayoutOptions.Start,
			HorizontalOptions = LayoutOptions.Center,
			Margin = new Thickness(0, 20)
		};
		alertButton.Clicked += AlertButtonClicked;

		Content = alertButton;
	}

	private async void AlertButtonClicked(object? sender, EventArgs e)
	{
		bool result = await DisplayAlert("Confirm the action", "Do you want to delete the emlement?", "Yes", "No");
		if (result)
		{
			await DisplayAlert("Notice", "You chose YES", "OK");
		}
		else
		{
			await DisplayAlert("Notice", "You chose NO", "Cancel");
		}
	}

	//async void AlertButtonClicked(object? sender, EventArgs e)
	//{
	//	await DisplayAlert("Notice", "New message came", "OK");
	//}


}