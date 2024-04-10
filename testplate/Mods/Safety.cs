using BepInEx;
using ExitGames.Client.Photon;
using OculusSampleFramework;
using Photon.Pun;
using Photon.Realtime;
using PlayFab.DataModels;
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;
using static Silly.Classes.RigManager;
using static Silly.Menu.Main;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;
using static UnityEngine.Object;

namespace Silly.Mods
{
    internal class Safety
    {
        public static void DisableRoomJoining()
        {
            GameObject.Find("Environment Objects/TriggerZones_Prefab/").SetActive(false);
        }
        public static void EnableRoomJoining()
        {
            GameObject.Find("Environment Objects/TriggerZones_Prefab/").SetActive(true);
        }
    }
}
