var Person = new Person
{
    FirstName = "Kelly",
    LastName = "Murcury",
    SocialSecurityNumber = 291991025,
    Photo = new PersonPhoto { Photo = new Byte[] { 0, 1, 0, 1 }}
};

var Person2 = new Person
{
    FirstName = "Dana",
    LastName = "Moore",
    SocialSecurityNumber = 291231010,
    Photo = new PersonPhoto { Photo = new Byte[] { 1, 1, 1 ,1 }}
};

using (PersonDbContext dbContext = new PersonDbContext())
{
    var person1 = dbContext.People.Find(1);
    var person2 = dbContext.People.Find(2);
    var person3 = dbContext.People.Find(3);
    person1.Photo = new PersonPhoto { Caption = "Picture of BeachFront Home", Photo = new byte[] { 0, 0, 1, 0}};
    person2.Photo = new PersonPhoto { Caption = "Cool Car in front of Home", Photo = new byte[] { 0, 0, 0, 1}};
    person3.Photo = new PersonPhoto { Caption = "In front of pool at home", Photo = new byte[] { 1, 1, 1, 0}};
    
    dbContext.AddRange(person1.Photo, person2.Photo, person3.Photo);
    dbContext.SaveChanges();
}

System.Console.WriteLine("Data updated to Database");
Console.ReadKey();