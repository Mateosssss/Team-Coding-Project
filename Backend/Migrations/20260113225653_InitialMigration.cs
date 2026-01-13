using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektZespołówka.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    hasło = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    imię_nazwisko = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    rola = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    data_rejestracji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_Gniazda_oznaczenie_techniczne",
                table: "Gniazda",
                column: "oznaczenie_techniczne",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Użytkownicy_email",
                table: "Użytkownicy",
                column: "email",
                unique: true);
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
                name: "Serwisanci_w_projektach");

            migrationBuilder.DropTable(
                name: "Szafy_sieciowe");

            migrationBuilder.DropTable(
                name: "Uwagi");

            migrationBuilder.DropTable(
                name: "Użytkownicy");

            migrationBuilder.DropTable(
                name: "Załączniki");
        }
    }
}
