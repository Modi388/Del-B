class Student // skapar klassen Student
{
    public string Name; // gör att varje Student har sitt egna namn. public betyder att man komma åt det utifrån
    public List<Course> Courses = new List<Course>(); // en lista som inehåller course-objekt. new List<course>() gör att varje student får en tom lista från start

    public Student(string name) //konstruktor. körs automatiskt när man skriver new Student i program.cs
    {
        Name = name; // Name är objektets fält. name är parametern som kom in i konstruktorn. Hela raden kopierar in värdet i objektet
    }
    public override string ToString() // gör att objektet skrivs ut som nament i stället för klassrummet. 
    {
        return Name; 
    }

    public void Join(Course course) 
    {
        course.Enroll(this); // metoden skickar vidare till enroll som finns i course.cs istället för att göra det själv. den gör så för att all logik ska ligga i samma plats och regleln gäller oavsett från vilket håll man anmäler.
    }
}