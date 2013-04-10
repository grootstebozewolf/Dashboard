using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Xml;

namespace HelpdeskKPI
{
    public class CustomerSectionHandler: IConfigurationSectionHandler
    {
        public class Customer
        {
            public string ID;
            public string Name;
            public string Image;
        }

        private List<Customer> Customers;
        public object Create(object parent, object configContext, XmlNode section)
        {
            Customers = new List<Customer>();
            foreach(XmlNode objXmlNode in section.ChildNodes)
            {
                Customers.Add(new Customer
                                  {
                                      ID = objXmlNode.Attributes["id"].Value,
                                      Name = objXmlNode.Attributes["name"].Value,
                                      Image = objXmlNode.Attributes["image"].Value
                                  });
            }
            return Customers;
        }
    }
}
