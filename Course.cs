
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

    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)"; // skriver ut kursens namn. antal studenter som går i kursen och i slutet maxkapacitetet. Student.Count läses varje gång en utskrift sker så texten uppdateras av sig själv när någon ny går med i kursen
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

    public void Remove(Student student)
    {
        if (!Students.Contains(student)) // ! gör att motsatesen händer. Alltså kolla ifall studenten inte existerar i denna kursens lista
        {
            Console.WriteLine("Studenten går inte i denna kurs");
            return;
        }

        Students.Remove(student); // tar bort student
        student.Courses.Remove(this); // gör att det funkar åt båda håll. kursen ska bort från studentens kurslista och studenten ska bort från kursens studentlista
    }

    public void RollCall() // en metod som visar en lista på alla studenternas namn i kursen
    {
        Console.WriteLine(this); // visar namnet av kursen med antal elever och vad maxkapaciteten är.
        for (int i = 0; i < Students.Count; i++) // for loop som går igenom alla studenter i listan
        {
            Console.WriteLine(Students[i]);
        }

    }
}