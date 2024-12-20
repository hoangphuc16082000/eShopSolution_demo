using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        public decimal Price { set; get; } = 0m;
        public decimal OriginalPrice { set; get; } = 0m;
        public int Stock { set; get; } = 0;
        public string Name { set; get; } = string.Empty; // Giá trị mặc định
        public string Description { set; get; } = string.Empty;
        public string Details { set; get; } = string.Empty;
        public string SeoDescription { set; get; } = string.Empty;
        public string SeoTitle { set; get; } = string.Empty;
        public string SeoAlias { get; set; } = string.Empty;
        public string LanguageId { set; get; } = string.Empty; // Giá trị mặc định
        public IFormFile? ThumbnailImage { get; set; } // Nullable
    }
}