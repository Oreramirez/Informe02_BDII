using System;
using System.Linq;
using EF6CodeFirstDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //public void ObtenerGradoConIDUnoSatisfactoriamente()
        //{
        //    var ctx = new SchoolContext();
        //    var Grades01 = ctx.Grades.FirstOrDefault();
        //    Assert.IsNotNull(Grades01);
        //}

        //public void ObtenerEstudianteConIDUnoSatisfactoriamente()
        //{
        //    var ctx = new SchoolContext();
        //    var estudiante = ctx.Students.Find(1);
        //    Assert.IsNotNull(estudiante);
        //}


        //public void ObtenerAlEstudienteConIDUno()
        //{
        //    var ctx = new SchoolContext();
        //    var student = ctx.Students.Find(1);
        //}

        //public void BuscarAlPrimerEstudianteConElNombreBill()
        //{
        //    using (var ctx = new SchoolContext())
        //    {
        //        var student = (from s in ctx.Students
        //                       where s.StudentName == "Bill"
        //                       select s).FirstOrDefault<Student>();
        //    }
        //}

        //public void BuscarEstudiantesAgrupadosPorEstandarGrade()
        //{
        //    using (var ctx = new SchoolContext())
        //    {
        //        var students = from s in ctx.Students
        //                       group s by s.GradeId into studentsByStandard
        //                       select studentsByStandard;
        //        foreach (var groupItem in students)
        //        {
        //            Console.WriteLine(groupItem.Key);
        //            foreach (var stud in groupItem)
        //            {
        //                Console.WriteLine(stud.StudentID);
        //            }
        //        }
        //    }
        //}

        //public void ObtenerListadoDeEstudiantesOrdenadosPorNombre()
        //{
        //    using (var ctx = new SchoolContext())
        //    {
        //        var students = ctx.Students.OrderBy(s => s.StudentName).ToList();
        //       // var descStudents = ctx.Students.OrderByDescending(s => s.StudentName
        //       //).ToList();
        //    }
        //}

        public void BuscarTodosLostudiantesConElEstandarUno()
        {
            using (var ctx = new SchoolContext())
            {
                var anonymousObjResult = from s in ctx.Students
                                         where s.GradeId == 1
                                         select new
                                         {
                                             Id = s.StudentID,
                                             Name = s.StudentName
                                         };

                foreach (var obj in anonymousObjResult)
                {
                    Console.Write(obj.Name);
                }
            }
        }
    }
}
