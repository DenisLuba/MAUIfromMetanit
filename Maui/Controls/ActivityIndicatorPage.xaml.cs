namespace MetanitLessons.Maui.Controls;

/** ActivityIndicator
 * Свойства:

	IsRunning: при значении true индиктор активен.

	Color: цвет индикатора

 */

public partial class ActivityIndicatorPage : ContentPage
{
	ActivityIndicator activityIndicator = new ActivityIndicator { IsRunning = true, Color = Colors.SeaGreen };
	Label label = new Label();

	public ActivityIndicatorPage()
	{
		StackLayout stackLayout = new StackLayout { Children = { label, activityIndicator }, Padding = 20 };
		Content = stackLayout;
	}

	protected override async void OnAppearing()
	{
		int count = 0;
		while (count != 100)
		{
			label.Text = $"The state of the process: {count} %";
			await Task.Delay(1000);
			count += 10;
		}
		label.Text = "The process completed";
		activityIndicator.IsRunning = false;

		base.OnAppearing();
	}
}