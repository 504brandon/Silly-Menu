using Photon.Pun;
using static Silly.Menu.Main;

namespace Silly.Mods
{
    internal class Global
    {
        public static void Disconnect()
        {
            PhotonNetwork.Disconnect();
        }
        public static void ReturnHome()
        {
            buttonsType = 0;
        }
        public static void MovementMods()
        {
            buttonsType = 1;
        }
        public static void EnterSafety()
        {
            buttonsType = 2;
        }
    }
}
