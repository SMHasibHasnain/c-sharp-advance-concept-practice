public class WordDecorator01 : Decorator
{
    public WordDecorator01(IWord w) : base(w) {}
    
    public override string Write()
    {
        return "play" + " " + _word.Write();
    }
}
