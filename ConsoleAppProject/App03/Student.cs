namespace ConsoleAppProject.App03
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Student class keeps student details
    /// </summary>
    /// <author>Chris Edgley</author>
    public class Student
    {
        /// <summary>
        /// backing field of first name prop
        /// </summary>
        private string firstName;
        /// <summary>
        /// backing field of last name prop
        /// </summary>
        public string lastName;
        /// <summary>
        /// backing field of mark prop
        /// </summary>
        private int mark = default!;
        /// <summary>
        /// backing field of grade prop
        /// </summary>
        private Grades grade;

        /// <summary>
        /// Create new empty student model
        /// </summary>
        public Student() { }

        /// <summary>
        /// Create new student with id, first and last name
        /// </summary>
        /// <param name="id">The id of the student</param>
        /// <param name="firstName">The first name of the student</param>
        /// <param name="lastName">The last name of the student</param>
        public Student(int id, string firstName, string lastName)
        {
            this.StudentId = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// The id of this student
        /// </summary>
        [Key]
        public int StudentId { get; set; }

        /// <summary>
        /// The name of this student
        /// </summary>
        public string FirstName
        {
            get => this.firstName;
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("invalid Student name!");
                else if (value is null || value is "")
                    throw new NullReferenceException("Enter your Name!");

                this.firstName = value;
            }
        }

        /// <summary>
        /// The last name of this student
        /// </summary>
        public string LastName
        {
            get => lastName;
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("invalid Student name!");
                else if (value is null || value is "")
                    throw new NullReferenceException("enter your Name!");
                lastName = value;
            }
        }

        /// <summary>
        /// The full name of this student
        /// </summary>
        public string FullName => $"{this.FirstName} {this.LastName}";

        /// <summary>
        /// The grade of this student
        /// </summary>
        public Grades Grade
        {
            get => this.grade;
            set => this.grade = value; 
        }

        /// <summary>
        /// The mark in percentages of this student
        /// </summary>
        public int Mark
        {
            get => this.mark;
            set
            {
                if (value < 0 )
                    throw new ArgumentOutOfRangeException(nameof(this.Mark));

                this.mark = value;
                
                SetGrade();
            }
        }

        /// <summary>
        /// Override to string method 
        /// </summary>
        /// <returns>Return this student details in string</returns>
        public override string ToString()
            => $"{this.StudentId}. {this.FullName} - {this.Mark}%, {this.grade}";

        /// <summary>
        /// Set the grade of this student depend on the mark
        /// </summary>
        private void SetGrade()
        {
            if (this.mark < 40)
                this.grade = Grades.F;

            else if (this.mark < 50)
                this.grade = Grades.D;
            
            else if (this.mark < 60)
                this.grade = Grades.C;
            
            else if (this.mark < 70)
                this.grade = Grades.B;
            
            else if (this.mark <= 100)
                this.grade = Grades.A;
        }
    }
}
