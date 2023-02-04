using AdapterPattern;

class Program
{
    static void Main(string[] args)
    {
        Adaptee ad = new Adaptee();
        ITarget target = new Adapter(ad);
        Console.WriteLine(target.GetTargetRequest());
    }
}