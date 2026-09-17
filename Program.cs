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

