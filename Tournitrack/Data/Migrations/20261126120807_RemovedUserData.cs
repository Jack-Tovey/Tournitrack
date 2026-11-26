using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tournitrack.Migrations;

/// <inheritdoc />
public partial class _20261126120807_RemovedUserData : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "FirstName",
            table: "AspNetUsers",
            type: "TEXT",
            nullable: true);

        migrationBuilder.AddColumn<string>(
            name: "LastName",
            table: "AspNetUsers",
            type: "TEXT",
            nullable: true);

        migrationBuilder.AddColumn<int>(
            name: "TeamID",
            table: "AspNetUsers",
            type: "INTEGER",
            nullable: true);

        migrationBuilder.CreateTable(
            name: "Clubs",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<string>(type: "TEXT", nullable: false),
                Logo = table.Column<byte[]>(type: "BLOB", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Clubs", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "Matches",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                TournamentID = table.Column<int>(type: "INTEGER", nullable: false),
                ScheduledMatchDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                ActualMatchDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                TeamIDHome = table.Column<int>(type: "INTEGER", nullable: false),
                HomeTeamSheetID = table.Column<int>(type: "INTEGER", nullable: true),
                TeamIDAway = table.Column<int>(type: "INTEGER", nullable: false),
                AwayTeamSheetID = table.Column<int>(type: "INTEGER", nullable: true),
                PitchNumber = table.Column<int>(type: "INTEGER", nullable: false),
                PoolID = table.Column<int>(type: "INTEGER", nullable: true),
                Description = table.Column<string>(type: "TEXT", nullable: true),
                GameLength = table.Column<double>(type: "REAL", nullable: false),
                MatchComplete = table.Column<bool>(type: "INTEGER", nullable: false),
                ResultNeeded = table.Column<bool>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Matches", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "MatchOfficials",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                MatchID = table.Column<int>(type: "INTEGER", nullable: false),
                UserID = table.Column<string>(type: "TEXT", nullable: false),
                RoleID = table.Column<int>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_MatchOfficials", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "MatchTeamSheet",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                MatchID = table.Column<int>(type: "INTEGER", nullable: false),
                TeamID = table.Column<int>(type: "INTEGER", nullable: false),
                CoachName = table.Column<string>(type: "TEXT", nullable: true),
                ManagerName = table.Column<string>(type: "TEXT", nullable: true),
                MedicalName = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_MatchTeamSheet", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "OfficialAvailability",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                UserID = table.Column<string>(type: "TEXT", nullable: false),
                Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                Morning = table.Column<bool>(type: "INTEGER", nullable: false),
                Afternoon = table.Column<bool>(type: "INTEGER", nullable: false),
                Evening = table.Column<bool>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_OfficialAvailability", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "OfficialRoles",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                RoleName = table.Column<string>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_OfficialRoles", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "PlayerCards",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                PlayerID = table.Column<int>(type: "INTEGER", nullable: false),
                MatchID = table.Column<int>(type: "INTEGER", nullable: false),
                MatchMinute = table.Column<int>(type: "INTEGER", nullable: false),
                CardType = table.Column<string>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PlayerCards", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "PlayerGoals",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                PlayerID = table.Column<int>(type: "INTEGER", nullable: false),
                MatchID = table.Column<int>(type: "INTEGER", nullable: false),
                GoalType = table.Column<string>(type: "TEXT", nullable: false),
                MatchMinute = table.Column<int>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PlayerGoals", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "Players",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                AccountID = table.Column<string>(type: "TEXT", nullable: true),
                FirstName = table.Column<string>(type: "TEXT", nullable: false),
                LastName = table.Column<string>(type: "TEXT", nullable: false),
                dob = table.Column<DateOnly>(type: "TEXT", nullable: false),
                shirtNumber = table.Column<int>(type: "INTEGER", nullable: false),
                ClubID = table.Column<int>(type: "INTEGER", nullable: false),
                Notes = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Players", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "Pools",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                TournamentID = table.Column<int>(type: "INTEGER", nullable: false),
                PoolNumber = table.Column<int>(type: "INTEGER", nullable: false),
                PhaseNumber = table.Column<int>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Pools", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "PoolTeams",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                PoolID = table.Column<int>(type: "INTEGER", nullable: false),
                TeamID = table.Column<int>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PoolTeams", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "Teams",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                TeamName = table.Column<string>(type: "TEXT", nullable: false),
                ClubID = table.Column<int>(type: "INTEGER", nullable: false),
                HomeTopColour = table.Column<string>(type: "TEXT", nullable: false),
                HomeShortColour = table.Column<string>(type: "TEXT", nullable: false),
                HomeSockColour = table.Column<string>(type: "TEXT", nullable: false),
                AwayTopColour = table.Column<string>(type: "TEXT", nullable: false),
                AwayShortColour = table.Column<string>(type: "TEXT", nullable: false),
                AwaySockColour = table.Column<string>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Teams", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "TeamSheetPlayers",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                TeamSheetID = table.Column<int>(type: "INTEGER", nullable: false),
                PlayerID = table.Column<int>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_TeamSheetPlayers", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "TournamentOfficials",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                TournamentID = table.Column<int>(type: "INTEGER", nullable: false),
                UserID = table.Column<string>(type: "TEXT", nullable: false),
                RoleID = table.Column<int>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_TournamentOfficials", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "Tournaments",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                TournamentName = table.Column<string>(type: "TEXT", nullable: false),
                TournamentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                Location = table.Column<string>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Tournaments", x => x.ID);
            });

        migrationBuilder.CreateTable(
            name: "TournamentTeams",
            columns: table => new
            {
                ID = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                TournamentID = table.Column<int>(type: "INTEGER", nullable: false),
                TeamID = table.Column<int>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_TournamentTeams", x => x.ID);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Clubs");

        migrationBuilder.DropTable(
            name: "Matches");

        migrationBuilder.DropTable(
            name: "MatchOfficials");

        migrationBuilder.DropTable(
            name: "MatchTeamSheet");

        migrationBuilder.DropTable(
            name: "OfficialAvailability");

        migrationBuilder.DropTable(
            name: "OfficialRoles");

        migrationBuilder.DropTable(
            name: "PlayerCards");

        migrationBuilder.DropTable(
            name: "PlayerGoals");

        migrationBuilder.DropTable(
            name: "Players");

        migrationBuilder.DropTable(
            name: "Pools");

        migrationBuilder.DropTable(
            name: "PoolTeams");

        migrationBuilder.DropTable(
            name: "Teams");

        migrationBuilder.DropTable(
            name: "TeamSheetPlayers");

        migrationBuilder.DropTable(
            name: "TournamentOfficials");

        migrationBuilder.DropTable(
            name: "Tournaments");

        migrationBuilder.DropTable(
            name: "TournamentTeams");

        migrationBuilder.DropColumn(
            name: "FirstName",
            table: "AspNetUsers");

        migrationBuilder.DropColumn(
            name: "LastName",
            table: "AspNetUsers");

        migrationBuilder.DropColumn(
            name: "TeamID",
            table: "AspNetUsers");
    }
}
