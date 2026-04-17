public class WordDecorator02 : Decorator
{
    public WordDecorator02(IWord w) : base(w) {}
    
    public override string Write()
    {
        return "eat" + " " + _word.Write();
    }    
}