﻿using KBVault.Dal.Entities;
using KBVault.Web.Models;

namespace KBVault.Web.Business.Categories
{
    public interface ICategoryFactory
    {
        Category CreateCategory(string name, bool isHot, string icon, long author, int? parent);
        CategoryViewModel CreateCategoryViewModel(Category cat);
    }
}