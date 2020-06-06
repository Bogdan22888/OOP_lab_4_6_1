using System;

namespace OOP_lab_4_6_1
{
    class Program
    {
		static void Main(string[] args)
		{
			Student student = new Student();

			Console.WriteLine("Enter student's name:");
			student.SetName(Console.ReadLine());

			Console.WriteLine("Enter student's surname:");
			student.SetLastName(Console.ReadLine());

			Console.WriteLine("Enter student's group name:");
			student.SetGroup(Console.ReadLine());

			Console.WriteLine("Enter student's year:");
			student.SetYear(Convert.ToInt32(Console.ReadLine()));

			Console.WriteLine("Enter student's address:");
			student.SetAddress(Console.ReadLine());

			Console.WriteLine("Enter student's passport id:");
			student.SetPassport(Convert.ToInt32(Console.ReadLine()));

			Console.WriteLine("Enter student's age:");
			student.SetAge(Convert.ToInt32(Console.ReadLine()));

			Console.WriteLine("Enter student's phone number:");
			student.SetTelephone(Convert.ToInt32(Console.ReadLine()));

			Console.WriteLine("Enter student's rating:");
			student.SetRating(Convert.ToInt32(Console.ReadLine()));

			student.StudentRating(student.GetRating());
		}
	}
}
