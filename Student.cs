class Student // skapar klassen Student
{
    public string Name; // gör att varje Student har sitt egna namn. public betyder att man komma åt det utifrån
    public List<Course> Courses = new List<Course>(); // en lista som inehåller course-objekt. new List<course>() gör att varje student får en tom lista frpn start

    public Student(string name) //konstruktor. körs automatiskt när man skriver nre Student i program.cs
    {
        Name = name; // Name är objektets fält. name är parametern som kom in i konstruktorn. Hela raden kopierar in värdet i objektet
    }
}