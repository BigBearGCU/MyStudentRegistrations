﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace StudentRegistrationApp.Model
{
    /// <summary>
    /// Class <c>Student</c> represents the information about
    /// a student in the Registration system.
    /// </summary>
    public class Student : IEquatable<Student>
    {
        private string _FirstName;

        /// <summary>
        /// Gets or Sets the Name of the Student
        /// </summary>
        [Required(ErrorMessage="Student Name cannot be blank.  Please enter a valid Firstname.")]
        public string Firstname { get; set;}

        /// <summary>
        /// Gets or sets the Surname of the Student
        /// </summary>
        [Required(ErrorMessage="Student Surname cannot be blank.  Please enter a valid name.")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets the Date of Birth of the Student
        /// </summary>
        [Required(ErrorMessage="Date of Birth is a required value.  Please enter a valid date")]
        [DataType(DataType.DateTime, ErrorMessage="Entered value is not a date, please enter a valid date")]
        public DateTime DOB { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Address"/>Address of the Student.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the Title of the Course.
        /// </summary>
        [Required(ErrorMessage="Course title cannot be blank, please enter a valid course title.")]
        public string Course { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="YearOfStudy"/> Year Of Study for the Student.
        /// </summary>
        [Required(ErrorMessage="Year of study is required, please select a valid value from the list.")]
        public YearOfStudyEnum YearOfStudy { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Contact"/> Contact information for the Student
        /// </summary>
        public ContactDetail Contact { get; set; }


        /// <summary>
        /// We implement the IEquatable interface so that we can
        /// determine the rules that make student records equal.
        /// </summary>
        /// <param name="other">The Student record being compared to this student record</param>
        /// <returns>True if equal otherwise false.</returns>
        public bool Equals(Student other)
        {
            //  Determine that Student Records are Equal 'the same'
            //  if the Firstname and Surname are the same.
            if (other == null) throw new ArgumentNullException("No valid Student available for equality check");

            return 
                (this.Firstname == other.Firstname &&
                this.Surname == other.Surname &&
                this.DOB == other.DOB);
        }
    }
}
