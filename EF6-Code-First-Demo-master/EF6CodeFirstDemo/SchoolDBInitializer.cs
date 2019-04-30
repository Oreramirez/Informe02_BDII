using System.Collections.Generic;
using System.Data.Entity;

namespace EF6CodeFirstDemo
{
    public class SchoolDBInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            IList<Grade> grades = new List<Grade>();

            grades.Add(new Grade() { GradeName = "Grade 1", Section = "A" });
            grades.Add(new Grade() { GradeName = "Grade 1", Section = "B" });
            grades.Add(new Grade() { GradeName = "Grade 1", Section = "C" });
            grades.Add(new Grade() { GradeName = "Grade 2", Section = "A" });
            grades.Add(new Grade() { GradeName = "Grade 3", Section = "A" });

            context.Grades.AddRange(grades);

            IList<Student> student = new List<Student>();

            student.Add(new Student() { StudentName = "Bill", Height = 1.70, Weight = 68, GradeId = 2 });
            student.Add(new Student() { StudentName = "Steve", Height = 1.75, Weight = 88, GradeId = 2 });
            student.Add(new Student() { StudentName = "James", Height = 1.68, Weight = 70, GradeId = 4 });
            student.Add(new Student() { StudentName = "Tim", Height = 1.60, Weight = 64, GradeId = 1 });
            student.Add(new Student() { StudentName = "Rama", Height = 1.74, Weight = 75, GradeId = 3 });
            student.Add(new Student() { StudentName = "Mohan", Height = 1.73, Weight = 83, GradeId = 3 });
            student.Add(new Student() { StudentName = "Merry", Height = 1.70, Weight = 80, GradeId = 1 });
            student.Add(new Student() { StudentName = "Kapil", Height = 1.67, Weight = 69, GradeId = 4 });
            student.Add(new Student() { StudentName = "Imran", Height = 1.81, Weight = 80, GradeId = 4 });
            student.Add(new Student() { StudentName = "Don", Height = 1.73, Weight = 76, GradeId = 2 });
            context.Students.AddRange(student);
            base.Seed(context);
        }


    }
}