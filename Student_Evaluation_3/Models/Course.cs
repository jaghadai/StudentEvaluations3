﻿using System.Collections.Generic;

namespace Student_Evaluation_3.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }


        
    }
}
