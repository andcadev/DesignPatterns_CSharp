using System.Xml.Linq;

namespace AbstractFactory
{
    public class XmlCommandBuilder : ICommandBuilder
    {
        // Build command to set the temperature set point
        public string BuildSetTemperature(int temperature) => new XElement("Command",
            new XElement("SetTemperature",
            new XElement("Value", temperature)
        )
    ).ToString(SaveOptions.DisableFormatting);


        // Build command to start the Oven
        public string BuildStartCycle() => new XElement("Command",
            new XElement("StartCycle")).ToString(SaveOptions.DisableFormatting);
    }
}