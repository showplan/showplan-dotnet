using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Shouldly;
using Xunit;

namespace Showplan.Tests
{
    public class UnitTest1
    {
        private XmlSerializer _xmlSerializer;


        public UnitTest1()
        {
            _xmlSerializer = new XmlSerializer(typeof(ShowPlanXML));
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Test1(string fileName)
        {
            File.Exists(fileName).ShouldBeTrue();
            var showplan = (ShowPlanXML) _xmlSerializer.Deserialize(File.OpenRead(fileName));
            showplan.BatchSequence.ShouldNotBeEmpty();
        }

        public static IEnumerable<object[]> Data => System.IO.Directory.GetFiles("plans").Select(i => new object[] {i});
    }
}
