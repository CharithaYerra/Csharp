using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Course
{
    // ---------------- Abstract Class ----------------
    abstract class Course
    {
        public string Title { get; set; }
        public double BaseFee { get; set; }

        public Course(string title, double fee)
        {
            Title = title;
            BaseFee = fee;
        }

        public abstract double CalculateFinalFee();
    }

    // ---------------- Polymorphism via Overriding ----------------
    class DesignCourse : Course
    {
        public bool IncludesPortfolio { get; set; }

        public DesignCourse(string title, double fee, bool hasPortfolio)
            : base(title, fee)
        {
            IncludesPortfolio = hasPortfolio;
        }

        public override double CalculateFinalFee()
        {
            return BaseFee + (IncludesPortfolio ? 300 : 0);
        }
    }

    class DevCourse : Course
    {
        public bool IncludesLiveProject { get; set; }

        public DevCourse(string title, double fee, bool hasProject)
            : base(title, fee)
        {
            IncludesLiveProject = hasProject;
        }

        public override double CalculateFinalFee()
        {
            return BaseFee + (IncludesLiveProject ? 500 : 0);
        }
    }

    // ---------------- Extension Method ----------------
    static class CourseExtensions
    {
        public static bool IsAdvanced(this Course course)
        {
            return course.BaseFee > 1000;
        }
    }

    // ---------------- Static Utility ----------------
    static class FeeHelper
    {
        public static double AddPlatformFee(double amount)
        {
            return amount + 100; // Platform fee
        }
    }

    // ---------------- Student Class ----------------
    class Learner
    {
        public string FullName { get; set; }
        public List<Course> EnrolledCourses { get; set; }

        public Learner(string name)
        {
            FullName = name;
            EnrolledCourses = new List<Course>();
        }

        public void Enroll(Course course)
        {
            EnrolledCourses.Add(course);
            Console.WriteLine($"Enrolled in: {course.Title} (Advanced: {course.IsAdvanced()})");
        }

        public async Task ViewCoursesAsync()
        {
            Console.WriteLine($"\n{FullName}'s Enrolled Courses:");

            await Task.Delay(1000); // Simulate loading time

            double total = 0;
            foreach (var c in EnrolledCourses)
            {
                double fee = c.CalculateFinalFee();
                Console.WriteLine($"- {c.Title}: ₹{fee}");
                total += fee;
            }

            double finalAmount = FeeHelper.AddPlatformFee(total);
            Console.WriteLine($"\nTotal with platform fee: ₹{finalAmount}");
        }

        public async Task DownloadCertificateAsync()
        {
            Console.WriteLine("\nPreparing your certificate...");
            await Task.Delay(2000); // Simulate download
            Console.WriteLine("📜 Certificate downloaded successfully!");
        }
    }

    // ---------------- Program Entry ----------------
    class Program
    {
        static async Task Main()
        {
            Learner learner = new Learner("Aarav Shah");

            Course c1 = new DesignCourse("UI/UX Design", 900, true);
            Course c2 = new DevCourse("Full Stack Development", 1200, true);

            learner.Enroll(c1);
            learner.Enroll(c2);

            await learner.ViewCoursesAsync();
            await learner.DownloadCertificateAsync();
        }
    }

}