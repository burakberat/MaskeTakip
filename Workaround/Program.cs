

using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.FirstName = "Ahmet";
        person1.LastName = "Mehmet";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentity = 123456;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
    }
}