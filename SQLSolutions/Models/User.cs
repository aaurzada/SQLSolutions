using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace SQLSolutions.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Euid { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; } 
    }

    public class UserMap : ClassMapping<User>
    {
        public UserMap() 
        {
            Table("users");

            Id(x => x.Id, x => x.Generator(Generators.Identity));

            Property(x => x.Euid, x => x.NotNullable(true));
            Property(x => x.FirstName, x => x.NotNullable(true));
            Property(x => x.LastName, x => x.NotNullable(true));
            Property(x => x.Email, x => x.NotNullable(true));
        }
    }
}