using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolkidApp
{

    public partial class Form1 : Form
    {

        private List<Student> students;

        public Form1()
        {
            InitializeComponent();
            students = new List<Student>


            {
                new Student
            {
                LastName = "Иванов",
                FirstName = "Иван",
                MiddleName = "Иванович",
                DateOfBirth = new DateTime(2008, 3, 15),
                Residence = "Судак",
                Workplace = "Школа №2",
                PaymentDate = new DateTime(2023, 6, 1)
            },
        new Student
        {
            LastName = "Петров",
            FirstName = "Петр",
            MiddleName = "Петрович",
            DateOfBirth = new DateTime(2007, 7, 20),
            Residence = "Судак",
            Workplace = "Школа №3",
            PaymentDate = new DateTime(2023, 9, 1)
        },
        new Student
        {
            LastName = "Сидорова",
            FirstName = "Мария",
            MiddleName = "Ивановна",
            DateOfBirth = new DateTime(2006, 11, 12),
            Residence = "Судак",
            Workplace = "Гимназия №1",
            PaymentDate = new DateTime(2023, 4, 15)
        },
        new Student
        {
            LastName = "Кузнецов",
            FirstName = "Максим",
            MiddleName = "Александрович",
            DateOfBirth = new DateTime(2009, 2, 28),
            Residence = "Судак",
            Workplace = "Колледж",
            PaymentDate = new DateTime(2023, 7, 1)
        },
        new Student
        {
            LastName = "Смирнова",
            FirstName = "Анна",
            MiddleName = "Сергеевна",
            DateOfBirth = new DateTime(2006, 5, 10),
            Residence = "Судак",
            Workplace = "Школа №2",
            PaymentDate = new DateTime(2023, 11, 1)
        },
        new Student
        {
            LastName = "Михайлов",
            FirstName = "Дмитрий",
            MiddleName = "Михайлович",
            DateOfBirth = new DateTime(2007, 9, 22),
            Residence = "Судак",
            Workplace = "Школа №2",
            PaymentDate = new DateTime(2023, 2, 15)
        },
        new Student
        {
            LastName = "Соколова",
            FirstName = "Елена",
            MiddleName = "Владимировна",
            DateOfBirth = new DateTime(2006, 4, 5),
            Residence = "Судак",
            Workplace = "Гимназия №4",
            PaymentDate = new DateTime(2023, 6, 1)
        },
        new Student
        {
            LastName = "Волков",
            FirstName = "Андрей",
            MiddleName = "Александрович",
            DateOfBirth = new DateTime(2007, 11, 18),
            Residence = "Судак",
            Workplace = "Колледж",
            PaymentDate = new DateTime(2023, 9, 1)
        },
        new Student
        {
            LastName = "Орлова",
            FirstName = "Ольга",
            MiddleName = "Ивановна",
            DateOfBirth = new DateTime(2006, 8, 3),
            Residence = "Судак",
            Workplace = "Школа №4",
            PaymentDate = new DateTime(2023, 3, 15)
        },
        new Student
        {
            LastName = "Павлов",
            FirstName = "Сергей",
            MiddleName = "Павлович",
            DateOfBirth = new DateTime(2008, 6, 12),
            Residence = "Судак",
            Workplace = "Школа №4",
            PaymentDate = new DateTime(2023, 12, 1)
        }
    };
            UpdateStudentList();
        }




        private void UpdateStudentList()
        {
            listBox1.Items.Clear();
            foreach (var student in students)
            {
                listBox1.Items.Add(student.FullName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                var selectedStudent = students[listBox1.SelectedIndex];
                textBox1.Text = selectedStudent.LastName;
                textBox2.Text = selectedStudent.FirstName;
                textBox3.Text = selectedStudent.MiddleName;
                dateTimePicker1.Value = selectedStudent.DateOfBirth;
                textBox4.Text = selectedStudent.Residence;
                textBox5.Text = selectedStudent.Workplace;
                dateTimePicker2.Value = selectedStudent.PaymentDate;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Введите корректный текст в поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newStudent = new Student
            {
                LastName = textBox1.Text,
                FirstName = textBox2.Text,
                MiddleName = textBox3.Text,
                DateOfBirth = dateTimePicker1.Value,
                Residence = textBox4.Text,
                Workplace = textBox5.Text,
                PaymentDate = dateTimePicker2.Value
            };
            students.Add(newStudent);
            UpdateStudentList();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                var selectedStudent = students[listBox1.SelectedIndex];
                selectedStudent.LastName = textBox1.Text;
                selectedStudent.FirstName = textBox2.Text;
                selectedStudent.MiddleName = textBox3.Text;
                selectedStudent.DateOfBirth = dateTimePicker1.Value;
                selectedStudent.Residence = textBox4.Text;
                selectedStudent.Workplace = textBox5.Text;
                selectedStudent.PaymentDate = dateTimePicker2.Value;
                UpdateStudentList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                students.RemoveAt(listBox1.SelectedIndex);
                UpdateStudentList();
            }
        }


        public class Student
        {

            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Residence { get; set; }
            public string Workplace { get; set; }
            public DateTime PaymentDate { get; set; }

            public string FullName
            {
                get { return $"{LastName} {FirstName} {MiddleName}"; }
            }

        }
    }
}