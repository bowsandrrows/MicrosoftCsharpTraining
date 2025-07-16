using System;

Console.WriteLine( "\tReturn numbers from methods\n" );


#region Create a method that returns an integer
/*
double usd = 23.73;
int vnd = UsdToVnd( usd );

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine( $"${vnd} VND = ${VndToUsd( vnd )} USD" );

int UsdToVnd( double usd )
{
    int rate = 23500;
    return (int) ( usd * rate );
}

double VndToUsd(int vnd )
{
    double rate = 23500;
    return vnd / rate;
}
*/
#endregion

#region Return strings from methods
/*
string input = "there are snakes at the zoo";

Console.WriteLine( input );
Console.WriteLine( ReverseSentence( input ) );

string ReverseWord( string word )
{
    string result = "";
    for ( int i = word.Length - 1; i >= 0; i-- )
    {
        result += word[ i ];
    }
    return result;
}

string ReverseSentence( string input )
{
    string result = "";
    string[] words = input.Split( " " );
    foreach ( string word in words )
    {
        result += ReverseWord( word ) + " ";
    }
    return result.Trim();
}
*/
#endregion

#region Return Booleans from methods
/*
string[] words = [ "racecar", "talented", "deified", "tent", "tenet" ];

Console.WriteLine( "Is it a palindrome?" );
foreach ( string word in words )
{
    Console.WriteLine( $"{word}: {IsPalindrome( word )}" );
}

static bool IsPalindrome( string word )
{
    int start = 0;
    int end = word.Length - 1;

    while ( start < end )
    {
        if ( word[ start ] != word[end] )
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}
*/
#endregion

#region AI lambda practice
/*
List<int> numbers = [1, 5, 10, 15, 20];

// TODO: Use a lambda with Where() to get all numbers > 10
var result = numbers.Where( n => n > 10);

foreach ( var n in result )
{
    Console.WriteLine( n );
}

Console.WriteLine();

List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

// TODO: Use Select() to turn each name into uppercase
var upperNames = names.Select( name => name.ToUpper());

foreach ( var name in upperNames )
{
    Console.WriteLine( name );
}

Console.WriteLine();

var people = new List<Person>
{
    new("Lily", 12),
    new("Noah", 15),
    new("Ella", 19),
    new("Max", 21)
};

// TODO: Use Count() to find how many are teenagers (13–19)
int teens = people.Count( p => p.Age >= 13 && p.Age <= 19);
Console.WriteLine( $"Teenagers: {teens}" );

class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person( string name, int age )
    {
        Name = name;
        Age = age;
    }
}
*/
#endregion

#region  returning arrays from methods

//int[] TwoCoins( int[] coins, int target )
//{
//    for ( global::System.Int32 curr = 0; curr < coins.Length; curr++ )
//    {

//    }
//    return new int[ 0 ];
//}
#endregion

#region add methods to make the game playable

Random rnd = new();

Console.WriteLine( "Would you like to play? (Y/N)" );
string? answer = Console.ReadLine();
if ( !string.IsNullOrWhiteSpace( answer ) && answer == "y" || answer == "Y" )
{
    var cleaned_answer = answer.Trim();

    ShouldPlay( cleaned_answer );
}
else
{
    return;
}

if ( ShouldPlay( answer ) )
{
    PlayGame();
}
else
{
    return;
}

void PlayGame()
{
    var play = true;

    while ( play )
    {
        var target = rnd.Next( 1, 6 );
        var roll = rnd.Next( 1, 6 );

        Console.WriteLine( $"Roll a number greater than {target} to win!" );
        Console.WriteLine( $"You rolled a {roll}" );

        Console.WriteLine( WinOrLose( target, roll ) );
        Console.WriteLine( "\nPlay again? (Y/N)" );
        string? playAgainAnswer = Console.ReadLine();
        if ( !string.IsNullOrWhiteSpace(playAgainAnswer) && playAgainAnswer == "y" || playAgainAnswer == "Y")
        {
            var answer = playAgainAnswer.Trim();
            play = ShouldPlay( answer );
        }
        else
        {
            break;
        }
    }
}

string WinOrLose( int target, int roll )
{
    if ( roll < target || roll == target )
    {
        return $"You lose {roll} is not greater than {target}";
    }
    else
    {
        return $"You won {roll} is greater than {target}";
    }
}

bool ShouldPlay( string answer )
{
    return true;
}


#endregion