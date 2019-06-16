using Application.Commands.Rule;
using Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.RuleCommand
{
    public class EfGetOneRuleCommand : EfBaseCommand, IGetOneRuleCommand
    {
        public EfGetOneRuleCommand(UniPin_Context context) : base(context)
        {
        }

        public RuleDTO Execute(int request)
        {
            if(request == null)
            {
                throw new EntryPointNotFoundException();
            }
            var ruleDto = _context.Rules.Find(request);

            return new RuleDTO
            {
                Id = ruleDto.Id,
                Naziv = ruleDto.Naziv
            };
        }
    }
}
