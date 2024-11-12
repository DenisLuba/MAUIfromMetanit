namespace MetanitLessons.Maui.CollectionViews;

public partial class VerticalGridCollectionViewPage : ContentPage
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


	public VerticalGridCollectionViewPage()
	{
		CollectionView collectionView = new CollectionView { VerticalOptions = LayoutOptions.Start };
		// 2 �������
		collectionView.ItemsLayout = new GridItemsLayout(ItemsLayoutOrientation.Vertical) { Span = 2 };
		// ���������� �������� ������
		collectionView.ItemsSource = users;
		// ���������� ������ ������
		collectionView.ItemTemplate = new DataTemplate(usersDataTemplate);

		Content = collectionView;

		InitializeComponent();
	}


	StackLayout usersDataTemplate()
	{
		var nameLabel = new Label { FontSize = 20, TextColor = Color.FromArgb("#006064"), Margin = 10 };
		nameLabel.SetBinding(Label.TextProperty, nameof(User.Name));

		var ageLabel = new Label();
		ageLabel.SetBinding(Label.TextProperty, new Binding { Path = nameof(User.Age), StringFormat = "�������: {0}" });

		var companyLabel = new Label();
		companyLabel.SetBinding(Label.TextProperty, nameof(User.Company));

		return new StackLayout
		{
			Children = { nameLabel, ageLabel, companyLabel },
			Margin = 20
		};
	}
}