Console.WriteLine( "\tTHE CODE BELOW IS ACTIVE\n" );


/*
Console.WriteLine( "Contents of Array:" );
int[] ints = [ 1, 2, 3 ];

void ShowResult()
{
    foreach ( var item in ints )
    {
        Console.Write( $"Item - {item}," );
    }
    Console.WriteLine();
}
ShowResult();

Console.WriteLine( "What's your grade? " );

var massege = 0;
var myGrade = int.TryParse( Console.ReadLine()!, out massege );
if ( !myGrade )
{
    Console.WriteLine( "\nInvalid input" );
}
else
{
    var result = massege switch
    {
        1 => "WOW You're a genius!",
        2 or 3 => "Ok, this is also good.",
        4 => "Well, you've barely made it.",
        _ => "That is not good at all!"
    };
    Console.WriteLine( result );
}

*/

Console.WriteLine( "\nGuese 5 numbers from 1 to 100.\n5 numbers = $10000, 4 numbers = $2000, 3 numbers = $100. " );
Console.WriteLine( "To quit at any time type Q/q" );
int pickedNumbers = 1;
int currentNumber = 1;
while ( pickedNumbers < 6 )
{
    Console.Write( $"Enter {pickedNumbers} number:  " );
    string? prompt = Console.ReadLine();
    if ( prompt.ToLower() == "q" )
    {
        break;
    }
    else
    {
        var userNumberChoise = int.TryParse( prompt, out currentNumber );

        if ( !userNumberChoise )
        {
            Console.WriteLine( "Enter number in digits" );
        }
        else if ( userNumberChoise == default || currentNumber == default )
        {
            Console.WriteLine( "number can not be 0" );
        }
        else
        {
            pickedNumbers++;
        }
    }


}

/*

if ( userNumberChoise == "" )
{
    Console.WriteLine( "\nInvalid input" );
}
else
{
    Console.WriteLine( "\nWinning numbers are:" );
    DisplayRandomNumbers();
}


void DisplayRandomNumbers()
{
    Random random = new();  // Random random = new Random();

    for ( int i = 0; i < 5; i++ )
    {
        Console.Write( $"{random.Next( 1, 101 )} " );
    }
    Console.WriteLine();
}
*/