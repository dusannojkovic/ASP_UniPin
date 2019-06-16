using Application.Commands.Rule;
using Application.DTO;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UniPin_DataAccess;
using Domain;

namespace EFCommand.RuleCommand
{
    public class EfCreateRuleCommand : EfBaseCommand, ICreateRuleCommand
    {
        public EfCreateRuleCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(RuleDTO request)
        {
            if(_context.Rules.Any(r => r.Naziv == request.Naziv))
            {
                throw new EntityAlreadyExistsException("Role");
            }
            _context.Rules.Add( new Domain.Rule
            {
                  
                  Naziv  = request.Naziv
            });
            _context.SaveChanges();
            
        }
    }
}
