
namespace MetanitLessons;

/** RadioButton
 * ��������:

Content: ���������� ������ � ���� ������ ��� ������� View, ������������ ������ �� ����� ������.

GroupName: ���������� ��� ������, � ������� ����������� ������ �����������

Value: ���������� ��������� �������� (������������ ��� object), ��������� � ������ ������������

BorderColor: ������������ ��� Color � ���������� ���� �������.

BorderWidth: ������������ ��� double � ���������� ������� �������.

CharacterSpacing: ������������ ��� double � ���������� ���������� ����� ��������� ������ ��� ������.

CornerRadius: ������������ ��� int � ���������� ������ ������.

FontAttributes: ������������ ��� FontAttributes � ���������� ����� ������.

FontAutoScalingEnabled: ������������ ��� bool � ����������, ����� �� ����������� ��������� ���������������. 
	�� ��������� ����� true, �� ���� ��������������� �����������.

FontFamily: ������������ ��� string � ���������� ������������ ��������� �������.

FontSize: ������������ ��� double � ���������� ������ ������.

TextColor: ������������ ��� Color � ���������� ���� ������.

IsChecked: ���������, ��������� �� ����������� � ���������� ��������� (�������� true) 
	��� ������������ (�������� false)

 *
 * ��� ������������ ��������� ��������� ����������� ����� RadioButton ���������� ������� CheckedChanged. 
 * ��� �������� CheckedChangedEventArgs � ������� �������� Value ��������� �������� ����� ��������� - 
 * ����� �������� �������� IsChecked.


 * RadioButtonGroup
 * ��������:

GroupName: �������� ������.

SelectedValue: ��������� ������ RadioButton

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