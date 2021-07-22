﻿using Microsoft.EntityFrameworkCore.Migrations;
using PK.DataAccess.Extensions;
using System;
using System.IO;

namespace PK.DataAccess.Migrations
{
    public partial class PopulateLanguages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertDataFromCsv("Languages", "Languages.csv");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteAllDataFromTable("Languages");
        }
    }
}
