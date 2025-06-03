using System.Numerics;

Console.WriteLine( "\n\tCreate a method with parameters\n" );


#region
/*
string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

DisplayStudents( students );
DisplayStudents( new string[] { "Robert", "Vanya", "Leo" } );

void DisplayStudents( string[] students )
{
    foreach ( string student in students )
    {
        Console.Write( $"{student}, " );
    }
    Console.WriteLine();
}
*/
#endregion


#region Understand method scope
/*
double pi = 3.14159;
PrintCircleInfo( 12 );
PrintCircleInfo( 24 );

void PrintCircleInfo( int radius )
{
    Console.WriteLine($"Circle with a radius {radius}"); 
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

void PrintCircleArea( int radius )
{
    double area = pi * ( radius * radius );
    Console.WriteLine( $"Area = {area}" );
}


void PrintCircleCircumference( int radius )
{
    double circumference = 2 * pi * radius;
    Console.WriteLine( $"Circumference = {circumference}" );
}
*/
#endregion

#region Test pass by value
/*
int a = 3;
int b = 4;
int c = 0;

Multiply( a, b, c );
Console.WriteLine($"Global statement: {a} x {b} = {c}");

static void Multiply( int a, int b, int c )
{
    c = a * b;
    Console.WriteLine($"Inside Multiply method: {a} x {b} = {c}");
}
*/
#endregion

#region Test pass by reference
/*
int[] array = { 1, 2, 3, 4, 5 };

PrintArray( array );
Clear( array );
PrintArray( array );

void PrintArray( int[] array )
{
    foreach ( int a in array )
    {
        Console.Write( $"{a}, " );
    }
    Console.WriteLine();
}

void Clear( int[] array )
{
    for ( int i = 0; i < array.Length; i++ )
    {
        array[ i ] = 0;
    }
}
*/
#endregion

#region Test with strings

string status = "Healthy";

Console.WriteLine( $"Start: {status}" );
SetHealthStatus( false );
Console.WriteLine( $"End: {status}" );

void SetHealthStatus(bool isHealthy )
{
    status = ( isHealthy ? "Healthy" : "Unhealthy" );
    Console.WriteLine( $"Middle: {status}" );
}

#endregion