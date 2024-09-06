namespace MetanitLessons;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		// InitializeComponent();

		
		AbsoluteLayout absoluteLayout = new AbsoluteLayout();

		// ���������� ��������, ������� ������� �� ��������:
		// ������� ������������� �������
		BoxView boxView = new BoxView { Color = Colors.LightBlue };
		// ��������� �������, ������� ����� ������������� ������ boxView
		Label label = new Label { Text = ".NET MAUI", FontSize = 20 };

		// ��������� �������� � absoluteLayout
		absoluteLayout.Add(boxView);
		absoluteLayout.Add(label);

		// ���������� ��� ���� ��������� ������������ � �������
		int x = 30; // ������� ���������� X �� ��������
		int y = 70; // ������� ���������� Y �� ��������
		int width = 320; // ������ ����� ��������
		int height = 100; // ������ ����� ��������
		Rect rect = new Rect(x, y, width, height);

		absoluteLayout.SetLayoutBounds(boxView, rect);

		absoluteLayout.SetLayoutBounds(
			label,
			new Rect(50, 100, 300, 40)
			);

		// ��������� absoluteLayout � ���������� ��������
		Content = absoluteLayout;

		
	}
}