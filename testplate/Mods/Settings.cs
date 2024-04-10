using static Silly.Menu.Main;
using static Silly.Menu.Settings;

namespace Silly.Mods
{
    internal class SettingsMods
    {
        public static void EnterSettings()
        {
            buttonsType = 2;
        }

        public static void MenuSettings()
        {
            buttonsType = 3;
        }

        public static void MovementSettings()
        {
            buttonsType = 4;
        }

        public static void ProjectileSettings()
        {
            buttonsType = 5;
        }

        public static void RightHand()
        {
            rightHanded = true;
        }

        public static void LeftHand()
        {
            rightHanded = false;
        }

        public static void EnableFPSCounter()
        {
            fpsCounter = true;
        }

        public static void DisableFPSCounter()
        {
            fpsCounter = false;
        }

        public static void EnableNotifications()
        {
            disableNotifications = false;
        }

        public static void DisableNotifications()
        {
            disableNotifications = true;
        }

        public static void EnableDisconnectButton()
        {
            disconnectButton = true;
        }

        public static void DisableDisconnectButton()
        {
            disconnectButton = false;
        }
    }
}
