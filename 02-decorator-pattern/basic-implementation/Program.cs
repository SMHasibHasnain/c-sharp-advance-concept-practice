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

public abstract class Decorator : IWord
{
    protected IWord _word;
    public Decorator(IWord w)
    {
        _word = w;
    }
    public abstract string Write();
}


public class WordDecorator01 : Decorator
{
    public WordDecorator01(IWord w) : base(w) {}
    
    public override string Write()
    {
        return "play" + " " + _word.Write();
    }
}

public class WordDecorator02 : Decorator
{
    public WordDecorator02(IWord w) : base(w) {}
    
    public override string Write()
    {
        return "eat" + " " + _word.Write();
    }    
}