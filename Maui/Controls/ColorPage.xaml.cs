namespace MetanitLessons;

/**
 * Color:
 
Color.FromArgb(string hex): ���������� ������ Color, ��������� �� ����������� � �������� ��������� ������������������ ��������. 
	� �������� �������� � ����� ���������� ������ � ������� "#AARRGGBB", "#RRGGBB", "#ARGB" ��� "RGB", ��� A - ���������� ������������, 
	R - �������� ��� �������� �����, G - �������� ��� �������� ���������� � B - ������������ ����� ����

Color.FromRgb(double r, double g, double b): ���������� ������ Color, ��� �������� ����� ��������������� ���������� ��������, �������� � ������

Color.FromRgb(int r, int g, int b): ���������� ���������� ������ ������, ������ ������ ���������� ��������, �������� � ������ ����� ������������� �������� �� 0 �� 255

Color.FromRgba(double r, double g, double b, double a): ��������� �������� ������������ �� ��������� �� 0.0 (��������� ����������) �� 1.0 (�� ����������)

Color.FromRgba(int r, int g, int b, int a): ��������� �������� ������������ �� ��������� �� 0 (��������� ����������) �� 255 (�� ����������)

Color.FromHsla(double h, double s, double l, double a): ������������� ��������������� ��������� h (hue - ��� �����), s (saturation - ������������), 
	l (luminosity - �������) � ������������

* ���������� ������:

ToHex: ���������� ����������������� �������� �������� ����� � ���� ������.

ToArgbHex: ���������� ����������������� �������� �������� ����� � ���� ������ � ������� ARGB

ToRgbaHex: ���������� ����������������� �������� �������� ����� � ���� ������ � ������� RGBA

ToInt: ���������� �������� ARGB-������������� �������� ����� � ���� �������� int

ToUint: ���������� �������� ARGB-������������� �������� ����� � ���� �������� uint

ToRgb: ����������� ������� ���� � ��������� ���������� RGB ���� byte

ToRgba: ����������� ������� ���� � ��������� ���������� RGBA ���� byte

ToHsl: ����������� ������� ���� � ��������� ���������� HSL ���� float

* 

AddLuminosity: ��������� ����� �������

MultiplyAlpha: �������� �����-���������� (������������) ����� �� ���������� �������� ���� float

WithAlpha: �������� �����-���������� �����

WithHue: �������� ��� �����

WithLuminosity: �������� ������� �����

WithSaturation: �������� ������������ �����

 */

public partial class ColorPage : ContentPage
{
	public ColorPage()
	{
        Content = new Label
		{
			Text = "Hello World!",
			// ������������ �� ����������� � ���������
			HorizontalTextAlignment = TextAlignment.Center,
			VerticalTextAlignment = TextAlignment.Center,
			// ������� ����
			BackgroundColor = new Color(178, 223, 219, 200),
            // ��� BackgroundColor = Color.FromRgba(178, 223, 219, 200)
            // ��� BackgroundColor = Color.FromArgb("#C8B2DFDB")
            // ���� ������
            TextColor = Colors.DarkBlue
		};

        InitializeComponent();
	}
}