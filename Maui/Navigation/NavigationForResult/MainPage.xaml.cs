using System.Collections.ObjectModel; // ObservableCollection

namespace MetanitLessons.Maui.Navigation.NavigationForResult;

public partial class MainPage : ContentPage
{
	ObservableCollection<Person> People { get; set; }


	public MainPage()
	{
		InitializeComponent();

		People = new ObservableCollection<Person>
		{
			new Person { Name = "Tom", Age = 38 },
			new Person { Name = "Bob", Age = 42 },
			new Person { Name = "Sam", Age = 25 }
		};

		peopleList.BindingContext = People;
	}

	// ���������� ������ ��������� � ������
	async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
	{
		// �������� ��������� �������
		if (args.SelectedItem is Person selectedPerson)
		{
			// ������� ���������
			peopleList.SelectedItem = null;
			// ��������� �� �������� �������������� ��������
			await Navigation.PushAsync(new PersonPage(selectedPerson));
		}
    }

	// ������ �������� �� �������� PersonPage ��� ���������� ������ ��������
	async void AddButtonClick(object sender, EventArgs e)
		=> await Navigation.PushAsync(new PersonPage(null));

	// ��������������� ����� ��� ���������� �������� � ������
	protected internal void AddPerson(Person person) => People.Add(person);
}