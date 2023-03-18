using System;
using System.Linq;
using System.Collections.Generic;
using Faro_Shuffle;
// See https://aka.ms/new-console-template for more information
/**
 * <summary>This console program implements the Faro Shuffle technique (shuffling cards)</summary>
 */

var startingDeck = from s in Suits()
                   from r in Ranks()
                   select new { Suit = s, Rank = r };

/**
 * <summary>The above code is equivalent to the below code</summary>
 * <code>
 * var startingDeck = Suits()
 *  .SelectMany(suit => Ranks()
 *  .Select(rank => new { Suit = suit, Rank = rank }));
 * </code>
 */




foreach (var card in startingDeck)
{
    Console.WriteLine(card);
}
static IEnumerable<string> Suits()
{
    yield return "clubs";
    yield return "diamonds";
    yield return "hearts";
    yield return "spades";
}

static IEnumerable<string> Ranks()
{
    yield return "two";
    yield return "three";
    yield return "four";
    yield return "five";
    yield return "six";
    yield return "seven";
    yield return "eight";
    yield return "nine";
    yield return "ten";
    yield return "jack";
    yield return "queen";
    yield return "king";
    yield return "ace";
}

/**
 * <summary>Split the deck into two halves, each having 26 cards</summary>
 */
var top = startingDeck.Take(26); // only include the first 26 of the starting Deck
var bottom = startingDeck.Skip(26); // .... last ....
var shuffle = top.InterLeaveSequenceWith(bottom);

/*
Console.WriteLine("top");
foreach (var card in top)
{
    Console.WriteLine(card);
}

Console.WriteLine("bottom");
foreach (var card in bottom)
{
    Console.WriteLine(card);
}


Console.WriteLine("shuffle");

foreach (var card in shuffle)
{
    Console.WriteLine(card);
}
*/

var times = 0;
shuffle = startingDeck;
do
{ 
    top = shuffle.Take(26);
    bottom = shuffle.Skip(26);
    shuffle = top.InterLeaveSequenceWith(bottom);
    foreach (var card in shuffle) 
    {
        Console.WriteLine(card);
    }
    Console.WriteLine();
    times ++;
} while (!startingDeck.SequenceEqual(shuffle));

Console.WriteLine(times);