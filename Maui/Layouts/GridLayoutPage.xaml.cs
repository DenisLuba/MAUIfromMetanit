namespace MetanitLessons;

public partial class GridLayoutPage : ContentPage
{
    public GridLayoutPage()
    {
		InitializeComponent();

		//// ����� �����
		//Grid grid = new Grid()
		//{
		//	// ������� ����� ���������
		//	ColumnSpacing = 5,
		//	// ������� ����� ��������
		//	RowSpacing = 8,
		//	// ��������� �����
		//	RowDefinitions =
		//	{
		//		// ���������� ������ � ������� 120px
		//		new RowDefinition { Height = new GridLength(120) },
		//		// ��� ������ ������ ��������� ����� � ����������
		//		new RowDefinition()
		//	},
		//	// ��������� ��������
		//	ColumnDefinitions =
		//	{
		//		// ���������� ��������
		//		new ColumnDefinition { Width = new GridLength(100) },
		//		new ColumnDefinition(),
		//		new ColumnDefinition { Width = new GridLength(100) }
		//	}
		//};

		//// ������ �������
		//grid.Add(new BoxView { Color = Colors.Red }, 0, 0);
		//grid.Add(new BoxView { Color = Colors.Blue }, 0, 1);

		//// ������ �������
		//// ������� boxView
		//BoxView greenBox = new BoxView { Color= Colors.Green };
		//// ��������� ��� �� ������ ������� � ������ ������
		//grid.Add(greenBox, 1, 0);
		//// ����������� ��� �� 2 ������, �.� �� 1 � 2
		//Grid.SetRowSpan(greenBox, 2);

		//// ������ �������
		//grid.Add(new BoxView { Color = Colors.Olive }, 2, 0);
		//grid.Add(new BoxView { Color = Colors.Pink }, 2, 1);

		//Content = grid;

	}
}