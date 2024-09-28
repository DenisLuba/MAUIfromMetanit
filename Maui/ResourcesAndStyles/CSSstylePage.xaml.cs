namespace MetanitLessons.Maui.ResourcesAndStyles;

using Microsoft.Maui.Controls.StyleSheets;
using System.Reflection;
using System.Collections.Generic;

public partial class CSSstylePage : ContentPage
{
	public CSSstylePage()
	{
		// Поскольку файл стилей используется как ресурс, он добавляется
		// в коллекцию ресурсов страницы с помощью метода Resources.Add().
		// Для загрузки самих стилей применяется метод StyleSheet.FromResource().

		// Первый аргумент этого метода -путь к файлу стилй внутри проекта -
		// в данном случае название файла, так как он располагается в корне проекта.
		// А второй аргумент - сборка, которая содержит файл стилей.
		Resources.Add(StyleSheet.FromResource(
			"Styles/mystyles.css", 
			IntrospectionExtensions
				.GetTypeInfo(typeof(MainPage))
				.Assembly));

		Label header = new Label
		{
			Text = "Words",
			StyleId = "header"
		};

		Label appleEnglish = new Label { Text = "apple", StyleClass = new List<string>() { "english" } };
		Label appleRussian = new Label { Text = "яблоко", StyleClass = new List<string>() { "russian" } };
		Label houseEnglish = new Label { Text = "house", StyleClass = new List<string>() { "english" } };
		Label houseRussian = new Label { Text = "дом", StyleClass = new List<string>() { "russian" } };
		Label breadEnglish = new Label { Text = "bread", StyleClass = new List<string>() { "english" } };
		Label breadRussian = new Label { Text = "хлеб", StyleClass = new List<string>() { "russian" } };

		Content = new StackLayout
		{
			header,
			appleEnglish,
			appleRussian,
			houseEnglish,
			houseRussian,
			breadEnglish,
			breadRussian
		};

		//InitializeComponent();
	}
}