// See https://aka.ms/new-console-template for more information
using Polymorphism.Models;
using RuntimePolymorphism.Models;

Console.WriteLine("Hello, World!");
Document MyDocument = new Document(1, "TheNomadCapitalist", "Abstract of Nomad Capitalist");
Paper MyPaper = new Paper(1, "TheNomadCapitalist", "Abstract of Nomad Capitalist","Andrew Henderson");
Article MyArticle = new Article(1, "TheNomadCapitalist", "Abstract of Nomad Capitalist", DateTime.Now);
Thesis MyThesis = new Thesis(1, "TheNomadCapitalist", "Abstract of Nomad Capitalist", "Text of Thesis");


Docs docs = new Docs();
docs.PaperList.Add(MyPaper);
docs.Articles.Add(MyArticle);
docs.Thesis.Add(MyThesis);
docs.List.Add(MyDocument);
Document myUpdatedDocument = docs.PaperList.First();



Console.WriteLine(myUpdatedDocument.ToString());


