using DependencyInjectionPratic.Teacher;

namespace DependencyInjectionPratic
{
    public class ClassRoom
    {


        private readonly ITeacher _teacher; // ITeacher interface türünde bağımlılık

        // Constructor Injection
        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }


        public string GetTeacherInfo()
        {
            return _teacher.GetInfo(); // Teacher'ın GetInfo() metodunu çağırıyoruz
        }


    }
}
