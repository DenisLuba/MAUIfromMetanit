
namespace MetanitLessons.Maui.Controls;

/** Picker
 * Свойства:

ItemsSource: представляет тип IList и определяет коллекцию отображаемых элементов. По умолчанию равно null.

SelectedIndex: представляет тип int, хранит индекс выделенного элемента. По умолчанию равно -1.

SelectedItem: представляет тип object, хранит выбранный элемент. По умолчанию равно null.

CharacterSpacing: представляет тип double и определяет расстояние между символами в Picker.

FontAttributes: представляет тип FontAttributes и определяет атрибуты шрифта.

FontAutoScalingEnabled: представляет тип bool и определяет, будет ли применяться к элементу системное масштабирование.

FontFamily: представляет тип string и определяет используемое семейство шрифтов.

FontSize: представляет тип double и определяет высоту шрифта.

TextColor: представляет тип Color и определяет цвет текста.

TitleColor: представляет тип Color и определяет цвет заголовка.

 * С помощью события SelectedIndexChanged можно обработать выбор элемента в Picker
 */

public partial class PickerPage : ContentPage
{
	Label header = new Label { Text = "Choose a language", FontSize = 18 };
	Picker languagePicker = new Picker { Title = "A programming language", WidthRequest = 200, HorizontalOptions = LayoutOptions.Start };

	public PickerPage()
	{
		// можно динамически добавлять элементы
		languagePicker.Items.Add("C#");
		languagePicker.Items.Add("JavaScript");
		languagePicker.Items.Add("Java");

		// можно сразу установить список элементов
		// languagePicker.ItemsSource = new string[] { "C#", "JavaScript", "Java" };

		// установка выделенного индекса
		//languagePicker.SelectedIndex = 0;

		languagePicker.SelectedIndexChanged += PickerSelectedIndexChanged;

		Content = new StackLayout { Children = { header, languagePicker }, Padding = 8 };

		InitializeComponent();
	}

	private void PickerSelectedIndexChanged(object? sender, EventArgs e)
	{
		header.Text = $"You choosed {languagePicker.Items[languagePicker.SelectedIndex]}";
		// или так
		//header.Text = $"You choosed {languagePicker.SelectedItem}";
	}

	private void PickerSelected(object? sender, EventArgs e)
	{
		label.Text = $"Вы выбрали {picker.SelectedItem}";
	}
}