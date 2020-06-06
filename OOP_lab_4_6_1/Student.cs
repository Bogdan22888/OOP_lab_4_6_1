using System;

namespace OOP_lab_4_6_1
{
	public class Student
	{
		private string name;
		private string lastName;
		private string group;
		private int year;
		private string address;
		private int passport;
		private int age;
		private int telephone;
		private int rating;

		public Student() { }

		public string GetName() { return name; }
		public string GetLastName() { return lastName; }
		public string GetGroup() { return group; }
		public int GetYear() { return year; }
		public string GetAddress() { return address; }
		public int GetPassport() { return passport; }
		public int GetAge() { return age; }
		public int GetTelephone() { return telephone; }
		public int GetRating() { return rating; }
		public void SetName(string name) { this.name = name; }
		public void SetLastName(string surname) { lastName = surname; }
		public void SetGroup(string group) { this.group = group; }
		public void SetYear(int year) { this.year = year; }
		public void SetAddress(string address) { this.address = address; }
		public void SetPassport(int passportId) { passport = passportId; }
		public void SetAge(int age) { this.age = age; }
		public void SetTelephone(int phoneNumber) { telephone = phoneNumber; }
		public void SetRating(int rating) { this.rating = rating; }

		public void StudentRating(int R)
		{
			if (rating >= 90)
			{
				Console.WriteLine("Вітаємо відмінника");
			}
			else if (rating >= 75)
			{
				Console.WriteLine("Можна вчитися краще");
			}
			else
			{
				Console.WriteLine("Варто більше уваги приділяти навчанню");
			}
		}
	}
}
