State state1 = new();
Country country1 = new();
//вывод всего
Console.WriteLine(state1.x);
Console.WriteLine(state1.y);
Console.WriteLine(country1.x);
Console.WriteLine(country1.y);
Console.WriteLine();
//присвоение
struct State
{
    public int x;
    public int y;
    public Country country;
    public State()
    {
        x = 12;
        y = 423;
        country = new Country();
    }
}
class Country
{
    public int x;
    public int y;
    public Country()
    {
        x = 19;
        y = 65;
    }
}
//the whole program work