using Application.Commands.Category;
using Application.DTO;
using Application.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.CategoryCommand
{
    public class EfCreateCategoryCommand : EfBaseCommand, ICreateCategoryCommand
    {
        public EfCreateCategoryCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(CategoryDTO request)
        {
            if(_context.Categories.Any(c => c.Naziv == request.Naziv))
            {
                throw new EntityAlreadyExistsException("Category");
            }
            _context.Categories.Add(new Category
            {
                Naziv = request.Naziv
            });

            _context.SaveChanges();

        }
    }
}
