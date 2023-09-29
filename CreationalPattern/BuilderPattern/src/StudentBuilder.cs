namespace BuilderPattern;
public abstract class StudentBuilder
{
    public int RollNumber { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public List<string> Subjects { get; set; }

    public StudentBuilder SetRollNumber(int rollNumber)
    {
        this.RollNumber = rollNumber;
        return this;
    }

    public StudentBuilder SetAge(int age)
    {
        this.Age = age;
        return this;
    }
    public StudentBuilder SetName(string name)
    {
        this.Name = name;
        return this;
    }
    public StudentBuilder SetFatherName(string fatherName)
    {
        this.FatherName = fatherName;
        return this;
    }
    public StudentBuilder SetMotherName(string motherName)
    {
        this.MotherName = motherName;
        return this;
    }
    public abstract StudentBuilder SetSubjects();

    public Student Build()
    {
        return new Student(this);
    }

}