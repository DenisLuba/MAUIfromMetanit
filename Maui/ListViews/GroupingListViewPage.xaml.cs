using System.Collections.ObjectModel;

namespace MetanitLessons.Maui.ListViews;

public partial class GroupingListViewPage : ContentPage
{
	// список групп, к которым идет привязка
	// ObservableCollection из ObservableCollectin (т.к. Grouping : ObservableCollection)
	public ObservableCollection<Grouping<string, User>> UserGroups { get; set; }

	public GroupingListViewPage()
	{
		InitializeComponent();

		// начальные данные
		var users = new List<User>
		{
			new User { Name = "Tom", Company = "Microsoft" },
			new User { Name = "Sam", Company = "Google" },
			new User { Name = "Alice", Company = "Microsoft" },
			new User { Name = "Bob", Company = "JetBrains" },
			new User { Name = "Kate", Company = "Google" }
		};

		// получаем группы
		IEnumerable<Grouping<string, User>> groups = users
			.GroupBy(u => u.Company)
			.Select(g => new Grouping<string, User>(g.Key, g));

		// передаем группы в UserGroups
		UserGroups = new ObservableCollection<Grouping<string, User>>(groups);

		BindingContext = this;
	}

	public class User
	{
		public string Name { get; set; } = "";
		public string Company { get; set; } = "";
	}

	public class Grouping<K, T> : ObservableCollection<T>
	{
		public K Name { get; private set; }

		public Grouping(K name, IEnumerable<T> items) : base(items)
		{
			Name = name;
		}
	}
}