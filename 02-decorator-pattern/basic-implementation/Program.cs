using System.IO.Pipes;

var one = new WordDecorator01(
    new WordDecorator02(
    new ChosenWord()))
    .Write();

Console.WriteLine(one);


public interface IWord
{
    string Write();
}

class ChosenWord : IWord
{
    public string Write()
    {
        return "football";
    }
}
