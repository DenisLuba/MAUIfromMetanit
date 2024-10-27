
namespace MetanitLessons.Maui.ListViews;

public partial class DataTemplateTappedSelected : ContentPage
{
	public List<Employee> Employees { get; set; } = new();

	Label selectedItemHeader = new Label { FontSize = 18 };
	Label tappedItemHeader = new Label { FontSize = 18 };

	public DataTemplateTappedSelected()
	{
		// ���������� ������
		Employees = new List<Employee>
		{
			new Employee("Tom", 38),
			new Employee("Bob", 42),
			new Employee("Sam", 28),
			new Employee("Alice", 33)
		};
		ListView employeeListView = new ListView();
		// ���������� �������� ������
		employeeListView.ItemsSource = Employees;

		// ���������� ������ ������
		employeeListView.ItemTemplate = new DataTemplate(() =>
		{
			// �������� � �������� Name
			Label nameLabel = new Label { FontSize = 16 };
			nameLabel.SetBinding(Label.TextProperty, "Name");

			// �������� � �������� Age
			Label ageLabel = new Label { FontSize = 16 };
			ageLabel.SetBinding(Label.TextProperty, "Age");

			// ������� ������ ViewCell
			return new ViewCell
			{
				View = new StackLayout
				{
					Padding = new Thickness(0, 5),
					Orientation = StackOrientation.Vertical,
					Children = { nameLabel, ageLabel }
				}
			};
		});

		employeeListView.ItemSelected += EmployeeListView_ItemSelected;
		employeeListView.ItemTapped += EmployeeListView_ItemTapped;

		Content = new StackLayout
		{
			Children =
			{
				selectedItemHeader,
				tappedItemHeader,
				employeeListView
			},

			Padding = 7
		};

		//InitializeComponent();
	}

	private void EmployeeListView_ItemSelected(object? sender, SelectedItemChangedEventArgs e)
	{
		var selectedEmployee = e.SelectedItem as Employee;
		if (selectedEmployee is not null)
			selectedItemHeader.Text = $"�������: {selectedEmployee.Name}";
    }

	private void EmployeeListView_ItemTapped(object? sender, ItemTappedEventArgs e)
	{
		var tappedEmployee = e.Item as Employee;
		if (tappedEmployee is not null)
			tappedItemHeader.Text = $"������: {tappedEmployee.Name}";
	}
}

public record Employee(string name, int age)
{
	public string Name { get; set; } = name;
	public int Age { get; set; } = age;
}