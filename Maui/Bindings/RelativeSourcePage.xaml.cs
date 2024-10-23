using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace MetanitLessons.Maui.Bindings;

/*
��� �������� ������������� �������� ����������� ���������� �������� RelativeSource. 
(��������, TextColor="{Binding Source={RelativeSource Self}}, Path=Text" - 
- �������� TextColor ������� �� �������� Text ������ �������)
��� ����� ��������� ��������:

Mode: ������������ ��� RelativeBindingSourceMode � ������������� ����� ��������.
������ �������� ����� ��������� ��������� ��������:

	TemplatedParent: ����������� ��� ��������� �������� ������ ������� ��������.

	Self: ��������� �� �������� � ������ ����

	FindAncestor: ��������� �� ��������� � ���������� ������ ���������, 
	��� ���� ������ ������-�������� ��������.

	FindAncestorBindingContext: �������� ����� ���� � �������� BindingContext ����������.

AncestorLevel: ������������ ������� ��������� � ���������� ������ ������������ ����������, 
��� ����� ���� ����� �������-��������� �������� (���� �������� Mode ����� �������� FindAncestor)

AncestorType: ������������ ��� Type � ��������� �� ��� ���������, 
����� ������� ����� ���� ����� �������-��������� ��������
(���� �������� Mode ����� �������� FindAncestor)


���� ��� ��������� �������� �������� Mode ����� ������� �� ������, �� ���� ��� ��������:

	�������� AncestorType � �������� �������� �������� ������, ����������� �� Element. 
	� ���� ������ �������� Mode ������ �������� �������� FindAncestor

	�������� AncestorType � �������� �������� �������� ������, ������������� �� Element. 
	� ���� ������ �������� Mode ������ �������� �������� FindAncestorBindingContext
*/

public partial class RelativeSourcePage : ContentPage
{
	public RelativeSourcePage()
	{
		InitializeComponent();
	}
}

public class StringToColorsConverter : IValueConverter
{
	public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
		=> Color.TryParse(value?.ToString(), out var color) ? color : Colors.Black;

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
		=> (value as Color)?.ToHex();
}

public class User : INotifyPropertyChanged
{
	string name = "";
	int age;

	public event PropertyChangedEventHandler? PropertyChanged;

	public string Name
	{
		get => name;
		set
		{
			if (name != value)
			{
				name = value;
				OnPropertyChanged();
			}
		}
	}

	public int Age
	{
		get => age;
		set
		{
			if (age != value)
			{
				age = value;
				OnPropertyChanged();
			}
		}
	}

	public void OnPropertyChanged([CallerMemberName] string property = "")
	    => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
}