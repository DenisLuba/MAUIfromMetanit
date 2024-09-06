
namespace MetanitLessons;

/**
 * Entry
 * Свойства:
 
CharacterSpacing: расстояние между символами в тексте в виде значения типа double

ClearButtonVisibility: значение типа ClearButtonVisibility, которое указывает, 
	надо ли отображать рядом с полем кнопку для очистки содержимого в поле

CursorPosition: значение типа int, которое определяет положение курсора внутри поля

FontAttributes: определяет стиль текста

FontAutoScalingEnabled: значение типа bool, устанавливает, будет ли к тексту применяться 
	системное масштабирование

FontFamily: семейство шрифтов в виде строки

FontSize: размер шрифта (значение типа double)

Keyboard: объект типа Keyboard, который позволяет установить тип клавиатуры
	
	Статические свойства класса Keyboard:
	
		Default: раскладка по умолчанию

		Text: для набора текста

		Chat: для набора текста и эмодзи

		Url: для набора url-адресов

		Email: для набора электронных адресов

		Telephone: для набора номера телефона

		Numeric: для ввода чисел

	Константы перечисления KeyboardFlags:

		None: для клавиатуры не добавляется никакой дополнительной функциональности

		CapitalizeSentence: указывает, что первая буква первого слова каждого 
			предложения автоматически будет заглавной

		Spellcheck: указывает, что для введенного текста будет применяться 
			проверка правописания

		Suggestions: при вводе слова будут предлагаться завершения слова

		CapitalizeWord: первая буква каждого слова автоматически будет заглавной

		CapitalizeCharacter: каждый введенный символ будет автоматически делаться заглавным

		CapitalizeNone: автоматическая капитализация отключена

		All: будут автоматически применяться значения CapitalizeSentence, 
			Spellcheck и Suggestions

IsPassword: значение типа bool, которое указывает, предназначено ли поле для ввода пароля

IsTextPredictionEnabled: значение типа bool, которое указывает, будет ли применяться 
	предсказание ввода и его автоисправление

Placeholder: - плейсхолдер - текст, который отображается, если поле пусто

PlaceholderColor: цвет плейсхолдера

Text: текст элемента

TextColor: цвет текста

SelectionLength: значение типа int, которое определяет количество выделенных символов

MaxLength: максимальное допустимое количество символов

IsReadOnly: значение типа bool, которое указывает, доступно ли поле только для чтения. 
	По умолчанию значение false, то есть поле доступно для редактирования

IsSpellCheckEnabled: значение типа bool, которое указывает, включена ли проверка орфографии

TextTransform: объект типа TextTransform, который определяет преобразование текста

HorizontalTextAlignment: значение TextAlignment, которое определяет выравнивание текста 
	по горизонтали

VerticalTextAlignment: значение типа TextAlignment, которое определяет выравнивание текста 
	по вертикали

 * События:
 
TextChanged: возникает при вводе символов в поле

Completed: возникает при завершении ввода

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