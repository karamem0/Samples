using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karamem0.Samples.Models.DomainModels
{

    public class PeriodSelectDomainModel
    {

        public PeriodSelectDomainModel()
        {
        }

        public Guid Id { get; set; }

        public DateTime Period { get; set; }

    }

}
