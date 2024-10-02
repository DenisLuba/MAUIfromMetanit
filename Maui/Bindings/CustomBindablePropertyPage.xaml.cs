namespace MetanitLessons.Maui.Bindings;

public partial class CustomBindablePropertyPage : ContentPage
{
	public CustomBindablePropertyPage()
	{
		TagLabel tagLabel = new TagLabel();
		Entry entry = new Entry();
		// ������������� ��������
		// �������� �������� - entry, ���� �������� - tagLabel
		tagLabel.BindingContext = entry;
		// ��������� �������� ��������� � ����
		// ������ � ���� (tagLabel) �������� � �������� Text ��������� (entry)
		// � �������� Text (��� �� ������������� Label) � ����� �������� Tag
		tagLabel.SetBinding(TagLabel.TextProperty, nameof(entry.Text));
		tagLabel.SetBinding(TagLabel.TagProperty, nameof(entry.Text));

		Label label = new Label();
		// � ������ �������� label � tagLabel
		// ������������� �������� � �������� Tag ������� tagLabel
		label.BindingContext = tagLabel;
		label.SetBinding(Label.TextProperty, nameof(tagLabel.Tag));

		Content = new StackLayout
		{
			Padding = 20,
			Children = { tagLabel, entry, label }
		};

		InitializeComponent();
	}
}

// ������� ���� �����, ����������� �� Label. �� ����� �������� ��������� �������� Tag
public class TagLabel : Label
{
	public static readonly BindableProperty TagProperty = BindableProperty.Create(
			"Tag",				// �������� ��������
			typeof(string),		// ������������ ���
			typeof(TagLabel),	// ���, � ������� ����������� ��������
			"0"					// �������� ��-���������
		); 

	public string Tag
	{
		set
		{
			SetValue(TagProperty, value);
		}
		get
		{
			return (string)GetValue(TagProperty);
		}
	}
}