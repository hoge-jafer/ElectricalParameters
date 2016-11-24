using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalParameters.Models
{
   public class FindComputer
    {
        public int Id { get; set; }
        //品牌类别
        public string ComputerCategory { get; set; }
        //电脑名称
        public string ComputerName { get; set; }
        //系统
        public string System { get; set; }
        //芯片类型
        public string CPUType { get; set; }
        //频率
        public double Frequency { get; set; }
        //运行内存
        public int Ram { get; set; }
        //内存类型
        public int RamType { get; set; }
        //硬盘容量
        public string HardCapacity { get; set; }  
        //屏幕尺寸
        public double Size { get; set; }
        //分辨率
        public string Res { get; set; }
        //显卡
        public string Graphics { get; set; }
        //显卡运存
        public int GraphicsRam { get; set; }
        //显卡类型
        public int GraphicsType { get; set; }
        //图片
        public string ComputerImage{ get; set; }
    }
    public class FindComputerManager
    {
        public static void GetComputer(string computercategory, ObservableCollection<FindComputer> Computers)
        {
            var allComputer= getcomputer();
            var filteredComputer = allComputer.Where(p => p.ComputerCategory == computercategory).ToList();
            Computers.Clear();
            filteredComputer.ForEach(p => Computers.Add(p));
        }
        public static List<FindComputer> getcomputer()
        {
            var computers = new List<FindComputer>();

            computers.Add(new FindComputer()
            {
                Id=1,
                ComputerCategory= "microsoft",
                ComputerName= "Surface Book",
                System= "Windows 10 专业版",
                CPUType= "Intel 酷睿i7 6600U",
                Frequency=2.6,
                Ram=16,
                RamType=3,
                HardCapacity= "1TB",
                Size=13.5,
                Res= "3000*2000",
                Graphics= "NVIDIA Geforce",
                GraphicsRam=1,
                GraphicsType=5,
                ComputerImage="/Images/ComputerImage/Microsoft/sb.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 2,
                ComputerCategory = "microsoft",
                ComputerName = "Surface Pro 4",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6650U",
                Frequency = 2.2,
                Ram = 16,
                RamType = 3,
                HardCapacity = "256GB",
                Size = 12.3,
                Res = "2736*1824",
                Graphics = "Intel GMA HD 540",
                GraphicsRam = 1,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Microsoft/cew6irpspY9Zk.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 3,
                ComputerCategory = "microsoft",
                ComputerName = "Surface Pro 3",
                System = "Windows 8.1 Professional",
                CPUType = "Intel 酷睿i5 4300U",
                Frequency = 1.9,
                Ram = 4,
                RamType = 3,
                HardCapacity = "128GB",
                Size = 12,
                Res = "2160*1440",
                Graphics = "Intel GMA HD 4400",
                GraphicsRam = 1,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Microsoft/cecG9Nldy7FiM.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 4,
                ComputerCategory = "microsoft",
                ComputerName = "Surface Book",
                System = "Windows 10 Professional",
                CPUType = "Intel 酷睿i5 6300U",
                Frequency = 2.4,
                Ram = 8,
                RamType = 5,
                HardCapacity = "256GB",
                Size = 13.5,
                Res = "3000*2000",
                Graphics = "NVIDIA GeForce",
                GraphicsRam = 1,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Microsoft/cesGUtGWgwvY.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 5,
                ComputerCategory = "microsoft",
                ComputerName = "Surface Pro 3",
                System = "Windows 8.1",
                CPUType = "Intel 酷睿i7 4650U",
                Frequency = 1.7,
                Ram = 8,
                RamType = 3,
                HardCapacity = "512GB",
                Size = 12,
                Res = "2160*1440",
                Graphics = "核芯显卡",
                GraphicsRam = 1,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Microsoft/ce7N9dHudIIrY.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 6,
                ComputerCategory = "appletable",
                ComputerName = "iPad mini 2",
                System = "iOS 8",
                CPUType = "苹果 A7",
                Frequency = 1.5,
                Ram = 16,
                RamType = 3,
                HardCapacity = "16GB",
                Size = 7.9,
                Res = "2048*1536",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Apple/cecsrhlQFAJYo.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 7,
                ComputerCategory = "appletable",
                ComputerName = "iPad Air 2",
                System = "iOS 8",
                CPUType = "苹果 A8X",
                Frequency = 1.5,
                Ram = 2,
                RamType = 3,
                HardCapacity = "16GB",
                Size = 9.7,
                Res = "2048*1536",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Apple/ce1aHYMUMHnuU.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 8,
                ComputerCategory = "appletable",
                ComputerName = "",
                System = "iOS 9.3",
                CPUType = "苹果 A9X/M9",
                Frequency = 2.26,
                Ram =2,
                RamType = 3,
                HardCapacity = "128GB",
                Size = 9.7,
                Res = "2048*1536",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Apple/cecTYVBVea7uw.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 9,
                ComputerCategory = "appletable",
                ComputerName = "iPad Air 2",
                System = "iOS 8",
                CPUType = "苹果 A8X",
                Frequency = 1.5,
                Ram = 2,
                RamType = 3,
                HardCapacity = "64GB",
                Size = 9.7,
                Res = "2048*1536",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Apple/ceQJxmgmuAc.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 10,
                ComputerCategory = "appletable",
                ComputerName = "ipad mini 4",
                System = "iOS 9",
                CPUType = "苹果 A8",
                Frequency = 1.5,
                Ram = 2,
                RamType = 3,
                HardCapacity = "1TB",
                Size = 7.9,
                Res = "2048*1536",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Apple/ce8ntYuXiceiw.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 11,
                ComputerCategory = "hp",
                ComputerName = "WASD 15-AX016TX",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i5 6300HQ",
                Frequency = 2.3,
                Ram = 4,
                RamType = 3,
                HardCapacity = "128GB+1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 960M",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Hp/ceKoJ8t8Y8GQI.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 12,
                ComputerCategory = "hp",
                ComputerName = "Spectre 13-V014TU",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i5 6200U",
                Frequency = 2.3,
                Ram = 8,
                RamType = 3,
                HardCapacity = "256GB",
                Size = 13.3,
                Res = "1920*1080",
                Graphics = "Intel GMA HD 520",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Hp/ceadXvXO68reU.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 13,
                ComputerCategory = "hp",
                ComputerName = "ENVY 13-D023TU",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i5 6200U",
                Frequency = 2.3,
                Ram = 4,
                RamType = 3,
                HardCapacity = "128GB",
                Size = 13.3,
                Res = "1920*1080",
                Graphics = "Intel GMA HD 520 ",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Hp/ceThwQ0AO0P56.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 14,
                ComputerCategory = "hp",
                ComputerName = "Pavilion 15-AU034TX",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i5 6200U",
                Frequency = 2.3,
                Ram = 4,
                RamType = 3,
                HardCapacity = "500GB",
                Size = 15.6,
                Res = "1366*768",
                Graphics = "NVIDIA GeForce 940M",
                GraphicsRam = 2,
                GraphicsType = 4,
                ComputerImage = "/Images/ComputerImage/Hp/ceUCpJcrPuGQk.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 15,
                ComputerCategory = "hp",
                ComputerName = "Pavilion Gaming NB",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i5 6300HQ",
                Frequency = 2.3,
                Ram = 4,
                RamType = 3,
                HardCapacity = "128GB+1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 950M",
                GraphicsRam =4,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Hp/ce2zdhWnBD2g.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 16,
                ComputerCategory = "dell",
                ComputerName = "XPS 13",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i5 6200U",
                Frequency = 2.3,
                Ram = 4,
                RamType = 3,
                HardCapacity = "128GB",
                Size = 13.3,
                Res = "1920*1080",
                Graphics = "Intel GMA HD 520",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Dell/ceEvPyl1uO5vo.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 17,
                ComputerCategory = "dell",
                ComputerName = "燃7000",
                System = "",
                CPUType = "",
                Frequency = 2.5,
                Ram = 4,
                RamType = 5,
                HardCapacity = "128GB+500GB",
                Size = 14,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce 940MX",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Dell/cerW6TnxDfCmQ.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 18,
                ComputerCategory = "dell",
                ComputerName = "Vostro 成就 15",
                System = "Windows 10",
                CPUType = "Intel 酷睿i5 7200U",
                Frequency = 2.5,
                Ram = 4,
                RamType = 5,
                HardCapacity = "1TB",
                Size = 13.5,
                Res = "1366*768",
                Graphics = "NVIDIA GeForce GTX 940MX",
                GraphicsRam = 4,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Dell/ceFig3R3dsFng.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 19,
                ComputerCategory = "dell",
                ComputerName = "Latitude 15",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i7 6600U",
                Frequency = 2.6,
                Ram = 8,
                RamType =4,
                HardCapacity = "1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "AMD Radeon R7 M360",
                GraphicsRam =2,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Dell/cenWG2S98yRdw.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 20,
                ComputerCategory = "dell",
                ComputerName = "XPS 15",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 8,
                RamType = 4,
                HardCapacity = "256GB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 960M",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Dell/ce9nnMzCzhhWQ.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 21,
                ComputerCategory = "asus",
                ComputerName = "灵耀U3000",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i7 6500U",
                Frequency = 2.5,
                Ram = 8,
                RamType = 3,
                HardCapacity = "512GB",
                Size = 13.3,
                Res = "1920*1080",
                Graphics = "Intel GMA HD 520",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Asus/cebF7NX2roHLI.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 22,
                ComputerCategory = "asus",
                ComputerName = "FX-PRO",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 4,
                RamType = 4,
                HardCapacity = "1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 960M",
                GraphicsRam = 4,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Asus/ceOvPZnhXPOo.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 23,
                ComputerCategory = "asus",
                ComputerName = "VM510L5200",
                System = "Windows 8.1",
                CPUType = "Intel 酷睿i5 5200U",
                Frequency = 2.2,
                Ram = 4,
                RamType = 3,
                HardCapacity = "500GB",
                Size = 13.5,
                Res = "1366*768",
                Graphics = "入门级独立显卡",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Asus/ce8NEaGcRf66k.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 24,
                ComputerCategory = "asus",
                ComputerName = "FX50JK4200",
                System = "Windows 8.1",
                CPUType = "Intel 酷睿i5 4200H",
                Frequency = 2.8,
                Ram = 4,
                RamType = 3,
                HardCapacity = "500GB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 850M",
                GraphicsRam = 2,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Asus/ceOcFZZRLvOaE.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 25,
                ComputerCategory = "asus",
                ComputerName = "D555YA7010",
                System = "Windows 10",
                CPUType = "AMD E1-7010",
                Frequency = 1.5,
                Ram = 4,
                RamType = 3,
                HardCapacity = "500GB",
                Size = 15.6,
                Res = "1366*768",
                Graphics = "Intel GMA HD",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Asus/ceS82dO3vglKk.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 26,
                ComputerCategory = "hasee",
                ComputerName = "战神K650D-i7D3",
                System = ":Windows 8.1",
                CPUType = "Intel 酷睿i7 4710MQ ",
                Frequency = 2.5,
                Ram = 4,
                RamType = 3,
                HardCapacity = "500GB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 950M",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Hasee/cejJ1eTntJRmU.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 27,
                ComputerCategory = "hasee",
                ComputerName = "战神GX10-SP7 PLUS",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700K",
                Frequency = 4.0,
                Ram = 32,
                RamType = 4,
                HardCapacity = "2TB",
                Size = 17.3,
                Res = "3840*2160",
                Graphics = "双路NVIDIA GeForce GTX 1080",
                GraphicsRam =8,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Hasee/ceZeBAALNMz2.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 28,
                ComputerCategory = "hasee",
                ComputerName = "战神Z6-SL7D1",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram =8,
                RamType = 3,
                HardCapacity = "1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 960M",
                GraphicsRam =2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Hasee/ceeeVYL14N8yg.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 29,
                ComputerCategory = "hasee",
                ComputerName = "战神Z7-SP7S1",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 16,
                RamType = 3,
                HardCapacity = "512GB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 1060",
                GraphicsRam = 6,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Hasee/ceDu2Bsq1RGMY.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 30,
                ComputerCategory = "hasee",
                ComputerName = "战神Z7-SL7S4",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 8,
                RamType = 4,
                HardCapacity = "512GB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 970M",
                GraphicsRam =6,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Hasee/ceeoGHab7LE7A.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 31,
                ComputerCategory = "thinkpad",
                ComputerName = "ThinkPad T460s",
                System = "Windows 10",
                CPUType = "Intel 酷睿i5 6200U",
                Frequency = 2.3,
                Ram = 4,
                RamType = 4,
                HardCapacity = "256GB",
                Size = 14,
                Res = "1920*1080",
                Graphics = "NVIDIA Geforce 930M",
                GraphicsRam = 2,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Lenovo/ceuRZCtmzjaLY.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 32,
                ComputerCategory = "thinkpad",
                ComputerName = "ThinkPad T460P",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i5 6300HQ",
                Frequency = 2.3,
                Ram = 4,
                RamType = 4,
                HardCapacity = "1TB",
                Size = 14,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce 940MX",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Lenovo/ceOHTRyHn1P0Y.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 33,
                ComputerCategory = "thinkpad",
                ComputerName = "ThinkPad T460",
                System = "Windows 10 ",
                CPUType = "Intel 酷睿i5 6200U",
                Frequency = 2.3,
                Ram = 8,
                RamType = 3,
                HardCapacity = "8GB+500GB",
                Size = 13.5,
                Res = "1366*768",
                Graphics = "NVIDIA GeForce 940MX ",
                GraphicsRam = 2,
                GraphicsType =5,
                ComputerImage = "/Images/ComputerImage/Lenovo/ceosgBMFqfDhI.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 34,
                ComputerCategory = "thinkpad",
                ComputerName = "ThinkPad X1",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i5 6200U",
                Frequency = 2.3,
                Ram = 8,
                RamType = 3,
                HardCapacity = "192GB",
                Size = 14,
                Res = "1920*1080",
                Graphics = "Intel GMA HD 520",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Lenovo/cecEsH2GGSbMY.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 35,
                ComputerCategory = "thinkpad",
                ComputerName = "ThinkPad E460",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6500U",
                Frequency = 2.5,
                Ram = 4,
                RamType = 3,
                HardCapacity = "1TB",
                Size = 14,
                Res = "1920*1080",
                Graphics = "AMD Radeon R7 M360",
                GraphicsRam = 2,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Lenovo/ceOHTRyHn1P0Y.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 36,
                ComputerCategory = "acertable",
                ComputerName = "ICONIA_W510-27602G06iss",
                System = "Windows 8 Home Basic Edition",
                CPUType = "Intel Atom Z2760",
                Frequency = 1.8,
                Ram = 2,
                RamType = 3,
                HardCapacity = "64GB",
                Size = 10.1,
                Res = "1366*768",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Acer/ce4xDX6a5VBrM.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 37,
                ComputerCategory = "acertable",
                ComputerName = "Acer Predator 8",
                System = "Android5.1",
                CPUType = "Intel Atom X7-Z8700",
                Frequency = 1.6,
                Ram = 2,
                RamType = 3,
                HardCapacity = "64GB",
                Size = 8,
                Res = "1920*1200",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Acer/cenkCaxgJuu2.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 38,
                ComputerCategory = "acer",
                ComputerName = "G9-591-72F3",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i5 6300HQ",
                Frequency = 2.6,
                Ram = 16,
                RamType =4,
                HardCapacity = "128GB+1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce 970MX",
                GraphicsRam = 3,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Acer/ceduEb9EYKhc.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 39,
                ComputerCategory = "acer",
                ComputerName = "G9-591-72F3",
                System = "Windows 10",
                CPUType = "Intel 酷睿i5 6200U",
                Frequency = 2.6,
                Ram = 8,
                RamType = 4,
                HardCapacity = "1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA Geforce 950M",
                GraphicsRam = 2,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Acer/ceImiuuMQW01A.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 40,
                ComputerCategory = "acer",
                ComputerName = "F5-572G-5224",
                System = "Windows 10",
                CPUType = "Intel 酷睿i5 6200U",
                Frequency = 2.3,
                Ram = 8,
                RamType = 3,
                HardCapacity = "1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA Geforce 940M",
                GraphicsRam = 2,
                GraphicsType =3,
                ComputerImage = "/Images/ComputerImage/Acer/ceVNJcKX8LxNA.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 41,
                ComputerCategory = "thunderobot",
                ComputerName = "911-S2g",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 8,
                RamType = 4,
                HardCapacity = "128GB+1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 965M",
                GraphicsRam = 4,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Thunderobot/ceyZukkK9UB2.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 42,
                ComputerCategory = "thunderobot",
                ComputerName = "小钢炮ST-R1",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 8,
                RamType =4,
                HardCapacity = "128GB+500GB",
                Size = 14,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 965M",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Thunderobot/ceiwEzHLPTB6.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 43,
                ComputerCategory = "thunderobot",
                ComputerName = "ST-Pro",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 16,
                RamType = 4,
                HardCapacity = "512GB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 1060",
                GraphicsRam = 6,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Thunderobot/ce5Xlsl8Oab6.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 44,
                ComputerCategory = "thunderobot",
                ComputerName = "G150S-47104G500G9502G",
                System = "Windows 10",
                CPUType = "",
                Frequency = 2.5,
                Ram = 4,
                RamType = 3,
                HardCapacity = "500GB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 950M",
                GraphicsRam = 2,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Thunderobot/ceOw8uR50inDU.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 45,
                ComputerCategory = "thunderobot",
                ComputerName = "911M-M1",
                System = "Windows 7",
                CPUType = "Intel 酷睿i7 4720HQ",
                Frequency = 2.6,
                Ram = 16,
                RamType = 3,
                HardCapacity = "1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 970M",
                GraphicsRam = 6,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Thunderobot/ce17M0gAZKkMM.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 46,
                ComputerCategory = "samsung",
                ComputerName = "900X5M-K03",
                System = "Windows 10",
                CPUType = "Intel 酷睿i5 7200U",
                Frequency = 2.5,
                Ram = 8,
                RamType = 3,
                HardCapacity = "256GB",
                Size = 15,
                Res = "1920*1080",
                Graphics = "Intel GMA HD 620",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Samsung/ce4R8WRMoAvg.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 47,
                ComputerCategory = "samsung",
                ComputerName = "300E5K-Y06",
                System = "Windows 10 home",
                CPUType = "Intel 酷睿i5 5200U",
                Frequency = 2.2,
                Ram = 4,
                RamType = 3,
                HardCapacity = "256GB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA Geforce 910M",
                GraphicsRam = 2,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Samsung/ce04u1ZsUaXk.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 48,
                ComputerCategory = "samsung",
                ComputerName = "900X3L-K01",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6500U",
                Frequency = 2.5,
                Ram = 8,
                RamType = 3,
                HardCapacity = "256GB",
                Size = 13.3,
                Res = "1920*1080",
                Graphics = "Intel GMA HD 520",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Samsung/ceoyJp10sEuI.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 49,
                ComputerCategory = "samsung",
                ComputerName = "900X3M-K02",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 7500U",
                Frequency = 2.7,
                Ram = 8,
                RamType = 3,
                HardCapacity = "512GB",
                Size = 13.3,
                Res = "1920*1080",
                Graphics = "Intel GMA HD 620",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Samsung/cevKfJ5BBmr5A.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 50,
                ComputerCategory = "samsung",
                ComputerName = "900X5M-K03",
                System = "Windows 10",
                CPUType = "Intel 酷睿i5 7200U",
                Frequency = 2.5,
                Ram = 8,
                RamType = 3,
                HardCapacity = "256GB",
                Size = 15,
                Res = "1920*1080",
                Graphics = "Intel GMA HD 620",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Samsung/cehbyd1ysifPI.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 51,
                ComputerCategory = "razer",
                ComputerName = "Razer Blade Pro 2014",
                System = "Windows 8.1",
                CPUType = "Intel 酷睿i7 4700HQ",
                Frequency = 2.4,
                Ram = 16,
                RamType = 3,
                HardCapacity = "256GB",
                Size = 17.3,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 860M",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Razer/ceBJ80WM6lkYc.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 52,
                ComputerCategory = "razer",
                ComputerName = "Razer Blade Pro 2015",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 4720HQ",
                Frequency = 2.6,
                Ram = 16,
                RamType = 3,
                HardCapacity = "512GB+1TB",
                Size = 17.3,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 960M",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Razer/ceaXWRGYR3u6.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 53,
                ComputerCategory = "razer",
                ComputerName = "Razer Blade Stealth",
                System = "Windows 10 home",
                CPUType = "Intel 酷睿i7 6500U",
                Frequency = 2.5,
                Ram = 8,
                RamType = 3,
                HardCapacity = "512GB",
                Size = 12.5,
                Res = "3840*2160",
                Graphics = "Intel GMA HD 520",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Razer/ceSfDmxJ8zaQ.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 54,
                ComputerCategory = "razer",
                ComputerName = "Razer Blade 2016",
                System = "Windows 10 home",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 16,
                RamType = 3,
                HardCapacity = "256GB",
                Size = 14,
                Res = "3200*1800",
                Graphics = "NVIDIA GeForce GTX 970M",
                GraphicsRam = 6,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Razer/ceiLZ977Kw3s.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 55,
                ComputerCategory = "razer",
                ComputerName = "Razer Blade Stealth",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i7 6500U",
                Frequency = 2.5,
                Ram = 8,
                RamType = 3,
                HardCapacity = "512GB",
                Size = 12.5,
                Res = "3840*1440",
                Graphics = "Intel GMA HD 520",
                GraphicsRam = 1,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Razer/cegBNXoJi6jNU.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 56,
                ComputerCategory = "toshiba",
                ComputerName = "P50-C S01M1",
                System = "",
                CPUType = "Intel 酷睿i7 5500U",
                Frequency = 2.4,
                Ram = 8,
                RamType = 3,
                HardCapacity = "8GB+1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 950M",
                GraphicsRam = 4,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Toshiba/ceLOcH8tMiOeU.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 57,
                ComputerCategory = "toshiba",
                ComputerName = "X70-AT02S",
                System = "Windows 8",
                CPUType = "Intel 酷睿i7 4700MQ",
                Frequency = 2.4,
                Ram = 16,
                RamType = 3,
                HardCapacity = "1TB",
                Size = 17.3,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 770M",
                GraphicsRam = 3,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Toshiba/ceVfvUcskns82.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 58,
                ComputerCategory = "toshiba",
                ComputerName = "C50-CK30B1",
                System = "DOS",
                CPUType = "Intel 赛扬双核 3205U",
                Frequency = 1.5,
                Ram = 4,
                RamType = 3,
                HardCapacity = "500GB",
                Size = 15.6,
                Res = "1366*768",
                Graphics = "Intel GMA HD(集成于处理器)",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Toshiba/cebHh5b7ZvlP.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 59,
                ComputerCategory = "toshiba",
                ComputerName = "Z30-C",
                System = "Windows 7 Professional",
                CPUType = "Intel 酷睿i7 6600U",
                Frequency = 2.6,
                Ram = 8,
                RamType = 3,
                HardCapacity = "256GB",
                Size = 13.3,
                Res = "1920*1080",
                Graphics = "Intel GMA HD 520",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Toshiba/ceF8cuNjgNmyQ.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 60,
                ComputerCategory = "toshiba",
                ComputerName = "Z40-B K24M",
                System = "Windows 7 Professional",
                CPUType = "Intel 酷睿i5 5300U",
                Frequency = 2.3,
                Ram = 4,
                RamType = 3,
                HardCapacity = "500GB",
                Size = 14,
                Res = "1366*768",
                Graphics = "Intel GMA HD 5500",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Toshiba/ceF891YUe4q0g.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 61,
                ComputerCategory = "gigabyte",
                ComputerName = "P15F",
                System = "DOS",
                CPUType = "Intel 酷睿i7 4710MQ",
                Frequency = 2.5,
                Ram = 4,
                RamType = 3,
                HardCapacity = "1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 850M",
                GraphicsRam = 2,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Gigabyte/cem8B9AUjzeV2.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 62,
                ComputerCategory = "gigabyte",
                ComputerName = "P35W v5",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 16,
                RamType = 4,
                HardCapacity = "128GB+1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 970M",
                GraphicsRam = 6,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Gigabyte/ceeHShl9F89Pg.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 63,
                ComputerCategory = "gigabyte",
                ComputerName = "P37X v5",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 16,
                RamType = 4,
                HardCapacity = "1TB",
                Size = 17.3,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 980M",
                GraphicsRam = 8,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Gigabyte/ceZp6f4EnaOdQ.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 64,
                ComputerCategory = "gigabyte",
                ComputerName = "Aorus X3 Plus v5",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 16,
                RamType = 4,
                HardCapacity = "512GB",
                Size = 13.9,
                Res = "3200*1800",
                Graphics = "NVIDIA GeForce GTX 970M",
                GraphicsRam = 6,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Gigabyte/ceZatkgKKtF.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 65,
                ComputerCategory = "gigabyte",
                ComputerName = "P34W v5",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 16,
                RamType = 4,
                HardCapacity = "128GB+1TB",
                Size = 14,
                Res = "2560*1440",
                Graphics = "NVIDIA GeForce GTX 970M",
                GraphicsRam = 3,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Gigabyte/cenWiDgzo99s.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 66,
                ComputerCategory = "terransforce",
                ComputerName = "S5 1060 67T",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700K",
                Frequency = 4.0,
                Ram = 8,
                RamType = 4,
                HardCapacity = "250GB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 1060",
                GraphicsRam = 6,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Terransforce/ceNixqfCdKGUg.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 67,
                ComputerCategory = "terransforce",
                ComputerName = "X599 1070 67SH1",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700K",
                Frequency = 4.0,
                Ram = 16,
                RamType = 3,
                HardCapacity = "250GB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 1070",
                GraphicsRam = 8,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Terransforce/ceJNTgl4ronmw.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 68,
                ComputerCategory = "terransforce",
                ComputerName = "T7-1060-67SH1",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6820HK",
                Frequency = 2.7,
                Ram = 8,
                RamType = 4,
                HardCapacity = "1TB",
                Size = 17.3,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 1060",
                GraphicsRam = 6,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Terransforce/cezrfqRvAoB7Y.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 69,
                ComputerCategory = "terransforce",
                ComputerName = "T5 SKYLAKE 970M 67SH1",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram = 8,
                RamType = 4,
                HardCapacity = "120GB+1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 970M",
                GraphicsRam = 3,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Terransforce/cefI1hCERVE.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 70,
                ComputerCategory = "terransforce",
                ComputerName = "X599 980M 47K",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 4790K ",
                Frequency = 4.0,
                Ram = 32,
                RamType = 3,
                HardCapacity = "1TB+2TB",
                Size = 15.6,
                Res = "3840*2160",
                Graphics = "NVIDIA GeForce GTX 980M",
                GraphicsRam = 8,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Terransforce/cejEE0BOk1hc.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 71,
                ComputerCategory = "lenovo",
                ComputerName = "G50-70AT-ITH",
                System = "DOS",
                CPUType = "Intel 酷睿i3 4010U",
                Frequency = 1.7,
                Ram = 4,
                RamType = 3,
                HardCapacity = "500GB",
                Size = 15.6,
                Res = "1366*768",
                Graphics = "NVIDIA GeForce 820M",
                GraphicsRam = 2,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Lenovo/ceOvjlaE5E50Y.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 72,
                ComputerCategory = "lenovo",
                ComputerName = "Y50-70AM-IFI",
                System = "Windows 8.1",
                CPUType = "Intel 酷睿i5 4200H",
                Frequency = 2.8,
                Ram = 4,
                RamType = 3,
                HardCapacity = "1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 860M",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Lenovo/ce5RluNKCHXLo.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 73,
                ComputerCategory = "lenovo",
                ComputerName = "小新Air 13 Pro",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i5 6200U",
                Frequency = 2.3,
                Ram = 4,
                RamType =4,
                HardCapacity = "1TB",
                Size = 13.3,
                Res = "1920*1080",
                Graphics = "NVIDIA Geforce 940MX",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Lenovo/cefpmHKPmcyE.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 74,
                ComputerCategory = "lenovo",
                ComputerName = "Miix 510",
                System = "Windows 10",
                CPUType = "Intel 酷睿i5 6200U",
                Frequency = 2.3,
                Ram = 8,
                RamType = 3,
                HardCapacity = "256GB",
                Size = 12.2,
                Res = "1920*1200",
                Graphics = "Intel GMA HD 520",
                GraphicsRam = 1,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Lenovo/cesV10lvFkzE.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 75,
                ComputerCategory = "lenovo",
                ComputerName = "YOGA 5 Pro",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿 i5/7",
                Frequency = 2.6,
                Ram = 8,
                RamType = 4,
                HardCapacity = "256GB/512GB/1TB",
                Size = 13.9,
                Res = "3840*2160",
                Graphics = "Intel GMA HD",
                GraphicsRam = 1,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Lenovo/ceBFw59SgiO6A.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 76,
                ComputerCategory = "mi",
                ComputerName = "小米笔记本Air",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i5 6200U",
                Frequency = 2.3,
                Ram = 8,
                RamType = 4,
                HardCapacity = "1TB",
                Size = 13.3,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce 940MX",
                GraphicsRam = 1,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Mi/ce6HhBA34tK6.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 77,
                ComputerCategory = "mi",
                ComputerName = "小米笔记本Air",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿M3 6Y30",
                Frequency = 0.9,
                Ram = 4,
                RamType = 3,
                HardCapacity = "128GB",
                Size = 12.5,
                Res = "1920*1080",
                Graphics = "Intel HD Graphics 515",
                GraphicsRam = 1,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Mi/cePbkekq1OUuM.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 78,
                ComputerCategory = "microsofttable",
                ComputerName = "Surface Pro 4",
                System = "Windows 10",
                CPUType = "Intel 酷睿i7 6650U",
                Frequency = 2.2,
                Ram = 16,
                RamType = 3,
                HardCapacity = "256GB",
                Size = 12.3,
                Res = "2736*1824",
                Graphics = "Intel GMA HD 540",
                GraphicsRam = 1,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Microsoft/cew6irpspY9Zk.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 79,
                ComputerCategory = "microsofttable",
                ComputerName = "Surface Pro 3",
                System = "Windows 8.1 Professional",
                CPUType = "Intel 酷睿i5 4300U",
                Frequency = 1.9,
                Ram = 4,
                RamType = 3,
                HardCapacity = "128GB",
                Size = 12,
                Res = "2160*1440",
                Graphics = "Intel GMA HD 4400",
                GraphicsRam = 1,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Microsoft/cecG9Nldy7FiM.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 80,
                ComputerCategory = "samsungtable",
                ComputerName = "",
                System = "Android6.0",
                CPUType = "无数据",
                Frequency = 1.6,
                Ram =2,
                RamType = 3,
                HardCapacity = "16GB",
                Size = 10.1,
                Res = "1920*1200",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Samsung/cevP0yp0Cink.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 81,
                ComputerCategory = "samsungtable",
                ComputerName = "Galaxy TabPro S",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿M3 6Y30",
                Frequency = 0.9,
                Ram = 4,
                RamType = 3,
                HardCapacity = "128GB",
                Size = 12,
                Res = "2160*1440",
                Graphics = "Intel GMA HD 515",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Samsung/ceMY6WQJMVqYw.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 82,
                ComputerCategory = "samsungtable",
                ComputerName = "GALAXY Tab S T800",
                System = "Android4.4",
                CPUType = "无数据",
                Frequency = 3.2,
                Ram = 3,
                RamType = 3,
                HardCapacity = "16GB",
                Size = 10.5,
                Res = "2560*1600",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Samsung/ceYcQHG4vhPA.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 83,
                ComputerCategory = "ramostable",
                ComputerName = "i10s win8",
                System = "Windows 8.1",
                CPUType = "Intel Atom Z3735F",
                Frequency = 1.33,
                Ram = 2,
                RamType = 3,
                HardCapacity = "32GB",
                Size = 10.1,
                Res = "1920*1200",
                Graphics = "Intel HD Gen7 Graphic",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Ramos/ce4Ypz3F4I2hY.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 84,
                ComputerCategory = "ramostable",
                ComputerName = "M12",
                System = "Windows 8.1",
                CPUType = "Intel Core M 5Y10",
                Frequency = 0.8,
                Ram = 4,
                RamType = 3,
                HardCapacity = "256GB",
                Size = 11.6,
                Res = "1920*1080",
                Graphics = "Intel HD Graphic",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Ramos/cednH82G6ZF1k.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 85,
                ComputerCategory = "ramostable",
                ComputerName = "i100 Pro",
                System = "Android4.4",
                CPUType = "Intel Atom Z3735F",
                Frequency = 1.33,
                Ram = 2,
                RamType = 3,
                HardCapacity = "64GB",
                Size = 10.6,
                Res = "1920*1080",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Ramos/ce7PInvQdWoRk.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 86,
                ComputerCategory = "teclasttable",
                ComputerName = "TBook 11",
                System = "Android5.1+ Windows 10",
                CPUType = "Intel Cherry Trail X5-Z8300",
                Frequency =1.44,
                Ram = 4,
                RamType = 3,
                HardCapacity = "64GB",
                Size = 10.6,
                Res = "1920*1080",
                Graphics = "Intel HD Graphic",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Teclast/cefQM2DtGcrec.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 87,
                ComputerCategory = "teclasttable",
                ComputerName = "X3 Pro",
                System = "Windows 10",
                CPUType = "Intel Core M3-6Y30",
                Frequency = 0.9,
                Ram = 8,
                RamType = 3,
                HardCapacity = "128GB",
                Size = 11.6,
                Res = "1920*1080",
                Graphics = "Intel HD Graphic",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Teclast/ceUXXaYYbJwE.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 88,
                ComputerCategory = "teclasttable",
                ComputerName = "TBook 10",
                System = "Android5.1+ Windows 10",
                CPUType = "Intel Cherry Trail X5-Z8300",
                Frequency = 1.44,
                Ram = 4,
                RamType = 3,
                HardCapacity = "64GB",
                Size = 10.1,
                Res = "1920*1200",
                Graphics = "Intel HD Graphic",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Teclast/ceEx8iBwmLBQ.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 89,
                ComputerCategory = "thinkpadtable",
                ComputerName = "Miix 310",
                System = "Windows 10",
                CPUType = "Intel Cherry Trail X5-Z8300",
                Frequency = 1.44,
                Ram = 4,
                RamType = 3,
                HardCapacity = "64GB",
                Size = 10.1,
                Res = "1920*1080",
                Graphics = "Intel HD Graphic",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Lenovo/cejjmeFMPb2.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 90,
                ComputerCategory = "thinkpadtable",
                ComputerName = "TAB 3 7",
                System = "Android6.0",
                CPUType = "MTK MT8735P",
                Frequency = 1.0,
                Ram = 1,
                RamType = 3,
                HardCapacity = "16GB",
                Size = 7,
                Res = "1024*600",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Lenovo/cehPowYlzWdlo.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 91,
                ComputerCategory = "thinkpadtable",
                ComputerName = "YOGA平板2 Pro",
                System = "Windows 8.1",
                CPUType = "Intel Atom Z3745",
                Frequency = 1.33,
                Ram = 4,
                RamType = 3,
                HardCapacity = "64GB",
                Size = 13.3,
                Res = "2560*1440",
                Graphics = "Intel HD Graphic",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Lenovo/ceMslCszJDL6.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 92,
                ComputerCategory = "mitable",
                ComputerName = "小米平板2",
                System = "Android5.1(MIUI)",
                CPUType = "Intel Cherry Trail X5-Z8500",
                Frequency = 1.44,
                Ram = 2,
                RamType = 3,
                HardCapacity = "16GB",
                Size =7.9,
                Res = "2048*1536",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Mi/ce1ROpMYI6.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 93,
                ComputerCategory = "mitable",
                ComputerName = "小米平板2",
                System = "Windows 10",
                CPUType = "Intel Cherry Trail X5-Z8500",
                Frequency = 1.44,
                Ram = 2,
                RamType = 3,
                HardCapacity = "64GB",
                Size = 7.9,
                Res = "2048*1536",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Mi/ceAA4hqWVvq6.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id =94,
                ComputerCategory = "nokiatable",
                ComputerName = "Nokia N1",
                System = "Android5.0",
                CPUType = "Intel Atom Z3580",
                Frequency = 2.33,
                Ram = 2,
                RamType = 3,
                HardCapacity = "32GB",
                Size = 7.9,
                Res = "2048*1536 ",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Nokia/cetI3sRf8ESwY.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 95,
                ComputerCategory = "cubetable",
                ComputerName = "酷比魔方i7酷睿M",
                System = "Windows 8.1",
                CPUType = "Intel Core M",
                Frequency = 2.0,
                Ram = 4,
                RamType = 3,
                HardCapacity = "128GB",
                Size = 11.6,
                Res = "1920*1080",
                Graphics = "无数据",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Cube/ceO8DHTg6lF3M.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 96,
                ComputerCategory = "cubetable",
                ComputerName = "iwork10旗舰本",
                System = "Windows 10",
                CPUType = "Intel Cherry Trail X5-Z8300",
                Frequency = 1.44,
                Ram = 4,
                RamType = 3,
                HardCapacity = "64GB",
                Size = 10.1,
                Res = "1920*1200",
                Graphics = "Intel HD Graphic",
                GraphicsRam = 0,
                GraphicsType = 0,
                ComputerImage = "/Images/ComputerImage/Cube/ceA56bscGRuk6.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 97,
                ComputerCategory = "alienware",
                ComputerName = "Alienware 17",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i7 6820HK",
                Frequency = 2.7,
                Ram = 16,
                RamType = 4,
                HardCapacity = "512GB+1TB",
                Size = 17.3,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 980M",
                GraphicsRam = 8,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Alienware/ce28Sf1Rsq0Ck.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 98,
                ComputerCategory = "alienware",
                ComputerName = "Alienware 18",
                System = "Windows 8.1",
                CPUType = "Intel 酷睿i7 4940MX",
                Frequency = 3.1,
                Ram = 32,
                RamType = 3,
                HardCapacity = "512GB+1TB",
                Size = 18.4,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 980M",
                GraphicsRam = 16,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Alienware/cekLOAFJ6AWYc.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 99,
                ComputerCategory = "alienware",
                ComputerName = "Alienware 15",
                System = "Windows 8.1",
                CPUType = "",
                Frequency = 2.5,
                Ram =16,
                RamType = 3,
                HardCapacity = "128GB+1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 970M",
                GraphicsRam = 3,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Alienware/cePWUolmVmRzk.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id =100,
                ComputerCategory = "alienware",
                ComputerName = "Alienware 13",
                System = "Windows 8.1",
                CPUType = "Intel 酷睿i5 5200U",
                Frequency = 2.2,
                Ram = 8,
                RamType = 3,
                HardCapacity = "64GB",
                Size = 13,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 860M",
                GraphicsRam =2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Alienware/ceLrMo2xhdZQY.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 101,
                ComputerCategory = "alienware",
                ComputerName = "Alienware 15",
                System = "Windows 10 Home",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.7,
                Ram = 16,
                RamType = 3,
                HardCapacity = "256GB+1TB ",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 980M",
                GraphicsRam =8,
                GraphicsType =5,
                ComputerImage = "/Images/ComputerImage/Alienware/ce8D9jKAyfsMo.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 102,
                ComputerCategory = "machenike",
                ComputerName = "机械师F57-D5R热血版",
                System = "DOS",
                CPUType = "Intel 酷睿i7 6700HQ",
                Frequency = 2.6,
                Ram =8,
                RamType = 3,
                HardCapacity = "128GB+500GB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 950M",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Machenike/ceJpcBVScwSQU.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 103,
                ComputerCategory = "machenike",
                ComputerName = "机械师T47-i7 D2",
                System = "DOS",
                CPUType = "Intel 酷睿i7 4710MQ",
                Frequency = 2.5,
                Ram = 8,
                RamType = 3,
                HardCapacity = "1TB",
                Size = 14,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 950M",
                GraphicsRam = 2,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Machenike/ceFNf9gdGLKas.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 104,
                ComputerCategory = "machenike",
                ComputerName = "机械师T57-D3",
                System = "DOS",
                CPUType = "Intel 酷睿i5 6300HQ",
                Frequency = 2.3,
                Ram = 4,
                RamType = 3,
                HardCapacity = "1TB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 960M",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Machenike/ceVXcYWo1i2s.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 105,
                ComputerCategory = "machenike",
                ComputerName = "机械师M700S-i7 D1",
                System = "DOS",
                CPUType = "Intel 酷睿i5 6300HQ",
                Frequency = 2.6,
                Ram = 8,
                RamType = 3,
                HardCapacity = "1TB",
                Size = 17.3,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 950M",
                GraphicsRam = 2,
                GraphicsType = 3,
                ComputerImage = "/Images/ComputerImage/Machenike/ceIiA3JD1qMAA.jpg"
            });
            computers.Add(new FindComputer()
            {
                Id = 106,
                ComputerCategory = "machenike",
                ComputerName = "机械师F57-D1",
                System = "DOS",
                CPUType = "Intel 酷睿i5 6300HQ",
                Frequency = 2.3,
                Ram = 4,
                RamType = 3,
                HardCapacity = "500GB",
                Size = 15.6,
                Res = "1920*1080",
                Graphics = "NVIDIA GeForce GTX 950M",
                GraphicsRam = 2,
                GraphicsType = 5,
                ComputerImage = "/Images/ComputerImage/Machenike/ce4XvEO8T9Kd6.jpg"
            });
            return computers;
        }
    }
}
