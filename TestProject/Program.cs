﻿Console.WriteLine( "\tCreate a method with parameters\n" );


int[] schedule = { 800, 1200, 1600, 2000 };
DisplayAdjustedTimes( schedule, 6, -6 );

// This is a method signature
static void DisplayAdjustedTimes( int[] times, int currentGMT, int newGMT )
{
    int diff = 0;
    if ( Math.Abs( newGMT ) > 12 || Math.Abs( currentGMT ) > 12 )
    {
        Console.WriteLine( "Invalid GMT" );
    }
    else if ( newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0 )
    {
        diff = 100 * ( Math.Abs( newGMT ) - Math.Abs( currentGMT ) );
    }
    else
    {
        diff = 100 * ( Math.Abs( newGMT ) + Math.Abs( currentGMT ) );
    }

    for ( global::System.Int32 i = 0; i < times.Length; i++ )
    {
        int newTime = ( ( times[ i ] + diff ) ) % 2400;
        Console.WriteLine( $"{times[ i ]} -> {newTime}" );
    }
}