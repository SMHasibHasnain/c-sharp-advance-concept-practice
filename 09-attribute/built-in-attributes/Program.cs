using System.ComponentModel.DataAnnotations;

var task = new Task();
task.Summery();
task.Analysis();



class Task
{
    public string Title { get; set; }
    public string Cateogry { get; set; }
    public string Description { get; set; }
    public List<string> Tags { get; set; }
    public DateTime DeadLine { get; set; }
    public DateTime CreatedTime { get; init; }

    [Obsolete("This method is obsoleted. Use 'Analysis Method instead!'", false)]
    public void Summery()
    {
        System.Console.WriteLine("Here is task summery (old)!");
    }

    public void Analysis()
    {
        System.Console.WriteLine("Here is task summery (new)");
    }
}
