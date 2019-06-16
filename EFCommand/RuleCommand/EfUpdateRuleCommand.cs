using Application.Commands.Rule;
using Application.DTO;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.RuleCommand
{
    public class EfUpdateRuleCommand : EfBaseCommand, IUpdateRuleCommand
    {
        public EfUpdateRuleCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(RuleDTO request)
        {
            var rule = _context.Rules.Find(request.Id);

            if(rule == null)
            {
                throw new EntityNotFoundException("Role");
            }
            if (rule.Naziv.ToLower().Contains(request.Naziv.ToLower()))
            {
                throw new EntityAlreadyExistsException("Role");
            }

            rule.Id = request.Id;
            rule.Naziv = request.Naziv;

            _context.SaveChanges();
        }
    }
}
