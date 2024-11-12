namespace MetanitLessons.Maui.CollectionViews;

public partial class VerticalLinearCollectionViewPage : ContentPage
{
	public VerticalLinearCollectionViewPage()
	{
		CollectionView collectionView = new CollectionView();
		// определяем источник данных
		collectionView.ItemsSource = new string[] { "Tom", "Sam", "Bob", "Alice", "Kate" };
		// задаем расположение
		collectionView.ItemsLayout = LinearItemsLayout.Vertical;
		// или так:
		//collectionView.ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Vertical);

		Content = collectionView;

		InitializeComponent();
	}
}