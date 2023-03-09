﻿using System.Globalization;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace $safeprojectname$;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    public static ManualLogSource Log { get; set; }
    public ConfigEntry<string> TestSetting { get; private set; }


    private void Awake()
    {
        Log = Logger;

        TestSetting = Config.Bind("General", nameof(TestSetting), "test", "test description");

        Harmony harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        harmony.PatchAll();

    }

    public static void LogInfo(string text)
    {
        Plugin.Log.LogInfo(text);
    }

    public static string GetGameObjectPath(GameObject obj)
    {
        GameObject searchObject = obj;

        string path = "/" + searchObject.name;
        while (searchObject.transform.parent != null)
        {
            searchObject = searchObject.transform.parent.gameObject;
            path = "/" + searchObject.name + path;
        }
        return path;
    }

}
