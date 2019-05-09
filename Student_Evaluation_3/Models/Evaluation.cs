﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Evaluation_3.Models
{
    [Serializable]
    public class Evaluation
    {
        public int EvaluationID { get; set; }
        public int StakeholderID { get; set; }
        public ICollection<Stakeholder> stakeholders { get; set; }
        public int EnrollmentID { get; set; }
        public Enrollment Enrollment { get; set; }
        [DisplayName("Why did you take this course?")]
        public String why_course { get; set; }
        [DisplayName("How many hours per week were spent studying outside of class?")] 
        public String hours_week { get; set; }
        [DisplayName("How does this course connect with your life?")]
        public String life_connection { get; set; }
        public String grade { get; set; }
        public String clear_goals { get; set; }
        public String helpful_assignments { get; set; }
        public String reading_helpful { get; set; }
        public String relevant_materials { get; set; }
        public String challenged_learn { get; set; }
        public String clear_syllabus { get; set; }
        public String instructor_prepared { get; set; }
        public String instructor_knowledgeable { get; set; }
        public String effective_teaching { get; set; }
        public String timely_manner { get; set; }
        public String suggested_improvement { get; set; }
        public String grading_fair { get; set; }
        public String enthusiastic_teaching { get; set; }
        public String concern_understanding { get; set; }
        public String instructor_interaction { get; set; }
        public String different_views { get; set; }
        public String student_improved { get; set; }
        public String successful_in { get; set; }
        public String good_because { get; set; }
        public String improved_by { get; set; }
        public String good_job { get; set; }
        public String teaching_improved { get; set; }

    }
}
