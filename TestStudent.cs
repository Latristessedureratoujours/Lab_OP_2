using System;
namespace Lab_OP_2
{
    class TestStudent
    {
        static void Main()
        {
            const string DEFAULT_FACULTY = "ИЭФ";
            const int DEFAULT_COURSE = 2;
            const string DEFAULT_GROUP = "ПИр-151";

            System.DateTime Birthday = new DateTime(1998, 1, 1);


            Student[] stArray = {new Student(1721, "Апанасик", "Марина", "Юрьевна", new DateTime(1998, 4, 5),
                228222, "ИЭФ", 1, "ПИр-151"), new Student(2545, "Свириденко", "Виталий", "Вячеславович", new DateTime(1996, 3, 9),
                264774, "ИЭФ", 1, "ПИр-151"), new Student(5467, "Сидин", "Александр", "Сергеевич",
                new DateTime(1999, 11, 1), 224873, "ИЭФ", 1, "ПИр-151"), new Student(1111, "Ткачёва", "Алина", "Викторовна",
                new DateTime(1997, 4, 13), 214454, "ИЭФ", 2, "УИР-151"), new Student(0101, "Корпечин", "Роман", "Александрович",
                new DateTime(1996, 5, 15), 699669, "ИЭФ", 1, "ПИр-151"), new Student(878, "Калугина", "Ксения", "Юрьевна",
                new DateTime(1998, 7, 28), 225333, "ЭТФ", 2, "АСОИ-141"), new Student(7985, "Куприянов", "Владимир", "Владимирович",
                new DateTime(1999, 11, 11), 223415, "ИЭФ", 2, "ЭАиТР-141") };

            Console.WriteLine("Список студентов инженерно-экономического факультета: \n");
            foreach (Student student in stArray)
                if (student.GetFaculty() == DEFAULT_FACULTY) Console.WriteLine(student.ToString() + " ");

            Console.WriteLine("\n\n");

            Console.WriteLine("Список студентов 2 курса для инженерно-экономического факультета");
            foreach (Student student in stArray)
                if (student.GetFaculty() == DEFAULT_FACULTY && student.GetCourse() == DEFAULT_COURSE)
                    Console.WriteLine(student.ToString());

            Console.WriteLine("Список учебной группы {0}", DEFAULT_GROUP);
            foreach (Student student in stArray)
                if (student.GetGroup() == DEFAULT_GROUP)
                    Console.WriteLine(student.ToString());

            Console.WriteLine("\n\n");

            Console.WriteLine("Список студентов, родившихся после {0} года", Birthday.Year);
            foreach (Student student in stArray)
                if ((student.GetBirthDate().Year > Birthday.Year))
                    Console.WriteLine(student.ToString());
        }
    }
}
