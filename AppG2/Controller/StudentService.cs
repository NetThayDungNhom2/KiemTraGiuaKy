using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppG2.Model;
namespace AppG2.Controller
{
    public class StudentService
    {
        /// <summary>
        /// Lấy sinh viên theo mã sinh viên từ MockData
        /// </summary>
        /// <param name="idStudent">Mã sinh viên</param>
        /// <returns>Sinh viên có mã tương ứng hoặc null</returns>
        public static Student GetStudent(string idStudent)
        {
            Student student = new Student
            {
                IDStudent = idStudent,
                FirstName = "Zũng",
                LastName = "Nguyễn",
                DOB = new DateTime(2000, 5, 5),
                POB = "Thừa Thiên Huế",
                Gender = GENDER.Male
            };
            student.ListHistoryLearning = new List<HistoryLearning>();
            for (int i = 1; i <= 12; i++)
            {
                HistoryLearning historyLearning = new HistoryLearning
                {
                    IDHistoryLearning = i.ToString(),
                    YearFrom = 2006 + i,
                    YearEnd = 2007 + i,
                    Address = "THCS Phan Bội Châu",
                    IDStudent = idStudent,
                };
                student.ListHistoryLearning.Add(historyLearning);
            }
            return student;
        }

        /// <summary>
        /// Lấy sinh viên theo mã sinh viên từ File
        /// </summary>
        /// <param name="pathDataFile">Đường dẫn tới file chứa dữ liệu</param>
        /// <param name="idStudent">Mã sinh viên</param>
        /// <returns>Sinh viên theo mã sinh viên hoặc Null nếu không thấy</returns>
        public static Student GetStudent(string pathDataFile, string idStudent)
        {
            if (File.Exists(pathDataFile))
            {
                CultureInfo culture = CultureInfo.InvariantCulture;
                var listLines = File.ReadAllLines(pathDataFile);
                foreach (var line in listLines)
                {
                    var rs = line.Split(new char[] { '#' });
                    Student student = new Student
                    {
                        IDStudent = rs[0],
                        LastName = rs[1],
                        FirstName = rs[2],
                        Gender = rs[3] == "Male" ? GENDER.Male : (rs[3] == "Female" ? GENDER.Female : GENDER.Other),
                        DOB = DateTime.ParseExact(rs[4], "yyyy-MM-dd", culture),
                        POB = rs[5]
                    };
                    if (student.IDStudent == idStudent)
                        return student;
                }
                return null;
            }
            else
                return null;
        }

        /// <summary>
        /// Lấy danh sách quá trình học tập của 1 sinh viên
        /// </summary>
        /// <param name="pathDataFile">Đường dẫn file chứa dữ liệu</param>
        /// <param name="idStudent">Mã sinh viên cần lấy</param>
        /// <returns>Danh sách quá trình học tập</returns>
        public static List<HistoryLearning> GetHistoryLearning(
            string pathDataFile, string idStudent)
        {
            if (File.Exists(pathDataFile))
            {
                var listLines = File.ReadAllLines(pathDataFile);
                List<HistoryLearning> listHistory = new List<HistoryLearning>();
                foreach (var line in listLines)
                {
                    var rs = line.Split(new char[] { '#' });
                    HistoryLearning history = new HistoryLearning
                    {
                        IDHistoryLearning = rs[0],
                        YearFrom = int.Parse(rs[1]),
                        YearEnd = int.Parse(rs[2]),
                        Address = rs[3],
                        IDStudent = rs[4]
                    };
                    if (history.IDStudent == idStudent)
                        listHistory.Add(history);
                }
                return listHistory;
            }
            else
                return null;
        }

    }
}
