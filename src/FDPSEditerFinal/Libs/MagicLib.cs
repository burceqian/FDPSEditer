using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FDPSEditerFinal
{
    public static class MagicLib
    {
        public static MagicInfo[] MagicList1 = new MagicInfo[8];
        public static MagicInfo[] MagicList2 = new MagicInfo[8];
        public static MagicInfo[] MagicList3 = new MagicInfo[8];
        public static MagicInfo[] MagicList4 = new MagicInfo[8];
        public static MagicInfo[] MagicList5 = new MagicInfo[8];

        public static void Initialize()
        {
            string[] MagicInfoList = Properties.ResourceSetting.Magic.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            for (int i = 1; i < MagicInfoList.Length; i++)
            {
                var magicLine = MagicInfoList[i];

                try
                {
                    string[] itemDetail = magicLine.Split(',');
                    if (itemDetail.Length < 4)
                    {
                        continue;
                    }
                    MagicInfo item = new MagicInfo();
                    item.Column = itemDetail[0];
                    item.Code = itemDetail[1];
                    item.Name = itemDetail[2];
                    item.Mp = itemDetail[3];
                    MagicInfo[] MagicList = null;
                    switch (item.Column)
                    {
                        case "1":
                            MagicList = MagicList1;
                            break;
                        case "2":
                            MagicList = MagicList2;
                            break;
                        case "3":
                            MagicList = MagicList3;
                            break;
                        case "4":
                            MagicList = MagicList4;
                            break;
                        case "5":
                            MagicList = MagicList5;
                            break;
                        default:
                            break;
                    }
                    MagicList[int.Parse(item.Code) - 1] = item;
                }
                catch (Exception ex)
                {
                    string exe = ex.ToString();
                }
            }
        }
        public static List<string> GetMagicName(int[] magicCodeList)
        {
            List<string> magicNameList = new List<string>();

            int lMagic1 = magicCodeList[0];
            int lMagic2 = magicCodeList[1];
            int lMagic3 = magicCodeList[2];
            int lMagic4 = magicCodeList[3];
            int lMagic5 = magicCodeList[4];

            string lMagicByte1 = Convert.ToString(lMagic1, 2).PadLeft(8, '0');
            string lMagicByte2 = Convert.ToString(lMagic2, 2).PadLeft(8, '0');
            string lMagicByte3 = Convert.ToString(lMagic3, 2).PadLeft(8, '0');
            string lMagicByte4 = Convert.ToString(lMagic4, 2).PadLeft(8, '0');
            string lMagicByte5 = Convert.ToString(lMagic5, 2).PadLeft(8, '0');

            for (int i = 7; i >= 0; i--)
            {
                if (lMagicByte1.Substring(i, 1) == "1")
                {
                    magicNameList.Add(MagicList1[i].Name);
                }
            }

            for (int i = 7; i >= 0; i--)
            {
                if (lMagicByte2.Substring(i, 1) == "1")
                {
                    magicNameList.Add(MagicList2[i].Name);
                }
            }

            for (int i = 7; i >= 0; i--)
            {
                if (lMagicByte3.Substring(i, 1) == "1")
                {
                    magicNameList.Add(MagicList3[i].Name);
                }
            }

            for (int i = 7; i >= 0; i--)
            {
                if (lMagicByte4.Substring(i, 1) == "1")
                {
                    magicNameList.Add(MagicList4[i].Name);
                }
            }

            for (int i = 7; i >= 0; i--)
            {
                if (lMagicByte5.Substring(i, 1) == "1")
                {
                    magicNameList.Add(MagicList5[i].Name);
                }
            }
            return magicNameList;
        }
        public static string[] GetMagicCode(List<string> magicNameList)
        {
            string[] lMageList = new string[5];

            for (int i = 0; i < 8; i++)
            {
                if (!magicNameList.Contains(MagicList1[i].Name))
                {
                    lMageList[0] += "0";
                }
                else
                {
                    lMageList[0] += "1";
                }
                if (!magicNameList.Contains(MagicList2[i].Name))
                {
                    lMageList[1] += "0";
                }
                else
                {
                    lMageList[1] += "1";
                }
                if (!magicNameList.Contains(MagicList3[i].Name))
                {
                    lMageList[2] += "0";
                }
                else
                {
                    lMageList[2] += "1";
                }
                if (!magicNameList.Contains(MagicList4[i].Name))
                {
                    lMageList[3] += "0";
                }
                else
                {
                    lMageList[3] += "1";
                }
                if (!magicNameList.Contains(MagicList5[i].Name))
                {
                    lMageList[4] += "0";
                }
                else
                {
                    lMageList[4] += "1";
                }
            }

            for (int i = 0; i < 5; i++)
            {
                lMageList[i] = Convert.ToInt32(lMageList[i], 2).ToString();
            }

            return lMageList;
        }
        public static bool WriteOneMagic(string[] magicCodeList, Role role)
        {
            bool WriteSuccess = false;

            MemoryData[] magicInfo = new MemoryData[] { role.M27_法术1, role.M28_法术2, role.M29_法术3, role.M30_法术4, role.M31_法术5 };

            for (int i = 0; i < magicInfo.Length; i++)
            {
                MemoryData magicitem = magicInfo[i];
                string magicCode = magicCodeList[i];
                if (magicCode != magicitem.Value)
                {
                    WriteSuccess = Win32Lib.WriteMemory(magicitem.Address, int.Parse(magicCode), 1);
                    if (WriteSuccess == false)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
