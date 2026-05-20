namespace Esercizio1
{
    internal class Videogame
    {
        private string _title;
        private string _authorName;
        private string _authorSurname;
        private DateTime _pubblicationDate;

        public string Title { get => _title; set => _title = value; }
        public string AuthorName { get => _authorName; set => _authorName = value; }
        public string AuthorSurname { get => _authorSurname; set => _authorSurname = value; }

        public DateTime PubblicationDate
        {
            get => _pubblicationDate;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("La data di pubblicazione non può essere futura.");
                } else if(value.Year < 1952)
                {
                    throw new ArgumentException("La data di pubblicazione non può essere precedente al 1952, anno di uscita del primo videogioco (OXO).");
                }

                _pubblicationDate = value;
            }
        }

        // Ho costruito dei costruttori giocattolo per esercizio.
        public Videogame(string title, string authorName, string authorSurname, DateTime pubblicationDate)
        {
            Title = title;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            PubblicationDate = pubblicationDate;
        }

        public Videogame(string title, string authorName, string authorSurname)
        {
            Title = title;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
        }

        public Videogame(string title)
        {
            Title = title;
        }

        public Videogame()
        {
        }

        public override bool  Equals(object obj)
        {
            if (obj is Videogame)
            {
                Videogame other = (Videogame)obj;
                return this.Title == other.Title && this.AuthorName == other.AuthorName && this.AuthorSurname == other.AuthorSurname && this.PubblicationDate == other.PubblicationDate;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, AuthorName, AuthorSurname, PubblicationDate);
        }

    }
}
