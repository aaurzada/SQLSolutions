using System.Data;
using FluentMigrator;

namespace SQLSolutions.Migrations
{
    [Migration(2)]
    public class _002AddRolesTable : Migration
    {
        public override void Up()
        {
            //Migrate roles table to database
            Create.Table("roles")
                .WithColumn("id").AsInt32().Identity().PrimaryKey()
                .WithColumn("name").AsString();

            //Migrate roles_user table to database
            Create.Table("roles_users")
                .WithColumn("role_id").AsInt32().ForeignKey("roles", "id").OnDelete(Rule.Cascade)
                .WithColumn("user_id").AsInt32().ForeignKey("users", "id").OnDelete(Rule.Cascade);
        }

        public override void Down()
        {
            Delete.Table("roles_users");
            Delete.Table("roles");
        }
    }
}