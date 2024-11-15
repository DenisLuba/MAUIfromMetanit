

namespace MetanitLessons.Maui.Navigation.StackNavigation;

public class Page2 : ContentPage
{
	Label stackLabel;


	public Page2()
	{
		Title = "Page 2";
		Button forwardButton = new Button { Text = "¬перед" };
		forwardButton.Clicked += GoToForward;

		Button backButton = new Button { Text = "Ќазад" };
		backButton.Clicked += GoToBack;

		stackLabel = new Label();

		Content = new StackLayout { forwardButton, backButton, stackLabel };
	}

	// переход назад на MainPage
	private async void GoToBack(object? sender, EventArgs e)
	{
		await Navigation.PopAsync();
		// переход завершен, стек изменилс€, можно выводить содержимое стека
		if (Application.Current?.MainPage is NavigationPage navigationPage)
		{
			if (navigationPage.CurrentPage is Maui.Navigation.StackNavigation.MainPage mainPage)
			{
				mainPage.DisplayStack();
			}
		}
	}

	// переход вперед на Page3
	private async void GoToForward(object? sender, EventArgs e)
	{
		Page3 page = new Page3();
		await Navigation.PushAsync(page);
		page.DisplayStack(); // вызываем у Page3 метод DisplayStack
	}

	// метод отображает стэк страниц в текстовой метке stackLabel
	protected internal void DisplayStack()
	{
		if (Application.Current?.MainPage is NavigationPage navigationPage)
		{
			// выводим стек навигации
			stackLabel.Text = "";
			foreach (Page page in navigationPage.Navigation.NavigationStack)
			{
				stackLabel.Text = $"{page.Title}\n{stackLabel.Text}";
			}
		}
	}
}