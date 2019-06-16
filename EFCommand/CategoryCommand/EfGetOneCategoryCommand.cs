using Application.Commands.Category;
using Application.DTO;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.CategoryCommand
{
    public class EfGetOneCategoryCommand : EfBaseCommand, IGetOneCategoryCommand
    {
        public EfGetOneCategoryCommand(UniPin_Context context) : base(context)
        {
        }

        public CategoryDTO Execute(int request)
        {
            var category = _context.Categories.Find(request);

            if (category == null)
            {
                throw new EntityNotFoundException("Category");
            }
            return new CategoryDTO
            {
                Id = category.Id,
                Naziv = category.Naziv
            };
        }
    }
}
