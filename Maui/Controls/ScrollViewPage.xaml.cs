namespace MetanitLessons;


/** ScrollView
 * Свойства:

Content: представляет содержимое области прокрутки - любой объект типа View.

ContentSize: значение типа Size, которое хранит размер содержимого. Данное свойство доступно только для чтения.

HorizontalScrollBarVisibility: значение типа ScrollBarVisibility, которое устанавливает горизонтальную прокрутку.

VerticalScrollBarVisibility: значение типа ScrollBarVisibility, которое устанавливает вертикальную прокрутку.

Orientation: хранит значение типа ScrollOrientation, которое устанавливает направление прокрутки. 
	По умолчанию имеет значение Vertical.
	Свойство ScrollOrientation принимает одну из констант:

	Vertical: вертикальная прокрутка, значение по умолчанию
	
	Horizontal: горизонтальная прокрутка
	
	Both: сочетание вертикальной и горизонтальной прокрутки
	
	Neither: отсутствие прокрутки

ScrollX: значение типа double, которое задает X-позицию скорола. Значение по умолчанию - 0. 
	Данное свойство доступно только для чтения.

ScrollY: значение типа double, которое задает Y-позицию скорола. Значение по умолчанию - 0. 
	Данное свойство доступно только для чтения

 * Метод:

ScrollToAsync: имеет 2 версии:
	
	public Task ScrollToAsync(double x, double y, bool animated);

		x и y - точка, к которой происходит переход

		animated - показывает, нужно ли использовать анимацию

	public Task ScrollToAsync(Element element, ScrollToPosition position, bool animated);
		
		Element - элемент, к которому происходит переход

		animated - показывает, нужно ли использовать анимацию	

		ScrollToPosition - константа, которая устанавливает позицию скролла:

			MakeVisible: указывает, что элемент может прокручиваться, 
				пока он остается в видимой области ScrollView.
			
			Start: элемент может прокручиваться до начала ScrollView
			
			Center: элемент может прокручиваться до центра ScrollView
			
			End: элемент может прокручиваться до конца ScrollView
	
 */

public partial class ScrollViewPage : ContentPage
{
    string poem = """
			Мой дядя самых честных правил,
			Когда не в шутку занемог,
			Он уважать себя заставил
			И лучше выдумать не мог.
			Его пример другим наука;
			Но, боже мой, какая скука
			С больным сидеть и день и ночь,
			Не отходя ни шагу прочь!
			Какое низкое коварство
			Полуживого забавлять,
			Ему подушки поправлять,
			Печально подносить лекарство,
			Вздыхать и думать про себя:
			Когда же черт возьмет тебя!»

			Так думал молодой повеса,
			Летя в пыли на почтовых,
			Всевышней волею Зевеса
			Наследник всех своих родных.
			Друзья Людмилы и Руслана!
			С героем моего романа
			Без предисловий, сей же час
			Позвольте познакомить вас:
			Онегин, добрый мой приятель,
			Родился на брегах Невы,
			Где, может быть, родились вы
			Или блистали, мой читатель;
			Там некогда гулял и я:
			Но вреден север для меня.

			Служив отлично благородно,
			Долгами жил его отец,
			Давал три бала ежегодно
			И промотался наконец.
			Судьба Евгения хранила:
			Сперва Madame за ним ходила,
			Потом Monsieur ее сменил.
			Ребенок был резов, но мил.
			Monsieur l'Abbé, француз убогой,
			Чтоб не измучилось дитя,
			Учил его всему шутя,
			Не докучал моралью строгой,
			Слегка за шалости бранил
			И в Летний сад гулять водил.

			Когда же юности мятежной
			Пришла Евгению пора,
			Пора надежд и грусти нежной,
			Monsieur прогнали со двора.
			Вот мой Онегин на свободе;
			Острижен по последней моде,
			Как dandy лондонский одет —
			И наконец увидел свет.
			Он по-французски совершенно
			Мог изъясняться и писал;
			Легко мазурку танцевал
			И кланялся непринужденно;
			Чего ж вам больше? Свет решил,
			Что он умен и очень мил.
			""";

	string poemEnglish = """
			My uncle has most honest principles:
			when he was taken gravely ill,
			he forced one to respect him
			and nothing better could invent.
			To others his example is a lesson;
			but, good God, what a bore to sit
			by a sick person day and night, not stirring
			a step away!
			What base perfidiousness
			to entertain one half-alive,
			adjust for him his pillows,
			sadly serve him his medicine,
			sigh — and think inwardly
			when will the devil take you?

			Thus a young scapegrace thought
			as with post horses in the dust he flew,
			by the most lofty will of Zeus
			the heir of all his kin.
			Friends of Lyudmila and Ruslan!
			The hero of my novel,
			without preambles, forthwith,
			I'd like to have you meet:
			Onegin, a good pal of mine,
			was born upon the Neva's banks,
			where maybe you were born,
			or used to shine, my reader!
			There formerly I too promenaded —
			but harmful is the North to me.

			Having served excellently, nobly,
			his father lived by means of debts;
			gave three balls yearly
			and squandered everything at last.
			Fate guarded Eugene:
			at first, Madame looked after him;
			later, Monsieur replaced her.
			The child was boisterous but charming.
			Monsieur l'Abbé, a poor wretch of a Frenchman,
			not to wear out the infant,
			taught him all things in play,
			bothered him not with stern moralization,
			scolded him slightly for his pranks,
			and to the Letniy Sad took him for walks.

			Then, when the season of tumultuous youth
			for Eugene came,
			season of hopes and tender melancholy,
			Monsieur was ousted from the place.
			Now my Onegin is at large:
			hair cut after the latest fashion,
			dressed like a London Dandy2 —
			and finally he saw the World.
			In French impeccably
			he could express himself and write,
			danced the mazurka lightly, and
			bowed unconstrainedly —
			what would you more? The World decided
			that he was clever and most charming.
		""";

	ScrollView scrollView;

    public ScrollViewPage()
	{
		Label titleLabel = new Label
		{
			Text = "Евгений Онегин",
			FontSize = 22,
			HorizontalOptions = LayoutOptions.Center
		};

		Label textLabel = new Label
		{
			FontSize = 18,
			Text = poem
		};

		StackLayout stackLayout = new StackLayout
		{
			Children = { textLabel },
			Margin = new Thickness(20)
		};

		scrollView = new ScrollView
		{
			Content = stackLayout,
			HeightRequest = 300
		};

        Button button = new Button 
		{ 
			Text = "В начало", 
			Margin = new Thickness(40, 0, 40, 0) 
		};
        button.Clicked += ButtonClicked;

        StackLayout outerStackLayout = new StackLayout
        {
            Children = { titleLabel, scrollView, button }
        };

		//**************************************************

        Label englishTitleLabel = new Label
		{
			Text = "Eugene Onegin",
			FontSize = 22
		};

		Label englishTextLabel = new Label
		{
			Text = poemEnglish,
			FontSize = 18
		};

		ScrollView englishScrollView = new ScrollView 
		{ 
			Content = englishTextLabel,
            HeightRequest = 300,
			Orientation = ScrollOrientation.Both
        };

		Grid grid = new Grid
		{
			Padding = new Thickness(20, 20, 20, 0),
			RowDefinitions =
			{
				new RowDefinition { Height = GridLength.Auto },
				new RowDefinition { Height = GridLength.Star }
			},
		};

		grid.Add(englishTitleLabel, row: 0);
		grid.Add(englishScrollView, row: 1);

        //**************************************************

        StackLayout contentStackLayout = new StackLayout
		{
			Children = { outerStackLayout, grid }
		};

		Content = contentStackLayout;

        //InitializeComponent();
	}

	async void ButtonClicked(object? sender, EventArgs e)
	{
		await scrollView.ScrollToAsync(0, 20, true);
	}
}