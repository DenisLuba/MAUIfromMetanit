
namespace MetanitLessons.Maui.Controls;

/**
 * DisplayActionSheet

Task<string> DisplayActionSheet (String title, String cancel, String destruction, params String[] buttons)

	title: ��������� ����

	cancel: ����� ��� ������ ������. ����� ���� ����� null, ���� �� ����� ������ ��� ������

	destruction: ����� ��� ������ ��������. ����� ��� ������� ���� ������ ����� �������� �������� null

	buttons: ��������� ����� ��� �������������� ������
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