
namespace MetanitLessons.Maui.Controls;

/** DisplayPromptAsync

Task<string> DisplayPromptAsync(
							string title, 
							string message, 
							string accept = "OK", 
							string cancel = "Cancel", 
							string placeholder = null, 
							int maxLength = -1, 
							Keyboard keyboard = null, 
							string initialValue = "");

	title: ��������� ����

	message: ����������� � �����

	accept: ����� ��� ������ ������������� �����

	cancel: ����� ��� ������ ������. ����� ���� ����� null, ���� �� ����� ������ ��� ������

	placeholder: �����-���������� � ��������� ���� �����

	maxLength: ������������ ����� ���������� ���� �����

	keyboard: ������ KeyBoard, ������� ������������� ��� ���������� ��� �����

	initialValue: ��������� �������� � ���� �����

 */

public partial class DisplayPromptAsyncPage : ContentPage
{
	Label nameLabel;

	public DisplayPromptAsyncPage()
	{
		Button alertButton = new Button { Text = "Alert", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Start };
		alertButton.Clicked += AlertButtonClicked;
		nameLabel = new Label();
		Content = new StackLayout { Children = { alertButton, nameLabel } };
	}

	async void AlertButtonClicked(object? sender, EventArgs e)
	{
		string name = await DisplayPromptAsync("Login", "Enter a name:", "OK", "Cancel");
		nameLabel.Text = name;
	}
}