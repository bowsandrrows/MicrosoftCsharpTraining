
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




#endregion