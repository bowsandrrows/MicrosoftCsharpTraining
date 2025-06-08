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
/*
string status = "Healthy";

Console.WriteLine( $"Start: {status}" );
SetHealthStatus( false );
Console.WriteLine( $"End: {status}" );

void SetHealthStatus( bool isHealthy )
{
    ArgumentException.ThrowIfNullOrWhiteSpace( status );
    status = ( isHealthy ? "Healthy" : "Unhealthy" );
    Console.WriteLine( $"Middle: {status}" );
}
*/
#endregion

#region named and optional parameters.
/*
string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte", "Leo", "Edward", "Eva" };
string[] rsvps = new string[ 10 ];
int count = 0;


RSVP( "Rebecca", 1, "none", true );
RSVP( "Nadia", 2, "Nuts", true );
RSVP( "Linh", 2, "none", false );
RSVP( "Tony", 1, "Jackfruit", true );
RSVP( "Noor", 4, "none", false );
RSVP( "Jonte", 2, "Stone fruit", false );
RSVP( "Edward", 4, "Peanuts", false );
RSVP( "Leo", 9, "none", true );
ShowRSVPs();


void RSVP( string name, int partySize, string allergies, bool inviteOnly )
{
    if ( inviteOnly )
    {
        bool found = false;
        foreach ( string? guest in guestList )
        {
            if ( guest.Equals( name ) )
            {
                found = true; break;
            }
        }
        if ( !found )
        {
            Console.WriteLine( $"Sorry, {name} is not on the guest list" );
            return;
        }
    }
    rsvps[ count ] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine( "\nTotal RSVPs:" );
    for ( int i = 0; i < count; i++ )
    {
        Console.WriteLine( rsvps[ i ] );
    }
}

*/
#endregion



string[,] corporate = {
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = {
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

char at = '@';


string CreateMail()
{
    string externalDomain = "hayworth.com";

    for ( int i = 0; i < corporate.GetLength( 0 ); i++ )
    {
        // display internal email addresses
    }

    for ( int i = 0; i < external.GetLength( 0 ); i++ )
    {
        // display external email addresses
    }
}

