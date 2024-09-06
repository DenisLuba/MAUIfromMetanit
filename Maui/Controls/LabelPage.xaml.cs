namespace MetanitLessons;

/**
 * Свойства Label:

CharacterSpacing: расстояние между символами в тексте в виде значения типа double

FontAttributes: определяет стиль текста

FontAutoScalingEnabled: значение типа bool, устанавливает, будет ли к тексту применяться 
	системное масштабирование

FontFamily: семейство шрифтов в виде строки

FontSize: размер шрифта (значение типа double)

LineBreakMode: значение типа LineBreakMode, которое определяет, как будет производиться перенос строки, 
	если текст не вмещается

LineHeight: высота строки (значение типа double)

MaxLines: максимальное допустимое количество строк

Padding: внутренний отступ

Text: текст метки

TextColor: цвет текста

TextDecorations: декорации текста (его подчеркивание или зачеркивание) (значение типа TextDecorations)

TextTransform: объект типа TextTransform, который определяет преобразование текста

TextType: значение типа TextType, которое определяет тип текста - обычный текст или html

HorizontalTextAlignment: значение TextAlignment, которое определяет выравнивание текста по горизонтали

VerticalTextAlignment: значение типа TextAlignment, которое определяет выравнивание текста по вертикали

FormattedText: представляет отформатированный текст в виде объекта FormattedString
	FormattedString инкапсулирует объекты типа Span. Для стилизации объекта Span применяются свойства:

	Text
	FontFamily
	FontSize
	FontAttributes
	TextColor
	BackgroundColor

GestureRecognizers - добавление обработчика нажитий GestureRecognizer
*/

public partial class LabelPage : ContentPage
{
    public LabelPage()
	{
		FormattedString formattedString = new FormattedString();

		formattedString.Spans.Add(new Span
		{
			Text = "Сегодня",
			FontSize = 22
		});

		formattedString.Spans.Add(new Span
		{
			Text = " хорошая",
			TextColor = Colors.DarkRed,
			BackgroundColor = Colors.LightPink
		});

		formattedString.Spans.Add(new Span
		{
			Text = " погода",
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


        // обработка нажатий на Label
        Label tapLabel = new Label
        {
            Text = "Нажмите",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.End
        };

        TapGestureRecognizer tapGesture = new TapGestureRecognizer
        {
            NumberOfTapsRequired = 2
        };

        int count = 0; // счетчик нажатий
        tapGesture.Tapped += (s, e) =>
        {
            
            tapLabel.Text = $"Вы нажали {++count} раз";
        };

        tapLabel.GestureRecognizers.Add(tapGesture);


        Label label2 = new Label
		{
			Text =
			"""
			Его пример другим наука;
			Но, боже мой, какая скука
			С больным сидеть и день и ночь,
			Не отходя ни шагу прочь!
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