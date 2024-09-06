namespace MetanitLessons;

/**
 * �������� Label:

CharacterSpacing: ���������� ����� ��������� � ������ � ���� �������� ���� double

FontAttributes: ���������� ����� ������

FontAutoScalingEnabled: �������� ���� bool, �������������, ����� �� � ������ ����������� 
	��������� ���������������

FontFamily: ��������� ������� � ���� ������

FontSize: ������ ������ (�������� ���� double)

LineBreakMode: �������� ���� LineBreakMode, ������� ����������, ��� ����� ������������� ������� ������, 
	���� ����� �� ���������

LineHeight: ������ ������ (�������� ���� double)

MaxLines: ������������ ���������� ���������� �����

Padding: ���������� ������

Text: ����� �����

TextColor: ���� ������

TextDecorations: ��������� ������ (��� ������������� ��� ������������) (�������� ���� TextDecorations)

TextTransform: ������ ���� TextTransform, ������� ���������� �������������� ������

TextType: �������� ���� TextType, ������� ���������� ��� ������ - ������� ����� ��� html

HorizontalTextAlignment: �������� TextAlignment, ������� ���������� ������������ ������ �� �����������

VerticalTextAlignment: �������� ���� TextAlignment, ������� ���������� ������������ ������ �� ���������

FormattedText: ������������ ����������������� ����� � ���� ������� FormattedString
	FormattedString ������������� ������� ���� Span. ��� ���������� ������� Span ����������� ��������:

	Text
	FontFamily
	FontSize
	FontAttributes
	TextColor
	BackgroundColor

GestureRecognizers - ���������� ����������� ������� GestureRecognizer
*/

public partial class LabelPage : ContentPage
{
    public LabelPage()
	{
		FormattedString formattedString = new FormattedString();

		formattedString.Spans.Add(new Span
		{
			Text = "�������",
			FontSize = 22
		});

		formattedString.Spans.Add(new Span
		{
			Text = " �������",
			TextColor = Colors.DarkRed,
			BackgroundColor = Colors.LightPink
		});

		formattedString.Spans.Add(new Span
		{
			Text = " ������",
			FontAttributes = FontAttributes.Bold
		});

		Label label1 = new Label
		{
			FormattedText = formattedString,
			TextDecorations = TextDecorations.Underline,
			CharacterSpacing = 2,
			FontAttributes = FontAttributes.Bold,
			FontFamily = "Helvetica",
			FontSize = 22,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center
		};


        // ��������� ������� �� Label
        Label tapLabel = new Label
        {
            Text = "�������",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.End
        };

        TapGestureRecognizer tapGesture = new TapGestureRecognizer
        {
            NumberOfTapsRequired = 2
        };

        int count = 0; // ������� �������
        tapGesture.Tapped += (s, e) =>
        {
            
            tapLabel.Text = $"�� ������ {++count} ���";
        };

        tapLabel.GestureRecognizers.Add(tapGesture);


        Label label2 = new Label
		{
			Text =
			"""
			��� ������ ������ �����;
			��, ���� ���, ����� �����
			� ������� ������ � ���� � ����,
			�� ������ �� ���� �����!
			""",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Start,
			GestureRecognizers =
			{
				new GestureRecognizer
				{
					
				},
                tapGesture
            }
		};		

        Grid grid = new Grid();
        grid.Children.Add(label1);
		grid.Children.Add(label2);
		grid.Children.Add(tapLabel);
		Content = grid;

		//InitializeComponent();
	}
}