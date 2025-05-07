Console.WriteLine( "\tTHE CODE BELOW IS ACTIVE\n" );



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


Console.WriteLine( "\nGenerating random numbers:" );
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new();  // Random random = new Random();

    for ( int i = 0; i < 5; i++ )
    {
        Console.Write( $"{random.Next( 1, 100 )} " );
    }
    Console.WriteLine();
}