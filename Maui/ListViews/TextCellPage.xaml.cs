namespace MetanitLessons.Maui.ListViews;

public partial class TextCellPage : ContentPage
{
	public TextCellPage()
	{
		ListView usersListViewCS = new ListView();
		// ���������� �������� ������
		usersListViewCS.ItemsSource = new List<Person>
		{
			new Person { Name = "Tom", Age = 38 },
			new Person { Name = "Bob", Age = 40 },
			new Person { Name = "Sam", Age = 28 },
			new Person { Name = "Alice", Age = 35 }
		};
		// ���������� ������ ������
		usersListViewCS.ItemTemplate = new DataTemplate(GetTextCell);

		Label header = new Label { FontSize = 18, Text = "������ �������������" };
		Content = new StackLayout
		{
			Children = { header, usersListViewCS },
			Padding = 8
		};

		//InitializeComponent();
	}

	private Func<TextCell> GetTextCell = () =>
	{
		// ������� ������ TextCell
		TextCell textCell = new TextCell
		{
			TextColor = Color.FromArgb("#01579B"),
			DetailColor = Color.FromArgb("#0288D1")
		};
		// �������� � �������� Name
		textCell.SetBinding(TextCell.TextProperty, nameof(Person.Name));
		// �������� � �������� Age
		Binding ageBinding = new Binding { Path = nameof(Person.Age), StringFormat = "{0} ���" };
		textCell.SetBinding(TextCell.DetailProperty, ageBinding);
		return textCell;
	};

}

public class Person()
{
	public string Name { get; set; } = "";
	public int Age { get; set; }
}