namespace AssignmentWCD.Migrations
{
    using AssignmentWCD.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AssignmentWCD.Data.ShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AssignmentWCD.Data.ShopContext context)
        {
            var categories = new List<Category> {
                new Category {Id = 1, Name = "Top"},
                new Category {Id = 2, Name = "Bottom"}
            };

            var products = new List<Product>
            {
                new Product {Id = 1, Name = "Áo sọc", Price = 94500, Thumbnail = "https://media.gucci.com/style/White_South_0_160_316x316/1643223616/690464_ZAIZX_9093_002_100_0000_Light.jpg", CategoryId = 1},
                new Product {Id = 2, Name = "Áo khoác denim", Price = 100000, Thumbnail = "https://media.gucci.com/style/White_South_0_160_316x316/1643713256/692271_XDBYI_4452_002_100_0000_Light.jpg", CategoryId = 1},
                new Product {Id = 3, Name = "Áo trắng", Price = 95000, Thumbnail = "https://media.gucci.com/style/DarkGray_South_0_160_316x316/1603992604/649696_ZAGIR_9692_001_100_0000_Light-Cotton-shirt.jpg", CategoryId =1},
                new Product {Id = 4, Name = "Áo lụa xanh lá ", Price = 289000, Thumbnail = "https://media.gucci.com/style/DarkGray_South_0_160_316x316/1634920239/673622_ZAEBN_3239_001_100_0000_Light-GG-canvas-nylon-bowling-shirt.jpg", CategoryId = 1},
                new Product {Id = 5, Name = "Áo xanh lá khác", Price = 299000, Thumbnail = "https://media.gucci.com/style/DarkGray_South_0_160_316x316/1632937506/672701_ZAIB8_3768_001_100_0000_Light-Check-wool-button-down-shirt-with-rocking-horse.jpg", CategoryId = 1},
                new Product {Id = 6, Name = "Quần đùi hoa", Price = 149000, Thumbnail = "https://media.gucci.com/style/White_South_0_160_316x316/1643218216/692626_Z8AX1_9743_002_100_0000_Light.jpg", CategoryId = 2},
                new Product {Id = 7, Name = "Áo polo trắng", Price = 149000, Thumbnail = "https://media.gucci.com/style/White_South_0_160_316x316/1643220007/692141_XJD69_9750_002_100_0000_Light.jpg", CategoryId = 1},
                new Product {Id = 8, Name = "Áo polo xanh dương", Price = 319000, Thumbnail = "https://media.gucci.com/style/White_South_0_160_316x316/1643220004/692141_XJD69_4684_002_100_0000_Light.jpg", CategoryId = 1},
                new Product {Id = 9, Name = "Áo đen tay dài", Price = 279000, Thumbnail = "https://media.gucci.com/style/DarkGray_South_0_160_316x316/1635183003/676063_XJDWA_1152_001_100_0000_Light-Cotton-T-shirt-with-Gucci-mirror-print.jpg", CategoryId = 1},
                new Product {Id = 10, Name = "Áo racing boi vjp pr0", Price = 159000, Thumbnail = "https://media.gucci.com/style/DarkGray_South_0_160_316x316/1616580005/655435_XJDGE_2270_001_100_0000_Light-GG-silk-cotton-jersey-jacquard-polo.jpg", CategoryId = 1},
                new Product {Id = 11, Name = "Quần dài", Price = 119000, Thumbnail = "https://media.gucci.com/style/White_South_0_160_316x316/1643218229/692970_Z8AXZ_9743_002_100_0000_Light.jpg", CategoryId = 2},
                new Product {Id = 12, Name = "Quần ngắn", Price = 169000, Thumbnail = "https://media.gucci.com/style/White_South_0_160_316x316/1643218216/692626_Z8AX1_9743_002_100_0000_Light.jpg", CategoryId =2},

            };
            categories.ForEach(e => context.Categories.Add(e));
            products.ForEach(e => context.Products.Add(e));
        }
    }
}
