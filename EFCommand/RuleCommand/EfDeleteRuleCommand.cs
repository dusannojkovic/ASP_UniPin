using Application.Commands.Rule;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.RuleCommand
{
    public class EfDeleteRuleCommand : EfBaseCommand, IDeleteRuleCommand
    {
        public EfDeleteRuleCommand(UniPin_Context context) : base(context)
        {
        }

        public void Execute(int request)
        {
            var rule = _context.Rules.Find(request);
            if(rule == null)
            {
                throw new EntityNotFoundException("Role");
            }
            _context.Rules.Remove(rule);
            _context.SaveChanges();
        }
    }
}
