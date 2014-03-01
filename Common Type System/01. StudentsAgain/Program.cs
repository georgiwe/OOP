namespace StudentsAgain
{
    public class MainClass
    {
        public static void Main()
        {
            var student = new Student(
                                      "Georgi",
                                      "Hristov",
                                      "Prodanov",
                                      "Whatever 13",
                                      "483848481881",
                                      "0883444998",
                                      "email@email.com",
                                      5u,
                                      Specialty.Economics,
                                      University.UNWE,
                                      Faculty.FS);

            System.Console.WriteLine(student);

            var studentClone = student.Clone();

            System.Console.WriteLine(studentClone);
        }
    }
}
