namespace MetanitLessons.Maui.ListViews;

public partial class HeaderFooterListViewPage : ContentPage
{
	public HeaderFooterListViewPage()
	{
		ListView listViewCS = new ListView();
		listViewCS.RowHeight = 25;
		//listViewCS.Header = "Список пользователей";
		listViewCS.Header = new Label { Text = "Список пользователей", FontSize = 18 };
		//listViewCS.Footer = "январь 2024";
		listViewCS.Footer = new VerticalStackLayout
		{
			Children =
			{
				new Label { Text = "METANIT.COM", FontSize = 12 },
				new Label { Text = "январь 2024", FontSize = 12 }
			}
		};
		// определяем источник данных
		listViewCS.ItemsSource = new List<string> { "Tom", "Bob", "Sam", "John" };

		Content = new StackLayout { Children = { listViewCS }, Padding = 8 };

		InitializeComponent();
	}
}