﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Models.Contracts
{
    public interface IDeleteable
    {
        bool IsDeleted { get; set; }
        int? DeletedById { get; set; }
        DateTime? DeletedOn { get; set; }
        string DeleteRemarks { get; set; }
    }
}
