namespace MetanitLessons.Maui.ResourcesAndStyles;

using Microsoft.Maui.Controls.StyleSheets;
public partial class CSSstyleInCodePage : ContentPage
{
	string cssCode = "^contentpage { background-color: lightcyan } stacklayout {  margin: 15;  padding: 10; } stacklayout label { text-size: 44; font-weight: bold; color: blueviolet;}";
	public CSSstyleInCodePage()
	{
		using (var reader = new System.IO.StringReader("^contentpage"))
		{
			Resources.Add(StyleSheet.FromReader(reader));
		}

		Content = new StackLayout
		{
			new Label
			{
				Text="Welcome to .NET MAUI!",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
				StyleClass = new List<string> { "labelClass" }
			}
		};

		//InitializeComponent();
	}
}