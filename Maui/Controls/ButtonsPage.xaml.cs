
namespace MetanitLessons;

/**
 * Button (������)
 * 
 * ��������:

ontFamily: �����, ������� ������������ ��� ������ �� ������

FontSize: ������ ������ �� ������

FontAttributes: ��������� ������ ��� �������� ������ �� ������

FontAutoScalingEnabled: ���������, ����� �� ����� ������ ���������������� � ������������ � ����������� �������

LineBreakMode: ������ ���� LineBreakMode, ������� ���������, ��� ����� ������������ ����� ������

TextColor: ���� ������

BorderColor: ���� �������

BorderWidth: ������ �������

ImageSource: ��������� ������ ����������� �� ������


* �������:

Clicked: ������� ������� ������� ��� ���������� ���� �� ������. ������� �����������, ����� ������������ ������� ����� ��� ���� � ������

Pressed: ������� ������� ������� ��� ���������� ���� �� ������. ������� �����������, ����� ����� ������������ ��� ���� ��������� �� ������

Released: ������� ������� ������� ��� ���������� ���� �� ������. ������� �����������, ����� ������������ ����� ����� ��� ���� � ������
 */

public partial class ButtonsPage : ContentPage
{
	public ButtonsPage()
	{
		Button button = new Button
		{
			Text = "�����",
			// ������ ������
			FontSize = 22,
			// ������� �������
			BorderWidth = 1,
			// ���� ������
			BackgroundColor = Colors.LightPink,
			// ���� ������
			TextColor = Colors.DarkRed,
			// ������������ ������
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};

		button.Clicked += OnButtonClicked;

        Grid grid = new Grid();
		grid.Children.Add(button);

		Content = grid;

        InitializeComponent();
	}

    void OnButtonClicked(object? sender, EventArgs e)
    {
		(sender as Button)!.Text = "������";
    }
}