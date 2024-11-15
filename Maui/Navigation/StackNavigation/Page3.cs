
namespace MetanitLessons.Maui.Navigation.StackNavigation;

public class Page3 : ContentPage
{
	Label stackLabel;


	public Page3()
	{
		Title = "Page 3";

		Button backButton = new Button { Text = "Назад" };
		backButton.Clicked += GoToBack;

		Button rootButton = new Button { Text = "На главную" };
		rootButton.Clicked += GoToRoot;

		stackLabel = new Label();

		Content = new StackLayout { backButton, rootButton, stackLabel };
	}

	private async void GoToRoot(object? sender, EventArgs e)
	{
		await Navigation.PopToRootAsync(); // переход на начальную страницу

		if (Application.Current?.MainPage is NavigationPage navigationPage)
			if (navigationPage.CurrentPage is Maui.Navigation.StackNavigation.MainPage page)
				page.DisplayStack();
	}

	private async void GoToBack(object? sender, EventArgs e)
	{
		await Navigation.PopAsync();
		// переход завершен, стек изменился, можно выводить содержимое стека
		// получаем страницу навигации
		if (Application.Current?.MainPage is NavigationPage navigationPage)
		{
			// получаем страницу Page2 и вызываем у нее метод DisplayStack
			//if (navigationPage.CurrentPage is Page2 page) page.DisplayStack();

			// но можно и так:
			// получаем последнюю страницу в стеке
			int pageCount = navigationPage.Navigation.NavigationStack.Count;
			// navigationPage.Navigation.NavigationStack[pageCount - 1] - страница Page2
			if (navigationPage.Navigation.NavigationStack[pageCount - 1] is Page2 page)
			{
				// можем, например, добавить в стэк страницу Page3 перед Page2
				// с помощью метода InsertPageBefore(Page page, Page before)
				navigationPage.Navigation.InsertPageBefore(new Page3 { Title = "New Page 3"}, page);
				page.DisplayStack();
			}
				
		}
	}

	// метод отображает стэк страниц в текстовой метке stackLabel
	internal void DisplayStack()
	{
		if (Application.Current?.MainPage is NavigationPage navigationPage)
		{
			// выводим стэк навигации
			stackLabel.Text = "";

			foreach (Page page in navigationPage.Navigation.NavigationStack)
			{
				stackLabel.Text = $"{page.Title}\n{stackLabel.Text}";
			}
		}
	}
}