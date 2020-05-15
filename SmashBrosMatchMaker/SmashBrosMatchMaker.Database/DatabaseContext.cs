using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class DatabaseContext : DbContext
    {
        private static Database.DatabaseContext instance;
        private static object sync = new object();

        private DatabaseContext()
        {
        }

        public static Database.DatabaseContext Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            return (instance = new Database.DatabaseContext());
                        }
                    }
                }

                return instance;
            }
        }

        public virtual DbSet<CharacterTable> CharacterTable { get; set; }
        public virtual DbSet<CharactersInMatch> CharactersInMatch { get; set; }
        public virtual DbSet<GameType> GameType { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<ItemsInGames> ItemsInGames { get; set; }
        public virtual DbSet<MatchTable> MatchTable { get; set; }
        public virtual DbSet<Moves> Moves { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<PlayerType> PlayerType { get; set; }
        public virtual DbSet<PlayersWithCharacter> PlayersWithCharacter { get; set; }
        public virtual DbSet<Records> Records { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<StageType> StageType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=35.232.211.249;port=3306;database=team_08;user=team_08;password=kBHt77FFV3ZS", x => x.ServerVersion("5.7.30-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterTable>(entity =>
            {
                entity.ToTable("character_table");

                entity.HasIndex(e => e.CharacterName)
                    .HasName("character_name")
                    .IsUnique();

                entity.HasIndex(e => e.PlayerId)
                    .HasName("player_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasColumnName("character_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.GameOrigin)
                    .IsRequired()
                    .HasColumnName("game_origin")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("player_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.CharacterTable)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("character_table_ibfk_1");
            });

            modelBuilder.Entity<CharactersInMatch>(entity =>
            {
                entity.ToTable("characters_in_match");

                entity.HasIndex(e => e.CharacterTableId)
                    .HasName("character_table_id");

                entity.HasIndex(e => e.MatchTableId)
                    .HasName("match_table_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CharacterTableId)
                    .HasColumnName("character_table_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MatchTableId)
                    .HasColumnName("match_table_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CharacterTable)
                    .WithMany(p => p.CharactersInMatch)
                    .HasForeignKey(d => d.CharacterTableId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("characters_in_match_ibfk_2");

                entity.HasOne(d => d.MatchTable)
                    .WithMany(p => p.CharactersInMatch)
                    .HasForeignKey(d => d.MatchTableId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("characters_in_match_ibfk_1");
            });

            modelBuilder.Entity<GameType>(entity =>
            {
                entity.ToTable("game_type");

                entity.HasIndex(e => e.GameTypeName)
                    .HasName("game_type_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GameTypeName)
                    .IsRequired()
                    .HasColumnName("game_type_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.ToTable("items");

                entity.HasIndex(e => e.ItemName)
                    .HasName("item_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("item_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ItemPercent)
                    .HasColumnName("item_percent")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ItemsInGames>(entity =>
            {
                entity.ToTable("items_in_games");

                entity.HasIndex(e => e.ItemsId)
                    .HasName("items_id");

                entity.HasIndex(e => e.MatchTableId)
                    .HasName("match_table_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemsId)
                    .HasColumnName("items_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MatchTableId)
                    .HasColumnName("match_table_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Items)
                    .WithMany(p => p.ItemsInGames)
                    .HasForeignKey(d => d.ItemsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("items_in_games_ibfk_1");

                entity.HasOne(d => d.MatchTable)
                    .WithMany(p => p.ItemsInGames)
                    .HasForeignKey(d => d.MatchTableId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("items_in_games_ibfk_2");
            });

            modelBuilder.Entity<MatchTable>(entity =>
            {
                entity.ToTable("match_table");

                entity.HasIndex(e => e.CharacterTableId)
                    .HasName("character_table_id");

                entity.HasIndex(e => e.GameTypeId)
                    .HasName("game_type_id");

                entity.HasIndex(e => e.ItemsId)
                    .HasName("items_id");

                entity.HasIndex(e => e.StageId)
                    .HasName("stage_id");

                entity.HasIndex(e => e.WinnerName)
                    .HasName("winner_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CharacterTableId)
                    .HasColumnName("character_table_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GameTypeId)
                    .HasColumnName("game_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemsId)
                    .HasColumnName("items_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StageId)
                    .HasColumnName("stage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WinnerName)
                    .IsRequired()
                    .HasColumnName("winner_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.CharacterTable)
                    .WithMany(p => p.MatchTable)
                    .HasForeignKey(d => d.CharacterTableId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("match_table_ibfk_1");

                entity.HasOne(d => d.GameType)
                    .WithMany(p => p.MatchTable)
                    .HasForeignKey(d => d.GameTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("match_table_ibfk_2");

                entity.HasOne(d => d.Items)
                    .WithMany(p => p.MatchTable)
                    .HasForeignKey(d => d.ItemsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("match_table_ibfk_4");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.MatchTable)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("match_table_ibfk_3");
            });

            modelBuilder.Entity<Moves>(entity =>
            {
                entity.ToTable("moves");

                entity.HasIndex(e => e.CharacterTableId)
                    .HasName("character_table_id");

                entity.HasIndex(e => e.MoveName)
                    .HasName("move_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CharacterTableId)
                    .HasColumnName("character_table_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MoveName)
                    .IsRequired()
                    .HasColumnName("move_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.CharacterTable)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.CharacterTableId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("moves_ibfk_1");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("player");

                entity.HasIndex(e => e.PlayerName)
                    .HasName("player_name")
                    .IsUnique();

                entity.HasIndex(e => e.PlayerTypeId)
                    .HasName("player_type_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlayerName)
                    .IsRequired()
                    .HasColumnName("player_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PlayerTypeId)
                    .HasColumnName("player_type_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.PlayerType)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.PlayerTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("player_ibfk_1");
            });

            modelBuilder.Entity<PlayerType>(entity =>
            {
                entity.ToTable("player_type");

                entity.HasIndex(e => e.PlayerTypeName)
                    .HasName("player_type_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlayerTypeName)
                    .IsRequired()
                    .HasColumnName("player_type_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<PlayersWithCharacter>(entity =>
            {
                entity.ToTable("players_with_character");

                entity.HasIndex(e => e.CharacterTableId)
                    .HasName("character_table_id");

                entity.HasIndex(e => e.RecordId)
                    .HasName("record_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CharacterTableId)
                    .HasColumnName("character_table_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecordId)
                    .HasColumnName("record_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CharacterTable)
                    .WithMany(p => p.PlayersWithCharacter)
                    .HasForeignKey(d => d.CharacterTableId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("players_with_character_ibfk_1");

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.PlayersWithCharacter)
                    .HasForeignKey(d => d.RecordId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("players_with_character_ibfk_2");
            });

            modelBuilder.Entity<Records>(entity =>
            {
                entity.ToTable("records");

                entity.HasIndex(e => e.PlayerId)
                    .HasName("player_id");

                entity.HasIndex(e => e.RecordName)
                    .HasName("record_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CurrentRecord)
                    .HasColumnName("current_record")
                    .HasColumnType("int(55)");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("player_id")
                    .HasColumnType("int(55)");

                entity.Property(e => e.RecordName)
                    .IsRequired()
                    .HasColumnName("record_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Records)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("records_ibfk_1");
            });

            modelBuilder.Entity<Stage>(entity =>
            {
                entity.ToTable("stage");

                entity.HasIndex(e => e.StageName)
                    .HasName("stage_name")
                    .IsUnique();

                entity.HasIndex(e => e.StageTypeId)
                    .HasName("stage_type_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GameOrigin)
                    .IsRequired()
                    .HasColumnName("game_origin")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.StageName)
                    .IsRequired()
                    .HasColumnName("stage_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.StageTypeId)
                    .HasColumnName("stage_type_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.StageType)
                    .WithMany(p => p.Stage)
                    .HasForeignKey(d => d.StageTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("stage_ibfk_1");
            });

            modelBuilder.Entity<StageType>(entity =>
            {
                entity.ToTable("stage_type");

                entity.HasIndex(e => e.StageTypeName)
                    .HasName("stage_type_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StageTypeName)
                    .IsRequired()
                    .HasColumnName("stage_type_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
