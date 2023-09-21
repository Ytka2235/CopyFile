internal class Timer
{
    public DateTime dt1;
    public DateTime dt2;
    public Timer() /// Конструктор создаёт таймер вызывать так: Timer timer = new Timer();
    {

    }
    public void Start() /// запускает таймер вызывать так: timer.Start();
    {
        dt1 = DateTime.Now;
    }
    public void Stop() /// останавливает таймер и выводит сколько времени прошло с начала запуска вызывать так: Timer.Stop();
    {
        dt2 = DateTime.Now;
        TimeSpan ts = dt2 - dt1;
        Console.WriteLine("Времени прошло " + ts.TotalMilliseconds + " миллисекунда"); /// время отоброжается в миллисекундах
    }
}