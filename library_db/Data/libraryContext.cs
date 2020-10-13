using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using library_db.Models;

namespace library_db.Data
{
    public partial class libraryContext : DbContext
    {
        public libraryContext()
        {
        }

        public libraryContext(DbContextOptions<libraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Бригады> Бригады { get; set; }
        public virtual DbSet<ВидыРабот> ВидыРабот { get; set; }
        public virtual DbSet<Должности> Должности { get; set; }
        public virtual DbSet<Заказчики> Заказчики { get; set; }
        public virtual DbSet<Заказы> Заказы { get; set; }
        public virtual DbSet<Материалы> Материалы { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\ToPzSpAyWin10\\Documents\\database\\library.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Бригады>(entity =>
            {
                entity.HasKey(e => e.КодБригады);

                entity.HasIndex(e => e.КодСотрудника2)
                    .IsUnique();

                entity.HasIndex(e => e.КодСотрудника3)
                    .IsUnique();

                entity.Property(e => e.КодБригады)
                    .HasColumnName("Код_бригады")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.КодСотрудника1)
                    .HasColumnName("Код_сотрудника_1")
                    .HasColumnType("INT");

                entity.Property(e => e.КодСотрудника2)
                    .HasColumnName("Код_сотрудника_2")
                    .HasColumnType("INT");

                entity.Property(e => e.КодСотрудника3)
                    .HasColumnName("Код_сотрудника_3")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<ВидыРабот>(entity =>
            {
                entity.HasKey(e => e.КодВида);

                entity.ToTable("Виды_работ");

                entity.HasIndex(e => e.КодМатериала2)
                    .IsUnique();

                entity.HasIndex(e => e.КодМатериала3)
                    .IsUnique();

                entity.Property(e => e.КодВида)
                    .HasColumnName("Код_вида")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.КодМатериала1)
                    .HasColumnName("Код_материала_1")
                    .HasColumnType("INT");

                entity.Property(e => e.КодМатериала2)
                    .HasColumnName("Код_материала_2")
                    .HasColumnType("INT");

                entity.Property(e => e.КодМатериала3)
                    .HasColumnName("Код_материала_3")
                    .HasColumnType("INT");

                entity.Property(e => e.Наименование).HasColumnType("INT");

                entity.Property(e => e.Описание).HasColumnType("INT");

                entity.Property(e => e.ЦенаРаботы)
                    .HasColumnName("Цена_работы")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Должности>(entity =>
            {
                entity.HasKey(e => e.КодДолжности);

                entity.Property(e => e.КодДолжности)
                    .HasColumnName("Код_должности")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.НаименованиеДолжности)
                    .HasColumnName("Наименование_должности")
                    .HasColumnType("INT");

                entity.Property(e => e.Обязанности).HasColumnType("INT");

                entity.Property(e => e.Оклад).HasColumnType("INT");

                entity.Property(e => e.Требования).HasColumnType("INT");
            });

            modelBuilder.Entity<Заказчики>(entity =>
            {
                entity.HasKey(e => e.КодЗаказчика);

                entity.Property(e => e.КодЗаказчика)
                    .HasColumnName("Код_заказчика")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Адрес).HasColumnType("INT");

                entity.Property(e => e.ПаспортныеДанные)
                    .HasColumnName("Паспортные_данные")
                    .HasColumnType("INT");

                entity.Property(e => e.Телефон).HasColumnType("INT");

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Заказы>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.КодБригады)
                    .IsUnique();

                entity.HasIndex(e => e.КодВидаРабот)
                    .IsUnique();

                entity.HasIndex(e => e.КодСотрудника)
                    .IsUnique();

                entity.Property(e => e.ДатаНачала)
                    .HasColumnName("Дата_начала")
                    .HasColumnType("INT");

                entity.Property(e => e.ДатаОкончания)
                    .HasColumnName("_Дата_окончания")
                    .HasColumnType("INT");

                entity.Property(e => e.КодБригады)
                    .HasColumnName("Код_бригады")
                    .HasColumnType("INT");

                entity.Property(e => e.КодВидаРабот)
                    .HasColumnName("Код_вида_работ")
                    .HasColumnType("INT");

                entity.Property(e => e.КодЗаказчика)
                    .HasColumnName("Код_заказчика")
                    .HasColumnType("INT");

                entity.Property(e => e.КодСотрудника)
                    .HasColumnName("Код_сотрудника")
                    .HasColumnType("INT");

                entity.Property(e => e.ОбОплате)
                    .HasColumnName("_Об_оплате")
                    .HasColumnType("INT");

                entity.Property(e => e.ОтметкаОЗавершении)
                    .HasColumnName("Отметка_о_завершении")
                    .HasColumnType("INT");

                entity.Property(e => e.Стоимость).HasColumnType("INT");
            });

            modelBuilder.Entity<Материалы>(entity =>
            {
                entity.HasKey(e => e.КодМатериала);

                entity.Property(e => e.КодМатериала)
                    .HasColumnName("Код_материала")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Наименование).HasColumnType("INT");

                entity.Property(e => e.Описание).HasColumnType("INT");

                entity.Property(e => e.Упаковка).HasColumnType("INT");

                entity.Property(e => e.Цена).HasColumnType("INT");
            });

            modelBuilder.Entity<Сотрудники>(entity =>
            {
                entity.HasKey(e => e.КодСотрудника);

                entity.HasIndex(e => e.КодДолжности)
                    .IsUnique();

                entity.Property(e => e.КодСотрудника)
                    .HasColumnName("Код_сотрудника")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Адрес).HasColumnType("INT");

                entity.Property(e => e.Возраст).HasColumnType("INT");

                entity.Property(e => e.КодДолжности)
                    .HasColumnName("Код_должности")
                    .HasColumnType("INT");

                entity.Property(e => e.Пол).HasColumnType("INT");

                entity.Property(e => e.Телефон).HasColumnType("INT");

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasColumnType("INT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
