﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace TitleInjestion.Company.WFHowes.Onix_2_Short_Definition
{
    public class product_productidentifier
    {
        [XmlElement("b221", IsNullable = true)]
        public string b221_product_productidentifier { get; set; }

        [XmlElement("b233", IsNullable = true)]
        public string b233_product_productidentifier { get; set; }

        [XmlElement("b244", IsNullable = true)]
        public string b244_product_productidentifier { get; set; }
    }
}
