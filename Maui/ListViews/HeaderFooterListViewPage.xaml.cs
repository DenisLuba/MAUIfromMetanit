namespace MetanitLessons.Maui.ListViews;

public partial class HeaderFooterListViewPage : ContentPage
{
	public HeaderFooterListViewPage()
	{
		ListView listViewCS = new ListView();
		listViewCS.RowHeight = 25;
		//listViewCS.Header = "������ �������������";
		listViewCS.Header = new Label { Text = "������ �������������", FontSize = 18 };
		//listViewCS.Footer = "������ 2024";
		listViewCS.Footer = new VerticalStackLayout
		{
			Children =
			{
				new Label { Text = "METANIT.COM", FontSize = 12 },
				new Label { Text = "������ 2024", FontSize = 12 }
			}
		};
		// ���������� �������� ������
		listViewCS.ItemsSource = new List<string> { "Tom", "Bob", "Sam", "John" };

		Content = new StackLayout { Children = { listViewCS }, Padding = 8 };

		InitializeComponent();
	}
}