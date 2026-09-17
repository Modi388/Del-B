Student anna = new Student("Anna"); // kör konstruktorn och ger tillbaka ett klart objekt
Console.WriteLine(anna.Name); // tar ut nammnet från anna och skriver ut det
Console.WriteLine(anna.Courses.Count); // skriver ut hur många kurser anna har

Student modi = new Student("Modi");
Console.WriteLine(modi.Name);
Console.WriteLine(modi.Courses.Count);

Console.WriteLine(anna); // genom toString i Student.cs kan jag få namnet direkt 

Course matte = new Course("Matematik", 5);
Console.WriteLine(matte.Name);
Console.WriteLine(matte.MaxSeats);

matte.Enroll(anna);
Console.WriteLine(matte.Students.Count);
Console.WriteLine(anna.Courses.Count);

Course fysik = new Course("Fysik", 3);
modi.Join(fysik);
Console.WriteLine(fysik.Students.Count);   
Console.WriteLine(modi.Courses.Count);     

matte.Enroll(anna);
anna.Join(matte);

Course kemi = new Course("Kemi", 2);
kemi.Enroll(anna);
kemi.Enroll(modi);
Student bo = new Student("Bo");
kemi.Enroll(bo);

Console.WriteLine(kemi.Students.Count);   
Console.WriteLine(bo.Courses.Count);      