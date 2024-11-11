namespace MetanitLessons.Maui.CollectionViews;

public partial class CollectionViewPage : ContentPage
{
	public CollectionViewPage()
	{
		CollectionView collectionView = new CollectionView { Margin = 5 };
		// ���������� �������� ������
		collectionView.ItemsSource = new string[] { "Tom", "Sam", "Bob", "Alice", "Kate" };
		// ���������� ������ ������
		collectionView.ItemTemplate = new DataTemplate(() =>
		{
			var personLabel = new Label 
			{ 
				FontSize = 16, 
				TextColor = Color.FromArgb("#1565C0") 
			};

			// �������� � ������ RelativeBindingSource.Self,
			// �.�. � BindingContext ������ ������� Label,
			// ������� �������� �������� DataTemplate (������ personLabel).
			// �������� BindingContext ������� ������� DataTemplate
			// �� ��������� ��������� �� ��� ������� ������ ("Tom", "Sam" � �.�.).
			// �.�. �������� � �������� ������.
			personLabel.SetBinding(Label.TextProperty, new Binding(path: "BindingContext", source: RelativeBindingSource.Self));
			return personLabel;
		});

		/**************************************************************/

		CollectionView usersCollectionView = new CollectionView();
		// Header � Footer
		usersCollectionView.Header = "������ �������������";
		usersCollectionView.Footer = "������� 2024";

		// ���������� �������� ������
		usersCollectionView.ItemsSource = new List<User>
		{
			new User { Name = "Tom", Age = 38, Company = "Microsoft" },
			new User { Name = "Sam", Age = 25, Company = "Google" },
			new User { Name = "Bob", Age = 42, Company = "JetBrains" },
			new User { Name = "Alice", Age = 33, Company = "Microsoft" },
			new User { Name = "Kate", Age = 29, Company = "Google" },
			new User { Name = "Amelina", Age = 35, Company = "JetBrains" }
		};
		// ���������� ������ ������
		usersCollectionView.ItemTemplate = new DataTemplate(UserDataTemplate);


		Content = new StackLayout { collectionView, usersCollectionView };

		//InitializeComponent();
	}

	// ����� � �������� ������������� ���� ���������� object,
	// �� ��� ��������� ������������������ ������������� ������� ������ ���
	// - StackLayout, � ������ ������
	StackLayout UserDataTemplate()
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
			Margin = new Thickness(15, 10)
		};
	}
}