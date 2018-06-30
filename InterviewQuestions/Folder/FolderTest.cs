using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Xunit;

namespace InterviewQuestions.Folder
{
    public class FolderTest
    {
        static IEnumerable<string> FindFolder(char letter, string xml)
        {
            XElement folder = XElement.Parse(xml);
            IEnumerable<XElement> items =
                from el in folder.Descendants("name") where el.Value.StartsWith(letter)
                select el;

            return items.Select(x=>x.Value).ToList();
        }
        [Fact]
        public void Find_Folder_Names_Start_With_Letter_U()
        {
            var xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>" +
                @"<folder>" +
                @"<name>program files</name>" +
                @"<name>install Files</name>" +
                @"<name>users</name>" +
                @"</folder>";

            var folders = FindFolder('u', xml);

            Assert.Single(folders);

        }


    }
}
