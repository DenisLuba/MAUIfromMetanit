namespace MetanitLessons.Maui.Bindings;

public partial class BindingPage : ContentPage
{
	public BindingPage()
	{
/********************************************************************************************/
		// ������ ������ �������� - �������� BindingContext:

		Label label1 = new Label();
		Entry entry1 = new Entry();

		// ������������� ��������
		// �������� �������� - Entry, ���� �������� - Label
		label1.BindingContext = entry1;
		// ��������� �������� ���� Label (BindableProperty - TextProperty) � ��������� Entry (Text)
		label1.SetBinding(Label.TextProperty, "Text");

		/********************************************************************************************/

		// ������ ������ �������� - ������ Binding

		Label label2 = new Label();
		Entry entry2 = new Entry();

		// ���������� ������ ��������: Source - ��������, Path - ��� ��������
		Binding binding = new Binding { Source = entry2, Path = "Text" };
		// ��������� �������� ��� �������� TextProperty
		label2.SetBinding(Label.TextProperty, binding);

/********************************************************************************************/
		StackLayout stackLayout = new StackLayout
		{
			Children = { label1, entry1, label2, entry2 },
			Padding = 20
		};
		Content = stackLayout;

		InitializeComponent();
	}
}