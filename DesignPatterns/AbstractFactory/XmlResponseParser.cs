using System.Xml.Linq;

namespace FactoryMethod
{
    public class XmlResponseParser : IResponseParser
    {
        // Parse response and extract the temperature value
        public int ParseTemperature(string response)
        {
            XElement doc;

            try
            {
                doc = XElement.Parse(response);
            }
            catch (Exception ex)
            {
                throw new FormatException("Invalid XML format", ex);
            }

            XElement? valueElement = doc.Element("Value");
            if (valueElement == null)
            {
                throw new FormatException("Missing <Value> element in temperature response");
            }

            string? valueText = valueElement.Value;
            if (int.TryParse(valueText, out int temperature))
            {
                return temperature;
            }

            throw new FormatException("Temperature value is not a valid integer");
        }

        // Parse response and extract the oven status
        public string ParseStatus(string response)
        {
            XElement doc = XElement.Parse(response);
            XElement? statusElement = doc.Element("Status");
            return statusElement?.Value ?? "UNKNOWN";
        }
    }


}