namespace BuilderPattern;

public class Student
{
    public int RollNumber { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public List<string> Subjects { get; set; }

    public Student(StudentBuilder builder)
    {
        this.RollNumber = builder.RollNumber;
        this.Age = builder.Age;
        this.Name = builder.Name;
        this.FatherName = builder.FatherName;
        this.MotherName = builder.MotherName;
        this.Subjects = builder.Subjects;
    }
}