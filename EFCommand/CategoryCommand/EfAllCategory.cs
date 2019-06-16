using Application.Commands.Category;
using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.CategoryCommand
{
    public class EfAllCategory : EfBaseCommand, IAllCategory
    {
        public EfAllCategory(UniPin_Context context) : base(context)
        {
        }

        public ICollection<CategoryDTO> Execute(CategoryDTO request)
        {
            var categories = _context.Categories.AsQueryable();
            return categories.Select(c => new CategoryDTO
            {
                Id= c.Id,
                Naziv = c.Naziv
            }).ToList();

        }
    }
}
