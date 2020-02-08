using busines;
using data.Models;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Web.Helpers;

namespace DebagIterationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminManager admin = new AdminManager();
            //Course course1 = new Course() { Name = "Test18", CourseInfo = "Pro test18" };
            //Thread.Sleep(20000);
            //string json = JsonSerializer.Serialize<Course>(course1);

            //object forcourse = json;
            //admin.CreatCourse(forcourse);

            //Course course2 = new Course() { Name = "Front-End", CourseInfo = "Pro Front-End" };
            //json = JsonSerializer.Serialize<Course>(course2);

            //forcourse = json;
            //admin.CreatCourse(forcourse);
            Thread.Sleep(20000);
            IList<Course> courses = (List<Course>)admin.GetAll<Course>();
            foreach(Course item in courses)
            {
                Console.WriteLine($"{item.Name} {item.CourseInfo}");
            }

        }
    }
}
