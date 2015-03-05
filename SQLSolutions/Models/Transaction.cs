using System;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace SQLSolutions.Models
{
    public class Transaction
    {
        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int BookAssetNum { get; set; }
        public virtual DateTime CheckoutDate { get; set; }
        public virtual DateTime DueDate { get; set; }
    }

    public class TransactionMap : ClassMapping<Transaction>
    {
        public TransactionMap()
        {
            Table("transactions");

            Id(x => x.Id, x => x.Generator(Generators.Identity));

            Property(x => x.UserId, x =>
            {
                x.Column("users_id");
                x.NotNullable(true);
            });
            Property(x => x.BookAssetNum, x =>
            {
                x.Column("books_assetNum");
                x.NotNullable(true);
            });
            Property(x => x.CheckoutDate, x => x.NotNullable(true));
            Property(x => x.DueDate, x => x.NotNullable(true));
        }
    }
}