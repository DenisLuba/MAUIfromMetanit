namespace MetanitLessons;

/**
 * Font:
 
FontFamily: ������������� ����������� ��������� ������� � ���� �������� ���� string

FontSize: ������������� ������ ������ � ���� �������� double

FontAttributes: ������������� �������������� ���������� ������� ������ - ��������� ������ ��� ��������

FontAutoScalingEnabled: ���������, ����� �� ��� ������ �������������� ���������������, 
    ������������� � �������. ��������� �������� bool - ���� ��������������� �����������, 
    �� ������������ �������� true. �� ��������� �������� true
 */

public partial class FontStylizationPage : ContentPage
{
    public FontStylizationPage()
    {


        Label label = new Label
        {
            Text = ".NET MAUI in Sahica",
            // FontFamily ������ �������������� �� ���� ���������� 
            FontFamily = "Sahica",
            FontSize = 26, // double
            FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
            // ������������ ������
            VerticalTextAlignment = TextAlignment.Center,
            HorizontalTextAlignment = TextAlignment.Center
        };

        Content = label;

        InitializeComponent();
    }
}