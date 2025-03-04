using Assignment_02_EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_02_EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region CRUD

            using ItiDbContext Context = new ItiDbContext();


            #region Insert
            Student student01 = new Student { FName = "Mohammed", LName = "Ahmed", Address = "Cairo", Age = 25, Dep_Id = 100 };
            Student student02 = new Student { FName = "Sherouk", LName = "Mohy", Address = "Mansoura", Age = 23, Dep_Id = 101 };

            //Console.WriteLine(Context.Entry(student01).State);

            //Context.Students.Add(student01);
            //Context.Students.Add(student02);

            //Console.WriteLine(Context.Entry(student01).State);

            //Context.SaveChanges();
            //Console.WriteLine(Context.Entry(student01).State); 

            #endregion

            #region Read

            //var student = Context.Students.Where(x => x.ID == 1).AsNoTracking().FirstOrDefault();

            //if (student is not null)
            //    Console.WriteLine(student.LName);
            //else
            //    Console.WriteLine("Student not Found");

            #endregion

            #region Update

            //var student = (from e in Context.Students
            //               where e.ID == 1
            //               select e).FirstOrDefault();

            //if (student is not null)
            //{
            //    student.FName = "Eman";

            //    Context.SaveChanges();

            //}

            #endregion


            //var student = (from e in Context.Students
            //               where e.ID == 1
            //               select e).FirstOrDefault();

            //if (student is not null)
            //{
            //    Console.WriteLine(Context.Entry(student01).State);

            //    Context.Students.Remove(student);

            //    Console.WriteLine(Context.Entry(student01).State);

            //    Context.SaveChanges();

            //    Console.WriteLine(Context.Entry(student01).State);

            //}



            #endregion
        }
    }
}
