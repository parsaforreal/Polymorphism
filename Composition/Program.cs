// See https://aka.ms/new-console-template for more information

using Polymorphism.Models;

Document MyDocument = new Document(1,
    "TheNomadCapitalist",
    "Abstract of Nomad Capitalist",
    new Paper("Andrew Henderson"));

var MyUpdatedDocument = (Paper)MyDocument.Details!;



Console.WriteLine(MyUpdatedDocument.Author);