namespace MetanitLessons.Maui.Navigation.NavigationForResult;

public partial class PersonPage : ContentPage
{
	// добавляемый/редактируемый человек
	Person? Person { get; set; }
	// флаг редактирования
	bool edited = true;


	public PersonPage(Person? person)
	{
		InitializeComponent();

		if (person is null) // добавление нового человека в список
		{
			Person = new Person();
			edited = false;
		}
		else Person = person; // редактирование человека из списка

		BindingContext = Person;
	}

	async void SavePersonButton(object sender, EventArgs e)
	{
		await Navigation.PopAsync(); // возвращаемся назад на страницу MainPage

		// если добавление человека
		if (!edited)
		{
			if (Application.Current?.MainPage is NavigationPage navigationPage)
			{
				// стек навигации
				IReadOnlyList<Page> navigationStack = navigationPage.Navigation.NavigationStack;
				// количество страниц в стеке
				int pageCount = navigationPage.Navigation.NavigationStack.Count;
				// находим в стеке предыдущую страницу - то есть MainPage
				if (navigationStack[pageCount - 1] is MetanitLessons.Maui.Navigation.NavigationForResult.MainPage mainPage)
				{
					// вызываем у главной страницы метод AddPerson для добавления
					mainPage.AddPerson(Person!);
				}
			}
		}
	}
}