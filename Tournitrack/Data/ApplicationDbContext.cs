using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tournitrack.Data.Models;

namespace Tournitrack.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Teams> Teams { get; set; }
    public DbSet<Players> Players { get; set; }
    public DbSet<Matches> Matches { get; set; }
    public DbSet<Tournaments> Tournaments { get; set; }
    public DbSet<TournamentTeams> TournamentTeams { get; set; }
    public DbSet<Clubs> Clubs { get; set; }
    public DbSet<Pools> Pools { get; set; }
    public DbSet<PoolsTeams> PoolTeams { get; set; }
    public DbSet<MatchTeamSheet> MatchTeamSheet { get; set; }
    public DbSet<TeamSheetPlayers> TeamSheetPlayers { get; set; }
    public DbSet<OfficialRoles> OfficialRoles { get; set; }
    public DbSet<MatchOfficials> MatchOfficials { get; set; }
    public DbSet<TournamentOfficials> TournamentOfficials { get; set; }
    public DbSet<OfficialAvailability> OfficialAvailability { get; set; }
    public DbSet<PlayerCards> PlayerCards { get; set; }
    public DbSet<PlayerGoals> PlayerGoals { get; set; }
}