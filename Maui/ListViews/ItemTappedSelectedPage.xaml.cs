namespace MetanitLessons.Maui.ListViews;

public partial class ItemTappedSelectedPage : ContentPage
{
	readonly object locker = new();
	int count = 0;

	public ItemTappedSelectedPage()
	{
		InitializeComponent();
		// устанавливаем источник данных для ListView
		usersListView.ItemsSource = new List<string> { "Tom", "Bob", "Sam", "Alice" };
	}

	// itemSelected срабатывает при выборе элемента и при снятии выделения с элемента
	// повторное нажатие на элемент не вызывает itemSelected в отличие от itemTapped
	void UsersListItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		// SelectedItem - выбранный элемент (свойство SelectedItemChangedEventArgs)
		selectedLabel.Text = $"Выбрано: {e.SelectedItem}";
		lock (locker) { count = 0; }
	}
	// itemTapped вызывается при каждом нажатии на элемент
	void UsersListItemTapped(object sender, ItemTappedEventArgs e)
	{

		lock (locker) { count++; }
		// itemIndex - индекс элемента в источнике данных (в List)
		tappedLabel.Text = $"{e.Item} - {e.ItemIndex} - нажато {count} раз(а)";
	}
}