using Silly.Classes;
using Silly.Mods;
using static Silly.Menu.Settings;

namespace Silly.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Safety Mods", method =() => Global.EnterSafety(), isTogglable = false, toolTip = "Takes you to the Safety Mods page."},
                new ButtonInfo { buttonText = "Movement Mods", method =() => Global.MovementMods(), isTogglable = false, toolTip = "Takes you to the Movement Mods page."},
            },

            new ButtonInfo[] { // Movement Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Ghost Monkey", method =() => Movement.GhostMonkey(), toolTip = "Use Right Grab to go invisible and use Left Grab to go back to normal."},
                new ButtonInfo { buttonText = "Platforms", method =() => Movement.Platforms(), toolTip = "Use Right Grab and Left Grab."},
                new ButtonInfo { buttonText = "Size Changer", method =() => Movement.SizeChanger(), toolTip = "Size up with Right Grab and go back to normal with Left Grab."},
                new ButtonInfo { buttonText = "Speedboost", method =() => Movement.Speedboost(), toolTip = "Gives you a speedboost!"},
            },

            new ButtonInfo[] { // Safety Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Disable Joining Rooms", method =() => Safety.DisableRoomJoining(), isTogglable = false, toolTip = "Disables joining rooms."},
                new ButtonInfo { buttonText = "Enable Joining Rooms", method =() => Safety.EnableRoomJoining(), isTogglable = false, toolTip = "Enables joining rooms."},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

            new ButtonInfo[] { // cum shack
                new ButtonInfo { buttonText = "Disconnect", method =() => Global.Disconnect(), isTogglable = false, toolTip = "Disconnects you from the lobby."},
            },
        };
    }
}
