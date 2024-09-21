
namespace MetanitLessons.Maui.Controls;

/** Picker
 * ��������:

ItemsSource: ������������ ��� IList � ���������� ��������� ������������ ���������. �� ��������� ����� null.

SelectedIndex: ������������ ��� int, ������ ������ ����������� ��������. �� ��������� ����� -1.

SelectedItem: ������������ ��� object, ������ ��������� �������. �� ��������� ����� null.

CharacterSpacing: ������������ ��� double � ���������� ���������� ����� ��������� � Picker.

FontAttributes: ������������ ��� FontAttributes � ���������� �������� ������.

FontAutoScalingEnabled: ������������ ��� bool � ����������, ����� �� ����������� � �������� ��������� ���������������.

FontFamily: ������������ ��� string � ���������� ������������ ��������� �������.

FontSize: ������������ ��� double � ���������� ������ ������.

TextColor: ������������ ��� Color � ���������� ���� ������.

TitleColor: ������������ ��� Color � ���������� ���� ���������.

 * � ������� ������� SelectedIndexChanged ����� ���������� ����� �������� � Picker
 */

public partial class PickerPage : ContentPage
{
	Label header = new Label { Text = "Choose a language", FontSize = 18 };
	Picker languagePicker = new Picker { Title = "A programming language", WidthRequest = 200, HorizontalOptions = LayoutOptions.Start };

	public PickerPage()
	{
		// ����� ����������� ��������� ��������
		languagePicker.Items.Add("C#");
		languagePicker.Items.Add("JavaScript");
		languagePicker.Items.Add("Java");

		// ����� ����� ���������� ������ ���������
		// languagePicker.ItemsSource = new string[] { "C#", "JavaScript", "Java" };

		// ��������� ����������� �������
		//languagePicker.SelectedIndex = 0;

		languagePicker.SelectedIndexChanged += PickerSelectedIndexChanged;

		Content = new StackLayout { Children = { header, languagePicker }, Padding = 8 };

		InitializeComponent();
	}

	private void PickerSelectedIndexChanged(object? sender, EventArgs e)
	{
		header.Text = $"You choosed {languagePicker.Items[languagePicker.SelectedIndex]}";
		// ��� ���
		//header.Text = $"You choosed {languagePicker.SelectedItem}";
	}

	private void PickerSelected(object? sender, EventArgs e)
	{
		label.Text = $"�� ������� {picker.SelectedItem}";
	}
}