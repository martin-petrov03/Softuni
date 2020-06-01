using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.Dtos.Import
{
    [XmlType("Car")]
    public class ImportCarDto
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("traveled-distance")]
        public long TravelledDistance { get; set; }

        [XmlElement("parts")]
        public ImportPartCarDto Parts { get; set; }
    }
}
