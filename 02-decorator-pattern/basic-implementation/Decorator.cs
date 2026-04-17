public abstract class Decorator : IWord
{
    protected IWord _word;
    public Decorator(IWord w)
    {
        _word = w;
    }
    public abstract string Write();
}
