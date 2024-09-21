
namespace MetanitLessons;

/** RadioButton
 * Свойства:

Content: содержимое кнопки в виде текста или объекта View, отображается справа от круга кнопки.

GroupName: определяет имя группы, к которой принадлежит данная радиокнопка

Value: определяет некоторое значение (представляет тип object), связанное с данной радиокнопкой

BorderColor: представляет тип Color и определяет цвет границы.

BorderWidth: представляет тип double и определяет толщину границы.

CharacterSpacing: представляет тип double и определяет расстояние между символами текста при кнопке.

CornerRadius: представляет тип int и определяет радиус кнопки.

FontAttributes: представляет тип FontAttributes и определяет стиль текста.

FontAutoScalingEnabled: представляет тип bool и определяет, будет ли применяться системное масштабирование. 
	По умолчанию равно true, то есть масщтабирование применяется.

FontFamily: представляет тип string и определяет используемое семейство шрифтов.

FontSize: представляет тип double и определяет размер шрифта.

TextColor: представляет тип Color и определяет цвет текста.

IsChecked: указывает, находится ли радиокнопка в отмеченном состоянии (значение true) 
	или неотмеченном (значение false)

 *
 * Для отслеживания изменения состояния радиокнопки класс RadioButton определяет событие CheckedChanged. 
 * Его параметр CheckedChangedEventArgs с помощью свойства Value позволяет получить новое состояние - 
 * новое значение свойства IsChecked.


 * RadioButtonGroup
 * Свойства:

GroupName: название группы.

SelectedValue: выбранный объект RadioButton

 */

public partial class RadioButtonPage : ContentPage
{
	Label headerCs = new Label { Text = "Choose a programming language" };

	public RadioButtonPage()
	{
		string[] languages = ["C#", "Java", "C++"];

		StackLayout stackLayout = new StackLayout { headerCs };

		foreach (var language in languages)
		{
			RadioButton languageRadioButton = new RadioButton 
			{ 
				GroupName = "languagesCs", 
				Content = language, 
				Value = language 
			};

			languageRadioButton.CheckedChanged += OnLanguageCheckedChangedCs;
			stackLayout.Add(languageRadioButton);
		}

		Content = stackLayout;

		InitializeComponent();
	}

	private void OnLanguageCheckedChangedCs(object? sender, CheckedChangedEventArgs e)
	{
		if (sender is RadioButton selectedRadioButton && headerCs is Label label)
		{
			label.Text = $"Selected language is {selectedRadioButton.Value}";
		}
	}

	void OnLanguageCheckedChangedXaml(object? sender, CheckedChangedEventArgs e)
	{
		if (sender is RadioButton selectedRadioButton && header2 is Label label)
		{
			label.Text = $"Selected language is {selectedRadioButton.Value}";
		}
	}
}