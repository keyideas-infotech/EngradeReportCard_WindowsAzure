using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERC.DataModel;

namespace ERC.BusinessLogic.Export
{
	public class CommonPlaceholderHelper
	{
		private Dictionary<string, string> Values
		{
			get
			{
				return _values ?? (_values = new Dictionary<string, string>());
			}
		}
		private Dictionary<string, string> _values;


		public string GetValue(CommonPlacholder placholder)
		{
			return GetValue(placholder.ToString());
		}

		public string GetValue(String placeholder)
		{
			return Values.ContainsKey(placeholder) ? Values[placeholder] : String.Empty;
		}

		public void SetValue(CommonPlacholder placeholder, string value)
		{
			SetValue(placeholder.ToString(), value);
		}

		public void SetValue(string placeholder, string value)
		{
			Values[placeholder] = value;
		}



		public void SetValues(SchoolPeriod schoolPeriod, ReportingPeriod reportingPeriod, School school, SchoolDistrict district)
		{
			SetValue(CommonPlacholder.DistrictName, district.Name);
			SetValue(CommonPlacholder.PeriodName, reportingPeriod.Name);
			SetValue(CommonPlacholder.SchoolName, school.Name);
		}

		public void SetValues(Student student, Teacher teacher)
		{
			SetValue(CommonPlacholder.StudentFirstName, student.FirstName);
			SetValue(CommonPlacholder.StudentLastName, student.LastName);
			SetValue(CommonPlacholder.StudentMiddleName, student.MiddleName);
			SetValue(CommonPlacholder.StudentName, student.Name);
			SetValue(CommonPlacholder.StudentFullName, student.FullName);
			SetValue(CommonPlacholder.StudentGradeLevel, student.GradeLevelShort);
			SetValue(CommonPlacholder.StudentIDNumber, student.IDNumber);

			SetValue(CommonPlacholder.TeacherEmail, teacher.Email);
			SetValue(CommonPlacholder.TeacherFirstName, teacher.FirstName);
			SetValue(CommonPlacholder.TeacherIDNumber, teacher.IDNumber);
			SetValue(CommonPlacholder.TeacherLastName, teacher.LastName);
			SetValue(CommonPlacholder.TeacherName, teacher.FullName);
			SetValue(CommonPlacholder.TeacherNameSortable, teacher.FullNameSortable);
			SetValue(CommonPlacholder.TeacherPhone, teacher.Phone);

			SetValue(CommonPlacholder.GradeLevel, student.GradeLevelShort);
		}


		public static Dictionary<string, string> GetPlaceholderList()
		{
			var dict = new Dictionary<string, string>();

			dict.Add(CommonPlacholder.DistrictName.ToString(), "District Name");
			dict.Add(CommonPlacholder.PeriodName.ToString(), "School Period Name (ie \"Fall 2010\" or \"2010 - 2011\")");
			dict.Add(CommonPlacholder.SchoolName.ToString(), "School Name");
			dict.Add(CommonPlacholder.StudentFirstName.ToString(), "Student's First Name");
			dict.Add(CommonPlacholder.StudentMiddleName.ToString(), "Student's Middle Name");
			dict.Add(CommonPlacholder.StudentLastName.ToString(), "Student's Last Name");
			dict.Add(CommonPlacholder.StudentName.ToString(), "Student's Name (First Last)");
			dict.Add(CommonPlacholder.StudentFullName.ToString(), "Student's Full Name (First Middle Last)");
			dict.Add(CommonPlacholder.StudentIDNumber.ToString(), "Student's ID Number");
			dict.Add(CommonPlacholder.TeacherEmail.ToString(), "Student's Email Address");
			dict.Add(CommonPlacholder.TeacherFirstName.ToString(), "Teacher's First Name");
			dict.Add(CommonPlacholder.TeacherLastName.ToString(), "Teacher's Last Name");
			dict.Add(CommonPlacholder.TeacherName.ToString(), "Teacher's Name (First Last)");
			dict.Add(CommonPlacholder.TeacherNameSortable.ToString(), "Teacher's Sortable Name (Last, First)");
			dict.Add(CommonPlacholder.TeacherIDNumber.ToString(), "Teacher's ID Number");
			dict.Add(CommonPlacholder.TeacherPhone.ToString(), "Teacher's Phone Number");

			return dict;
		}
	}


	public enum CommonPlacholder
	{
		DistrictName,
		SchoolName,
		PeriodName,
		GradeLevel,
		TeacherName,
		TeacherNameSortable,
		TeacherFirstName,
		TeacherLastName,
		TeacherPhone,
		TeacherEmail,
		TeacherIDNumber,
		StudentName,
		StudentFullName,
		StudentFirstName,
		StudentLastName,
		StudentMiddleName,
		StudentIDNumber,
		StudentGradeLevel
	}
}
