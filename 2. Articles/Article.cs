namespace _2._Articles
{
    public class Article
    {

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(Article article, string newOne)
        {
            article.Content = newOne;
        }

        public void ChangeAuthor(Article article, string newOne)
        {
            article.Author = newOne;
        }

        public void Rename(Article article, string newOne)
        {
            article.Title = newOne;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
