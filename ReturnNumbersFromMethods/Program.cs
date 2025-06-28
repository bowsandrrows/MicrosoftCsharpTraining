
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


string word = "Hello";
string getWord = ReversWord(  word );
Console.WriteLine(word);
Console.WriteLine(getWord);

    ///  reverse a string by iterating from the end of the string. 
    string ReversWord( string word )
{
    string result = "";

    for ( global::System.Int32 i = word.Length - 1; i >= 0; i -= 1 )
    {
        result += word[ i ];
    }
    return result;
}



#endregion