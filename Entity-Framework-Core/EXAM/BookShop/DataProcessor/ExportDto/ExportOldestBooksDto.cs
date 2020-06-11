namespace BookShop.DataProcessor.ExportDto
{
    using System;
    using System.Xml.Serialization;

    public class ExportOldestBooksDto
    {
        [XmlAttribute("Pages")]
        public string Pages { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Date")]
        public DateTime Date { get; set; }        
    }
}
