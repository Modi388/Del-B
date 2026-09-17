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



}