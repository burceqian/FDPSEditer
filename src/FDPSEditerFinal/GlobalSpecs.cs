using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDPSEditerFinal
{
    public static class GlobalSpecs
    {
        public static MemorySearchType SearchType;
        public static string RoundCount = "";
        public static Process FDPSProcess = null;
        public static bool NeedReSearch = false;
        public static string SearchStartAddress;
        //public static int BaseStartAddress;
        public static List<string> RoleStartAddress = new List<string>();
        public static List<Role> FriendsRoleList = new List<Role>();
        public static List<Role> EnemyRoleList = new List<Role>();
        public static int StartSearchAddress = 0;
        public static bool TopMost = false;
        public static FrmMain MainForm = null;
        public static string MagicLocationAddress = "";
        private static int _DeveloperMagicCount = 0;
        public static int DeveloperMagicCount {
            set
            {
                if (_DeveloperMagicCount > 5)
                {

                }
                else if (_DeveloperMagicCount == 5)
                {
                    _DeveloperMagicCount += 1;
                    MessageBox.Show("开发者模式开启!"+ Environment.NewLine + "你是怎么知道的？？", "惊奇", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MainForm != null)
                    {
                        MainForm.DeveloperMode();
                        
                    }
                }
                else
                {
                    _DeveloperMagicCount += 1;
                }
            }
        }

        public static void Initialize()
        {
            SettingsLib.Initialize();
            Win32Lib.Initialize();
            MagicLib.Initialize();
        }
    }

    public static class GlobalConst
    {
        public const int AddressForward = 6;
        public const int Acion_Moved = 128; // 已行动
        public const int Acion_nonMoved = 0; // 未行动
        public const int Acion_Dead = 1; // 未轮到
        public const int Item_Equiped = 64; // 已装备
        public const int Item_nonEquiped = 0; // 未装备
        public const int Item_nonState = 128; // 该物品为空
        public const int Item_nonItem= 255;  // 该物品为空
        public static byte[] MagicLocationDataArray = { 56, 64, 28, 0, 204, 72, 28, 0, 96, 81, 28, 0, 244, 89, 28, 0, 136, 98, 28, 0, 28, 107, 28, 0, 176, 115, 28, 0, 68, 124, 28, 0 };
    }

    public enum MemorySearchType
    {
        battle,
        shop
    }
}
