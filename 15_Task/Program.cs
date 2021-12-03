// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите значение разности арифметической прогрессии");
ArithProgression arithProgression = new ArithProgression();
for (int i=0; i<5; i++)
Console.WriteLine("Следующее значение равно " + arithProgression.getNext());
Console.WriteLine("\nПереход в исходное состояние."); arithProgression.reset();
Console.WriteLine("Введите значение знаменателя геометрической прогрессии");
GeoProgression geoProgression = new GeoProgression();
for (int i = 0; i < 5; i++)
Console.WriteLine("Следующее значение равно " + geoProgression.getNext());
Console.WriteLine("\nПереход в исходное состояние."); geoProgression.reset();

interface ISeries
{
    void setStart(int x);
    int getNext();
    void reset();
}
class ArithProgression : ISeries
{
    int start;
    int val;
    int n = Convert.ToInt32(Console.ReadLine());
    public ArithProgression()
    {
        start = 0;
        val = 0;
    }
    public int getNext()
    {
        val += n;
        return val;
    }

    public void reset()
    {
        val = start;
    }
    public void setStart(int x)
    {
        start = x;
        val = start;
    }

}
class GeoProgression : ISeries
{
    int start;
    int val;
    int q = Convert.ToInt32(Console.ReadLine());
    public GeoProgression()
    {
        start = 0;
        val = 1;
    }
    public int getNext()
    {
        val *=q;
        return val;
    }

    public void reset()
    {
        val = start;
    }
    public void setStart(int x)
    {
        start = x;
        val = start;
    }

}