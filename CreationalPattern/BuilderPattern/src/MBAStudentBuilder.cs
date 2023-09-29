namespace BuilderPattern;

public class MBAStudentBuilder : StudentBuilder
{
    public override StudentBuilder SetSubjects()
    {
        List<string> subjects = new List<string>();
        subjects.Add("DSA");
        subjects.Add("OS");
        subjects.Add("OOT");
        this.Subjects = subjects;
        return this;
    }
}