namespace MetanitLessons.Maui.CollectionViews;

public partial class CollectionViewPage : ContentPage
{
	public CollectionViewPage()
	{
		CollectionView collectionView = new CollectionView { Margin = 5 };
		// определяем источник данных
		collectionView.ItemsSource = new string[] { "Tom", "Sam", "Bob", "Alice", "Kate" };
		// определяем шаблон данных
		collectionView.ItemTemplate = new DataTemplate(() =>
		{
			var personLabel = new Label 
			{ 
				FontSize = 16, 
				TextColor = Color.FromArgb("#1565C0") 
			};

			// Привязка в режиме RelativeBindingSource.Self,
			// т.е. к BindingContext самого объекта Label,
			// который является шаблоном DataTemplate (лямбда personLabel).
			// Свойство BindingContext объекта шаблона DataTemplate
			// по умолчанию ссылается на сам элемент списка ("Tom", "Sam" и т.д.).
			// Т.е. привязка к элементу списка.
			personLabel.SetBinding(Label.TextProperty, new Binding(path: "BindingContext", source: RelativeBindingSource.Self));
			return personLabel;
		});

		/**************************************************************/

		CollectionView usersCollectionView = new CollectionView();
		// Header и Footer
		usersCollectionView.Header = "Список пользователей";
		usersCollectionView.Footer = "Декабрь 2024";

		// определяем источник данных
		usersCollectionView.ItemsSource = new List<User>
		{
			new User { Name = "Tom", Age = 38, Company = "Microsoft" },
			new User { Name = "Sam", Age = 25, Company = "Google" },
			new User { Name = "Bob", Age = 42, Company = "JetBrains" },
			new User { Name = "Alice", Age = 33, Company = "Microsoft" },
			new User { Name = "Kate", Age = 29, Company = "Google" },
			new User { Name = "Amelina", Age = 35, Company = "JetBrains" }
		};
		// определяем шаблон данных
		usersCollectionView.ItemTemplate = new DataTemplate(UserDataTemplate);


		Content = new StackLayout { collectionView, usersCollectionView };

		//InitializeComponent();
	}

	// можно в качестве возвращаемого типа установить object,
	// но для повышения производительности рекомендуется указать нужный тип
	// - StackLayout, в данном случае
	StackLayout UserDataTemplate()
	{
		var nameLabel = new Label { FontSize = 20, TextColor = Color.FromArgb("#006064"), Margin = 10 };
		nameLabel.SetBinding(Label.TextProperty, nameof(User.Name));

		var ageLabel = new Label();
		ageLabel.SetBinding(Label.TextProperty, new Binding { Path = nameof(User.Age), StringFormat = "Возраст: {0}" });

		var companyLabel = new Label();
		companyLabel.SetBinding(Label.TextProperty, nameof(User.Company));

		return new StackLayout
		{
			Children = { nameLabel, ageLabel, companyLabel },
			Margin = new Thickness(15, 10)
		};
	}
}