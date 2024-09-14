namespace MetanitLessons;

/**
 * DatePicker
 * ��������:

MaximumDate: ������������ ��������� ����, �� ��������� ����� 31 ������� 2100

MinimumDate: ����������� ��������� ����, �� ��������� ����� 1 ������ 1900

Date: ��������� ���� - �������� ��������� DateTime, �� ��������� ����� �������� DateTime.Today

Format: ���������� ������ ����, ��������� ����������� ��� .NET ������� .�� ��������� ����� "D" - 
	�� ���� ���� ������������ � ����������� �������

 * ����� ���������� ������� DateSelected, ������� ����������� ��� ������ ����

public event EventHandler<DateChangedEventArgs> DateSelected;

� �������� ������� ��������� ���������� ������� ��������� ������ DateChangedEventArgs, 
� �������� ����� �������� ��� ��������: NewDate (��������� ����) � OldDate (������ ����)
 */

public partial class DatePickerPage : ContentPage
{
	Label label;
    public DatePickerPage()
	{
		label = new Label { Text = "�������� ����" };
		DatePicker datePicker = new DatePicker
		{
			Format = "d",
			MaximumDate = DateTime.Now.AddDays(5),
			MinimumDate = DateTime.Now.AddDays(-5)
		};

		datePicker.DateSelected += DateSelected;
		StackLayout stackLayout = new StackLayout { Children = { label, datePicker }, Padding = 20 };
		Content = stackLayout;
		
		InitializeComponent();
	}

    void DateSelected(object? sender, DateChangedEventArgs e)
    {
		label.Text = $"�� ������� {e.NewDate.ToString("d")}";
    }

	void DateSelectedXaml(object? sender, DateChangedEventArgs e)
	{
		if (labelXaml is { })
			labelXaml.Text = $"�� ������� {e.NewDate.ToString("d")}";
    }
}