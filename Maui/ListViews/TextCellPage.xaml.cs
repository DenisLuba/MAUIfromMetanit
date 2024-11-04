namespace MetanitLessons.Maui.ListViews;

public partial class TextCellPage : ContentPage
{
	public TextCellPage()
	{
		ListView usersListViewCS = new ListView();
		// определ€ем источник данных
		usersListViewCS.ItemsSource = new List<Person>
		{
			new Person { Name = "Tom", Age = 38 },
			new Person { Name = "Bob", Age = 40 },
			new Person { Name = "Sam", Age = 28 },
			new Person { Name = "Alice", Age = 35 }
		};
		// определ€ем шаблон данных
		usersListViewCS.ItemTemplate = new DataTemplate(GetTextCell);

		Label header = new Label { FontSize = 18, Text = "—писок пользователей" };
		Content = new StackLayout
		{
			Children = { header, usersListViewCS },
			Padding = 8
		};

		//InitializeComponent();
	}

	private Func<TextCell> GetTextCell = () =>
	{
		// создаем объект TextCell
		TextCell textCell = new TextCell
		{
			TextColor = Color.FromArgb("#01579B"),
			DetailColor = Color.FromArgb("#0288D1")
		};
		// прив€зка к свойству Name
		textCell.SetBinding(TextCell.TextProperty, nameof(Person.Name));
		// прив€зка к свойству Age
		Binding ageBinding = new Binding { Path = nameof(Person.Age), StringFormat = "{0} лет" };
		textCell.SetBinding(TextCell.DetailProperty, ageBinding);
		return textCell;
	};

}

public class Person()
{
	public string Name { get; set; } = "";
	public int Age { get; set; }
}