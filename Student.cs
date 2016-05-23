using System;
namespace Lab_OP_2
{
    class Student
    {
        const string ERROR = "You've input an invalid value!";
        private int _id;
        private string _name;
        private string _surN;
        private string _secN;
        private DateTime _birthDate;
        private int _phoneNum;
        private string _faculty;
        private int _course;
        private string _group;

        public Student() { }

        public Student(int id, string surName, string Name, string secondName, DateTime dateTime,
            int phoneNumber, string faculty, int course, string group)
        {
            _id = id;
            _surN = surName;
            _name = Name;
            _secN = secondName;
            _birthDate = dateTime;
            _phoneNum = phoneNumber;
            _faculty = faculty;
            _course = course;
            _group = group;
        }
        
        public int GetId()
        { return _id; }
        public string GetName()
        {
            if (string.IsNullOrWhiteSpace(_name))
                return ERROR;
            else return _name;
        }
        public string GetSurname()
        {
            if (string.IsNullOrWhiteSpace(_surN))
                return ERROR;
            else return _surN;
        }
        public string GetSecondName()
        {
            if (string.IsNullOrWhiteSpace(_secN))
                return ERROR;
            else return _secN;
        }
        public DateTime GetBirthDate()
        { return _birthDate; }
        public int GetPhoneNumber()
        { return _phoneNum; }
        public string GetFaculty()
        { return _faculty; }
        public int GetCourse()
        {
            return _course;
        }
        public string GetGroup()
        { return _group; }

        public override string ToString()
        {
            return string.Format("Студент № {0} - {1} {2} {3}; Дата рождения: {4}; домашний телефон: {5};\t факультет: {6}, курс {7}, группа {8}\n"
                , GetId(),  GetSurname(), GetName(), GetSecondName(), GetBirthDate().Year, GetPhoneNumber(), 
                GetFaculty(), GetCourse(), GetGroup());
        }


    }
}