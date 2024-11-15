
namespace MetanitLessons.Maui.Navigation.StackNavigation;

public class Page3 : ContentPage
{
	Label stackLabel;


	public Page3()
	{
		Title = "Page 3";

		Button backButton = new Button { Text = "�����" };
		backButton.Clicked += GoToBack;

		Button rootButton = new Button { Text = "�� �������" };
		rootButton.Clicked += GoToRoot;

		stackLabel = new Label();

		Content = new StackLayout { backButton, rootButton, stackLabel };
	}

	private async void GoToRoot(object? sender, EventArgs e)
	{
		await Navigation.PopToRootAsync(); // ������� �� ��������� ��������

		if (Application.Current?.MainPage is NavigationPage navigationPage)
			if (navigationPage.CurrentPage is Maui.Navigation.StackNavigation.MainPage page)
				page.DisplayStack();
	}

	private async void GoToBack(object? sender, EventArgs e)
	{
		await Navigation.PopAsync();
		// ������� ��������, ���� ���������, ����� �������� ���������� �����
		// �������� �������� ���������
		if (Application.Current?.MainPage is NavigationPage navigationPage)
		{
			// �������� �������� Page2 � �������� � ��� ����� DisplayStack
			//if (navigationPage.CurrentPage is Page2 page) page.DisplayStack();

			// �� ����� � ���:
			// �������� ��������� �������� � �����
			int pageCount = navigationPage.Navigation.NavigationStack.Count;
			// navigationPage.Navigation.NavigationStack[pageCount - 1] - �������� Page2
			if (navigationPage.Navigation.NavigationStack[pageCount - 1] is Page2 page)
			{
				// �����, ��������, �������� � ���� �������� Page3 ����� Page2
				// � ������� ������ InsertPageBefore(Page page, Page before)
				navigationPage.Navigation.InsertPageBefore(new Page3 { Title = "New Page 3"}, page);
				page.DisplayStack();
			}
				
		}
	}

	// ����� ���������� ���� ������� � ��������� ����� stackLabel
	internal void DisplayStack()
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