namespace MetanitLessons.Maui.ListViews;

public partial class BindingToSelectedItemPage : ContentPage
{
	public BindingToSelectedItemPage()
	{
		Label header = new Label();

		ListView usersListView = new ListView() 
		{ 
			RowHeight = 100 // ��������� ������ �����
			// RowHeight ����� �����������,
			// ���� �������� HasUnevenRows ����� false (�������� �� ���������)
		};
		// ���������� �������� ������
		usersListView.ItemsSource = new string[] { "Tomas", "Bobby", "Pepe", "Jacky" };
		// ��������� �������� � SelectedItem
		header.SetBinding(
			Label.TextProperty,
			new Binding { Source = usersListView, Path = nameof(ListView.SelectedItem) });

		Content = new StackLayout
		{
			Children = { header, usersListView },
			Padding = 8
		};

		InitializeComponent();
	}
}