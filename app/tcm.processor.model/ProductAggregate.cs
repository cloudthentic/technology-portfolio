﻿using System.Collections.Generic;

namespace tcm.processor.model
{
    public class ProductAggregate
    {
        public string product { get; set; } //: Azure API Management
        public string productId { get; set; } //: azure-api-management|basic
        public string productVersion { get; set; } //: Basic
        public string recordDate { get; set; } //: 2018/11/01

        public ProductCapabilities productCapabilities { get; }

        public IList<Capability> capabilities { get;  }

        public ProductAggregate()
        {
            productCapabilities = new ProductCapabilities();
        }


    }
}