namespace MetanitLessons.Maui.CarouselViews;

public class Product(string name, string description, string imagePath)
{
	public string Name { get; set; } = name;
	public string Description { get; set; } = description;
	public string ImagePath { get; set; } = imagePath;

	public Product() : this("", "", "") { }
}
