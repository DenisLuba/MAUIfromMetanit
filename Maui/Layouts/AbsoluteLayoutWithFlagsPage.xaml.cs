using Microsoft.Maui.Layouts;

namespace MetanitLessons;


/** AbsoluteLayoutFlags:
 
 * None: все значени€ интерпретируютс€ как абсолютные
  
 * All: все значени€ интерпретируютс€ как пропорциональные
  
 * WidthProportional: пропорциональной считаетс€ только ширина пр€моугольной области элемента, 
   а все остальные значени€ рассматриваютс€ как абсолютные

 * HeightProportional: пропорциональной считаетс€ только высота пр€моугольной обласи элемента, 
   а все остальные значени€ рассматриваютс€ как абсолютные

 * XProportional: пропорциональной считаетс€ только координата X элемента, 
   а все остальные значени€ рассматриваютс€ как абсолютные

 * YProportional: пропорциональной считаетс€ только координата Y элемента, 
   а все остальные значени€ рассматриваютс€ как абсолютные

 * PositionProportional: пропорциональными считаютс€ только координаты X и Y позиции элемента

 * SizeProportional: пропорциональными считаютс€ только ширина и высота пр€моугольной области элемента
 
 Ќапример, при WidthProportional, если width = 0.25, 
 то ширина элемента занимает 25% от общей ширины контейнера

  оординаты рассчитываютс€ так: 
 например, при XProportional координата X = (ширина контейнера - ширина элемента) * значение X 
 т.е. если ширина AbsoluteLayout равна 400, а ширина элемента (например, BoxView) равна 100,
 а значение x в AbsoluteLaout.SetLayoutBounds установлено 0.2, то координата X = (400 - 100) * 0.2 = 60 px
 
 */

public partial class AbsoluteLayoutWithFlagsPage : ContentPage
{
	public AbsoluteLayoutWithFlagsPage()
	{
		InitializeComponent();

		/*

		AbsoluteLayout absoluteLayout = new AbsoluteLayout();

		BoxView redBox = new BoxView { BackgroundColor = Colors.Red };
		BoxView blueBox = new BoxView { BackgroundColor = Colors.Blue };
		BoxView greenBox = new BoxView { BackgroundColor = Colors.Green };

		absoluteLayout.SetLayoutBounds(redBox, new Rect(0.1, 0.2, 50, 80));
		// устанавливаем пропорциональные координаты
		AbsoluteLayout.SetLayoutFlags(redBox, AbsoluteLayoutFlags.PositionProportional);

		AbsoluteLayout.SetLayoutBounds(blueBox, new Rect(1, 0.2, 50, 80));
		absoluteLayout.SetLayoutFlags(blueBox, AbsoluteLayoutFlags.PositionProportional);

		AbsoluteLayout.SetLayoutBounds(greenBox, new Rect(0.4, 0.8, 0.2, 0.2));
		AbsoluteLayout.SetLayoutFlags(greenBox, AbsoluteLayoutFlags.All);

		absoluteLayout.Children.Add(redBox);
		absoluteLayout.Children.Add(blueBox);
		absoluteLayout.Children.Add(greenBox);

		absoluteLayout.BackgroundColor = Colors.LightBlue;

		Content = absoluteLayout;

		*/
	}
}