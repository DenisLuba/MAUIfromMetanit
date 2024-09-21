namespace MetanitLessons.Maui.Controls;

/** TableView
 * ��������:

Intent: ���������� ���������� ������� �� iOS (����������� ������ � iOS). 
������������ ���� �� �������� ������������ TableIntent:

	Data: ������������ ��� �������� ����������� ������

	Form: ������������ ����� ����� ������, ��� � ������� ����

	Menu: ������������ ��� ������ ����

	Settings: ������������ ��� ����������� ������ ��������

HasUnevenRows: ������������ ��� bool � ���������, ����� �� ������ � ������� ����� ��������� ������. 
�������� �� ���������false.

Root: ���������� ����������� ������� � ���� ������� TableRoot.

RowHeight: ���������� ������ ����� � ���� �������� int, ���� �������� HasUnevenRows ����� false.

 * ����� ���������� ���������� TableView, ���� ��� �������� Root ��������� ��������� ������ TableRoot. 
 * TableRoot ������ ������ ������� � ���� �������� TableSection. 
 * ������ �� ������ � ���� ������� �������� ����� ��������� ����� ��� ��������� Cell.
 * 
 * ���� �����:

EntryCell: ������������ ����� � ��������� ����� ��� ����� ������. ���������� ������� Completed

	�������� EntryCell:

		Keyboard: ��� ����������, ������� ������������ ��� ����� ������

		Label: ��������� �����, ������� ������������ ����� �� ���� �����

		LabelColor: ���� ������ �����

		Placeholder: �����, ������������ �� ����� ������

		Text: ��� ��������� �����

		HorizontalTextAlignment: �������������� ������������ ������

SwitchCell: ������������ ����� � ��������������. ���������� ������� OnChanged

	�������� SwitchCell:
		
		Text: ������������ ����� ������

		On: ���������, ��������� � ���������� ��� ��� ���������

TextCell: ��� ����� ��� ������ ������

ImageCell: ���������� TextCell �� ���������� �����������

ViewCell: ���������� � ������ ����������� ������ ������ ������������ �������������

 */

public partial class TableViewPage : ContentPage
{
	public TableViewPage()
	{
		TableView tableView = new TableView
		{
			Margin = 10,
			Intent = TableIntent.Data, // ��� iOS
			Root = new TableRoot("���������� ��")
			{
				new TableSection("����� ����������������")
				{
					new TextCell { Text = "Java", Detail = "��� ������ � 1995 ���� � �������� Sun Microsystems" },
					new TextCell { Text = "C#", Detail = "��� ������ � 2000 ���� � �������� Microsoft" }
				},

				new TableSection("���� ������")
				{
					new TextCell { Text = "MySQL", Detail = "���� ������� � 1995 ���� � �������� MySQL AB" },
					new TextCell { Text = "MS SQL Server", Detail = "���� ������� � 1989 ���� � �������� Microsoft" }
				}
			}
		};

		Content = tableView;

		InitializeComponent();
	}

	void OnTextCompleted(object? sender, EventArgs e)
	{
		loginLabel.Text = loginEntry.Text;
	}

	void OnStatusChanged(object? sender, ToggledEventArgs e)
	{
		saveLabel.Text = saveSwitch.On ? "Saved" : "Not Saved";
	}
}