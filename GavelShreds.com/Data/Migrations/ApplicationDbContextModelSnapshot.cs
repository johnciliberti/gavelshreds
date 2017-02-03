using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GavelShreds.com.Data;
using GavelShreds.com.Models.Band;

namespace GavelShreds.com.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GavelShreds.com.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CoverArtMediaId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("AlbumId");

                    b.HasIndex("CoverArtMediaId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Accesses");

                    b.Property<DateTime>("ArchiveDate");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<bool>("Publish");

                    b.Property<string>("Summary")
                        .HasMaxLength(1024);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("ArticleId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.BandMember", b =>
                {
                    b.Property<int>("BandMemberId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio")
                        .HasMaxLength(10000);

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(100);

                    b.Property<string>("Facebook")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Instagram")
                        .HasMaxLength(100);

                    b.Property<DateTime>("JoinedBand");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("LeftBand");

                    b.Property<string>("NicName")
                        .HasMaxLength(30);

                    b.Property<string>("Talent")
                        .HasMaxLength(100);

                    b.Property<string>("Twitter")
                        .HasMaxLength(100);

                    b.HasKey("BandMemberId");

                    b.ToTable("BandMembers");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArticleId");

                    b.Property<int?>("EventId");

                    b.Property<bool>("Flagged");

                    b.Property<int>("Likes");

                    b.Property<bool>("ModeratorApproved");

                    b.Property<DateTime>("PostedDate");

                    b.Property<int?>("SongId");

                    b.Property<string>("UserId");

                    b.HasKey("CommentId");

                    b.HasIndex("ArticleId");

                    b.HasIndex("EventId");

                    b.HasIndex("SongId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.Property<DateTime>("EventDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("VenueId");

                    b.HasKey("EventId");

                    b.HasIndex("VenueId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Media", b =>
                {
                    b.Property<int>("MediaId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Accesses");

                    b.Property<int?>("ArticleId");

                    b.Property<int?>("BandMemberId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<int?>("EventId");

                    b.Property<int?>("EventId1");

                    b.Property<int?>("EventId2");

                    b.Property<double>("Likes");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.Property<int>("MediaSource");

                    b.Property<int>("MediaType");

                    b.Property<int?>("MerchandiseId");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<double>("SizeInBytes");

                    b.Property<int?>("VenueId");

                    b.HasKey("MediaId");

                    b.HasIndex("ArticleId");

                    b.HasIndex("BandMemberId");

                    b.HasIndex("EventId");

                    b.HasIndex("EventId1");

                    b.HasIndex("EventId2");

                    b.HasIndex("MerchandiseId");

                    b.HasIndex("VenueId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Merchandise", b =>
                {
                    b.Property<int>("MerchandiseId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("InStock");

                    b.Property<string>("ItemDescription");

                    b.Property<string>("ItemName")
                        .IsRequired();

                    b.Property<float>("Price");

                    b.HasKey("MerchandiseId");

                    b.ToTable("Merchandise");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlbumId");

                    b.Property<int?>("AudioMediaId");

                    b.Property<string>("BackStory")
                        .HasMaxLength(5000);

                    b.Property<string>("Lyrics")
                        .HasMaxLength(5000);

                    b.Property<int?>("PhotoMediaId");

                    b.Property<int?>("VideoMediaId");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.HasIndex("AudioMediaId");

                    b.HasIndex("PhotoMediaId");

                    b.HasIndex("VideoMediaId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Venue", b =>
                {
                    b.Property<int>("VenueId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Address2")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<float>("Lattitude");

                    b.Property<float>("Longitude");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("VenueId");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Album", b =>
                {
                    b.HasOne("GavelShreds.com.Models.Band.Media", "CoverArt")
                        .WithMany()
                        .HasForeignKey("CoverArtMediaId");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Comment", b =>
                {
                    b.HasOne("GavelShreds.com.Models.Band.Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId");

                    b.HasOne("GavelShreds.com.Models.Band.Event")
                        .WithMany("Comments")
                        .HasForeignKey("EventId");

                    b.HasOne("GavelShreds.com.Models.Band.Song")
                        .WithMany("Comments")
                        .HasForeignKey("SongId");

                    b.HasOne("GavelShreds.com.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Event", b =>
                {
                    b.HasOne("GavelShreds.com.Models.Band.Venue", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueId");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Media", b =>
                {
                    b.HasOne("GavelShreds.com.Models.Band.Article")
                        .WithMany("Media")
                        .HasForeignKey("ArticleId");

                    b.HasOne("GavelShreds.com.Models.Band.BandMember")
                        .WithMany("Photos")
                        .HasForeignKey("BandMemberId");

                    b.HasOne("GavelShreds.com.Models.Band.Event")
                        .WithMany("Fliers")
                        .HasForeignKey("EventId");

                    b.HasOne("GavelShreds.com.Models.Band.Event")
                        .WithMany("Photos")
                        .HasForeignKey("EventId1");

                    b.HasOne("GavelShreds.com.Models.Band.Event")
                        .WithMany("Videos")
                        .HasForeignKey("EventId2");

                    b.HasOne("GavelShreds.com.Models.Band.Merchandise")
                        .WithMany("Photos")
                        .HasForeignKey("MerchandiseId");

                    b.HasOne("GavelShreds.com.Models.Band.Venue")
                        .WithMany("Photos")
                        .HasForeignKey("VenueId");
                });

            modelBuilder.Entity("GavelShreds.com.Models.Band.Song", b =>
                {
                    b.HasOne("GavelShreds.com.Models.Band.Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId");

                    b.HasOne("GavelShreds.com.Models.Band.Media", "Audio")
                        .WithMany()
                        .HasForeignKey("AudioMediaId");

                    b.HasOne("GavelShreds.com.Models.Band.Media", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoMediaId");

                    b.HasOne("GavelShreds.com.Models.Band.Media", "Video")
                        .WithMany()
                        .HasForeignKey("VideoMediaId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GavelShreds.com.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GavelShreds.com.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GavelShreds.com.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
