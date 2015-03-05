using System.Data;
using FluentMigrator;

namespace SQLSolutions.Migrations
{
    [Migration(1)]
    public class _001InitialTableMigration : Migration
    {
        public override void Up()
        {
            //Migrate users table to database
            Create.Table("users")
                .WithColumn("id").AsInt32().Identity().PrimaryKey()
                .WithColumn("euid").AsString()
                .WithColumn("firstname").AsString()
                .WithColumn("lastname").AsString()
                .WithColumn("email").AsCustom("VARCHAR(256)");

            //Migrate books table to database
            Create.Table("books")
                .WithColumn("assetNum").AsInt32().Identity().PrimaryKey()
                .WithColumn("isbn").AsCustom("INT(13)")
                .WithColumn("title").AsString()
                .WithColumn("author").AsString()
                .WithColumn("courseSection").AsString()
                .WithColumn("year").AsCustom("INT(4)")
                .WithColumn("edition").AsString()
                .WithColumn("isRequired").AsBoolean();

            //Migrate transactions table to database
            Create.Table("transactions")
                .WithColumn("id").AsInt32().Identity().PrimaryKey()
                .WithColumn("users_id").AsInt32().ForeignKey("users", "id").OnDelete(Rule.Cascade)
                .WithColumn("books_assetNum").AsInt32().ForeignKey("books", "assetNum").OnDelete(Rule.Cascade)
                .WithColumn("checkoutDate").AsDate()
                .WithColumn("dueDate").AsDate();

        }

        public override void Down()
        {
            Delete.Table("transactions");
            Delete.Table("books");
            Delete.Table("users");
        }
    }
}