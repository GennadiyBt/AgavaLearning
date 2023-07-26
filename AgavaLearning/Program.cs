namespace AgavaLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int programCount;
            int money;
            int time;
            bool truth;

            name = "Gennadiy";
            age = 45;
            programCount = 3;
            money = 1000;
            time = 1000000;
            truth = true;

            Console.WriteLine("Здравствуйте, меня зовут " + name + ".");
            Console.WriteLine("Мне " + age + " лет.");
            Console.WriteLine("Я хочу научиться делать игры, это моя " + programCount + " программа на языке C#.");
            Console.WriteLine("Когда я закончу обучение я хочу зарабатывать " + money + " денег в " + time + " наносекунд.");
            Console.WriteLine("Достигну ли я желаемого? " + truth + "!");
        }
    }
}