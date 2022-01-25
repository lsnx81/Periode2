// See https://aka.ms/new-console-template for more information
using RapportModule;

Console.WriteLine("RESULTATEN");
Resultaat mijnpunten = new Resultaat();
var lijstResultaten = new List<int>() {40, 50, 5, 90, 100,0};
foreach(int behaaldeScore in lijstResultaten) 
{
    mijnpunten.Percentage = behaaldeScore;
    mijnpunten.PrintGraad();
}