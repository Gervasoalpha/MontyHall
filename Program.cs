
using MontyHallLibrary;
//while (true)
//{
//    MontyHallGame montyHallGame = new MontyHallGame();


//    printdoors(montyHallGame.porte);

//    Console.WriteLine("Chose a door: 1,2 or 3");
//    int userdoor = int.Parse(Console.ReadLine()) - 1;
//    int portaaperta = montyHallGame.opendoor(userdoor);
//    printdoors(montyHallGame.porte);
//    Console.WriteLine("Do you want to change door?");
//    int choice = int.Parse(Console.ReadLine());
//    var res = montyHallGame.verificavincita(choice);
//    Console.WriteLine($"{res}");
//    Thread.Sleep(5000);
//}
Console.WriteLine("VERIFICA DEL PARADOSSO DI MONTY HALL:");
MontyHallGame.testautomatico(1000000,"cambiando");
MontyHallGame.testautomatico(1000000, "restando");
void printdoors<T>(List<T> lista)
{
    lista.ForEach(p => Console.WriteLine(p));
}