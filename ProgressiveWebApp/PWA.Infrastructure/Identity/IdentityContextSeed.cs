using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PWA.Infrastructure.Identity
{
    public sealed class IdentityContextSeed
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new List<User>()
                {
                    new User()
                    {
                        Id = "2570cebf-25a8-49ed-be0a-3b28c26278be",
                        Email = "foxychmoxy@admin",
                        NormalizedEmail = "FOXYCHMOXY@ADMIN",
                        EmailConfirmed = true,
                        UserName = "foxy.admin",
                        NormalizedUserName = "FOXY.ADMIN",
                        // admin123!
                        PasswordHash = "AQAAAAEAACcQAAAAEMF6mcJm2w8egVZZcYAa6/CUiTXP6wK5bE/LuBsFZ5v/euAn0IEcUZrEtgsXcAcjKg=="
                    },
                    new User()
                    {
                        Id = "74239187-19ab-4b09-9d91-559371ebfb0d",
                        Email = "foxychmoxy@user",
                        NormalizedEmail = "FOXYCHMOXY@user",
                        EmailConfirmed = true,
                        UserName = "foxy.user",
                        NormalizedUserName = "FOXY.USER",
                        // user123!
                        PasswordHash = "AQAAAAEAACcQAAAAELf3G6PzLYeF40ja7bwE2HEGC0I3nJP5ADbG5+olHlXJtpnbFHQCBtiCn0SxI25+3A=="
                    }
                }
            );

            modelBuilder.Entity<IdentityRole>().HasData(
                new List<IdentityRole>()
                {
                    new IdentityRole()
                    {
                        Id = "d6a8058c-d231-441b-a75f-6f468bfbf76a",
                        Name = "Administrator",
                        NormalizedName = "ADMINISTRATOR"
                    },
                    new IdentityRole()
                    {
                        Id = "76bf8de3-e4b3-4b5a-98e8-d52a901226b6",
                        Name = "User",
                        NormalizedName = "USER"
                    }
                }
            );
        }
    }
}
