﻿namespace _2011063274_NguyenQuangTam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategorytable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES(ID, NAME) VALUES (1, 'Develoment')");
            Sql("INSERT INTO CATEGORIES(ID, NAME) VALUES (2, 'Business')");
            Sql("INSERT INTO CATEGORIES(ID, NAME) VALUES (3, 'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
