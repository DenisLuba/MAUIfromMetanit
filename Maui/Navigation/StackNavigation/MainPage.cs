
using System.Text;

namespace MetanitLessons.Maui.Navigation.StackNavigation;

public class MainPage : ContentPage
{
	Label stackLabel;
	bool loaded;


	public MainPage()
	{
		Title = "Main Page";

		Button forwardButton = new Button { Text = "������" };
		forwardButton.Clicked += GoToForward;

		stackLabel = new Label();

		Content = new StackLayout { forwardButton, stackLabel };
	}

	// ����� OnAppearing ����������� ����� �������� ��������,
	// �� ������ ������ ����� ������ ����������� (�� ����� ����������� � �� �����,
	// ���� ������ ������� �������� PushAsync() � PopAsync() ��� ��������� �� �����������)
	protected override void OnAppearing()
	{
		base.OnAppearing();
		// �� ���� �������� ����� DisplayStack ����������� ���� ����� ������ �������� (?),
		// ������� ����� �������������� ���������� loaded
		if (!loaded)
		{
			DisplayStack();
			loaded = true;
		}
	}

	// ����� ���������� ���� ������� � ��������� ����� stackLabel
	// ����� �������� ����� ����, ���� ���������� � NavigationPage:
	// NavigationPage? navigationPage = Application.Current?.MainPage as NavigationPage;
	// var stack = navigationPage?.Navigation.NavigationStack;
	protected internal void DisplayStack()
	{
		if (Application.Current?.MainPage is NavigationPage navigationPage) 
		{
			stackLabel.Text = "";

			foreach (Page page in navigationPage.Navigation.NavigationStack)
			{
				stackLabel.Text = $"{page.Title}\n{stackLabel.Text}";
			}
		}

	}

	// ������� ������ �� Page2
	private async void GoToForward(object? sender, EventArgs e)
	{
		Page2 page = new Page2();
		await Navigation.PushAsync(page);
		page.DisplayStack();
	}
}