using Application.Commands.Category;
using Application.DTO;
using Application.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.CategoryCommand
{
    public class EfGetAllCategoryCommand : EfBaseCommand, IGetAllCategoryCommand
    {
        public EfGetAllCategoryCommand(UniPin_Context context) : base(context)
        {
        }

        public ICollection<CategoryDTO> Execute(CategorySearch request)
        {
            var query = _context.Categories.AsQueryable();
            if(request.Naziv != null)
            {
                query = query.Where(c => c.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }
            return query.Select(c => new CategoryDTO
            {
                Id = c.Id,
                Naziv = c.Naziv
            }).ToList();

            
        }
    }
}
