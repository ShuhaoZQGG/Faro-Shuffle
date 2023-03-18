﻿using System;
using System.Linq;
using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information
var startingDeck = from s in Suits()
                   from r in Ranks()
                   select new { Suit = s, Rank = r };
foreach(var card in startingDeck)
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
