using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace SQLSolutions.Models
{
    public class Book
    {
        public virtual int AssetNum { get; set; }
        public virtual int Isbn { get; set; }
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }
        public virtual string CourseSection { get; set; }
        public virtual int Year { get; set; }
        public virtual string Edition { get; set; }
        public virtual bool IsRequired { get; set; }
    }

    public class BookMap : ClassMapping<Book>
    {
        public BookMap()
        {
            Table("books");

            Id(x => x.AssetNum, x => x.Generator(Generators.Assigned));

            Property(x => x.Isbn, x => x.NotNullable(true));
            Property(x => x.Title, x => x.NotNullable(true));
            Property(x => x.Author, x => x.NotNullable(true));
            Property(x => x.CourseSection, x => x.NotNullable(true));
            Property(x => x.Year, x => x.NotNullable(true));
            Property(x => x.Edition, x => x.NotNullable(true));
            Property(x => x.IsRequired, x => x.NotNullable(true));
        }
    }
}