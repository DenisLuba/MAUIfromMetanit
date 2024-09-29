
using System.Text.RegularExpressions;

namespace MetanitLessons.Maui.ResourcesAndStyles;

/** VisualStateManager
 * 
 * �� ��������� Visual State Manager ����������� � ��������� ���������� 
 * ������ �� ���� ���������:

Disabled: ������� �������� ��� �������������

Focused: ������� ������� ����� � ������������ � ������� ������

Normal: ����������� ��������� ��������

PointerOver: ��������� ���� ��������� ��� ���������

 * ��������� Normal, Disabled, Focused � PointerOver �������������� 
 * ��� �������� ���� �������, ������� ������������ �� VisualElement 
 * (� ��� ����� ������� View � Page). 
 * 
 * � .NET MAUI ��� ���� ��������� ���� �������������� ���������:

VisualElement ���������� ����� ��� ���� ��������� ��������� Normal, Disabled, Focused � PointerOver

Button ���������� ��������� Pressed (������� ������)

CarouselView ���������� ��������� DefaultItem, CurrentItem, PreviousItem � NextItem

CheckBox ���������� ��������� IsChecked (������ �������)

CollectionView ���������� ��������� Selected (������� �������)

ImageButton ���������� ��������� Pressed (������� ������)

RadioButton ���������� ��������� Checked (������� ������) � Unchecked (������� �� ������)

Switch ���������� ��������� On (��������) � Off(���������)
 */

public partial class VisualStateManagerPage : ContentPage
{
	public VisualStateManagerPage()
	{
		InitializeComponent();

		SetState(false); // ���������� ���������� ���������
	}

	void EntryTextChanged(object sender, TextChangedEventArgs e)
	{
		// ��������� ��������� �������� �� ������������ ����������� ���������
		bool isValid = Regex.IsMatch(e.NewTextValue, @"^\+[1-9]-\d{3}-\d{3}-\d{4}$");
		SetState(isValid);
	}

	private void SetState(bool isValid)
	{
		string state = isValid ? "Valid" : "Invalid";
		// ������� ����������� ��������� ����� ��������� � ����� ����� �������� ����� 
		// VisualStateManager.GoToState(visualElement, "State"), 
		// ��� visualElement - �������, ��� �������� ����������� �� VisualElement (��������, ����� Entry);
		// "State" - �������� ��������� (��������, � ������ ������ ��������� ��������� "Valid" ��� "Invalid"
		VisualStateManager.GoToState(myEntry, state);
	}
}