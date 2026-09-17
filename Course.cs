
class Course
{
    public string Name; // gör att varje kurs har eget namn 

    public int MaxSeats; // maxantal platster

    public List<Student> Students = new List<Student>();

    public Course(string name, int maxSeats)
    {
        MaxSeats = maxSeats;
        Name = name;
    }

    public void Enroll(Student student) // void gör att den inte returnerar något bara att den gör att jag lägger till nya studenter till kurser. Student student tar emot student objekt och inuti metoden kallas det student.
    {
        if (Students.Contains(student)) // if sats som kollar ifall studenten redan går i vald kurs. 
        {
            Console.WriteLine($"{student.Name} går redan i {Name}");
            return; // stoppar hela metoden så den inte går vidare.
        }

        if (Students.Count >= MaxSeats) // kollar ifall kursen har nåt sin max kapacitet
        {
            Console.WriteLine("Kursen är full"); 
            return;
        }

        Students.Add(student); // gör så att enroll funkar som att en elev ska gå in i en kurs
        student.Courses.Add(this); // this är den kurs vi står i just nu. hela raden gör att båda listorna ska stämma. När man gör enroll det ska synas i både courses och students.

    }

    public void
}