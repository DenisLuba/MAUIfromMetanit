namespace MetanitLessons.Maui.CollectionViews;

public partial class VerticalLinearCollectionViewPage : ContentPage
{
	public VerticalLinearCollectionViewPage()
	{
		CollectionView collectionView = new CollectionView();
		// ���������� �������� ������
		collectionView.ItemsSource = new string[] { "Tom", "Sam", "Bob", "Alice", "Kate" };
		// ������ ������������
		collectionView.ItemsLayout = LinearItemsLayout.Vertical;
		// ��� ���:
		//collectionView.ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Vertical);

		Content = collectionView;

		InitializeComponent();
	}
}