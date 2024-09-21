namespace MetanitLessons.Maui.Controls;

/** ProgressBar
 * ��������:

Progress ������������ �������� ���� double, ������� ������������ �������� ���������. 
	������ ����� ��������� � ��������� �� 0 �� 1. �������� �� ��������� - 0.

	����� ��������, ��� �������� ������ 0 ����� ��������� �� 0, 
		� �������� ������ 1 ����� ��������� �� 1

ProgressColor ������������� ���� ��������

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

	// ����� OnAppearing() ����������, ����� �������� �������� ������������
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