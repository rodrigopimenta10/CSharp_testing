using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            XElement contacts = XElement.Parse(
                @"<Contacts>
                    <Contact>
                        <Name>Patrick Hines</Name>
                        <Phone Type=""home"">206-555-0144</Phone>
                        <Phone Type=""work"">425-555-0145</Phone>
                        <Address>
                        <Street1>123 Main St</Street1>
                        <City>Mercer Island</City>
                        <State>WA</State>
                        <Postal>68042</Postal>
                        </Address>
                        <NetWorth>10</NetWorth>
                    </Contact>
                    <Contact>
                        <Name>Gretchen Rivas</Name>
                        <Phone Type=""mobile"">206-555-0163</Phone>
                        <Address>
                        <Street1>123 Main St</Street1>
                        <City>Mercer Island</City>
                        <State>WA</State>
                        <Postal>68042</Postal>
                        </Address>
                        <NetWorth>11</NetWorth>
                    </Contact>
                </Contacts>");
            // Console.WriteLine(contacts);

            List<XElement> contactNodes = contacts.Elements("Contact").ToList();
            Console.WriteLine(contactNodes[0]);
        }
    }
}
