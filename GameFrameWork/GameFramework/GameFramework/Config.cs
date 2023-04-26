using System;
using System.Diagnostics;
using System.Xml;

namespace GameFramework
{
	public class Config
	{
        XmlDocument configDoc = new XmlDocument();

        public void ConfigureFromFile(string filePath)
        {
            configDoc.Load(filePath);

            ConfigureLog();
            ConfigureWorld();
            
            Logger.GetInstance().Log(TraceEventType.Information, "Configuration done: " + DateTime.Now);
        }
    }

    private void ConfigureLog()
    {
        string path = "";

        XmlNode? xNode = configDoc.DocumentElement?.SelectSingleNode("path");

        if (xNode != null)
            path = xNode.InnerText.Trim();


        Logger logger = Logger.CreateInstance(path);
    }

    private void ConfigureWorld()
    {
        int maxX = 0;
        int maxY = 0;

        XmlNode? xNode = configDoc.DocumentElement?.SelectSingleNode("world/maxX");

        if (xNode != null)
            maxX = ConvertInt(xNode);

        XmlNode? yNode = configDoc.DocumentElement?.SelectSingleNode("world/maxY");

        if (yNode != null)
            maxY = ConvertInt(yNode);

        World.SetDefaultValues(maxX, maxY);
    }
}

