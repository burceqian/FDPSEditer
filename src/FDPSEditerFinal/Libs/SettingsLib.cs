using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FDPSEditerFinal
{
    public static class SettingsLib
    {
        public static List<ItemInfo> ItemInfoList = new List<ItemInfo>();
        public static List<MagicAndJob> MagicAndJobInfoList = new List<MagicAndJob>();
        public static List<JobInfo> JobInfoList = new List<JobInfo>();
        public static List<RaceInfo> RaceInfoList = new List<RaceInfo>();
        public static List<RoleNameInfo> RoleNameInfoList = new List<RoleNameInfo>();
        public static void Initialize()
        {
            #region Item
            string[] itemInfoList = Properties.ResourceSetting.Items.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var itemInfo in itemInfoList)
            {
                try
                {
                    string[] itemDetail = itemInfo.Split('\t');
                    if (itemDetail.Length < 11)
                    {
                        continue;
                    }
                    ItemInfo item = new ItemInfo();
                    item.Name = itemDetail[0];
                    item.Code = itemDetail[1];
                    item.Category = itemDetail[2];
                    item.AP = itemDetail[3];
                    item.DP = itemDetail[4];
                    item.Hit = itemDetail[5];
                    item.EV = itemDetail[6];
                    item.Range = itemDetail[7];
                    item.Exist = itemDetail[8] == "可";
                    item.Price = itemDetail[9];
                    item.Special = itemDetail[10];
                    ItemInfoList.Add(item);
                }
                catch (Exception ex)
                {
                    string exe = ex.ToString();
                }
            }

            ItemInfoList.RemoveAt(0);
            #endregion
            #region MagicAndJob
            string[] magicAndJobInfoList = Properties.ResourceSetting.MagicAndJob.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var magicAndJobInfo in magicAndJobInfoList)
            {
                try
                {
                    string[] itemDetail = magicAndJobInfo.Split('\t');
                    if (itemDetail.Length < 4)
                    {
                        continue;
                    }
                    MagicAndJob item = new MagicAndJob();
                    item.Role = itemDetail[0];
                    item.Type = itemDetail[1];
                    item.Job = itemDetail[2];
                    item.Magic = itemDetail[3].Trim('"');
                    MagicAndJobInfoList.Add(item);
                }
                catch (Exception ex)
                {
                    string exe = ex.ToString();
                }
            }

            MagicAndJobInfoList.RemoveAt(0);
            #endregion
            #region Job
            string[] jobInfoList = Properties.ResourceSetting.Job.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var itemInfo in jobInfoList)
            {
                try
                {
                    string[] itemDetail = itemInfo.Split('\t');
                    if (itemDetail.Length < 2)
                    {
                        continue;
                    }
                    JobInfo item = new JobInfo();
                    item.Code = itemDetail[0];
                    item.Name = itemDetail[1];
                    JobInfoList.Add(item);
                }
                catch (Exception ex)
                {
                    string exe = ex.ToString();
                }
            }

            JobInfoList.RemoveAt(0);
            #endregion
            #region Race
            string[] raceInfoArray = Properties.ResourceSetting.Race.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var itemInfo in raceInfoArray)
            {
                try
                {
                    string[] itemDetail = itemInfo.Split('\t');
                    if (itemDetail.Length < 2)
                    {
                        continue;
                    }
                    RaceInfo item = new RaceInfo();
                    item.Code = itemDetail[0];
                    item.Name = itemDetail[1];
                    RaceInfoList.Add(item);
                }
                catch (Exception ex)
                {
                    string exe = ex.ToString();
                }
            }

            RaceInfoList.RemoveAt(0);
            #endregion
            #region Race
            string[] roleNameInfoArray = Properties.ResourceSetting.Role.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var itemInfo in roleNameInfoArray)
            {
                try
                {
                    string[] itemDetail = itemInfo.Split('\t');
                    if (itemDetail.Length < 3)
                    {
                        continue;
                    }
                    RoleNameInfo item = new RoleNameInfo();
                    item.Code = itemDetail[0];
                    item.Name = itemDetail[1];
                    item.Job = itemDetail[2];
                    RoleNameInfoList.Add(item);
                }
                catch (Exception ex)
                {
                    string exe = ex.ToString();
                }
            }

            RoleNameInfoList.RemoveAt(0);
            #endregion
            #region StartAddress
            //string settingIni = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
            //if (!File.Exists(settingIni))
            //{
            //    List<string> sb = new List<string>();
            //    sb.Add("[Setting]");
            //    //0x11700000
            //    sb.Add("StartSerachAddress=0x00000000");
            //    File.AppendAllLines(settingIni, sb);
            //}

            //IniLib.IniFilePath = settingIni;
            //settingIni = IniLib.IniRead("StartSerachAddress", "Setting");
            //GlobalSpecs.BaseStartAddress = ComLib.GetDec(settingIni);
            #endregion
        }

        //public static void WriteLastAddress(int startAddress)
        //{
        //    string settingIni = IniLib.IniRead("StartSerachAddress", "Setting");
        //    int intSetting = ComLib.GetDec(settingIni);
        //    if (intSetting == 0)
        //    {
        //        //0x11700000
        //        string forwardAddress = ComLib.GetHex(ComLib.GetDec(Win32Lib.GetAddress(startAddress).Substring(0, 3)) - GlobalConst.AddressForward) + "00000";
        //        GlobalSpecs.BaseStartAddress = ComLib.GetDec(forwardAddress);
        //        string baseAddress = "0x" + Win32Lib.GetAddress(GlobalSpecs.BaseStartAddress);
        //        IniLib.IniWrite("StartSerachAddress", baseAddress, "Setting");
        //    }
        //}
    }
}
