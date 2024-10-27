namespace MetanitLessons.Maui.ListViews;

public partial class DataTemplatePage : ContentPage
{
	public List<User> Users { get; set; }

	public DataTemplatePage()
	{
		Label header = new Label { Text = "—писок пользователей", FontSize = 18 };

		// определ€ем данные 
		Users = new List<User>
		{
			new User { Name = "Tom", Age = 38 },
			new User { Name = "Bob", Age = 42 },
			new User { Name = "Sam", Age = 28 },
			new User { Name = "Alice", Age = 33 }
		};

		ListView usersListViewCS = new ListView();
		// определ€ем источник данных
		usersListViewCS.ItemsSource = Users;

		// определ€ем шаблон данных
		usersListViewCS.ItemTemplate = new DataTemplate(() =>
		{
			// прив€зка к свойству Name
			Label nameLabel = new Label { FontSize = 16 };
			nameLabel.SetBinding(Label.TextProperty, "Name");

			// прив€зка к свойству Age
			Label ageLabel = new Label { FontSize = 14 };
			ageLabel.SetBinding(Label.TextProperty, "Age");

			// создаем объект ViewCell
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
		// определ€ем прив€зку к выбранному элементу
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