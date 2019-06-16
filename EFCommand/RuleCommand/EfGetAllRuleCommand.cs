using Application.Commands.Rule;
using Application.DTO;
using Application.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniPin_DataAccess;

namespace EFCommand.RuleCommand
{
    public class EfGetAllRuleCommand : EfBaseCommand, IGetAllRuleCommand
    {
        public EfGetAllRuleCommand(UniPin_Context context) : base(context)
        {
        }

        public ICollection<RuleDTO> Execute(RuleSearch request)
        {
            var query = _context.Rules.AsQueryable();
            if(request.Naziv != null)
            {
                query = _context.Rules.Where(r => r.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }
            return query.Select(r => new RuleDTO
            {
                Id = r.Id,
                Naziv = r.Naziv

            }).ToList();
        }
    }
}
