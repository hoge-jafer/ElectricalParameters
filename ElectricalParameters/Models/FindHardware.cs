using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalParameters.Models
{
    public class FindHardware
    {
        public int Id { get; set; }
        //硬件类别
        public string HardwareCategory { get; set; }
        //硬件名称
        public string HardwareName { get; set; }
        //显卡芯片
        public string GraphicsChip { get; set; }
        //核心频率
        public string CoreFrequency { get; set; }
        //显存频率
        public int MemoryFrequency { get; set; }
        //显存类型
        public int VideoMemoryType { get; set; }
        //显存
        public string AvailableMemory { get; set; }
        //分辨率
        public string Res { get; set; }
        //硬件图片
        public string HardwareImage { get; set; }
    }
    public class FindHardwareManager
    {
        public static void GetHardware(string hardwarecategory, ObservableCollection<FindHardware> Hardwares)
        {
            var allHardware= gethardware();
            var filteredHardware = allHardware.Where(p => p.HardwareCategory == hardwarecategory).ToList();
            Hardwares.Clear();
            filteredHardware.ForEach(p => Hardwares.Add(p));
        }
        public static List<FindHardware> gethardware()
        {
            var hardwares = new List<FindHardware>();

            hardwares.Add(new FindHardware (){
                Id=1,
                HardwareCategory="asus",
                HardwareName= "华硕GTX 980Ti-6GD5",
                GraphicsChip= "GeForce GTX 980Ti ",
                CoreFrequency= "1000/1075",
                MemoryFrequency=7010,
                VideoMemoryType= 5,
                AvailableMemory= "6144",
                Res= "4096*2160",
                HardwareImage="/Images/HardwareImage/VideoCard/Asus/980.jpg"
            });

            hardwares.Add(new FindHardware()
            {
                Id = 2,
                HardwareCategory = "gigabyte",
                HardwareName = "GV-N98TXTREME C-6GD",
                GraphicsChip = "GeForce GTX 980Ti ",
                CoreFrequency = "1000/1075",
                MemoryFrequency = 7200,
                VideoMemoryType = 5,
                AvailableMemory = "6144",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Gigabyte/ceJzF5oAgacwQ.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 3,
                HardwareCategory = "gigabyte",
                HardwareName = "GV-N1060 XTREME-6GD",
                GraphicsChip = "GeForce GTX 1060",
                CoreFrequency = "1620/1847",
                MemoryFrequency = 8164,
                VideoMemoryType = 5,
                AvailableMemory = "6144",
                Res = "7680*4320",
                HardwareImage = "/Images/HardwareImage/VideoCard/Gigabyte/ceTy8SN504PFs.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 4,
                HardwareCategory = "msi",
                HardwareName = "GTX 1070 GAMING X 8G",
                GraphicsChip = "GeForce GTX 1070",
                CoreFrequency = "1582/1771",
                MemoryFrequency = 8108,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "7680*4320",
                HardwareImage = "/Images/HardwareImage/VideoCard/MSI/ceHRA7TfUfd6.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 4,
                HardwareCategory = "sapphiretech",
                HardwareName = "Radeon RX 460 4G D5",
                GraphicsChip = "Radeon RX 460",
                CoreFrequency = "1250",
                MemoryFrequency = 7000,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "3840*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Sapphiretech/ceCjyoc4kU4nY.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 5,
                HardwareCategory = "colorful",
                HardwareName = "烈焰战神X-8GD5X Top",
                GraphicsChip = "GeForce GTX 1080",
                CoreFrequency = "1607/1847",
                MemoryFrequency = 10010,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "7680*4320",
                HardwareImage = "/Images/HardwareImage/VideoCard/Colorful/ceZ0ePVvQqe6.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 6,
                HardwareCategory = "colorful",
                HardwareName = "烈焰战神U-4GD5",
                GraphicsChip = "GeForce GTX 960",
                CoreFrequency = "1203/1266",
                MemoryFrequency = 7010,
                VideoMemoryType = 5,
                AvailableMemory = "4096",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Colorful/cedTvYPE6uyZM.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 7,
                HardwareCategory = "colorful",
                HardwareName = "烈焰战神U-2GD5",
                GraphicsChip = "GeForce GTX 950",
                CoreFrequency = "1026/1140",
                MemoryFrequency = 6600,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Colorful/ced8IWIBESvc.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 8,
                HardwareCategory = "colorful",
                HardwareName = "烈焰战神U-4GD5",
                GraphicsChip = "GeForce GTX 970",
                CoreFrequency = "1051/1127",
                MemoryFrequency = 7010,
                VideoMemoryType = 5,
                AvailableMemory = "4096",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Colorful/ce4vJJThmAzw.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 9,
                HardwareCategory = "colorful",
                HardwareName = "烈焰战神U-Twin-1GD5",
                GraphicsChip = "GeForce GTX 750",
                CoreFrequency = "1020/1098",
                MemoryFrequency = 5000,
                VideoMemoryType = 5,
                AvailableMemory = "1024",
                Res = "2560*1600",
                HardwareImage = "/Images/HardwareImage/VideoCard/Colorful/ce9l5lmzqJoc.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 10,
                HardwareCategory = "colorful",
                HardwareName = "烈焰战神S-8GD5",
                GraphicsChip = "GeForce GTX 1070",
                CoreFrequency = "1531/1721",
                MemoryFrequency = 8008,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "7680*4320",
                HardwareImage = "/Images/HardwareImage/VideoCard/Colorful/cep9gSM4jFR82.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 11,
                HardwareCategory = "galaxytechnology",
                HardwareName = "GTX 750Ti大将",
                GraphicsChip = "GeForce GTX 750Ti",
                CoreFrequency = "1110/1189",
                MemoryFrequency = 5400,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Galaytechnology/cefiRsYywz0Pg.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 12,
                HardwareCategory = "galaxytechnology",
                HardwareName = "GAMER 6GB",
                GraphicsChip = "GeForce GTX 1060",
                CoreFrequency = "1556/1771",
                MemoryFrequency = 8000,
                VideoMemoryType = 5,
                AvailableMemory = "6144",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Galaytechnology/cebZGa7LM44uI.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 13,
                HardwareCategory = "galaxytechnology",
                HardwareName = "GTX 950黑将",
                GraphicsChip = "GeForce GTX 950",
                CoreFrequency = "1165/1355",
                MemoryFrequency = 6696,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Galaytechnology/ceL0Q676QKWs.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 14,
                HardwareCategory = "galaxytechnology",
                HardwareName = "GTX 750黑将",
                GraphicsChip = "GeForce GTX 750",
                CoreFrequency = "110/1189",
                MemoryFrequency = 5000,
                VideoMemoryType = 5,
                AvailableMemory = "1024",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Galaytechnology/ceEHVbReuKwT2.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 15,
                HardwareCategory = "galaxytechnology",//
                HardwareName = "GTX 1060名人堂限量版",
                GraphicsChip = "GeForce GTX 1060",
                CoreFrequency = "1620/1847",
                MemoryFrequency = 8000,
                VideoMemoryType = 5,
                AvailableMemory = "6144",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Galaytechnology/ceG7901kqUux6.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 16,
                HardwareCategory = "zotac",
                HardwareName = "GTX 1060-6GD5 X-Gaming OC",
                GraphicsChip = "GeForce GTX 1060",
                CoreFrequency = "1569/1784",
                MemoryFrequency = 8008,
                VideoMemoryType = 5,
                AvailableMemory = "6144",
                Res = "暂无",
                HardwareImage = "/Images/HardwareImage/VideoCard/Zotac/cem6nTr9gUdBU.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 17,
                HardwareCategory = "zotac",
                HardwareName = "GTX 1070-8GD5 X-Gaming",
                GraphicsChip = "GeForce GTX 1070",
                CoreFrequency = "1531/1721",
                MemoryFrequency = 8008,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "暂无",
                HardwareImage = "/Images/HardwareImage/VideoCard/Zotac/cewRG76O91ooQ.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 18,
                HardwareCategory = "zotac",
                HardwareName = "GTX 950-2GD5 X Gaming OC",
                GraphicsChip = "GeForce GTX 950",
                CoreFrequency = "1114/1304",
                MemoryFrequency = 6610,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "5120*3200",
                HardwareImage = "/Images/HardwareImage/VideoCard/Zotac/ceUaoZQxSrvIE.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 19,
                HardwareCategory = "zotac",
                HardwareName = "GTX 950-2GD5 GAME HA",
                GraphicsChip = "GeForce GTX 950",
                CoreFrequency = "1203/1405",
                MemoryFrequency = 7010,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "5120*3200",
                HardwareImage = "/Images/HardwareImage/VideoCard/Zotac/ceaOclb8bIS4c.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 20,
                HardwareCategory = "zotac",
                HardwareName = "1070-8GD5 玩家力量至尊OC",
                GraphicsChip = "GeForce GTX 1070",
                CoreFrequency = "1594/1784",
                MemoryFrequency = 8058,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "暂无",
                HardwareImage = "/Images/HardwareImage/VideoCard/Zotac/ceegntFFkymU.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 21,
                HardwareCategory = "msi",
                HardwareName = "GTX 1060 GAMING X 6G",
                GraphicsChip = "GeForce GTX 1060",
                CoreFrequency = "1506/1809",
                MemoryFrequency = 8000,
                VideoMemoryType = 5,
                AvailableMemory = "6144",
                Res = "7680*4320",
                HardwareImage = "/Images/HardwareImage/VideoCard/MSI/celkWRFkP9Ss.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 22,
                HardwareCategory = "msi",
                HardwareName = "GTX 960 GAMING 2G",
                GraphicsChip = "GeForce GTX 960",
                CoreFrequency = "1216/1279",
                MemoryFrequency = 7010,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/MSI/ceTl3QZiiYPJo.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 23,
                HardwareCategory = "msi",
                HardwareName = "GTX 970 GAMING 4G",
                GraphicsChip = "GeForce GTX 970",
                CoreFrequency = "1140/1279",
                MemoryFrequency = 7010,
                VideoMemoryType = 5,
                AvailableMemory = "4096",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/MSI/ceMESi9SQcHQ.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 24,
                HardwareCategory = "msi",
                HardwareName = "N750TI GAMING 2G",
                GraphicsChip = "GeForce GTX 750Ti",
                CoreFrequency = "1085/1163",
                MemoryFrequency = 5400,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "2560*1600",
                HardwareImage = "/Images/HardwareImage/VideoCard/MSI/ce094lct4jU2.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 25,
                HardwareCategory = "msi",
                HardwareName = "GTX 980 GAMING 4G",
                GraphicsChip = "GeForce GTX 980",
                CoreFrequency = "1216/1317",
                MemoryFrequency = 7010,
                VideoMemoryType = 5,
                AvailableMemory = "4096",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/MSI/ce1TZ2DVb4AY.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 26,
                HardwareCategory = "sapphiretech",
                HardwareName = "RX 480 8G D5 超白金 OC",
                GraphicsChip = "Radeon RX 480",
                CoreFrequency = "1266/1342",
                MemoryFrequency = 8000,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "3840*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Sapphiretech/ceCmEPSzJ6vA.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 27,
                HardwareCategory = "sapphiretech",
                HardwareName = "FURY 4GB HBM Tri-X OC超白金",
                GraphicsChip = "Radeon R9 FURY",
                CoreFrequency = "1050",
                MemoryFrequency = 1000,
                VideoMemoryType = 5,
                AvailableMemory = "4096",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Sapphiretech/ceWqObHCV4a7.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 28,
                HardwareCategory = "sapphiretech",
                HardwareName = "RX 460 2G D5 白金版 OC",
                GraphicsChip = "Radeon RX 460",
                CoreFrequency = "1200",
                MemoryFrequency = 7000,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "3840*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Sapphiretech/ceEYyp7qTtcyY.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 29,
                HardwareCategory = "sapphiretech",
                HardwareName = "R9 390 8G D5 超白金 OC",
                GraphicsChip = "Radeon R9 390",
                CoreFrequency = "1060",
                MemoryFrequency = 6000,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Sapphiretech/cebuLcdtxidM6.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 30,
                HardwareCategory = "sapphiretech",
                HardwareName = "270X 2G GDDR5 With Boost",
                GraphicsChip = "Radeon R9 270X",
                CoreFrequency = "1100/1150",
                MemoryFrequency = 7000,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "2560*1600",
                HardwareImage = "/Images/HardwareImage/VideoCard/Sapphiretech/ce6HZBkWrswpc.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 31,
                HardwareCategory = "gigabyte",
                HardwareName = "GV-N1060G1 GAMING-6GD",
                GraphicsChip = "GeForce GTX 1060",
                CoreFrequency = "1594/1847",
                MemoryFrequency = 8008,
                VideoMemoryType = 5,
                AvailableMemory = "6144",
                Res = "7680*4320",
                HardwareImage = "/Images/HardwareImage/VideoCard/Gigabyte/ceuk3108QALtc.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 32,
                HardwareCategory = "gigabyte",
                HardwareName = "GV-N1080 G1 GAMING-8GD",
                GraphicsChip = "GeForce GTX 1080",
                CoreFrequency = "1695/183",
                MemoryFrequency = 10010,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "7680*4320",
                HardwareImage = "/Images/HardwareImage/VideoCard/Gigabyte/ce0xzBlYqZBcI.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 33,
                HardwareCategory = "gigabyte",
                HardwareName = "GV-N75TOC-2GI",
                GraphicsChip = "GeForce GTX 750Ti",
                CoreFrequency = "1033/1111",
                MemoryFrequency = 5400,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Gigabyte/ceqf0tbZz0Aik.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 34,
                HardwareCategory = "gigabyte",
                HardwareName = "GV-N970WF3OC-4GD",
                GraphicsChip = "GeForce GTX 970",
                CoreFrequency = "1114/1253",
                MemoryFrequency = 7000,
                VideoMemoryType = 5,
                AvailableMemory = "4096",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Gigabyte/ce9ity940Hy6.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 35,
                HardwareCategory = "gigabyte",
                HardwareName = "GV-N1080 XTREME-8GD Premium pack",
                GraphicsChip = "GeForce GTX 1080",
                CoreFrequency = "1759/1898",
                MemoryFrequency = 10416,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "7680*4320",
                HardwareImage = "/Images/HardwareImage/VideoCard/Gigabyte/ce3avZzfjleuY.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 36,
                HardwareCategory = "asus",
                HardwareName = "GTX 1080-8G",
                GraphicsChip = "GeForce GTX 1080",
                CoreFrequency = "1607/1733",
                MemoryFrequency = 10000,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "5120*3200",
                HardwareImage = "/Images/HardwareImage/VideoCard/Asus/cepZVRJ01FqHA.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 37,
                HardwareCategory = "asus",
                HardwareName = "STRIX-GTX 960-DC2OC-2GD5",
                GraphicsChip = "GeForce GTX 960",
                CoreFrequency = "1317/1253",
                MemoryFrequency = 7200,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Asus/ceCWG01rZnAX2.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 38,
                HardwareCategory = "asus",
                HardwareName = "圣骑士GTX 750Ti-OC-2GD5",
                GraphicsChip = "GeForce GTX 750Ti",
                CoreFrequency = "1072/1150",
                MemoryFrequency = 5400,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "2560*1600",
                HardwareImage = "/Images/HardwareImage/VideoCard/Asus/ce9tKVpKYKGQ.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 39,
                HardwareCategory = "asus",
                HardwareName = "STRIX-GTX 970-DC2OC-4GD5",
                GraphicsChip = "GeForce GTX 970",
                CoreFrequency = "1114/1253",
                MemoryFrequency = 7010,
                VideoMemoryType = 5,
                AvailableMemory = "4096",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Asus/cerJ4CE0DEkPg.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 40,
                HardwareCategory = "asus",
                HardwareName = "ROG STRIX-GTX 1080-O8G-GAMING",
                GraphicsChip = "GeForce GTX 1080",
                CoreFrequency = "1759/1936",
                MemoryFrequency = 10000,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "7680*4320",
                HardwareImage = "/Images/HardwareImage/VideoCard/Asus/cevW1z1uGTV4A.jpg"
 
            });
            hardwares.Add(new FindHardware()
            {
                Id = 41,
                HardwareCategory = "colorfire",
                HardwareName = "R9-370 1024SP悍甲蜥-2GD5",
                GraphicsChip = "Radeon R9 370",
                CoreFrequency = "980",
                MemoryFrequency =5600 ,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Colorfire/cepIz9lYRJuWo.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 42,
                HardwareCategory = "colorfire",
                HardwareName = "R9 285毒蜥-2GD5",
                GraphicsChip = "Radeon R9 285",
                CoreFrequency = "918",
                MemoryFrequency = 5500,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "暂无数据",
                HardwareImage = "/Images/HardwareImage/VideoCard/Colorfire/ceQA4NxNWOsk.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 43,
                HardwareCategory = "colorfire",
                HardwareName = "R9 270毒蜥twin-2GD5",
                GraphicsChip = "Radeon R9 270",
                CoreFrequency = "925/975",
                MemoryFrequency = 5600,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "暂无数据",
                HardwareImage = "/Images/HardwareImage/VideoCard/Colorfire/ceanHclkmhTqE.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 44,
                HardwareCategory = "colorfire",
                HardwareName = "R9 295X2龙蜥-8GD5",
                GraphicsChip = "Radeo R9 295X2",
                CoreFrequency = "1018",
                MemoryFrequency = 5000,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "暂无数据",
                HardwareImage = "/Images/HardwareImage/VideoCard/Colorfire/ceV4UOiqxkY.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 45,
                HardwareCategory = "colorfire",
                HardwareName = "R9 270毒蜥top-2GD5",
                GraphicsChip = "Radeon R9 270",
                CoreFrequency = "975",
                MemoryFrequency = 5600,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "暂无数据",
                HardwareImage = "/Images/HardwareImage/VideoCard/Colorfire/ceHcftozIXSHA.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 46,
                HardwareCategory = "maxsun",
                HardwareName = "R9 390终结者8G",
                GraphicsChip = "Radeon R9 390",
                CoreFrequency = "1000",
                MemoryFrequency = 6000,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Maxsun/ceUw1SlS0HHJY.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 47,
                HardwareCategory = "maxsun",
                HardwareName = "GTX 760终结者2G",
                GraphicsChip = "GeForce GTX 760",
                CoreFrequency = "980/1033",
                MemoryFrequency = 6008,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "2560*1600",
                HardwareImage = "/Images/HardwareImage/VideoCard/Maxsun/ce4JnZRlIOtxg.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 48,
                HardwareCategory = "maxsun",
                HardwareName = "GTX 760 JetStream",
                GraphicsChip = "GeForce GTX 760",
                CoreFrequency = "1072/1137",
                MemoryFrequency = 6200,
                VideoMemoryType = 5,
                AvailableMemory = "2048",
                Res = "2560*1600",
                HardwareImage = "/Images/HardwareImage/VideoCard/Maxsun/ceeTRYndaAZw.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 49,
                HardwareCategory = "maxsun",
                HardwareName = "GTX 1080 Super JetStream 8G",
                GraphicsChip = "GeForce GTX 1080",
                CoreFrequency = "1709/1848",
                MemoryFrequency = 10000,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "7680*4320",
                HardwareImage = "/Images/HardwareImage/VideoCard/Maxsun/cePmKYZudpxm6.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 50,
                HardwareCategory = "maxsun",
                HardwareName = "GTX 1060 终结者 6G",
                GraphicsChip = "GeForce GTX 1060",
                CoreFrequency = "1506/1708",
                MemoryFrequency = 8000,
                VideoMemoryType = 5,
                AvailableMemory = "6144",
                Res = "7680*4320",
                HardwareImage = "/Images/HardwareImage/VideoCard/Maxsun/ceHCf43nVLISA.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 51,
                HardwareCategory = "gainward",
                HardwareName = "GTX 970 赵云版 4G",
                GraphicsChip = "GeForce GTX 970",
                CoreFrequency = "1126/1266",
                MemoryFrequency = 7010,
                VideoMemoryType = 5,
                AvailableMemory = "4096",
                Res = "4096*2160",
                HardwareImage = "/Images/HardwareImage/VideoCard/Gainward/ceNXLAO0w59oY.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 52,
                HardwareCategory = "gainward",
                HardwareName = "GTX 1070 G魂 极客版",
                GraphicsChip = "GeForce GTX 1070",
                CoreFrequency = "1657/1860",
                MemoryFrequency = 8008,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "暂无数据",
                HardwareImage = "/Images/HardwareImage/VideoCard/Gainward/ce1488gANDnfQ.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 53,
                HardwareCategory = "gainward",
                HardwareName = "GTX 1060 G魂",
                GraphicsChip = "GeForce GTX 1060",
                CoreFrequency = "1582/1797",
                MemoryFrequency = 8000,
                VideoMemoryType = 5,
                AvailableMemory = "6144",
                Res = "暂无数据",
                HardwareImage = "/Images/HardwareImage/VideoCard/Gainward/cet5mMITs1zO6.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 54,
                HardwareCategory = "gainward",
                HardwareName = "GTX 1070 追风版 8G",
                GraphicsChip = "GeForce GTX 1070",
                CoreFrequency = "1594/1784",
                MemoryFrequency = 8008,
                VideoMemoryType = 5,
                AvailableMemory = "8008",
                Res = "暂无数据",
                HardwareImage = "/Images/HardwareImage/VideoCard/Gainward/ceFAcMu7PhZQ.jpg"
            });
            hardwares.Add(new FindHardware()
            {
                Id = 55,
                HardwareCategory = "gainward",
                HardwareName = "GTX 1080 追风版",
                GraphicsChip = "GeForce GTX 1080",
                CoreFrequency = "1657/1797",
                MemoryFrequency = 10000,
                VideoMemoryType = 5,
                AvailableMemory = "8192",
                Res = "暂无数据",
                HardwareImage = "/Images/HardwareImage/VideoCard/Gainward/ceDThsualrOFs.jpg"
            });
            return hardwares;
        }
    }
}
