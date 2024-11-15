namespace MetanitLessons.Maui.Navigation.NavigationForResult;

public partial class PersonPage : ContentPage
{
	// �����������/������������� �������
	Person? Person { get; set; }
	// ���� ��������������
	bool edited = true;


	public PersonPage(Person? person)
	{
		InitializeComponent();

		if (person is null) // ���������� ������ �������� � ������
		{
			Person = new Person();
			edited = false;
		}
		else Person = person; // �������������� �������� �� ������

		BindingContext = Person;
	}

	async void SavePersonButton(object sender, EventArgs e)
	{
		await Navigation.PopAsync(); // ������������ ����� �� �������� MainPage

		// ���� ���������� ��������
		if (!edited)
		{
			if (Application.Current?.MainPage is NavigationPage navigationPage)
			{
				// ���� ���������
				IReadOnlyList<Page> navigationStack = navigationPage.Navigation.NavigationStack;
				// ���������� ������� � �����
				int pageCount = navigationPage.Navigation.NavigationStack.Count;
				// ������� � ����� ���������� �������� - �� ���� MainPage
				if (navigationStack[pageCount - 1] is MetanitLessons.Maui.Navigation.NavigationForResult.MainPage mainPage)
				{
					// �������� � ������� �������� ����� AddPerson ��� ����������
					mainPage.AddPerson(Person!);
				}
			}
		}
	}
}