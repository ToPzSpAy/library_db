using Microsoft.EntityFrameworkCore.Migrations;

namespace library_db.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Бригады",
                columns: table => new
                {
                    Код_бригады = table.Column<int>(type: "INT", nullable: false),
                    Код_сотрудника_1 = table.Column<int>(type: "INT", nullable: false),
                    Код_сотрудника_2 = table.Column<int>(type: "INT", nullable: false),
                    Код_сотрудника_3 = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Бригады", x => x.Код_бригады);
                });

            migrationBuilder.CreateTable(
                name: "Виды_работ",
                columns: table => new
                {
                    Код_вида = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<int>(type: "INT", nullable: false),
                    Код_материала_1 = table.Column<int>(type: "INT", nullable: false),
                    Описание = table.Column<int>(type: "INT", nullable: false),
                    Цена_работы = table.Column<int>(type: "INT", nullable: false),
                    Код_материала_2 = table.Column<int>(type: "INT", nullable: false),
                    Код_материала_3 = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Виды_работ", x => x.Код_вида);
                });

            migrationBuilder.CreateTable(
                name: "Должности",
                columns: table => new
                {
                    Код_должности = table.Column<int>(type: "INT", nullable: false),
                    Наименование_должности = table.Column<int>(type: "INT", nullable: false),
                    Оклад = table.Column<int>(type: "INT", nullable: false),
                    Обязанности = table.Column<int>(type: "INT", nullable: false),
                    Требования = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Должности", x => x.Код_должности);
                });

            migrationBuilder.CreateTable(
                name: "Заказчики",
                columns: table => new
                {
                    Код_заказчика = table.Column<int>(type: "INT", nullable: false),
                    Телефон = table.Column<int>(type: "INT", nullable: false),
                    Паспортные_данные = table.Column<int>(type: "INT", nullable: false),
                    Адрес = table.Column<int>(type: "INT", nullable: false),
                    ФИО = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Заказчики", x => x.Код_заказчика);
                });

            migrationBuilder.CreateTable(
                name: "Заказы",
                columns: table => new
                {
                    Код_заказчика = table.Column<int>(type: "INT", nullable: false),
                    Код_вида_работ = table.Column<int>(type: "INT", nullable: false),
                    Код_бригады = table.Column<int>(type: "INT", nullable: false),
                    Стоимость = table.Column<int>(type: "INT", nullable: false),
                    Дата_начала = table.Column<int>(type: "INT", nullable: false),
                    _Дата_окончания = table.Column<int>(type: "INT", nullable: false),
                    Отметка_о_завершении = table.Column<int>(type: "INT", nullable: false),
                    _Об_оплате = table.Column<int>(type: "INT", nullable: false),
                    Код_сотрудника = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Материалы",
                columns: table => new
                {
                    Код_материала = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<int>(type: "INT", nullable: false),
                    Упаковка = table.Column<int>(type: "INT", nullable: false),
                    Описание = table.Column<int>(type: "INT", nullable: false),
                    Цена = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Материалы", x => x.Код_материала);
                });

            migrationBuilder.CreateTable(
                name: "Сотрудники",
                columns: table => new
                {
                    Код_сотрудника = table.Column<int>(type: "INT", nullable: false),
                    ФИО = table.Column<int>(type: "INT", nullable: false),
                    Возраст = table.Column<int>(type: "INT", nullable: false),
                    Пол = table.Column<int>(type: "INT", nullable: false),
                    Адрес = table.Column<int>(type: "INT", nullable: false),
                    Телефон = table.Column<int>(type: "INT", nullable: false),
                    Код_должности = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Сотрудники", x => x.Код_сотрудника);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Бригады_Код_сотрудника_2",
                table: "Бригады",
                column: "Код_сотрудника_2",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Бригады_Код_сотрудника_3",
                table: "Бригады",
                column: "Код_сотрудника_3",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Виды_работ_Код_материала_2",
                table: "Виды_работ",
                column: "Код_материала_2",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Виды_работ_Код_материала_3",
                table: "Виды_работ",
                column: "Код_материала_3",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_бригады",
                table: "Заказы",
                column: "Код_бригады",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_вида_работ",
                table: "Заказы",
                column: "Код_вида_работ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Заказы_Код_сотрудника",
                table: "Заказы",
                column: "Код_сотрудника",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Сотрудники_Код_должности",
                table: "Сотрудники",
                column: "Код_должности",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Бригады");

            migrationBuilder.DropTable(
                name: "Виды_работ");

            migrationBuilder.DropTable(
                name: "Должности");

            migrationBuilder.DropTable(
                name: "Заказчики");

            migrationBuilder.DropTable(
                name: "Заказы");

            migrationBuilder.DropTable(
                name: "Материалы");

            migrationBuilder.DropTable(
                name: "Сотрудники");
        }
    }
}
