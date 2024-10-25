namespace MetanitLessons.Maui.ListViews;

public partial class ListViewPage : ContentPage
{ 
	// источник данных должен быть публичным
	public List<string> Goods { get; set; }

	public ListViewPage()
	{
		Label header = new Label { Text = "Список пользователей" };
		// данные для ListView
		string[] people = new string[] { "Tom", "Bob", "Sam", "Alice" };

		ListView listView = new ListView();
		// определяем источник данных
		listView.ItemsSource = people;
		Content = new StackLayout { Children = { header, listView }, Padding = 8 };



		InitializeComponent();
		Goods = new List<string> { "Mouse", "Keyboard", "Monitor", "Processor" };
		// устанавливаем контекст привязки страницы,
		// чтобы из XAML можно было обратиться ко всем публичным свойствам страницы
		BindingContext = this;
	}
}