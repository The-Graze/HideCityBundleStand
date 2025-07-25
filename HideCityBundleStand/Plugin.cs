using System;
using System.Collections.Generic;
using BepInEx;
using UnityEngine;
using Utilla;

namespace HideCityBundleStand
{
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin
	{
		List<GameObject> DisabledStuff = new();
		void Start()
		{
            GorillaTagger.OnPlayerSpawned(GStart);
		}

        private void GStart()
        {
	    Transform ForestKiosk = GameObject.Find("LocalObjects_Prefab").transform.FindChildRecursive("ForestKiosk_Anchor");
	    DisabledStuff = new()
	    {
                ForestKiosk.transform.FindChildRecursive("gorilla_new").GetChild(2).gameObject,
                ForestKiosk.FindChildRecursive("EndCap_PackSign").gameObject,
                ForestKiosk.FindChildRecursive("EndCap_BackgroundTexture").gameObject,
                ForestKiosk.FindChildRecursive("PurchaseButton").gameObject,
                ForestKiosk.FindChildRecursive("CreatorCodeMonitor").gameObject,
                ForestKiosk.FindChildRecursive("FrontPanel_Center").gameObject,
		ForestKiosk.FindChildRecursive("rig").gameObject,
		ForestKiosk.FindChildRecursive("PalmEnergyBlast_FBX").gameObject,
                ForestKiosk.FindChildRecursive("CloudPants_Wardrobe Variant").gameObject
            };
            foreach (var g in DisabledStuff)
            {
                g.SetActive(false);
            }
        }
    }
}
