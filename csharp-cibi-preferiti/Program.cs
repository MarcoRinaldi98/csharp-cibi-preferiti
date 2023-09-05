Console.WriteLine("BENVENUTI NELLA CLASSIFICA DEI MIEI CIBI PREFERITI!");

// Creo l'array di stringhe che formerà la mia classifica
string[] cibiPreferiti = { "Pizza", "Pasta", "Nutella", "Sushi", "Gelato", "Bistecca", "Insalata" };

cibiPreferiti[6] = "Formaggio"; // soistituisco il 7° elemento della mia array

Console.WriteLine(Environment.NewLine); // linea vuota

// Dichiaro il numero di elementi da cui è composta la mia classifica
Console.WriteLine($"La classifica è composta da  { cibiPreferiti.Length} cibi, ovvero:");
// Elenco gli elementi da cui è composta la mia classifica con un ciclo for
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    var numeroClassifica = i + 1;
    Console.WriteLine($"{numeroClassifica}°  {cibiPreferiti[i]}");
}

Console.WriteLine(Environment.NewLine); // linea vuota

// Riporto il mio cibo preferito a schermo
Console.WriteLine($"- Il cibo preferito è {cibiPreferiti[0]};");
// Riporto il mio cibo meno preferito della classifica a schermo
Console.WriteLine($"- Il cibo peggiore tra i preferiti è {cibiPreferiti[cibiPreferiti.Length - 1]};");


// BONUS
var centroClassifica = cibiPreferiti.Length / 2; //trovo l'elemento centrale della mia classifica

if (centroClassifica % 2 == 0) // SE l'elemento centrale della mia classifica è pari 
{
    Console.WriteLine($"- I cibi a centro classifica sono {cibiPreferiti[centroClassifica - 1]} e {cibiPreferiti[centroClassifica]};"); // riporto a schermo i due elementi centrali della mia classifica
} else
{
    Console.WriteLine($"- Il cibo a centro classifica è {cibiPreferiti[centroClassifica]};"); // riporto l'unico elemento al centro della mia classifica
}



