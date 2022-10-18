//Jeremy Lapham
//10-18-22
//Reverse It
//This program will ask the user for either a number or a word and it will reverse it



string reverseIt;
string reverseTwo = "";
bool isNum;
int goodNum = 0;
int remainder = 0;
int reverseNum = 0;
bool playAgain = false;

while(!playAgain)
{
    Console.WriteLine("We are going to play a game.");
    Console.WriteLine("This game is called Reverse It.");
    Console.WriteLine("");
        
Console.WriteLine("Enter a number thats more than two digits long. Or type any word.");
reverseIt = Console.ReadLine();
isNum = Int32.TryParse(reverseIt, out goodNum);

if(isNum)
{
    Console.WriteLine("Thats a good number!");
    Console.WriteLine("");

    while(goodNum > 0)
    {
        remainder = goodNum % 10;
        goodNum = goodNum/10;
        reverseNum = (reverseNum*10) + remainder;
    }
    Console.WriteLine(reverseIt + " || " + reverseNum);
}
else 
{
    Console.WriteLine("Thats a nice word!");
    Console.WriteLine("");
    for(int i = reverseIt.Length - 1; i >= 0; i--)
    {
         reverseTwo = reverseTwo + reverseIt[i]; 
    }
    Console.WriteLine(reverseIt + " || " + reverseTwo );

}
Console.WriteLine("");
    Console.WriteLine("Do you want to play again?");
    Console.WriteLine("Type anything to play again. Or type end to stop.");
    string playAgain1 = Console.ReadLine().ToLower();
    if(playAgain1 == "end")
    {
        playAgain = true;
    }
}
Console.WriteLine("Thank you for playing! Come again soooon!");