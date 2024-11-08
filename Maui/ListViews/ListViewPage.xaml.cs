namespace MetanitLessons.Maui.ListViews;


/** ��������� ����������� (�������� CachingStrategy):
	
	RetainElement 
				
		* ���� ������ ������ ListView ����� ������� ���������� �������� (20-30 � �����)
	
		* ���� ������ ������ ����� ��������
	
		* ���� ������ ��������� (RecycleElement) ��� ��� �� �������� ���������� ������ ����������
	

	RecycleElement

		* ���� ������ ������ ListView ����� ��������� ���������� ��������
		
		* ���� �������� BindingContext ������ ���������� ��� �� ������
		
		* ���� ������ �� ������ ����������, � �� ������ �������� ����������
 */

public partial class ListViewPage : ContentPage
{ 
	// �������� ������ ������ ���� ���������
	public List<string> Goods { get; set; }

	public ListViewPage()
	{
		Label header = new Label { Text = "������ �������������" };
		// ������ ��� ListView
		string[] people = new string[] { "Tom", "Bob", "Sam", "Alice" };

		//ListView listView = new ListView();
		// ����� ���������� �������� ����������� (�� ��������� ����� RetainElement)
		 ListView listView = new ListView(ListViewCachingStrategy.RecycleElement);
		// ���������� �������� ������
		listView.ItemsSource = people;
		
		Content = new StackLayout { Children = { header, listView }, Padding = 8 };



		InitializeComponent();
		Goods = new List<string> { "Mouse", "Keyboard", "Monitor", "Processor" };
		// ������������� �������� �������� ��������,
		// ����� �� XAML ����� ���� ���������� �� ���� ��������� ��������� ��������
		BindingContext = this;
	}
}