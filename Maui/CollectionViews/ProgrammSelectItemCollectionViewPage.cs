namespace MetanitLessons.Maui.CollectionViews;

public class ProgrammSelectItemCollectionViewPage : ContentPage
{
	List<User> users = new List<User>
	{
		new  User { Name="Tom", Age=38, Company ="Microsoft" },
		new  User { Name="Sam", Age=25,  Company ="Google" },
		new  User { Name="Bob", Age=42,  Company ="JetBrains" },
		new  User { Name="Alice", Age=33,  Company ="Microsoft" },
		new  User { Name="Kate", Age=29,  Company ="Google" },
		new  User { Name="Amelia", Age=35,  Company ="JetBrains" }
	};


	public ProgrammSelectItemCollectionViewPage()
	{
		CollectionView collectionView = new CollectionView { VerticalOptions = LayoutOptions.Start };
		// устанавливаем режим выбора
		collectionView.SelectionMode = SelectionMode.Single;
		// определяем источник данных
		collectionView.ItemsSource = users;
		// выбираем второй элемент
		collectionView.SelectedItem = users[1];
		// определяем шаблон данных
		collectionView.ItemTemplate = new DataTemplate(userDataTemplate);

		Content = collectionView;
	}

	StackLayout userDataTemplate()
	{
		var nameLabel = new Label { FontSize = 20, TextColor = Color.FromArgb("#006064") };
		nameLabel.SetBinding(Label.TextProperty, "Name");

		var ageLabel = new Label();
		ageLabel.SetBinding(Label.TextProperty, new Binding { Path = "Age", StringFormat = "Возраст: {0}" });

		var companyLabel = new Label();
		companyLabel.SetBinding(Label.TextProperty, "Company");

		return new StackLayout
		{
			Children = { nameLabel, ageLabel, companyLabel },
			Padding = 10
		};
	}		
}