
using DependencyInjectionPratic;
using DependencyInjectionPratic.Teacher;

ITeacher teacher = new Teacher("Emre", "Can");

ClassRoom classRoom = new ClassRoom(teacher);

Console.WriteLine(classRoom.GetTeacherInfo());