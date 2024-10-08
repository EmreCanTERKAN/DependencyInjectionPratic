namespace DependencyInjectionPratic.Teacher
{
    public interface ITeacher
    {

            string FirstName { get; set; }
            string LastName { get; set; }
            string GetInfo(); // Öğretmenin adını ve soyadını döndüren metot
        
    }
}
