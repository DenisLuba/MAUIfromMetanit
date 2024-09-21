
namespace MetanitLessons.Maui.Controls;

/**
 * DisplayActionSheet

Task<string> DisplayActionSheet (String title, String cancel, String destruction, params String[] buttons)

	title: заголовок окна

	cancel: текст для кнопки отмены. Может быть равен null, если мы хотим скрыть эту кнопку

	destruction: текст для кнопки удаления. Также для скрытия этой кнопки можно передать значение null

	buttons: текстовые метки для дополнительных кнопок
 */

public partial class DisplayActionSheetPage : ContentPage
{
	Label actionLabel;

	public DisplayActionSheetPage()
	{
		Button alertButton = new Button
		{
			Text = "Alert",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Start,
			Margin = new Thickness(20)
		};

		alertButton.Clicked += AlertButtonClicked;
		actionLabel = new Label();
		Content = new StackLayout { Children = { alertButton, actionLabel } };
	}

	async void AlertButtonClicked(object? sender, EventArgs e)
	{
		string action = await DisplayActionSheet("Choose the language", "Cancel", "Delete", "C#", "JavaScript", "Java");
		actionLabel.Text = action;
	}
}