// See https://aka.ms/new-console-template for more information
string[] cibiPreferiti = { "Pizza", "Pasta", "Nutella", "Sushi", "Gelato", "Bistecca", "Insalata", "Arancia" };

cibiPreferiti[6] = "Formaggio";

Console.WriteLine("-------------------------------------------------------");

Console.WriteLine("La classifica è composta da " +  cibiPreferiti.Length + " cibi, ovvero:");

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    var numeroClassifica = i + 1;
    Console.WriteLine(numeroClassifica + "° " +  cibiPreferiti[i]);
}

Console.WriteLine("-------------------------------------------------------");

Console.WriteLine("Il cibo preferito è " + cibiPreferiti[0]);
Console.WriteLine("Il cibo peggiore tra i preferiti è " + cibiPreferiti[cibiPreferiti.Length - 1]);

// BONUS

var centroClassifica = cibiPreferiti.Length / 2;

if (centroClassifica % 2 == 0)
{
    Console.WriteLine("I cibi a centro classifica sono " + cibiPreferiti[centroClassifica--] + " e " + cibiPreferiti[centroClassifica++]);
} else
{
    Console.WriteLine("Il cibo a centro classifica è " + cibiPreferiti[centroClassifica]);
}


