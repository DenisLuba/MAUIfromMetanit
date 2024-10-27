namespace MetanitLessons.Maui.ListViews;

public partial class DataTemplatePage : ContentPage
{
	public List<User> Users { get; set; }

	public DataTemplatePage()
	{
		Label header = new Label { Text = "������ �������������", FontSize = 18 };

		// ���������� ������ 
		Users = new List<User>
		{
			new User { Name = "Tom", Age = 38 },
			new User { Name = "Bob", Age = 42 },
			new User { Name = "Sam", Age = 28 },
			new User { Name = "Alice", Age = 33 }
		};

		ListView usersListViewCS = new ListView();
		// ���������� �������� ������
		usersListViewCS.ItemsSource = Users;

		// ���������� ������ ������
		usersListViewCS.ItemTemplate = new DataTemplate(() =>
		{
			// �������� � �������� Name
			Label nameLabel = new Label { FontSize = 16 };
			nameLabel.SetBinding(Label.TextProperty, "Name");

			// �������� � �������� Age
			Label ageLabel = new Label { FontSize = 14 };
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

		Label selected = new Label { FontSize = 18 };
		// ���������� �������� � ���������� ��������
		Binding userBingind = new Binding 
		{ 
			StringFormat = "Selected: {0}", 
			Path = "SelectedItem.Name", 
			Source = usersListViewCS 
		};

		selected.SetBinding(Label.TextProperty, userBingind);

		Content = new StackLayout 
		{ 
			Children = { header, selected, usersListViewCS },
			Padding = 8 
		};

		//InitializeComponent();
	}
}

public class User
{
	public string Name { get; set; } = "";
	public int Age { get; set; }
}