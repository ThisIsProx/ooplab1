namespace ooplab1
{
    public class StudentViewModel
    {
        private string _surname = "";
        private string _name = "";
        private string _dayOfBirthday = "";
        public int Age { get; }

        public StudentViewModel(string surname, string name, string dayOfBirthday)
        {
            this._surname = surname;
            this._name = name;
            this._dayOfBirthday = dayOfBirthday;
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string DayOfBirthday
        {
            get { return _dayOfBirthday; }
            set { _dayOfBirthday = value; }
        }
    }
}
