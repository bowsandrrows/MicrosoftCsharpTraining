Console.WriteLine( "\tCreate a method with parameters\n" );


#region

string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

DisplayStudents( students );
DisplayStudents( new string[] { "Robert", "Vanya" } );

void DisplayStudents( string[] students )
{
    foreach ( string student in students )
    {
        Console.Write( $"{student}, " );
    }
    Console.WriteLine();
}

#endregion