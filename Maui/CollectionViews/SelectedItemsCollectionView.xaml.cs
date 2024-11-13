namespace MetanitLessons.Maui.CollectionViews;

public partial class SelectedItemsCollectionView : ContentPage
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


	public SelectedItemsCollectionView()
	{
		CollectionView collectionView = new CollectionView { VerticalOptions = LayoutOptions.Start };
		// устанавливаем режим выбора
		collectionView.SelectionMode = SelectionMode.Single;
		// определяем источник данных
		collectionView.ItemsSource = users;
		// определяем шаблон данных
		collectionView.ItemTemplate = new DataTemplate(userDataTemplate);
		// метка для вывода выбранного элемента
		Label selectedLabel = new Label { Margin = 8, FontSize = 18 };
		selectedLabel.SetBinding(
			Label.TextProperty,
			new Binding
			{
				Source = collectionView,
				Path = "SelectedItem.Name",
				StringFormat = "Selected: {0} "
			});

		Content = new StackLayout { selectedLabel, collectionView };


		InitializeComponent();
	}

	// DataTemplate для отображения ячеек
	StackLayout userDataTemplate()
	{
		var nameLabel = new Label { FontSize = 20, TextColor = Color.FromArgb("#006064") };
		nameLabel.SetBinding(Label.TextProperty, nameof(User.Name));

		var ageLabel = new Label();
		ageLabel.SetBinding(Label.TextProperty, new Binding { Path = nameof(User.Age), StringFormat = "Возраст: {0}" });

		var companyLabel = new Label();
		companyLabel.SetBinding(Label.TextProperty, nameof(User.Company));

		return new StackLayout
		{
			Children = { nameLabel, ageLabel, companyLabel },
			Margin = 8
		};
	}

	// обработка нажатия на 
	private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		string labelText = "";
		if (e.CurrentSelection.FirstOrDefault() is User current)
			labelText = $"Current: {current.Name}";
		if (e.PreviousSelection.FirstOrDefault() is User previous)
			labelText = $"{labelText}\nPrevious: {previous.Name}";

		selectedLabelXaml.Text = labelText;
	}
}