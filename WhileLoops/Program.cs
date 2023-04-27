

Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4); //neli viimane väärtus, ei kuva
    //Console.WriteLine(cpuRandom);
    Console.WriteLine("Make a guess. Number 1-3");

    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("WINWIN");
        loopActive= false;
        //break;
    }
    else
    {
        Console.WriteLine("LOSER");
    }

}

Console.WriteLine("Have a nice day");
