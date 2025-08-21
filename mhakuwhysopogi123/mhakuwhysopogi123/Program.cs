// See https://aka.ms/new-console-template for more information
String AI = "Mhak";
int choice;
Random random = new Random();
int CorrectNum = random.Next(1,101);
int userNum;




Console.WriteLine("Hello this is " + AI);
Console.WriteLine("What do you want me to do? ");
Console.WriteLine("1. Play a game");
choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    Console.WriteLine("THE GUESSING GAME");

    do
    {
        Console.WriteLine("Enter your guess: ");
        userNum = Convert.ToInt32(Console.ReadLine());


        if (userNum > CorrectNum)
        {
            Console.WriteLine("Too High! Try Again");

        } else if (userNum < CorrectNum){
            Console.WriteLine("Too Low! Try Again");

        } else

        {
            Console.WriteLine("Congrats you guess it");
        }

    } while (userNum != CorrectNum);
    
}
