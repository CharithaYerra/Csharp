using System;
using System.Threading.Tasks;

namespace AsyncClinicPreparation
{
    class ClinicTasks
    {
        public static async Task SanitizeRoomAsync()
        {
            var start = DateTime.Now;
            await Task.Delay(4000); // Simulate 4 sec cleaning
            var end = DateTime.Now;
            Console.WriteLine($" Room Sanitized (Took {(end - start).TotalSeconds} seconds)");
        }

        public static async Task CheckEquipmentAsync()
        {
            var start = DateTime.Now;
            await Task.Delay(3000); // Simulate 3 sec check
            var end = DateTime.Now;
            Console.WriteLine($" Equipment Checked (Took {(end - start).TotalSeconds} seconds)");
        }

        public static async Task PreparePatientRecordsAsync()
        {
            var start = DateTime.Now;
            await Task.Delay(2000); // Simulate 2 sec task
            var end = DateTime.Now;
            Console.WriteLine($" Patient Records Ready (Took {(end - start).TotalSeconds} seconds)");
        }
    }

    class Doctor
    {
        public static async Task PrepareForDay()
        {
            Console.WriteLine(" Preparing Clinic Asynchronously...\n");

            Task sanitize = ClinicTasks.SanitizeRoomAsync();
            Task check = ClinicTasks.CheckEquipmentAsync();
            Task prepare = ClinicTasks.PreparePatientRecordsAsync();

            Console.WriteLine(" Doctor is reviewing today’s appointments while tasks run...");

            await Task.WhenAll(sanitize, check, prepare);

            Console.WriteLine("\n Clinic is ready. Patients can be called in!");
        }
    }

    class Program
    {
        static async Task Main()
        {
            await Doctor.PrepareForDay();
        }
    }
}
