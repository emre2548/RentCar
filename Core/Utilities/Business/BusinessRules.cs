using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var item in logics)
            {
                if (!item.Success)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
