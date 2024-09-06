namespace MetanitLessons;

/**
 * LayoutOptions ��������� ��������:

Start: ������������ �� ������ ���� (������������ �� �����������) ��� �� ����� (������������ �� ���������)

Center: ������� ������������� �� ������

End: ������������ �� ������� ���� (������������ �� �����������) ��� �� ���� (������������ �� ���������)

Fill: ������� ��������� ��� ������������ ����������

 */

public partial class AlignmentPage : ContentPage
{
	public AlignmentPage()
	{
		Label label = new Label
		{
			Text = "Hello world"
		};
		// ������������ �� ��������� �� ������
		label.VerticalOptions = LayoutOptions.Center;
		// ������������ �� ����������� �� ������
		label.HorizontalOptions = LayoutOptions.Center;

		Content = label;

		InitializeComponent();
    }
}