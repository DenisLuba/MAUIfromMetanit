
namespace MetanitLessons;

/**
 * Entry
 * ��������:
 
CharacterSpacing: ���������� ����� ��������� � ������ � ���� �������� ���� double

ClearButtonVisibility: �������� ���� ClearButtonVisibility, ������� ���������, 
	���� �� ���������� ����� � ����� ������ ��� ������� ����������� � ����

CursorPosition: �������� ���� int, ������� ���������� ��������� ������� ������ ����

FontAttributes: ���������� ����� ������

FontAutoScalingEnabled: �������� ���� bool, �������������, ����� �� � ������ ����������� 
	��������� ���������������

FontFamily: ��������� ������� � ���� ������

FontSize: ������ ������ (�������� ���� double)

Keyboard: ������ ���� Keyboard, ������� ��������� ���������� ��� ����������
	
	����������� �������� ������ Keyboard:
	
		Default: ��������� �� ���������

		Text: ��� ������ ������

		Chat: ��� ������ ������ � ������

		Url: ��� ������ url-�������

		Email: ��� ������ ����������� �������

		Telephone: ��� ������ ������ ��������

		Numeric: ��� ����� �����

	��������� ������������ KeyboardFlags:

		None: ��� ���������� �� ����������� ������� �������������� ����������������

		CapitalizeSentence: ���������, ��� ������ ����� ������� ����� ������� 
			����������� ������������� ����� ���������

		Spellcheck: ���������, ��� ��� ���������� ������ ����� ����������� 
			�������� ������������

		Suggestions: ��� ����� ����� ����� ������������ ���������� �����

		CapitalizeWord: ������ ����� ������� ����� ������������� ����� ���������

		CapitalizeCharacter: ������ ��������� ������ ����� ������������� �������� ���������

		CapitalizeNone: �������������� ������������� ���������

		All: ����� ������������� ����������� �������� CapitalizeSentence, 
			Spellcheck � Suggestions

IsPassword: �������� ���� bool, ������� ���������, ������������� �� ���� ��� ����� ������

IsTextPredictionEnabled: �������� ���� bool, ������� ���������, ����� �� ����������� 
	������������ ����� � ��� ���������������

Placeholder: - ����������� - �����, ������� ������������, ���� ���� �����

PlaceholderColor: ���� ������������

Text: ����� ��������

TextColor: ���� ������

SelectionLength: �������� ���� int, ������� ���������� ���������� ���������� ��������

MaxLength: ������������ ���������� ���������� ��������

IsReadOnly: �������� ���� bool, ������� ���������, �������� �� ���� ������ ��� ������. 
	�� ��������� �������� false, �� ���� ���� �������� ��� ��������������

IsSpellCheckEnabled: �������� ���� bool, ������� ���������, �������� �� �������� ����������

TextTransform: ������ ���� TextTransform, ������� ���������� �������������� ������

HorizontalTextAlignment: �������� TextAlignment, ������� ���������� ������������ ������ 
	�� �����������

VerticalTextAlignment: �������� ���� TextAlignment, ������� ���������� ������������ ������ 
	�� ���������

 * �������:
 
TextChanged: ��������� ��� ����� �������� � ����

Completed: ��������� ��� ���������� �����

 */

public partial class EntryPage : ContentPage
{
	Entry entry;
	Entry entry2;
	Label label;

	public EntryPage()
	{
		StackLayout stackLayout = new StackLayout();

		label = new Label { FontSize = 22 };

		entry = new Entry
		{
			Placeholder = "Enter Email",
			FontFamily = "Helvetica",
			FontSize = 22,
			MaxLength = 20,
			Keyboard = Keyboard.Email,
		};

		entry.TextChanged += entryTextChanged;

		entry2 = new Entry
		{
			Keyboard = Keyboard
			.Create(
				  KeyboardFlags.Suggestions 
				| KeyboardFlags.CapitalizeCharacter)
		};


		stackLayout.Children.Add(entry);
		stackLayout.Children.Add(entry2);
		stackLayout.Children.Add(label);
		Content = stackLayout;

		InitializeComponent();
	}

    void entryTextChanged(object? sender, TextChangedEventArgs e)
    {
		label.Text = (sender as Entry)?.Text;

		string oldText = e.OldTextValue;
		string newText = e.NewTextValue;
    }

    void entryTextChanged2(object? sender, TextChangedEventArgs e)
    {
        label2.Text = (sender as Entry)?.Text;
    }
}