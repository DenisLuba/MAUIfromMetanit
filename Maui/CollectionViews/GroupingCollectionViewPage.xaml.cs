using System.Collections.ObjectModel;

namespace MetanitLessons.Maui.CollectionViews;

public partial class GroupingCollectionViewPage : ContentPage
{

	// список групп, к которым идет привязка
	// ObservableCollection из string в качестве ключа и ObservableCollection из User-ов
	public ObservableCollection<Grouping<string, User>> UsersGroups { get; set; }


	public GroupingCollectionViewPage()
	{
		InitializeComponent();

		// начальные данные
		var users = new List<User>
		{
			new  User { Name="Tom", Age=38, Company ="Microsoft" },
			new  User { Name="Sam", Age=25,  Company ="Google" },
			new  User { Name="Bob", Age=42,  Company ="JetBrains" },
			new  User { Name="Alice", Age=33,  Company ="Microsoft" },
			new  User { Name="Kate", Age=29,  Company ="Google" },
			new  User { Name="Amelia", Age=35,  Company ="JetBrains" }
		};

		// получаем группы
		IEnumerable<Grouping<string, User>> groups = users
			.GroupBy(user => user.Company)
			.Select(group => new Grouping<string, User>(group.Key, group));
		// передаем группы в UsersGroups
		UsersGroups = new ObservableCollection<Grouping<string, User>>(groups);
		// устанавливаем источник привязки
		BindingContext = this;
	}
}


public class Grouping<K, T> : ObservableCollection<T>
{
	public K Name { get; private set; }

	public Grouping(K name, IEnumerable<T> items) : base(items)
	{
		Name = name;
	}
}