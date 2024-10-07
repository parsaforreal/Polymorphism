// See https://aka.ms/new-console-template for more information
using PolymorphicRelations.Models;
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
var Document1 = new GenericDocument() 
{  
    Id = (int)1,
    DocumentName = "Document#1",
    DocumentType = new Seminar()
    {
        Subject = "The subject of Document 1!"
    }
};
var Document2 = new GenericDocument()
{
    Id = (int)2,
    DocumentName = "Document#2",
    DocumentType = new Thesis()
    {
        Text = "The subject of Document 2!"
    }
};
Console.WriteLine(Document1.Get());
Console.WriteLine(Document2.Get());
Console.ReadLine();