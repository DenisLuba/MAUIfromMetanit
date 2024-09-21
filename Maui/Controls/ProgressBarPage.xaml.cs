namespace MetanitLessons.Maui.Controls;

/** ProgressBar
 * —войства:

Progress представл€ет значение типа double, которое представл€ет значение прогресса. 
	ƒанное число находитс€ в диапазоне от 0 до 1. «начение по умолчанию - 0.

	—тоит отметить, что значени€ меньше 0 будут округлены до 0, 
		а значени€ больше 1 будут округлены до 1

ProgressColor устанавливает цвет элемента

 */

public partial class ProgressBarPage : ContentPage
{
	ProgressBar progressBar = new ProgressBar { ProgressColor = Colors.SeaGreen };
	Label label = new Label();

	public ProgressBarPage()
	{
		StackLayout stackLayout = new StackLayout { Children = { label, progressBar }, Padding = 20 };
		Content = stackLayout;
	}

	// метод OnAppearing() вызываетс€, когда страница начинает отображатьс€
	protected override async void OnAppearing()
	{
		while(progressBar.Progress < 0.9)
		{
			progressBar.Progress += 0.1;
			label.Text = $"The state of the process: {Math.Round(progressBar.Progress, 1) * 100} %";
			await Task.Delay(1000);
		}
		label.Text = "The process completed";
		base.OnAppearing();
	}
}