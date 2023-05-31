﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Base.Model;

namespace WebApplication.Schema.Product;

public class ProductResponse : BaseResponse
{
    public int CategoryId { get; set; }
    public CategoryResponse Category { get; set; }

    public string Name { get; set; }
    public int PriceId { get; set; }
    public bool IsValid { get; set; }
    public string Description { get; set; }
    public int ProductStock { get; set; }

}

