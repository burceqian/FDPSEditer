using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDPSEditerFinal
{
    public class Role
    {
        #region Field

        private string _startAddress;
        private List<MemoryData> Items = new List<MemoryData>();

        public string Address { get { return  _startAddress; } }

        public MemoryData M01_X = new MemoryData();
        public MemoryData M02_Y = new MemoryData();
        public MemoryData M03_人物图形 = new MemoryData();
        public MemoryData M04_人物方向 = new MemoryData(); // 0x0:下 0x1: 左 0x2:上 0x3:右
        public MemoryData M05_人物跑动动作 = new MemoryData();
        public MemoryData M06_是否可动 = new MemoryData();  // 0x00:可动 0x80:已动
        public MemoryData M07_人物阵营 = new MemoryData();  // 0x0 敌人 0x1 NPC 0x2 我方
        public MemoryData M08_人物肖像职业 = new MemoryData(); //人物名字
        public MemoryData M09_人物名字 = new MemoryData(); //人物名字(不一定总有，以人物肖像为准)
        public MemoryData M10_未知 = new MemoryData();
        public MemoryData M11_物品1状态 = new MemoryData(); //0x40 装备 0x00 未装备
        public MemoryData M12_物品1 = new MemoryData();
        public MemoryData M13_物品2状态 = new MemoryData(); //0x40 装备 0x00 未装备
        public MemoryData M14_物品2 = new MemoryData();
        public MemoryData M15_物品3状态 = new MemoryData(); //0x40 装备 0x00 未装备
        public MemoryData M16_物品3 = new MemoryData();
        public MemoryData M17_物品4状态 = new MemoryData(); //0x40 装备 0x00 未装备
        public MemoryData M18_物品4 = new MemoryData();
        public MemoryData M19_物品5状态 = new MemoryData(); //0x40 装备 0x00 未装备
        public MemoryData M20_物品5 = new MemoryData();
        public MemoryData M21_物品6状态 = new MemoryData(); //0x40 装备 0x00 未装备
        public MemoryData M22_物品6 = new MemoryData();
        public MemoryData M23_物品7状态 = new MemoryData(); //0x40 装备 0x00 未装备
        public MemoryData M24_物品7 = new MemoryData();
        public MemoryData M25_物品8状态 = new MemoryData(); //0x40 装备 0x00 未装备
        public MemoryData M26_物品8 = new MemoryData();
        //public MemoryDataInfo M99_可控 = new MemoryDataInfo(); // 0x00 可控 0xFF不可控
        public MemoryData M27_法术1 = new MemoryData();
        public MemoryData M28_法术2 = new MemoryData();
        public MemoryData M29_法术3 = new MemoryData();
        public MemoryData M30_法术4 = new MemoryData();
        public MemoryData M31_法术5 = new MemoryData();
        public MemoryData M32_人种 = new MemoryData();
        public MemoryData M33_职业 = new MemoryData();
        public MemoryData M34_等级 = new MemoryData();
        public MemoryData M35_增强AP = new MemoryData();
        public MemoryData M36_增强DP = new MemoryData();
        public MemoryData M37_增强HIT_EV = new MemoryData();
        public MemoryData M38_中毒 = new MemoryData();  // 0x0B 有 0x00 无
        public MemoryData M39_麻痹 = new MemoryData();  // 0x0B 有 0x00 无
        public MemoryData M40_禁咒 = new MemoryData();  // 0x0B 有 0x00 无
        public MemoryData M41_未知15 = new MemoryData();
        public MemoryData M42_基本AP = new MemoryData();
        public MemoryData M43_基本DP = new MemoryData();
        public MemoryData M44_移动 = new MemoryData();
        public MemoryData M45_经验 = new MemoryData();
        public MemoryData M90_未识别 = new MemoryData();
        public MemoryData M46_DX = new MemoryData();
        public MemoryData M47_HP = new MemoryData();
        public MemoryData M48_MaxHP = new MemoryData();
        public MemoryData M49_MP = new MemoryData();
        public MemoryData M50_MaxMp = new MemoryData();
        public MemoryData M51_AP = new MemoryData();
        public MemoryData M52_DP = new MemoryData();
        public MemoryData M53_HIT = new MemoryData();
        public MemoryData M54_EV = new MemoryData();
        #endregion

        public Role(string startAddress)
        {
            _startAddress = startAddress;
            Initilize();
        }
        public void Initilize()
        {
            #region Set Address And OffSet
            IniItem(M01_X, 1);
            IniItem(M02_Y, 1);
            IniItem(M03_人物图形, 1);
            IniItem(M04_人物方向, 1);
            IniItem(M05_人物跑动动作, 1);
            IniItem(M06_是否可动, 1);
            IniItem(M07_人物阵营, 1);
            IniItem(M08_人物肖像职业, 1);
            IniItem(M09_人物名字, 1);
            IniItem(M10_未知, 1);
            IniItem(M11_物品1状态, 1);
            IniItem(M12_物品1, 1);
            IniItem(M13_物品2状态, 1);
            IniItem(M14_物品2, 1);
            IniItem(M15_物品3状态, 1);
            IniItem(M16_物品3, 1);
            IniItem(M17_物品4状态, 1);
            IniItem(M18_物品4, 1);
            IniItem(M19_物品5状态, 1);
            IniItem(M20_物品5, 1);
            IniItem(M21_物品6状态, 1);
            IniItem(M22_物品6, 1);
            IniItem(M23_物品7状态, 1);
            IniItem(M24_物品7, 1);
            IniItem(M25_物品8状态, 1);
            IniItem(M26_物品8, 1);
            //IniItem(M99_可控, 1);
            IniItem(M27_法术1, 1);
            IniItem(M28_法术2, 1);
            IniItem(M29_法术3, 1);
            IniItem(M30_法术4, 1);
            IniItem(M31_法术5, 1);
            IniItem(M32_人种, 1);
            IniItem(M33_职业, 1);
            IniItem(M34_等级, 1);
            IniItem(M35_增强AP, 1);
            IniItem(M36_增强DP, 1);
            IniItem(M37_增强HIT_EV, 1);
            IniItem(M38_中毒, 1);
            IniItem(M39_麻痹, 1);
            IniItem(M40_禁咒, 1);
            IniItem(M41_未知15, 15);
            IniItem(M42_基本AP, 2);
            IniItem(M43_基本DP, 2);
            IniItem(M44_移动, 1);
            IniItem(M45_经验, 1);
            IniItem(M90_未识别, 1);
            IniItem(M46_DX, 2);
            IniItem(M47_HP, 2);
            IniItem(M48_MaxHP, 2);
            IniItem(M49_MP, 2);
            IniItem(M50_MaxMp, 2);
            IniItem(M51_AP, 2);
            IniItem(M52_DP, 2);
            IniItem(M53_HIT, 2);
            IniItem(M54_EV, 2);
            #endregion
            #region Add All Items to List
            Items.Add(M01_X);
            Items.Add(M02_Y);
            Items.Add(M03_人物图形);
            Items.Add(M04_人物方向);
            Items.Add(M05_人物跑动动作);
            Items.Add(M06_是否可动);
            Items.Add(M07_人物阵营);
            Items.Add(M08_人物肖像职业);
            Items.Add(M09_人物名字);
            Items.Add(M10_未知);
            Items.Add(M11_物品1状态);
            Items.Add(M12_物品1);
            Items.Add(M13_物品2状态);
            Items.Add(M14_物品2);
            Items.Add(M15_物品3状态);
            Items.Add(M16_物品3);
            Items.Add(M17_物品4状态);
            Items.Add(M18_物品4);
            Items.Add(M19_物品5状态);
            Items.Add(M20_物品5);
            Items.Add(M21_物品6状态);
            Items.Add(M22_物品6);
            Items.Add(M23_物品7状态);
            Items.Add(M24_物品7);
            Items.Add(M25_物品8状态);
            Items.Add(M26_物品8);
            //AllItem.Add(M99_可控);
            Items.Add(M27_法术1);
            Items.Add(M28_法术2);
            Items.Add(M29_法术3);
            Items.Add(M30_法术4);
            Items.Add(M31_法术5);
            Items.Add(M32_人种);
            Items.Add(M33_职业);
            Items.Add(M34_等级);
            Items.Add(M35_增强AP);
            Items.Add(M36_增强DP);
            Items.Add(M37_增强HIT_EV);
            Items.Add(M38_中毒);
            Items.Add(M39_麻痹);
            Items.Add(M40_禁咒);
            Items.Add(M41_未知15);
            Items.Add(M42_基本AP);
            Items.Add(M43_基本DP);
            Items.Add(M44_移动);
            Items.Add(M45_经验);
            Items.Add(M46_DX);
            Items.Add(M47_HP);
            Items.Add(M48_MaxHP);
            Items.Add(M49_MP);
            Items.Add(M50_MaxMp);
            Items.Add(M51_AP);
            Items.Add(M52_DP);
            Items.Add(M53_HIT);
            Items.Add(M54_EV);

            #endregion
        }
        private int _offSet = 0;
        private void IniItem(MemoryData pItem,int pByteCount)
        {
            if (_offSet != 0)
            {
                pItem.Address = Win32Lib.GetMoveAddress(_startAddress, _offSet);
            }
            else
            {
                pItem.Address = _startAddress;
            }

            pItem.ByteCount = pByteCount;

            _offSet += pByteCount;
        }
        public void FillData()
        {
            foreach (MemoryData item in Items)
            {
                item.Value = Win32Lib.ReadMemory(item.Address, item.ByteCount);
            }
        }
    }

    public class MemoryData
    {
        public string Address;
        public string Value;
        public int IntVal
        {
            get {
                int val = -1;
                if (int.TryParse(Value,out val))
                {
                    return val;
                }
                else
                {
                    return -1;
                }
                //return int.Parse(Value);
            }
            set {
                Value = value.ToString();
            }
        }
        public string HexVal
        {
            get {
                return ComLib.GetHex(IntVal);
            }
            set
            {
                Value = Convert.ToInt32(value, 16).ToString();
            }
        }
        public int ByteCount;
    }
}
