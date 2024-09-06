namespace MetanitLessons;

public partial class EditorPage : ContentPage
{
	public EditorPage()
	{
		StackLayout stackLayout = new StackLayout();

		Editor textEditor = new Editor { HeightRequest = 200, FontSize = 16 };
		stackLayout.Children.Add(textEditor);
		Content = stackLayout;

		InitializeComponent();
	}
}