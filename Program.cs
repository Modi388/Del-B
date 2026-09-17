Student tony = new Student("Tony");
Student chris = new Student("Christoffer");
Student paulie = new Student("Paulie");

Course geo = new Course("Geografi", 5);
Course his = new Course("Historia", 2);

Console.WriteLine("1 - Anmälan genom Enroll");
geo.Enroll(tony);
geo.RollCall();
tony.Schedule();

