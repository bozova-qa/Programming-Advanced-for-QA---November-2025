string[] articleInfo = Console.ReadLine().Split(", ").ToArray();
int n = int.Parse(Console.ReadLine());

string title = articleInfo[0];
string content = articleInfo[1];
string author = articleInfo[2];

Article article = new Article(title, content, author);

for (int i = 0; i < n; i++)
{
    string[] commandInfo = Console.ReadLine().Split(": ").ToArray();
    string command = commandInfo[0];
    string newInfo = commandInfo[1];

    if (command == "Edit")
    {
        article.Edit(newInfo);
    }
    else if(command == "ChangeAuthor")
    {
        article.ChangeAuthor(newInfo);
    }
    else if (command == "Rename")
    {
        article.Rename(newInfo);
    }

}

Console.WriteLine(article.ToString());

class Article
{
    public string Title { get; set; }
    public string Content { get; private set; }

    public string Author { get; set; }

public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor (string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename (string newTitle)
    {
        Title = newTitle;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";//слагаме properties тук
    }
}