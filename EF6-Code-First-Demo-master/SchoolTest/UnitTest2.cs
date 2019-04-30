using System;
using System.Collections.Generic;
using System.Linq;
using EF6CodeFirstDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        //public void InsertarEstudianteSatisfactoriamente()
        //{
        //    using (var context = new SchoolContext())
        //    {
        //        var std = new Student()
        //        {
        //            FirstName = "Bill",
        //            LastName = "Gates"
        //        };
        //        context.Students.Add(std);
        //        context.SaveChanges();
        //    }
        //}
        /*public void ActualizarElPrimerEstudianteSatisfactoriamente()
        {
            using (var context = new SchoolContext())
            {
                var std = context.Students.First<Student>();
                std.FirstName = "Steve";
                context.SaveChanges();
            }
        }*/

        //public void EliminarElPrimerEstudianteSatisfactoriamente()
        //{
        //    using (var context = new SchoolContext())
        //    {
        //        var std = context.Students.First<Student>();
        //        context.Students.Remove(std);
        //        context.SaveChanges();
        //    }
        //}

        public void AgregarTresEstudiantesSatisfactoriamente()
        {
            IList<Student> newStudents = new List<Student>();
            {
                new Student() { StudentName = "Steve" };
                new Student() { StudentName = "Bill" };
                new Student() { StudentName = "James" };
            };
            using (var context = new SchoolContext())
            {
                context.Students.AddRange(newStudents);
                context.SaveChanges();
            }
            Assert.IsNotNull(newStudents);
        }

        public void EliminarTresEstudiantesSatisfactoriamente()
        {
            IList<Student> studentsToRemove = new List<Student>();
            {
                new Student() { StudentID = 1, StudentName = "Steve" };
                new Student() { StudentID = 2, StudentName = "Bill" };
                new Student() { StudentID = 3, StudentName = "James" };
            };
            using (var context = new SchoolContext())
            {
                context.Students.RemoveRange(studentsToRemove);
                context.SaveChanges();
            }
        }
    }
}
