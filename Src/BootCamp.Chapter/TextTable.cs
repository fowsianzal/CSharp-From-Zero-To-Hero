using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 1.
    /// </summary>
    public static class TextTable
    {
        /*

         Input: "Hello", 0
           +-----+
           |Hello|
           +-----+
           
         Input: $"Hello{Environment.NewLine}World!", 0
           +------+
           |Hello |
           |World!|
           +------+
           
         Input: "Hello", 1
           +-------+
           |       |
           | Hello |
           |       |
           +-------+

         */

        /// <summary>
        /// Build a table for given message with given padding.
        /// Padding means how many spaces will a message be wrapped with.
        /// Table itself is made of: "+-" symbols. 
        /// </summary>
        public static string Build(string message, int padding)
        {
            if (string.IsNullOrEmpty(message) && padding==0)
            {
                return string.Empty;
            }

            var lines = message.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            int tableWidth = lines.Max(line => line.Length + 2 * padding);

            var topBorder = "+" + new string('-', tableWidth) + "+";

            var tableContent = new StringBuilder();
            tableContent.AppendLine(topBorder);

            for (int i = 0; i < padding; i++)
            {
                tableContent.AppendLine($"|{new string(' ', tableWidth)}|");
            }

            foreach (var line in lines)
            {
                var paddedLine = line.PadLeft(line.Length + padding).PadRight(tableWidth);
                tableContent.AppendLine($"|{paddedLine}|");
            }

            for (int i = 0; i < padding; i++)
            {
                tableContent.AppendLine($"|{new string(' ', tableWidth)}|");
            }

            tableContent.AppendLine(topBorder);
            return tableContent.ToString();
        }
    }
}
