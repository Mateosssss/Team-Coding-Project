using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektZespołówka.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dokumenty_wykonawcze",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    projekt_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    plik_pdf_url = table.Column<Guid>(type: "uniqueidentifier", maxLength: 500, nullable: false),
                    data_wygenerowania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    odbiorca = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dokumenty_wykonawcze", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Etapy_gniazda",
                columns: table => new
                {
                    etap_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    gniazdo_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etapy_gniazda", x => new { x.etap_id, x.gniazdo_id });
                });

            migrationBuilder.CreateTable(
                name: "Etapy_pomieszczenia",
                columns: table => new
                {
                    etap_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    pomieszczenie_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etapy_pomieszczenia", x => new { x.etap_id, x.pomieszczenie_id });
                });

            migrationBuilder.CreateTable(
                name: "Etapy_prac",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    projekt_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nazwa = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    przypisany_do = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    data_zakończenia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_rozpoczęcia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etapy_prac", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Gniazda",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    pomieszczenie_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    serwisant_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    oznaczenie_techniczne = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    liczba_gniazd = table.Column<int>(type: "int", nullable: false),
                    typ_gniazda = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    zdjęcie_zbiżenie_url = table.Column<Guid>(type: "uniqueidentifier", maxLength: 500, nullable: false),
                    zdjęcie_odległość_url = table.Column<Guid>(type: "uniqueidentifier", maxLength: 500, nullable: false),
                    status = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    data_instalacji = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gniazda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Lokalizacje",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dane_adresowe = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    dane_kontaktowe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    contact_phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    data_utworzenia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokalizacje", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Panele_szaf",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    szafa_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    typ = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    liczba_portów = table.Column<int>(type: "int", nullable: false),
                    pozycja = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panele_szaf", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pomiary",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    gniazdo_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    serwisant_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    plik_raportu_url = table.Column<Guid>(type: "uniqueidentifier", maxLength: 500, nullable: false),
                    wynik_pomiaru = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    parametry_techniczne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_pomiaru = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status_certyfikacji = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pomiary", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pomieszczenia",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    pietro_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nr_pomieszczenia = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    nazwa_pomieszczenia = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    oznaczenie_techniczne = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OutletCount = table.Column<int>(type: "int", nullable: false),
                    współrzędne_na_rzucie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pomieszczenia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Poziomy",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    projekt_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    numer = table.Column<int>(type: "int", nullable: false),
                    oznaczenie_techniczne = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    kat_rodzajKabla = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    plik_rzutu_url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    data_dodania = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poziomy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Projekty",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nazwa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    opis = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    dane_adresowe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    dane_kontaktowe = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    status_projektu = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    kierownik_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    inwestor_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    data_utworzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lokalizacja_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekty", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Serwisanci_w_projektach",
                columns: table => new
                {
                    projekt_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    serwisant_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    data_przypisania = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serwisanci_w_projektach", x => new { x.projekt_id, x.serwisant_id });
                });

            migrationBuilder.CreateTable(
                name: "Szafy_sieciowe",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    projekt_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    rozmiar = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    lokalizacja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zdjęcie_przód_url = table.Column<Guid>(type: "uniqueidentifier", maxLength: 500, nullable: false),
                    zdjęcie_bok_url = table.Column<Guid>(type: "uniqueidentifier", maxLength: 500, nullable: false),
                    zdjęcie_tył_url = table.Column<Guid>(type: "uniqueidentifier", maxLength: 500, nullable: false),
                    data_montażu = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szafy_sieciowe", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Uwagi",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    typ_encji = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    encja_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    autor_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    treść = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    data_dodania = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uwagi", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Użytkownicy",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    imię_nazwisko = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    rola = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    data_rejestracji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    refresh_token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    refresh_token_expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    hasło = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Użytkownicy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Załączniki",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    typ_encji = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    encja_id = table.Column<int>(type: "int", nullable: false),
                    plik_url = table.Column<Guid>(type: "uniqueidentifier", maxLength: 500, nullable: false),
                    dodane_przez = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    data_dodania = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Załączniki", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Role_Claims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role_Claims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_Claims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Użytkownicy_Claims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Użytkownicy_Claims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Użytkownicy_Claims_Użytkownicy_UserId",
                        column: x => x.UserId,
                        principalTable: "Użytkownicy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Użytkownicy_Loginy",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Użytkownicy_Loginy", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_Użytkownicy_Loginy_Użytkownicy_UserId",
                        column: x => x.UserId,
                        principalTable: "Użytkownicy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Użytkownicy_Role",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Użytkownicy_Role", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_Użytkownicy_Role_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Użytkownicy_Role_Użytkownicy_UserId",
                        column: x => x.UserId,
                        principalTable: "Użytkownicy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Użytkownicy_Tokeny",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Użytkownicy_Tokeny", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_Użytkownicy_Tokeny_Użytkownicy_UserId",
                        column: x => x.UserId,
                        principalTable: "Użytkownicy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gniazda_oznaczenie_techniczne",
                table: "Gniazda",
                column: "oznaczenie_techniczne",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Claims_RoleId",
                table: "Role_Claims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Użytkownicy",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Użytkownicy",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Użytkownicy_Claims_UserId",
                table: "Użytkownicy_Claims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Użytkownicy_Loginy_UserId",
                table: "Użytkownicy_Loginy",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Użytkownicy_Role_RoleId",
                table: "Użytkownicy_Role",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dokumenty_wykonawcze");

            migrationBuilder.DropTable(
                name: "Etapy_gniazda");

            migrationBuilder.DropTable(
                name: "Etapy_pomieszczenia");

            migrationBuilder.DropTable(
                name: "Etapy_prac");

            migrationBuilder.DropTable(
                name: "Gniazda");

            migrationBuilder.DropTable(
                name: "Lokalizacje");

            migrationBuilder.DropTable(
                name: "Panele_szaf");

            migrationBuilder.DropTable(
                name: "Pomiary");

            migrationBuilder.DropTable(
                name: "Pomieszczenia");

            migrationBuilder.DropTable(
                name: "Poziomy");

            migrationBuilder.DropTable(
                name: "Projekty");

            migrationBuilder.DropTable(
                name: "Role_Claims");

            migrationBuilder.DropTable(
                name: "Serwisanci_w_projektach");

            migrationBuilder.DropTable(
                name: "Szafy_sieciowe");

            migrationBuilder.DropTable(
                name: "Uwagi");

            migrationBuilder.DropTable(
                name: "Użytkownicy_Claims");

            migrationBuilder.DropTable(
                name: "Użytkownicy_Loginy");

            migrationBuilder.DropTable(
                name: "Użytkownicy_Role");

            migrationBuilder.DropTable(
                name: "Użytkownicy_Tokeny");

            migrationBuilder.DropTable(
                name: "Załączniki");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Użytkownicy");
        }
    }
}
