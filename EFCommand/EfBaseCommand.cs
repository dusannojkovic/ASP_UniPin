using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand
{
    public abstract class EfBaseCommand
    {
        protected EfBaseCommand(UniPin_Context context)
        {
            _context = context;
        }

  
        protected UniPin_Context _context { get; }


    }
}
