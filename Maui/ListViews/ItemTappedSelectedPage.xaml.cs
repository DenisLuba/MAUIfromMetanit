namespace MetanitLessons.Maui.ListViews;

public partial class ItemTappedSelectedPage : ContentPage
{
	readonly object locker = new();
	int count = 0;

	public ItemTappedSelectedPage()
	{
		InitializeComponent();
		// ������������� �������� ������ ��� ListView
		usersListView.ItemsSource = new List<string> { "Tom", "Bob", "Sam", "Alice" };
	}

	// itemSelected ����������� ��� ������ �������� � ��� ������ ��������� � ��������
	// ��������� ������� �� ������� �� �������� itemSelected � ������� �� itemTapped
	void UsersListItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		// SelectedItem - ��������� ������� (�������� SelectedItemChangedEventArgs)
		selectedLabel.Text = $"�������: {e.SelectedItem}";
		lock (locker) { count = 0; }
	}
	// itemTapped ���������� ��� ������ ������� �� �������
	void UsersListItemTapped(object sender, ItemTappedEventArgs e)
	{

		lock (locker) { count++; }
		// itemIndex - ������ �������� � ��������� ������ (� List)
		tappedLabel.Text = $"{e.Item} - {e.ItemIndex} - ������ {count} ���(�)";
	}
}