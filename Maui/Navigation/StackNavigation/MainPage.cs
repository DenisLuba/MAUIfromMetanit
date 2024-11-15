
using System.Text;

namespace MetanitLessons.Maui.Navigation.StackNavigation;

public class MainPage : ContentPage
{
	Label stackLabel;
	bool loaded;


	public MainPage()
	{
		Title = "Main Page";

		Button forwardButton = new Button { Text = "Вперед" };
		forwardButton.Clicked += GoToForward;

		stackLabel = new Label();

		Content = new StackLayout { forwardButton, stackLabel };
	}

	// метод OnAppearing срабатывает после загрузки страницы,
	// но момент вызова этого метода неопределен (он может происходить в то время,
	// пока вызовы методов перехода PushAsync() и PopAsync() еще полностью не завершились)
	protected override void OnAppearing()
	{
		base.OnAppearing();
		// на этой странице метод DisplayStack срабатывает лишь после первой загрузки (?),
		// поэтому здесь переопределена переменная loaded
		if (!loaded)
		{
			DisplayStack();
			loaded = true;
		}
	}

	// метод отображает стэк страниц в текстовой метке stackLabel
	// чтобы получить общий стэк, надо обратиться к NavigationPage:
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

	// переход вперед на Page2
	private async void GoToForward(object? sender, EventArgs e)
	{
		Page2 page = new Page2();
		await Navigation.PushAsync(page);
		page.DisplayStack();
	}
}