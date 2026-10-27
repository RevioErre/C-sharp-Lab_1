namespace Lab_3;

public enum Genre
{
	Action = 1,
	Comedy = 2,
	Drama = 3,
	SciFi = 4,
	Horror = 5
}

public class Movie
{
	public int Id { get; set; }
	public string Name { get; set; }
	public int Year { get; set; }
	public Genre MovieGenre { get; set; }
	public int Views { get; set; }
	public int Likes { get; set; }

	public Movie(int id, string name, int year, Genre genre, int views, int likes)
	{
		Id = id;
		Name = name;
		Year = year;
		MovieGenre = genre;
		Views = views;
		Likes = likes;
	}

	public double CalculateRating()
	{
		if (Views <= 0) 
			return 0;
		return Math.Sqrt((double)(Likes * Likes) / Views);
	}

	public override string ToString()
	{
		return string.Format("{0,4} {1,-15} ({2,-8}) {3,-12} {4,8:F3}", Id, Name, Year, MovieGenre.ToString(), CalculateRating());
	}
}