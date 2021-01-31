using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Book
    {
        Author author = new Author();
        Title title = new Title();
        Content content = new Content();

        public Book(string author, string title, string content)
        {
            this.author.author = author;
            this.title.title = title;
            this.content.content = content;
        }

        public void showAuthor()
        {
            author.Show();
        }
        public void showTitle()
        {
            title.Show();
        }
        public void showContent()
        {
            content.Show();
        }
    }

    class Title
    {
        public string title;

        public void Show()
        {
            System.Console.WriteLine($"Заголовок : {title}");
        }
    }

    class Author
    {

        public string author;

        public void Show()
        {
            System.Console.WriteLine($"Автор : {author}");
        }

    }

    class Content
    {
        public string content;

        public void Show()
        {
            System.Console.WriteLine($"Содержание : {content}");
        }
    }

   

}
