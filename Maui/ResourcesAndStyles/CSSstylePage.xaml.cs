namespace MetanitLessons.Maui.ResourcesAndStyles;

using Microsoft.Maui.Controls.StyleSheets;
using System.Reflection;
using System.Collections.Generic;

public partial class CSSstylePage : ContentPage
{
	public CSSstylePage()
	{
		// ��������� ���� ������ ������������ ��� ������, �� �����������
		// � ��������� �������� �������� � ������� ������ Resources.Add().
		// ��� �������� ����� ������ ����������� ����� StyleSheet.FromResource().

		// ������ �������� ����� ������ -���� � ����� ����� ������ ������� -
		// � ������ ������ �������� �����, ��� ��� �� ������������� � ����� �������.
		// � ������ �������� - ������, ������� �������� ���� ������.
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
		Label appleRussian = new Label { Text = "������", StyleClass = new List<string>() { "russian" } };
		Label houseEnglish = new Label { Text = "house", StyleClass = new List<string>() { "english" } };
		Label houseRussian = new Label { Text = "���", StyleClass = new List<string>() { "russian" } };
		Label breadEnglish = new Label { Text = "bread", StyleClass = new List<string>() { "english" } };
		Label breadRussian = new Label { Text = "����", StyleClass = new List<string>() { "russian" } };

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