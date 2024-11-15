

namespace MetanitLessons.Maui.Navigation.StackNavigation;

public class Page2 : ContentPage
{
	Label stackLabel;


	public Page2()
	{
		Title = "Page 2";
		Button forwardButton = new Button { Text = "������" };
		forwardButton.Clicked += GoToForward;

		Button backButton = new Button { Text = "�����" };
		backButton.Clicked += GoToBack;

		stackLabel = new Label();

		Content = new StackLayout { forwardButton, backButton, stackLabel };
	}

	// ������� ����� �� MainPage
	private async void GoToBack(object? sender, EventArgs e)
	{
		await Navigation.PopAsync();
		// ������� ��������, ���� ���������, ����� �������� ���������� �����
		if (Application.Current?.MainPage is NavigationPage navigationPage)
		{
			if (navigationPage.CurrentPage is Maui.Navigation.StackNavigation.MainPage mainPage)
			{
				mainPage.DisplayStack();
			}
		}
	}

	// ������� ������ �� Page3
	private async void GoToForward(object? sender, EventArgs e)
	{
		Page3 page = new Page3();
		await Navigation.PushAsync(page);
		page.DisplayStack(); // �������� � Page3 ����� DisplayStack
	}

	// ����� ���������� ���� ������� � ��������� ����� stackLabel
	protected internal void DisplayStack()
	{
		if (Application.Current?.MainPage is NavigationPage navigationPage)
		{
			// ������� ���� ���������
			stackLabel.Text = "";
			foreach (Page page in navigationPage.Navigation.NavigationStack)
			{
				stackLabel.Text = $"{page.Title}\n{stackLabel.Text}";
			}
		}
	}
}