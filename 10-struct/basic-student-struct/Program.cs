Student[] students =
{
    new() {Name = "Habib", Roll = 1, CGPA = 4.6},
    new() {Name = "Adnan", Roll = 2, CGPA = 4.2},
    new() {Name = "Halim", Roll = 3, CGPA = 5.00},
    new() {Name = "Khalid", Roll = 4, CGPA = 2.0},
    new() {Name = "Galib", Roll = 5, CGPA = 3.7},
    new() {Name = "Mofij", Roll = 6, CGPA = 2.7},
    new() {Name = "Rafi", Roll = 7, CGPA = 1.3},
    new() {Name = "Abdul", Roll = 8, CGPA = 3.2},
};

var filteredStudents = students.Where(s => s.CGPA > 4.0)
    .OrderByDescending(s => s.CGPA);

foreach (var student in filteredStudents)
{
    Console.WriteLine($"{student.Name}({student.Roll}) -> {student.CGPA}");
}

struct Student
{
    public string Name { get; init; }
    public int Roll { get; init; }
    public double CGPA { get; init; }
}