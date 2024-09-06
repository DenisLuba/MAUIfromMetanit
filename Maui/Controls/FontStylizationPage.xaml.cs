namespace MetanitLessons;

/**
 * Font:
 
FontFamily: устанавливает применяемое семейство шрифтов в виде значения типа string

FontSize: устанавливает высоту шрифта в виде значения double

FontAttributes: устанавливает дополнительные визуальные эффекты шрифта - выделение жирным или курсивом

FontAutoScalingEnabled: указывает, будет ли для шрифта использоваться масштабирование, 
    установленное в системе. Принимает значение bool - если масштабирование применяется, 
    то используется значение true. По умолчанию значение true
 */

public partial class FontStylizationPage : ContentPage
{
    public FontStylizationPage()
    {


        Label label = new Label
        {
            Text = ".NET MAUI in Sahica",
            // FontFamily должен поддерживаться на всех платформах 
            FontFamily = "Sahica",
            FontSize = 26, // double
            FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
            // выравнивание текста
            VerticalTextAlignment = TextAlignment.Center,
            HorizontalTextAlignment = TextAlignment.Center
        };

        Content = label;

        InitializeComponent();
    }
}