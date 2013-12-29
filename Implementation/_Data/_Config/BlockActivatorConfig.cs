﻿using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Xml;

namespace Terraria.Plugins.CoderCow.AdvancedCircuits {
  public class BlockActivatorConfig {
    public string TriggerPermission { get; set; }
    public int MaxChangeableBlocks { get; set; }
    public int Cooldown { get; set; }


    public BlockActivatorConfig() {
      this.MaxChangeableBlocks = 100;
      this.Cooldown = 30;
    }

    public static BlockActivatorConfig FromXmlElement(XmlElement xmlData) {
      BlockActivatorConfig resultingBlockActivatorConfig = new BlockActivatorConfig();
      if (xmlData["TriggerPermission"] != null)
        resultingBlockActivatorConfig.TriggerPermission = xmlData["TriggerPermission"].InnerText;
      resultingBlockActivatorConfig.MaxChangeableBlocks = int.Parse(xmlData["MaxChangeableBlocks"].InnerText);
      resultingBlockActivatorConfig.Cooldown = int.Parse(xmlData["Cooldown"].InnerText);

      return resultingBlockActivatorConfig;
    }
  }
}