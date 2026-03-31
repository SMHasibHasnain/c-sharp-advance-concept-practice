var robot1 = new CustomRobot
(
    new CanNotFly(), 
    new WalkingSlowly(), 
    new TalkInBangla());

robot1.Start();

Console.WriteLine("---------------------");

var robot2 = new CustomRobot
(
    new FlyingAnimal(), 
    new WalkingFaster(), 
    new CanNotTalk());

robot2.Start();

class CustomRobot
{
    private IFlyable _flyable;
    private IWalkable _walkable;
    private ITalkable _talkable;
    
    public CustomRobot(IFlyable f, IWalkable w, ITalkable t)
    {
        _flyable = f;
        _walkable = w;
        _talkable = t;
    }

    public void Start()
    {
        _flyable.FLy();
        _talkable.Talk();
        _walkable.Walk();
    }
}



interface IFlyable
{
    void FLy();
}

interface IWalkable
{
    void Walk();
}

interface ITalkable
{
    void Talk();
}

class FlyingAnimal : IFlyable
{
    public void FLy()
    {
        Console.WriteLine("Flying using own wings...");
    }
}
class FlyingJet : IFlyable
{
    public void FLy()
    {
        Console.WriteLine("Flying using jet engine...");
    }
}

class CanNotFly : IFlyable
{
    public void FLy()
    {
        Console.WriteLine("Cannot fly actually...");
    }
}

class WalkingSlowly : IWalkable
{
    public void Walk()
    {
        Console.WriteLine("Walking Slowly...");
    }
}

class WalkingFaster : IWalkable
{
    public void Walk()
    {
        Console.WriteLine("Walking Faster...");
    }
}


class CanNotWalk : IWalkable
{
    public void Walk()
    {
        Console.WriteLine("Cannot walk...");
    }
}

class TalkInEnglish : ITalkable
{
    public void Talk()
    {
        Console.WriteLine("Talking in english...");
    }
}

class TalkInBangla : ITalkable
{
    public void Talk()
    {
        Console.WriteLine("Talking in bangla....");
    }
}

class CanNotTalk : ITalkable
{
    public void Talk()
    {
        Console.WriteLine("Can not talk...");
    }
}