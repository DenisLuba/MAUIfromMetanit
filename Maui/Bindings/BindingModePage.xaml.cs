namespace MetanitLessons.Maui.Bindings;

/**
 * ����� �������� ���������� � ����� ������� ����� �������� ��������. 
 * ��� ��������� ������ �������� � ������� �������� �� ������������ BindingMode:

Default: �������� �� ���������. ��� ������ ��������� � ������� ����� ����������

OneWay: ��� ��������� � ��������� ���������� ���� (�� ��������� � ����)

OneTime: �������� ��������������� ������ ���������� � ������ �� ���������. 
	�� ���� ���� �������� �������� ��������� �������� �� ��������� ��������. 
	�� ��� ���������� ��������� � ��������� �������� ������ �� ���������

OneWayToSource: ��� ��������� � �������-���� �������� ���������� ������-�������� 
	(�� ���� �������� �������� �� ���� � ���������)

TwoWay: ��������� � ��������� ������������ �� ���� ��������, 
	� ��������� � ���� ������������ �� �������� (�� ���� ������������ ��������)


 * �� ��������� ����������� ��������� ��� ���� ��������� � �� ������� �������� �������� OneWay, 
 * �� ���� ������������� �������� �� ��������� � ����. 
 * ������ ��� ��������� � �� ������� �� ��������� ���������� ������������ ��������:

�������� Date �������� DatePicker

�������� Text ��������� Editor, Entry, SearchBar, � EntryCell

�������� IsRefreshing �������� ListView

�������� SelectedItem �������� MultiPage

�������� SelectedIndex � SelectedItem �������� Picker

�������� Value ��������� Slider � Stepper

�������� IsToggled ��������� Switch

�������� On �������� SwitchCell

�������� Time �������� TimePicker


 * ����� �������� �� ��������� � ������ �������� BindingProperty 
 * �������� � �������� DefaultBindingMode
 */

public partial class BindingModePage : ContentPage
{
	public BindingModePage()
	{

/********************* ����� BindingContext *********************/

		Entry entry1 = new Entry { Margin = 10 };
		Entry entry2 = new Entry { Margin = 10 };

		// entry1 - ����, entry2 - ��������
		entry1.BindingContext = entry2;
		// ������������� ������������� ��������
		// (���� ��� � ��� ��� Entry ����������� ��-���������)
		entry1.SetBinding(Entry.TextProperty, nameof(entry2.Text), BindingMode.TwoWay);

/*********************     ����� Binding     *********************/

		Entry entry3 = new Entry { Margin = 10 };
		Entry entry4 = new Entry { Margin = 10 };

		Binding binding = new Binding 
		{ 
			Source = entry3,			// �������� ��������
			Path = nameof(entry3.Text),	// �������� �������� - Text
			Mode = BindingMode.TwoWay   // ������������� ��������
		};
		// ���� �������� - entry4
		entry4.SetBinding(Entry.TextProperty, binding);

		Content = new StackLayout
		{
			Children = { entry1, entry2, entry3, entry4 },
			Padding = 10
		};

		InitializeComponent();
	}
}