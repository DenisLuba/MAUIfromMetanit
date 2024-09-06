namespace MetanitLessons;

/**
 * LayoutOptions принимает значения:

Start: выравнивание по левому краю (выравнивание по горизонтали) или по верху (выравнивание по вертикали)

Center: элемент выравнивается по центру

End: выравнивание по правому краю (выравнивание по горизонтали) или по низу (выравнивание по вертикали)

Fill: элемент заполняет все пространство контейнера

 */

public partial class AlignmentPage : ContentPage
{
	public AlignmentPage()
	{
		Label label = new Label
		{
			Text = "Hello world"
		};
		// выравнивание по вертикали по центру
		label.VerticalOptions = LayoutOptions.Center;
		// выравнивание по горизонтали по центру
		label.HorizontalOptions = LayoutOptions.Center;

		Content = label;

		InitializeComponent();
    }
}