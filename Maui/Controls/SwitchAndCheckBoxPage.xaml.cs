
namespace MetanitLessons;

/** Switch
 * ��������:

IsToggled: ���������, ��������� �� Switch �� ���������� ��������� (�������� true) 
	��� ����������� (�������� false)

ThumbColor: ���� ������ �������������

OnColor: ���� ������������� �� ���������� ���������

 * ��� ������������ ��������� ��������� �������� Switch ����� ���������� ������� Toggled. 
 * ��� �������� ToggledEventArgs � ������� �������� Value ��������� �������� ����� ��������� - 
 * ����� �������� �������� IsToggled.
 
 * 
 * CheckBox
 * ��������:

IsChecked: ���������, ��������� �� ������ � ���������� ��������� (�������� true) 
	��� ������������ (�������� false)

Color: ���� ������

 * ��� ������������ ��������� ��������� ������ ����� Checkbox ���������� ������� CheckedChanged. 
 * ��� �������� CheckedChangedEventArgs � ������� �������� Value ��������� �������� ����� ��������� 
 * - ����� �������� �������� IsChecked.
 */

public partial class SwitchAndCheckBoxPage : ContentPage
{
	Label labelCS;
	Label statusLabelCS;

	public SwitchAndCheckBoxPage()
	{
		Switch switcher = new Switch
		{
			IsToggled = true,
			HorizontalOptions = LayoutOptions.Start
		};

		switcher.Toggled += Switcher_Toggled;
		labelCS = new Label
		{
			FontSize = 16,
			Text = $"�������� = {switcher.IsToggled}"
		};

		/****************************************/

		CheckBox statusCheckBox = new CheckBox { IsChecked = false };
		statusCheckBox.CheckedChanged += StatusCheckBox_CheckedChanged;
		Label statusHeaderLabel = new Label { FontSize = 16, Text = "�����/�������", Margin = 4 };
		HorizontalStackLayout checkBoxStack = new HorizontalStackLayout
		{
			statusCheckBox, statusHeaderLabel
		};
		statusLabelCS = new Label
		{
			FontSize = 18,
			Text = "������: ������/�� �������"
		};

		Content = new StackLayout { Children = { switcher, labelCS, new BoxView { HeightRequest = 30, BackgroundColor = Colors.Transparent }, statusLabelCS, checkBoxStack }, Padding = 8 };

		InitializeComponent();
	}

	private void Switcher_Toggled(object? sender, ToggledEventArgs e)
	{
		labelCS.Text = $"�������� = {e.Value}";
	}

	void Switcher_Toggled_xaml(object? sender, ToggledEventArgs e)
	{
		labelXaml.Text = $"�������� = {e.Value}";
	}

	void StatusCheckBox_CheckedChanged(object? sender, CheckedChangedEventArgs e)
	{
		statusLabelCS.Text = $"������: {(e.Value ? "�����/�������" : "������/�� �������")}";
	}

	void StatusCheckBox_CheckedChanged_xaml(object? sender, CheckedChangedEventArgs e)
	{
		statusLabelXaml.Text = $"������: {(e.Value ? "�����/�������" : "������/�� �������")}";
	}
}