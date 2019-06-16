using Application.Commands.Category;
using Application.DTO;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.CategoryCommand
{
    public class EfUpdateCategoryCommand : EfBaseCommand, IUpdateCategoryCommand
    {
        public EfUpdateCategoryCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(CategoryDTO request)
        {
            var category = _context.Categories.Find(request.Id);

            if(category ==null)
            {
                throw new EntityNotFoundException("Category");
            }
            if(category.Naziv != request.Naziv)
            {
                if (_context.Categories.Any(c =>c.Naziv == request.Naziv))
                {
                    throw new EntityAlreadyExistsException("Category");
                }
                category.Id = request.Id;
                category.Naziv = request.Naziv;

                _context.SaveChanges();
                
            }
        }
    }
}
