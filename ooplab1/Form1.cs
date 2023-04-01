using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ooplab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_MouseClick(object sender, MouseEventArgs e)
        {
            // Отримати інформацію про студентів
            List<StudentViewModel> students = new List<StudentViewModel>();
            students.Add(new StudentViewModel(txtSurname.Text, txtName.Text, dtpBirthdate.Value.ToString("dd/MM/yyyy")));

            // Перевірити, чи існує файл INFO.TXT
            string filePath = "INFO.TXT";
            if (!File.Exists(filePath))
            {
                // Якщо файл не існує, створити його
                File.Create(filePath).Close();
            }

            // Зберегти інформацію у файлі INFO.TXT
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                foreach (StudentViewModel student in students)
                {
                    sw.WriteLine(student.Surname + " " + student.Name + " " + student.DayOfBirthday);
                }
            }

            MessageBox.Show("Інформацію збережено у файлі INFO.TXT.");
        }

        private void btnRead_MouseClick(object sender, MouseEventArgs e)
        {
            // Отримати місяць, за яким відбувається сортування
            int month = dtpSort.Value.Month;

            // Зчитати інформацію з файлу INFO.TXT
            List<string> students = new List<string>();
            using (StreamReader sr = new StreamReader("INFO.TXT"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    students.Add(line);
                }
            }

            // Відсортувати інформацію за датою народження
            students.Sort((a, b) =>
            {
                string[] studentA = a.Split(' ');
                string[] studentB = b.Split(' ');

                DateTime dateA = DateTime.ParseExact(studentA[2], "dd/MM/yyyy", null);
                DateTime dateB = DateTime.ParseExact(studentB[2], "dd/MM/yyyy", null);

                if (dateA.Month == month && dateB.Month == month)
                {
                    return dateA.CompareTo(dateB);
                }
                else if (dateA.Month == month)
                {
                    return -1;
                }
                else if (dateB.Month == month)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });

            // Вивести відсортовану інформацію за місяцем народження
            string output = "";
            foreach (string student in students)
            {
                string[] studentInfo = student.Split(' ');
                DateTime birthdate = DateTime.ParseExact(studentInfo[2], "dd/MM/yyyy", null);

                if (birthdate.Month == month)
                {
                    output += student + Environment.NewLine;
                }
            }

            MessageBox.Show(output);
        }
    }
};

