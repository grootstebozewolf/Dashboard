using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;

namespace AGaugeApp
{
    public class DashboardSectionHandler : IConfigurationSectionHandler
    {
        public object Create(object parent, object configContext, XmlNode section)
        {
            Config config = new Config();
            foreach (XmlNode objXmlNode in section.ChildNodes)
            {
                config[objXmlNode.Name] = new Config.GaugeSettings()
                                              {
                                                  BaseArcRadius =
                                                      int.Parse(objXmlNode.Attributes["Radius"].Value),
                                                  BaseArcStart = int.Parse(objXmlNode.Attributes["BaseArcStart"].Value),
                                                  BaseArcSweep = int.Parse(objXmlNode.Attributes["BaseArcSweep"].Value),
                                                  Center =
                                                      new Point(
                                                      int.Parse(objXmlNode.Attributes["Center"].Value.Split(',')[0]),
                                                      int.Parse(objXmlNode.Attributes["Center"].Value.Split(',')[1])),
                                                  NeedleRadius = int.Parse(objXmlNode.Attributes["Radius"].Value),
                                                  ScaleLinesInterInnerRadius = (int.Parse(objXmlNode.Attributes["Radius"].Value) + 5),
                                                  ScaleLinesInterOuterRadius = (int.Parse(objXmlNode.Attributes["Radius"].Value) + 10),
                                                  ScaleLinesMajorInnerRadius = int.Parse(objXmlNode.Attributes["Radius"].Value),
                                                  ScaleLinesMajorOuterRadius = (int.Parse(objXmlNode.Attributes["Radius"].Value) + 10),
                                                  ScaleLinesMinorInnerRadius = (int.Parse(objXmlNode.Attributes["Radius"].Value) + 5),
                                                  ScaleLinesMinorOuterRadius = (int.Parse(objXmlNode.Attributes["Radius"].Value) + 10),
                                                  ScaleNumbersRadius = (int.Parse(objXmlNode.Attributes["Radius"].Value) + 22)
                                              };
            }
            return config;
        }

        public class Config 
        {
            public readonly Dictionary<string,GaugeSettings> Items = new Dictionary<string,GaugeSettings>();

            public Config()
            {
                Items.Add("Gauge1", null);
                Items.Add("Gauge2", null);
                Items.Add("Gauge3", null);
                Items.Add("Gauge4", null);
            }

            public GaugeSettings this [string strIndex]
            {
                get
                {
                    return Items[strIndex];
                }
                set
                {
                    Items[strIndex] = value;
                }
            }

            public class GaugeSettings
            {
                public int BaseArcRadius;
                public int BaseArcStart;
                public int BaseArcSweep;
                public Point Center;
                public int NeedleRadius;
                public int ScaleLinesInterInnerRadius;
                public int ScaleLinesInterOuterRadius;
                public int ScaleLinesMajorInnerRadius;
                public int ScaleLinesMajorOuterRadius;
                public int ScaleLinesMinorInnerRadius;
                public int ScaleLinesMinorOuterRadius;
                public int ScaleNumbersRadius;
            }
        }
    }
}
