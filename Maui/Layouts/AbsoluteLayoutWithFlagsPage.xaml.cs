using Microsoft.Maui.Layouts;

namespace MetanitLessons;


/** AbsoluteLayoutFlags:
 
 * None: ��� �������� ���������������� ��� ����������
  
 * All: ��� �������� ���������������� ��� ����������������
  
 * WidthProportional: ���������������� ��������� ������ ������ ������������� ������� ��������, 
   � ��� ��������� �������� ��������������� ��� ����������

 * HeightProportional: ���������������� ��������� ������ ������ ������������� ������ ��������, 
   � ��� ��������� �������� ��������������� ��� ����������

 * XProportional: ���������������� ��������� ������ ���������� X ��������, 
   � ��� ��������� �������� ��������������� ��� ����������

 * YProportional: ���������������� ��������� ������ ���������� Y ��������, 
   � ��� ��������� �������� ��������������� ��� ����������

 * PositionProportional: ����������������� ��������� ������ ���������� X � Y ������� ��������

 * SizeProportional: ����������������� ��������� ������ ������ � ������ ������������� ������� ��������
 
 ��������, ��� WidthProportional, ���� width = 0.25, 
 �� ������ �������� �������� 25% �� ����� ������ ����������

 ���������� �������������� ���: 
 ��������, ��� XProportional ���������� X = (������ ���������� - ������ ��������) * �������� X 
 �.�. ���� ������ AbsoluteLayout ����� 400, � ������ �������� (��������, BoxView) ����� 100,
 � �������� x � AbsoluteLaout.SetLayoutBounds ����������� 0.2, �� ���������� X = (400 - 100) * 0.2 = 60 px
 
 */

public partial class AbsoluteLayoutWithFlagsPage : ContentPage
{
	public AbsoluteLayoutWithFlagsPage()
	{
		InitializeComponent();

		/*

		AbsoluteLayout absoluteLayout = new AbsoluteLayout();

		BoxView redBox = new BoxView { BackgroundColor = Colors.Red };
		BoxView blueBox = new BoxView { BackgroundColor = Colors.Blue };
		BoxView greenBox = new BoxView { BackgroundColor = Colors.Green };

		absoluteLayout.SetLayoutBounds(redBox, new Rect(0.1, 0.2, 50, 80));
		// ������������� ���������������� ����������
		AbsoluteLayout.SetLayoutFlags(redBox, AbsoluteLayoutFlags.PositionProportional);

		AbsoluteLayout.SetLayoutBounds(blueBox, new Rect(1, 0.2, 50, 80));
		absoluteLayout.SetLayoutFlags(blueBox, AbsoluteLayoutFlags.PositionProportional);

		AbsoluteLayout.SetLayoutBounds(greenBox, new Rect(0.4, 0.8, 0.2, 0.2));
		AbsoluteLayout.SetLayoutFlags(greenBox, AbsoluteLayoutFlags.All);

		absoluteLayout.Children.Add(redBox);
		absoluteLayout.Children.Add(blueBox);
		absoluteLayout.Children.Add(greenBox);

		absoluteLayout.BackgroundColor = Colors.LightBlue;

		Content = absoluteLayout;

		*/
	}
}