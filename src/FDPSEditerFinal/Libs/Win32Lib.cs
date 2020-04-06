using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FDPSEditerFinal
{
    public static class Win32Lib
    {
        #region Regist Win API
        public struct MEMORY_BASIC_INFORMATION
        {
            public int BaseAddress;
            public int AllocationBase;
            public int AllocationProtect;
            public int RegionSize;
            public int State;
            public int Protect;
            public int lType;
        }

        private const int MEM_COMMIT = 0x1000;       //已物理分配
        private const int MEM_PRIVATE = 0x20000;
        private const int PAGE_READWRITE = 0x04;     //可读写内存

        [DllImport("kernel32.dll")]     //查询内存块信息
        public static extern int VirtualQueryEx(
            IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, int dwLength);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(
            IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int size, out int numBytesRead);
        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(
            IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int size, out int numBytesWrite);
        #endregion

        static List<int> foundAddressList = new List<int>();
        public static Process ProgramProcess = null;
        public static Action<int> ReportProgress = null;
        public static int[] MagicData = new int[80];
        public static int[] MagicDataShop = new int[38];
        public static int[] MagicDataLandis = new int[15];
        public static int[] MagicDataFalianNa = new int[15];
        public static void Initialize()
        {
            #region MagicData
            MagicData[0] = 42;
            MagicData[1] = 2;
            MagicData[2] = 54;
            MagicData[3] = 2;
            MagicData[4] = 42;
            MagicData[5] = 2;
            MagicData[6] = 42;
            MagicData[7] = 2;
            MagicData[8] = 42;
            MagicData[9] = 2;
            MagicData[10] = 254;
            MagicData[11] = 255;
            MagicData[12] = 195;
            MagicData[13] = 1;
            MagicData[14] = 45;
            MagicData[15] = 2;
            MagicData[16] = 149;
            MagicData[17] = 1;
            MagicData[18] = 36;
            MagicData[19] = 2;
            MagicData[20] = 44;
            MagicData[21] = 0;
            MagicData[22] = 47;
            MagicData[23] = 2;
            MagicData[24] = 79;
            MagicData[25] = 1;
            MagicData[26] = 80;
            MagicData[27] = 1;
            MagicData[28] = 22;
            MagicData[29] = 2;
            MagicData[30] = 162;
            MagicData[31] = 1;
            MagicData[32] = 169;
            MagicData[33] = 1;
            MagicData[34] = 253;
            MagicData[35] = 255;
            MagicData[36] = 255;
            MagicData[37] = 255;
            MagicData[38] = 159;
            MagicData[39] = 1;
            MagicData[40] = 160;
            MagicData[41] = 1;
            MagicData[42] = 178;
            MagicData[43] = 1;
            MagicData[44] = 181;
            MagicData[45] = 1;
            MagicData[46] = 182;
            MagicData[47] = 1;
            MagicData[48] = 55;
            MagicData[49] = 2;
            MagicData[50] = 56;
            MagicData[51] = 2;
            MagicData[52] = 164;
            MagicData[53] = 1;
            MagicData[54] = 169;
            MagicData[55] = 1;
            MagicData[56] = 253;
            MagicData[57] = 255;
            MagicData[58] = 255;
            MagicData[59] = 255;
            MagicData[60] = 178;
            MagicData[61] = 1;
            MagicData[62] = 57;
            MagicData[63] = 2;
            MagicData[64] = 58;
            MagicData[65] = 2;
            MagicData[66] = 78;
            MagicData[67] = 1;
            MagicData[68] = 59;
            MagicData[69] = 2;
            MagicData[70] = 169;
            MagicData[71] = 1;
            MagicData[72] = 255;
            MagicData[73] = 255;
            MagicData[74] = 0;
            MagicData[75] = 0;
            MagicData[76] = 5;
            MagicData[77] = 30;
            MagicData[78] = 0;
            MagicData[79] = 0;
            #endregion
            #region MagicDataShop
            MagicDataShop[0] = 114;
            MagicDataShop[1] = 115;
            MagicDataShop[2] = 255;
            MagicDataShop[3] = 255;
            MagicDataShop[4] = 255;
            MagicDataShop[5] = 255;
            MagicDataShop[6] = 255;
            MagicDataShop[7] = 255;
            MagicDataShop[8] = 181;
            MagicDataShop[9] = 183;
            MagicDataShop[10] = 255;
            MagicDataShop[11] = 255;
            MagicDataShop[12] = 255;
            MagicDataShop[13] = 255;
            MagicDataShop[14] = 255;
            MagicDataShop[15] = 255;
            MagicDataShop[16] = 255;
            MagicDataShop[17] = 255;
            MagicDataShop[18] = 255;
            MagicDataShop[19] = 255;
            MagicDataShop[20] = 56;
            MagicDataShop[21] = 0;
            MagicDataShop[22] = 0;
            MagicDataShop[23] = 0;
            MagicDataShop[24] = 40;
            MagicDataShop[25] = 32;
            MagicDataShop[26] = 20;
            MagicDataShop[27] = 0;
            MagicDataShop[28] = 132;
            MagicDataShop[29] = 44;
            MagicDataShop[30] = 20;
            MagicDataShop[31] = 0;
            MagicDataShop[32] = 84;
            MagicDataShop[33] = 82;
            MagicDataShop[34] = 65;
            MagicDataShop[35] = 83;
            MagicDataShop[36] = 78;
            MagicDataShop[37] = 68;
            #endregion
            #region MagicDataLandis
            MagicDataLandis[0] = 0;
            MagicDataLandis[1] = 0;
            MagicDataLandis[2] = 0;
            MagicDataLandis[3] = 0;
            MagicDataLandis[4] = 0;
            MagicDataLandis[5] = 0;
            MagicDataLandis[6] = 67;
            MagicDataLandis[7] = 114;
            MagicDataLandis[8] = 101;
            MagicDataLandis[9] = 255;
            MagicDataLandis[10] = 116;
            MagicDataLandis[11] = 105;
            MagicDataLandis[12] = 118;
            MagicDataLandis[13] = 101;
            MagicDataLandis[14] = 32;
            #endregion
            #region MagicDataFalianNa
            MagicDataFalianNa[0] = 0;
            MagicDataFalianNa[1] = 0;
            MagicDataFalianNa[2] = 0;
            MagicDataFalianNa[3] = 0;
            MagicDataFalianNa[4] = 0;
            MagicDataFalianNa[5] = 0;
            MagicDataFalianNa[6] = 0;
            MagicDataFalianNa[7] = 0;
            MagicDataFalianNa[8] = 0;
            MagicDataFalianNa[9] = 255;
            MagicDataFalianNa[10] = 25;
            MagicDataFalianNa[11] = 0;
            MagicDataFalianNa[12] = 0;
            MagicDataFalianNa[13] = 0;
            MagicDataFalianNa[14] = 0;

            #endregion
        }
        public static int SearchMemory(int[] sampleData,int typeOfByte,int offset)
        {
            foundAddressList.Clear();

            //UpdateSearchType();

            int baseAddr = 0;// GlobalSpecs.BaseStartAddress; // 初始地址
            MEMORY_BASIC_INFORMATION mbi = new MEMORY_BASIC_INFORMATION();
            int searchLen = Marshal.SizeOf(mbi); // 寻找长度
            int readSize = 0;      //实际读取字节数
            int progressVal = 0;
            int progressValOld = 0;
            int[] memoryData = new int[sampleData.Length];
            List<int> matchAddress = new List<int>();
            int result = -1;
            int count = 0;

            //baseAddr = 0x11400000;

            int Subcount = 0;
            while (baseAddr >= 0 && baseAddr <= 0x7fffffff && mbi.RegionSize >= 0)
            {
                //nBaseAddr >= 0 在这期间nBaseAddr 可能溢出int范围变成负数
                progressVal = (int)((double)baseAddr / 0x7FFFFFFF * 100);
                if (progressVal > progressValOld)
                {
                    progressValOld = progressVal;
                    ReportProgress?.Invoke(progressVal);
                }

                searchLen = VirtualQueryEx(ProgramProcess.Handle, (IntPtr)baseAddr, out mbi, Marshal.SizeOf(mbi));  //扫描内存信息 
                if (searchLen == Marshal.SizeOf(typeof(MEMORY_BASIC_INFORMATION)))
                {
                    count += 1;
                    if (mbi.State == MEM_COMMIT && mbi.Protect == PAGE_READWRITE)
                    {     
                        //如果是已物理分配 并且是 可读写内存 那么读取内存
                        byte[] byData = new byte[mbi.RegionSize];
                        if (ReadProcessMemory(ProgramProcess.Handle, (IntPtr)baseAddr, byData, mbi.RegionSize, out readSize))
                        {
                            if (readSize == mbi.RegionSize)
                            {
                                for (int i = 0, len = byData.Length - typeOfByte; i < len; i += typeOfByte)
                                {
                                    int num = GetData(byData, i, typeOfByte);
                                    AddData(memoryData, num);
                                    if (CompareData(memoryData,sampleData))
                                    {
                                        result = CheckAddress(baseAddr + i, sampleData, typeOfByte, offset);
                                        if (result != -1)
                                        {
                                            break;
                                        }
                                    }

                                    Subcount += 1;
                                }
                            }
                        }
                    }
                }
                if (result != -1)
                {
                    break;
                }

                baseAddr += mbi.RegionSize;      //设置基地址偏移
            }

            //if (result != -1)
            //{
            //    SettingsLib.WriteLastAddress(result);
            //}

            return result;
        }
        private static int CheckAddress(int address, int[] sampleData, int typeOfByte, int offset)
        {
            int result = -1;
            
            result = address;
            result = result - (sampleData.Length - 1) * typeOfByte;
            result += offset;
            if (IsCorrectStartAddress(GetAddress(result)) && LogicCheckStartAddress(GetAddress(result)))
            {
                foundAddressList.Add(result);

                //if (GlobalSpecs.SearchType == MemorySearchType.shop && foundAddressList.Count == 1)
                //{
                //    return result;
                //}
                //else if(foundAddressList.Count > 1)
                //{
                //    return foundAddressList[2];
                //}
                return result;
            }

            return -1;
        }
        private static int CheckAddress_bak(int address, int[] sampleData, int offset)
        {
            int result = -1;
            int CatchCnt = GlobalSpecs.SearchType == MemorySearchType.battle ? 2 : 1;
            result = address;
            result = result - (sampleData.Length - 1);
            result += offset;
            if (IsCorrectStartAddress(GetAddress(result)))
            {
                //foundCnt += 1;
                //if (foundCnt == CatchCnt)
                //{
                //    return result;
                //}
            }

            return -1;
        }
        public static string ReadMemory(string pAddress, int pOffset)
        {
            int numBytesRead = 0;
            byte[] byRead = new byte[pOffset];
            long num;
            if (ReadProcessMemory(ProgramProcess.Handle, (IntPtr)Convert.ToInt32(pAddress, 16), byRead, pOffset, out numBytesRead))
            {
                if (numBytesRead == pOffset)
                {
                    num = byRead[pOffset - 1];
                    for (int j = pOffset, k = 2; j > 1; j--, k++)
                    {
                        num = num << 8;
                        num = num | byRead[pOffset - k];
                    }
                    return num.ToString();
                }
            }
            return "";
        }

        public static byte[] ReadMemoryGetArray(string pAddress, int pOffset)
        {
            int numBytesRead = 0;
            byte[] byRead = new byte[pOffset];
            if (ReadProcessMemory(ProgramProcess.Handle, (IntPtr)Convert.ToInt32(pAddress, 16), byRead, pOffset, out numBytesRead))
            {
                if (numBytesRead == pOffset)
                {
                    return byRead;
                }
            }
            return null;
        }

        public static bool WriteMemory(string pAddress, int intval, int pOffset)
        {
            byte[] byWrite = new byte[pOffset];
            long numWrite = Convert.ToInt64(intval.ToString());
            int numAddr = Convert.ToInt32(pAddress, 16);
            int numWriteSize = 0;
            //将数据写入byte数组中
            for (int i = 0; i < pOffset; i++)
            {
                byWrite[i] = (byte)((numWrite & (0x00000000000000FF << i * 8)) >> i * 8);
            }
            if (WriteProcessMemory(ProgramProcess.Handle, (IntPtr)numAddr, byWrite, pOffset, out numWriteSize))
            {
                if (numWriteSize == pOffset)      //如果和实际写入字节数一样提示成功
                    return true;
            }
            return false;
        }
        public static List<string> GetAllRoleByStartAddress(string pAddress)
        {
            List<string> RoleList = new List<string>();
            while (IsCorrectStartAddress(pAddress))
            {
                RoleList.Add(pAddress);
                pAddress = GetMoveAddress(pAddress, 80);
            }

            return RoleList;
        }
        public static bool IsCorrectStartAddress(string pAddress)
        {
            Role role = new Role(pAddress);
            role.FillData();

            if (role.M01_X.IntVal == 0 &&
                role.M02_Y.IntVal == 0 &&
                role.M06_是否可动.IntVal == 0 &&
                role.M48_MaxHP.IntVal == 0 &&
                role.M34_等级.IntVal == 0 &&
                role.M44_移动.IntVal == 0 &&
                role.M53_HIT.IntVal == 0 &&
                role.M54_EV.IntVal == 0)
            {
                return false;
            }

            if (role.M06_是否可动.IntVal != GlobalConst.Acion_Moved &&
                role.M06_是否可动.IntVal != GlobalConst.Acion_nonMoved &&
                role.M06_是否可动.IntVal != GlobalConst.Acion_Dead)
            {
                return false;
            }

            if (GlobalSpecs.SearchType == MemorySearchType.battle)
            {
                if (role.M01_X.IntVal > 80 ||
                    role.M02_Y.IntVal > 80)
                {
                    return false;
                }
                if (role.M07_人物阵营.IntVal > 2)
                {
                    return false;
                }
                if (role.M04_人物方向.IntVal != 0 &&
                    role.M04_人物方向.IntVal != 1 &&
                    role.M04_人物方向.IntVal != 2 &&
                    role.M04_人物方向.IntVal != 3)
                {
                    return false;
                }
                if (role.M06_是否可动.IntVal != GlobalConst.Acion_Moved &&
                    role.M06_是否可动.IntVal != GlobalConst.Acion_nonMoved &&
                    role.M06_是否可动.IntVal != GlobalConst.Acion_Dead)
                {
                    return false;
                }
            }

            return true;
        }
        public static bool LogicCheckStartAddress(string pAddress)
        {
            var AllRoleListAddress = GetAllRoleByStartAddress(pAddress);
            List<Role> friendsRoleList = new List<Role>();
            List<Role> enemyRoleList = new List<Role>();

            for (int i = 0; i < AllRoleListAddress.Count; i++)
            {
                Role role = new Role(AllRoleListAddress[i]);
                role.FillData();

                if (role.M48_MaxHP.IntVal == 0 ||
                    role.M34_等级.IntVal == 0 ||
                    role.M44_移动.IntVal == 0 ||
                    role.M53_HIT.IntVal == 0 ||
                    role.M54_EV.IntVal == 0)
                {
                    continue;
                }

                if (role.M07_人物阵营.IntVal == 0)
                {
                    enemyRoleList.Add(role);
                }
                else
                {
                    friendsRoleList.Add(role);
                }
            }

            if (GlobalSpecs.SearchType == MemorySearchType.battle && enemyRoleList.Count == 0)
            {
                return false;
            }

            if (GlobalSpecs.SearchType == MemorySearchType.shop && enemyRoleList.Count != 0)
            {
                return false;
            }

            return true;
        }
        public static void UpdateSearchType()
        {
            string baseAddress = "11000D08";

            for (int i = 0; i < 1000; i++)
            {
                baseAddress = GetMoveAddress(baseAddress, 65536);
                if (CheckMagicLocationAddress(baseAddress))
                {
                    GlobalSpecs.MagicLocationAddress = baseAddress;
                    break;
                }
            }




            //string add = "11850D50";
            //byte[] aa = Win32Lib.ReadMemoryGetArray(add, 32);
            //List<string> result = new List<string>();
            //for (int i = 0; i < 32; i++)
            //{
            //    result.Add(ComLib.GetHex(aa[i]));
            //}


            ////if (GlobalSpecs.MagicLocationAddress == "")
            ////{
            //string baseMagciLocationAddress = "0x11050D08";
            //    const int step = 4194304;
            //    for (int i = 0; i < 20; i++)
            //    {
            //        baseMagciLocationAddress = GetMoveAddress(baseMagciLocationAddress, step);
            //        if (CheckMagicLocationAddress(baseMagciLocationAddress))
            //        {
            //            GlobalSpecs.MagicLocationAddress = baseMagciLocationAddress;
            //            break;
            //        }
            //    }
            ////}

            //if (GlobalSpecs.MagicLocationAddress == "")
            //{
            //    foreach (var address in GlobalConst.MagicLocationAddressArray)
            //    {
            //        if (CheckMagicLocationAddress(address))
            //        {
            //            GlobalSpecs.MagicLocationAddress = address;
            //            break;
            //        }
            //    }
            //}

            if (GlobalSpecs.MagicLocationAddress == "")
            {
                return;
            }

            string MagciAddress = GlobalSpecs.MagicLocationAddress;
            string roundCount = ReadMemory(MagciAddress, 1);
            GlobalSpecs.RoundCount = roundCount;

            GlobalSpecs.SearchType = GetSearchType(MagciAddress);

            //if (roundCount == "0")
            //{
            //    GlobalSpecs.SearchType = MemorySearchType.shop;
            //}
            //else
            //{
            //    GlobalSpecs.SearchType = MemorySearchType.battle;
            //}
        }

        private static MemorySearchType GetSearchType(string baseAddress)
        {
            if (GlobalSpecs.RoundCount == "0")
            {
                return MemorySearchType.shop;
            }

            byte[] magicbyte1 = ReadMemoryGetArray(GetMoveAddress(baseAddress, 9552), 4);
            byte[] magicbyte2 = ReadMemoryGetArray(GetMoveAddress(baseAddress, 9696), 4);

            for (int i = 0; i < magicbyte1.Length; i++)
            {
                if (magicbyte1[i]!=0)
                {
                    return MemorySearchType.battle;
                }
            }

            for (int i = 0; i < magicbyte2.Length; i++)
            {
                if (magicbyte2[i] != 0)
                {
                    return MemorySearchType.battle;
                }
            }

            return MemorySearchType.shop;


            //int battleX = 0;
            //int battleY = 0;
            //int cmpX = 0;
            //int cmpY = 0;

            //battleY = int.Parse(ReadMemory(GetMoveAddress(baseAddress, -28), 1));
            //battleX = int.Parse(ReadMemory(GetMoveAddress(baseAddress, -20), 1));
            //cmpX = int.Parse(ReadMemory(GetMoveAddress(baseAddress, 9768), 1));
            //cmpY = int.Parse(ReadMemory(GetMoveAddress(baseAddress, 9772), 1));

            //if (battleX == cmpX && battleY == cmpY)
            //{
            //    return MemorySearchType.battle;
            //}
            //else
            //{
            //    return MemorySearchType.shop;
            //}

        }

        private static bool CheckMagicLocationAddress(string locationAddress)
        {
            string magicDataAddress = GetMoveAddress(locationAddress, +72);

            byte[] magicdata = ReadMemoryGetArray(magicDataAddress, 32);

            if (magicdata == null)
            {
                return false;
            }

            for (int i = 0; i < GlobalConst.MagicLocationDataArray.Length; i++)
            {
                if (GlobalConst.MagicLocationDataArray[i] != magicdata[i])
                {
                    return false;
                }
            }
            return true;
       }

        #region support methods
        private static void AddData(int[] memoryData, int num)
        {
            for (int i = memoryData.Length - 1; i > 0; i--)
            {
                memoryData[i] = memoryData[i - 1];
            }
            memoryData[0] = num;
        }
        private static bool CompareData(int[] memoryData, int[] sampleDat)
        {
            for (int i = 0; i < sampleDat.Length; i++)
            {
                if (memoryData[sampleDat.Length - i - 1] != sampleDat[i])
                {
                    return false;
                }
            }

            return true;
        }
        private static int GetData(byte[] byData,int cnt, int typeOfByte)
        {
            int num = byData[cnt + typeOfByte - 1];
            if (typeOfByte == 2)
            {
                num = num << 8;
                num = num | byData[cnt];
            }
            return num;
        }
        public static string GetMoveAddress(string pAddress, int pMove)
        {
            int x = Convert.ToInt32(pAddress, 16) + pMove;
            return x.ToString("x");
        }
        public static string GetAddress(int address)
        {
            int aa = address;
            string bb = aa.ToString("X").PadLeft(8, '0');
            return bb;
        }
        #endregion
    }
}
