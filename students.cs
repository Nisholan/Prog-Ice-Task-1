public static class Students
{
    string name;
    string course;
    bool decision;

    public students(string name, string course, bool employed)
    {
        this.Name = name;
        this.Course = course;
        this.Employed = employed;
    }

    public string Name { get => name; set => name = value; }
    public string Course { get => course; set => course = value; }
    public bool Employed { get => employed; set => employed = value; }
}