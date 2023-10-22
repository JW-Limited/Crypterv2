using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace TextPreviewLibrary.Core.Third_Party.Docx
{
    public class Converter
    {
        public static string ConvertToPlainText(string inputPath)
        {
            // Open the input DOCX file.
            XDocument inputDocument = XDocument.Load(inputPath);

            // Create a new output string.
            StringBuilder output = new StringBuilder();

            // Iterate over the body element of the input document.
            foreach (XElement element in inputDocument.Root.ElementsAfterSelf("body"))
            {
                // Process the element based on its type.
                switch (element.Name.LocalName)
                {
                    case "p": // Paragraph
                        output.AppendLine(element.Value.Trim());
                        break;
                    case "h1": // Heading 1
                        output.AppendLine(element.Value.Trim());
                        break;
                    case "h2": // Heading 2
                        output.AppendLine(element.Value.Trim());
                        break;
                    case "h3": // Heading 3
                        output.AppendLine(element.Value.Trim());
                        break;
                    case "ul": // Unordered list
                        output.AppendLine();
                        foreach (XElement childElement in element.Elements("li"))
                        {
                            output.AppendLine("- " + childElement.Value.Trim());
                        }
                        break;
                    case "ol": // Ordered list
                        output.AppendLine();
                        foreach (XElement childElement in element.Elements("li"))
                        {
                            output.AppendLine(childElement.Attribute("value")?.Value + ". " + childElement.Value.Trim());
                        }
                        break;
                    case "img": // Image
                        output.AppendLine("[Image omitted]");
                        break;
                    default: // Ignore other elements
                        break;
                }
            }

            // Return the output string.
            return output.ToString();
        }
    }
}

