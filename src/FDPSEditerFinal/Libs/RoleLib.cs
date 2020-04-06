using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDPSEditerFinal
{
    public static class RoleLib
    {
        #region Set Value
        public static void SetMoved(MemoryData moveItem, RoleMoved moveType)
        {
            if (moveType == RoleMoved.Moved)
            {
                moveItem.HexVal = "0x80";
            }
            else
            {
                moveItem.HexVal = "0x00";
            }
        }
        public static void SetState(MemoryData stateItem, RoleState state)
        {
            if (state == RoleState.has)
            {
                stateItem.HexVal = "0x0b";
            }
            else
            {
                stateItem.HexVal = "0x00";
            }
        }
        public static void SetEquip(MemoryData item, ItemEquip equip)
        {
            if (equip == ItemEquip.Equip)
            {
                item.HexVal = "0x40";
            }
            else
            {
                item.HexVal = "0x00";
            }
        }
        #endregion

        #region Get Value
        public static RoleVecter GetRoleVecter(MemoryData stateItem)
        {
            // 0x0:下 0x1: 左 0x2:上 0x3:右
            switch (stateItem.HexVal)
            {
                case "0x00":
                    return RoleVecter.down;
                case "0x01":
                    return RoleVecter.left;
                case "0x02":
                    return RoleVecter.up;
                case "0x03":
                    return RoleVecter.right;
                default:
                    return RoleVecter.down;
            }
        }
        public static RoleCamp GetCamp(MemoryData camp)
        {
            switch (camp.HexVal.PadLeft(2, '0'))
            {
                case "00":
                    return RoleCamp.Enemy;
                case "01":
                    return RoleCamp.NPC;
                case "02":
                    return RoleCamp.Ally;
                default:
                    return RoleCamp.Enemy;
            }
        }
        public static RoleState GetState(MemoryData stateItem)
        {
            if (stateItem.IntVal == 128)
            {
                return RoleState.has;
            }
            else if (stateItem.IntVal== 0)
            {
                return RoleState.non;
            }
            else
            {
                return RoleState.non;
            }
        }
        public static RoleMoved GetMoved(MemoryData moveItem)
        {
            if (moveItem.HexVal == "0x80")
            {
                return RoleMoved.Moved;
            }
            else if (moveItem.HexVal == "0x00")
            {
                return RoleMoved.NotMove;
            }
            else
            {
                return RoleMoved.NotMove;
            }
        }
        public static ItemEquip GetEquip(MemoryData itemState)
        {
            switch (itemState.HexVal.PadLeft(2,'0'))
            {
                case "00":
                    return ItemEquip.Unequip;
                case "40":
                    return ItemEquip.Equip;
                default:
                    return ItemEquip.Non;
            }
        }
        public static JobInfo GetJob(MemoryData job)
        {
            JobInfo jobInfo = SettingsLib.JobInfoList.FirstOrDefault(item => item.Code.ToLower().PadLeft(2,'0') == job.HexVal);
            return jobInfo;
        }
        public static JobInfo GetJob(string jobName)
        {
            JobInfo jobInfo = SettingsLib.JobInfoList.FirstOrDefault(item => item.Name == jobName);
            return jobInfo;
        }
        public static RaceInfo GetRace(MemoryData race)
        {
            RaceInfo raceInfo = SettingsLib.RaceInfoList.FirstOrDefault(item => item.Code.ToLower().PadLeft(2, '0') == race.HexVal);
            return raceInfo;
        }
        public static RoleNameInfo GetRoleName(MemoryData race)
        {
            RoleNameInfo roleNameInfo = SettingsLib.RoleNameInfoList.FirstOrDefault(item => item.Code.ToLower().PadLeft(2, '0') == race.HexVal);
            return roleNameInfo;
        }
        public static RaceInfo GetRace(string raceName)
        {
            RaceInfo raceInfo = SettingsLib.RaceInfoList.FirstOrDefault(item => item.Name == raceName);
            return raceInfo;
        }
        public static ItemInfo GetItem(MemoryData itemState)
        {
            ItemInfo item = SettingsLib.ItemInfoList.FirstOrDefault(ite => ite.Code.ToLower().PadLeft(2, '0') == itemState.HexVal);

            return item;
        }
        public static ItemInfo GetItem(string itemName)
        {
            ItemInfo item = SettingsLib.ItemInfoList.FirstOrDefault(ite => ite.Name == itemName);

            return item;
        }
        public static Bitmap GetFace(MemoryData face)
        {
            int faceId = face.IntVal + 1;
            Bitmap faceimg = (Bitmap)(Properties.ResourceBigFace.ResourceManager.GetObject("_1_" + faceId));
            return faceimg;
        }
        public static Bitmap[] GetMiniFace(MemoryData face,MemoryData miniface)
        {
            int faceId = face.IntVal;

            int startId = faceId * 12;

            startId += miniface.IntVal * 3 + 1;

            Bitmap minifaceimg1 = (Bitmap)(Properties.ResourceMiniFace.ResourceManager.GetObject("_1_" + startId));
            startId++;
            Bitmap minifaceimg2 = (Bitmap)(Properties.ResourceMiniFace.ResourceManager.GetObject("_1_" + startId));
            startId++;
            Bitmap minifaceimg3 = (Bitmap)(Properties.ResourceMiniFace.ResourceManager.GetObject("_1_" + startId));

            Bitmap[] MiniFaceArray = { minifaceimg1, minifaceimg2,minifaceimg3};

            return MiniFaceArray;
        }
        #endregion
    }

    public enum RoleCamp
    {
        Enemy,
        NPC,
        Ally
    }

    public enum RoleState
    {
        has,
        non
    }

    public enum RoleMoved
    {
        NotMove,
        Moved
    }

    public enum ItemEquip
    {
        Non,
        Equip,
        Unequip
    }

    public enum RoleVecter
    {
        up,
        down,
        left,
        right
    }
}
