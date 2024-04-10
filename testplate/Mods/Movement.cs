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
    internal class Movement
    {
        public static void Speedboost()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 9f;
        }
        public static void SizeChanger()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.Player.Instance.scale += 0.5f;
            }

            if (ControllerInputPoller.instance.leftGrab)
            {
                GorillaLocomotion.Player.Instance.scale = 1f;
            }
        }

        // platform GameObject shit for Platforms Script
        public static GameObject LeftPlat = null;
        public static GameObject RightPlat = null;

        public static void Platforms()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                if (RightPlat == null) 
                {
                    // make right platform
                    RightPlat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    RightPlat.transform.localScale = new Vector3(0.333f, 0.025f, 0.333f);
                    RightPlat.transform.position = GorillaTagger.Instance.rightHandTransform.transform.position;
                    RightPlat.transform.rotation = GorillaTagger.Instance.rightHandTransform.transform.rotation;
                    RightPlat.GetComponent<Renderer>().material.color = Color.magenta;
                }
            }
            else 
            {
                if (RightPlat != null) 
                {
                    // kys right platform
                    Destroy(RightPlat, Time.deltaTime);
                    RightPlat = null;
                }
            }

            if (ControllerInputPoller.instance.leftGrab)
            {
                if (LeftPlat == null) 
                {
                    // make left platform
                    LeftPlat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    LeftPlat.transform.localScale = new Vector3(0.333f, 0.025f, 0.333f);
                    LeftPlat.transform.position = GorillaTagger.Instance.leftHandTransform.transform.position;
                    LeftPlat.transform.rotation = GorillaTagger.Instance.leftHandTransform.transform.rotation;
                    LeftPlat.GetComponent<Renderer>().material.color = Color.magenta;
                }
            }
            else 
            {
                if (LeftPlat != null) 
                {
                    // kys left platform
                    Destroy(LeftPlat, Time.deltaTime);
                    LeftPlat = null;
                }
            }
        }
    }
}
