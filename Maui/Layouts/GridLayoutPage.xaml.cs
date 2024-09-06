namespace MetanitLessons;

public partial class GridLayoutPage : ContentPage
{
    public GridLayoutPage()
    {
		InitializeComponent();

		//// нова€ сетка
		//Grid grid = new Grid()
		//{
		//	// отступы между колонками
		//	ColumnSpacing = 5,
		//	// отступы между строками
		//	RowSpacing = 8,
		//	// коллекци€ строк
		//	RowDefinitions =
		//	{
		//		// добавление строки с высотой 120px
		//		new RowDefinition { Height = new GridLength(120) },
		//		// эта строка займет остальное место в контейнере
		//		new RowDefinition()
		//	},
		//	// коллекци€ столбцов
		//	ColumnDefinitions =
		//	{
		//		// добавление столбцов
		//		new ColumnDefinition { Width = new GridLength(100) },
		//		new ColumnDefinition(),
		//		new ColumnDefinition { Width = new GridLength(100) }
		//	}
		//};

		//// перва€ колонка
		//grid.Add(new BoxView { Color = Colors.Red }, 0, 0);
		//grid.Add(new BoxView { Color = Colors.Blue }, 0, 1);

		//// втора€ колонка
		//// создаем boxView
		//BoxView greenBox = new BoxView { Color= Colors.Green };
		//// добавл€ем его во вторую колонку в первую строку
		//grid.Add(greenBox, 1, 0);
		//// раст€гиваем его на 2 строки, т.е на 1 и 2
		//Grid.SetRowSpan(greenBox, 2);

		//// треть€ колонка
		//grid.Add(new BoxView { Color = Colors.Olive }, 2, 0);
		//grid.Add(new BoxView { Color = Colors.Pink }, 2, 1);

		//Content = grid;

	}
}