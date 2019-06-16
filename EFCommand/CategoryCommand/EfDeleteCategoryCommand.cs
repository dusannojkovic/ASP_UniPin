using Application.Commands.Category;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.CategoryCommand
{
    public class EfDeleteCategoryCommand : EfBaseCommand, IDeleteCategoryCommand
    {
        public EfDeleteCategoryCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(int request)
        {
            var category = _context.Categories.Find(request);

            if(category == null)
            {
                throw new EntityNotFoundException("Category");
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
