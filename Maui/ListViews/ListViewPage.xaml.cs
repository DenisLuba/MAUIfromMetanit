namespace MetanitLessons.Maui.ListViews;

public partial class ListViewPage : ContentPage
{ 
	// �������� ������ ������ ���� ���������
	public List<string> Goods { get; set; }

	public ListViewPage()
	{
		Label header = new Label { Text = "������ �������������" };
		// ������ ��� ListView
		string[] people = new string[] { "Tom", "Bob", "Sam", "Alice" };

		ListView listView = new ListView();
		// ���������� �������� ������
		listView.ItemsSource = people;
		Content = new StackLayout { Children = { header, listView }, Padding = 8 };



		InitializeComponent();
		Goods = new List<string> { "Mouse", "Keyboard", "Monitor", "Processor" };
		// ������������� �������� �������� ��������,
		// ����� �� XAML ����� ���� ���������� �� ���� ��������� ��������� ��������
		BindingContext = this;
	}
}