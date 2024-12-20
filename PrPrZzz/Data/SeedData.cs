using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PrPrZzz.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Убедиться, что база данных создана
            context.Database.EnsureCreated();

            // Проверить, есть ли данные в таблице Materials
            if (context.Materials.Any())
            {
                return; // Если данные уже есть, выходим
            }

            // Создать массив материалов
            var materials = new Material[]
            {
                new Material { Name = "Дерево" },
                new Material { Name = "Сталь" },
                new Material { Name = "Пластмасса" },
                new Material { Name = "Картон" }
            };

            // Добавить материалы в контекст
            context.Materials.AddRange(materials);

            // Сохранить изменения в базе данных
            context.SaveChanges();
        }
    }
}
