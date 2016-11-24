using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalParameters.Models
{
    public class FindPhone
    {
        public int Id { get; set; }
        //手机类别
        public string PhoneCategoryName { get; set; }
        //手机名
        public string PhoneName { get; set; }
        //屏幕尺寸
        public double ScreenSize { get; set; }
        //分辨率
        public string Res { get; set; }
        //屏幕材质
        public string ScreenMaterial { get; set; }
        //其他屏幕参数
        public string OtherScreenParameter { get; set; }
        //屏占比例
        public double ScreenProportion { get; set; }
        //网络类型
        public string NetWorkType { get; set; }
        //操作系统
        public string OperatingSystem { get; set; }
        //后置摄像头
        public int RearCamera { get; set; }
        //前置摄像头
        public int FrontFacingCamera { get; set; }
        //三防功能
        public string TH { get; set; }
        //感应器
        public string Sensors { get; set; }
        //运行内存
        public int Memory { get; set; }
        //机身颜色
        public string PhoneColor { get; set; }
        //闪光灯
        public string PhoneLamp { get; set; }
        //电池容量
        public int BatteryCapacity { get; set; }
        //核心数
        public string Cores { get; set; }
        //CPU
        public string PhoneCPU { get; set; }
        //CPU频率
        public double PhoneCPUFrequency { get; set; }
        //ROM容量
        public string PhoneROM { get; set; }
        //电池类型
        public string BatteryType { get; set; }
        //手机图像
        public string PhoneImage { get; set; }
    }
    public class FindPhoneManager
    {
        public static void GetPhone(string phonecategoryname, ObservableCollection<FindPhone> Phones)
        {
            var allPhone = getphone();
            var filteredPhone = allPhone.Where(p => p.PhoneCategoryName == phonecategoryname).ToList();
            Phones.Clear();
            filteredPhone.ForEach(p => Phones.Add(p));
        }
        public static List<FindPhone> getphone()
        {
            var phones = new List<FindPhone>();
            phones.Add(new FindPhone()
            {
                #region
                #region
                Id = 1,
                PhoneCategoryName = "iphone",
                PhoneName = "iPhone 6s",
                ScreenSize = 4.7,
                Res = "1334*750",
                ScreenMaterial = "Retina HD",
                OtherScreenParameter =@"500cd/m2最大亮度(标准),全sRGB
标准,支持广阔视角的双域像素,正
面采用防油渍防指纹涂层,支持多
种语言文字同时显示,放大显示,便
捷访问功能显示,2.5D玻璃",
                ScreenProportion = 65.62,
                NetWorkType = "全网通 ",
                OperatingSystem = "iOS 9",
                TH = "无",
                Sensors = @"加速传感器,光线传感器,距离传
感器,TouchID指纹识别传感器,
三轴陀螺仪,气压计,数字指南针",
                PhoneColor = "金色,玫瑰金色,银色,深空灰色",
                PhoneLamp = "True Tone",
                PhoneCPU = "苹果 A9+M9协处理器",
                PhoneROM = "16GB/64GB/128GB",
                PhoneCPUFrequency = 1.8,
                RearCamera = 1200,
                FrontFacingCamera = 500,
                Memory = 2,
                BatteryCapacity = 1715,
                Cores = "双",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/IPhone/I6s.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone()
            {
                Id = 2,
                PhoneCategoryName = "iphone",
                PhoneName = "iPhone 6s Plus",
                ScreenSize = 5.5,
                Res = "1920*1080",
                ScreenMaterial = "Retina HD",
                OtherScreenParameter = @"500cd/m2最大亮度(标准),全sRGB
标准,支持广阔视角的双域像素,
正面采用防油渍防指纹涂层,支持
多种语言文字同时显示,放大显示
,便捷访问功能显示",
                //屏幕比例
                ScreenProportion = 76.5,
                NetWorkType = "全网通",
                OperatingSystem = "iOS 9",
                TH = "无",
                Sensors = @"加速传感器,光线传感器,距离传
感器,TouchID指纹识别传感器,
三轴陀螺仪,气压计,数字指南针",
                PhoneColor = "金色,玫瑰金色,银色,深空灰色",
                PhoneLamp = "True Tone",
                PhoneCPU = "苹果A9+M9协处理器",
                PhoneROM = "16GB/64GB/128GB",
                PhoneCPUFrequency = 1.8,
                RearCamera = 800,
                FrontFacingCamera = 120,
                Memory = 1,
                BatteryCapacity = 1915,
                Cores = "双",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/IPhone/I6sP.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone()
            {
                Id = 3,
                PhoneCategoryName = "sanxing",
                PhoneName = "三星 S7 Edge",
                ScreenSize = 5.5,
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "Always on常亮显示屏",
                ScreenProportion = 76.12,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android OS 6.0",
                TH = "支持IP68级防水，防尘",
                Sensors = @"重力感应器,光线传感器,距离传
感器,加速传感器,指纹识别,气
压传感器,霍尔传感器,心率传感
器,陀螺仪",
                PhoneColor = @"黑色,金色,蓝色,银色铂光金,钛
泽银,星钻黑,雪晶白,粉金色",
                PhoneLamp = "LED",
                PhoneCPU = "高通 骁龙820",
                PhoneROM = "32GB/64GB",
                Res = "2560*1440",
                PhoneCPUFrequency = 2.15,
                RearCamera = 1200,
                FrontFacingCamera = 500,
                Memory = 4,
                BatteryCapacity = 3600,
                Cores = "四",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Samsung/S7e.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone()
            {
                Id = 4,
                PhoneCategoryName = "sanxing",
                PhoneName = "三星 Note7",
                ScreenSize = 5.7,
                Res = "2560*1440",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "双曲面屏,息屏提醒",
                ScreenProportion = 78.96,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "Android OS 6.0",
                TH = "支持IP68级防水，防尘",
                Sensors = @"重力感应器,光线传感器,距离传感
器,气压传感器,温度传感器,电子
罗盘,血压传感器,心率传感器,指
纹识别,虹膜识别,陀螺仪",
                PhoneColor = "黑色,金色,蓝色,银色",
                PhoneLamp = "LED",
                PhoneCPU = "高通 骁龙820 ",
                PhoneROM = "64GB",
                PhoneCPUFrequency = 2.15,
                RearCamera = 1200,
                FrontFacingCamera = 500,
                Memory = 4,
                BatteryCapacity = 3500,
                Cores = "四",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Samsung/N7.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id =5,
                PhoneCategoryName="sanxing",
                PhoneName="三星S7",
                ScreenSize=5.1,
                Res="2560*1440",
                ScreenMaterial= "Super AMOLED",
                OtherScreenParameter= "2.5D玻璃",
                ScreenProportion= 72.35,
                NetWorkType= "双卡,全网通",
                OperatingSystem= "Android OS 6.0",
                RearCamera= 1200,
                FrontFacingCamera= 500,
                TH= "支持IP68级防水,防尘",
                Sensors= @"加速感应器,气压传感器,指纹识别
,陀螺仪,重力感应器,霍尔传感器,
心率传感器,距离传感器,光线传感
器",
                Memory=4,
                PhoneColor= "黑色，粉金色",
                PhoneLamp= "LED",
                BatteryCapacity=3000,
                Cores="四",
                PhoneCPU= "高通 骁龙820",
                PhoneCPUFrequency=2.15,
                PhoneROM= "32GB",
                BatteryType="不可",
                PhoneImage="/Images/PhoneImage/Samsung/S7.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 6,
                PhoneCategoryName = "sanxing",
                PhoneName = "三星S6",
                ScreenSize =5.1,
                Res = "2560*1440",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "双面第四代康宁大猩猩玻璃",
                ScreenProportion = 70.93,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android OS 5.0",
                RearCamera = 1600,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,加速传感器,光线传感
器,距离传感器,按压式指纹识别,
心率传感器",
                Memory =3,
                PhoneColor =@"星钻黑色,雪晶白色,冰玉蓝色,铂
                光金色",
                PhoneLamp = "LED",
                BatteryCapacity =2550,
                Cores = "真八",
                PhoneCPU = "三星 Exynos 7420",
                PhoneCPUFrequency =2.1,
                PhoneROM ="32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Samsung/S6.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 7,
                PhoneCategoryName = "sanxing",
                PhoneName = "三星S6Egde",
                ScreenSize =5.1,
                Res = "2560*1440",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "双面第四代康宁大猩猩玻璃",
                ScreenProportion =71.99,
                NetWorkType = "单卡,全网通",
                OperatingSystem = "Android OS 5.0",
                RearCamera =1600,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,加速传感器,
光线传感器,距离传感器,
指纹识别,心率传感器",
                Memory =3,
                PhoneColor = "黑色,白色,金色,松柏绿色",
                PhoneLamp = "LED",
                BatteryCapacity =2600,
                Cores = "真八",
                PhoneCPU = "三星 Exynos 7420",
                PhoneCPUFrequency =2.1,
                PhoneROM = "32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Samsung/S6E.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 8,
                PhoneCategoryName = "iphone",
                PhoneName = "iPhone 5SE",
                ScreenSize =4,
                Res = "1136x640",
                ScreenMaterial = "视网膜Retina技术,Multi‑Touch",
                OtherScreenParameter = @"LED背光宽显示屏,800:1对比度(标
准),500cd/m2最大亮度(标准),全
sRGB标准,采用防油渍防指纹涂层,
支持多种语言文字同时显示",
                ScreenProportion =60.85,
                NetWorkType = "全网通",
                OperatingSystem = "iOS 9",
                RearCamera =1200,
                FrontFacingCamera =120,
                TH = "无",
                Sensors = @"加速传感器,光线传感器,距离传感
器,TouchID指纹识别传感器,三轴
陀螺仪,数字指南针",
                Memory =2,
                PhoneColor = "金色,玫瑰金色,银色,深空灰色",
                PhoneLamp = "True Tone",
                BatteryCapacity =1642,
                Cores = "双",
                PhoneCPU = "苹果 A9+M9协处理器",
                PhoneCPUFrequency =1.8,
                PhoneROM = "16GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/IPhone/I5SE.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 9,
                PhoneCategoryName = "iphone",
                PhoneName = "iPhone 6",
                ScreenSize =4.7,
                Res = "1334*750",
                ScreenMaterial = "Multi‑Touch(IPS技术)",
                OtherScreenParameter = "无",
                ScreenProportion =65.81,
                NetWorkType = "单卡,全网通",
                OperatingSystem = "iOS 8.0",
                RearCamera =800,
                FrontFacingCamera =120,
                TH = "无",
                Sensors = "背照式/BSI CMOS",
                Memory =1,
                PhoneColor = "深空灰色,银色,金色",
                PhoneLamp = "True Tone",
                BatteryCapacity =1810,
                Cores = "双",
                PhoneCPU = "苹果 A8+M8协处理器",
                PhoneCPUFrequency =1.4,
                PhoneROM = "16GB/64GB/128GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/IPhone/I6.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 10,
                PhoneCategoryName = "iphone",
                PhoneName = "iPhone 6Plus",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "Multi‑Touch(IPS技术)",
                OtherScreenParameter = "无",
                ScreenProportion =67.8,
                NetWorkType = "单卡",
                OperatingSystem = "iOS 8.0",
                RearCamera =800,
                FrontFacingCamera =120,
                TH = "无",
                Sensors = "背照式/BSI CMOS",
                Memory =1,
                PhoneColor = "太空灰,银白色,金色",
                PhoneLamp = "True Tone",
                BatteryCapacity =2915,
                Cores = "双",
                PhoneCPU = "苹果 A8+M8协处理器",
                PhoneCPUFrequency =1.4,
                PhoneROM = "16GB/64GB/128GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/IPhone/I6P.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 12,
                PhoneCategoryName = "iphone",
                PhoneName = "iPhone 5S",
                ScreenSize =4,
                Res = "1136x640",
                ScreenMaterial = "视网膜Retina技术",
                OtherScreenParameter = "无",
                ScreenProportion =60.85,
                NetWorkType = "单卡",
                OperatingSystem = "iOS 7.0",
                RearCamera =800,
                FrontFacingCamera =120,
                TH = "无",
                Sensors = @"重力感应器,加速传感器,光线传感
器,距离传感器,指纹识别,陀螺仪,
电子罗盘",
                Memory =1,
                PhoneColor = "深空灰色,银色,金色",
                PhoneLamp = "LED",
                BatteryCapacity =1560,
                Cores = "双",
                PhoneCPU = "苹果 A7/M7协处理器",
                PhoneCPUFrequency =1.3,
                PhoneROM = "16GB/32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/IPhone/I5S.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 13,
                PhoneCategoryName = "iphone",
                PhoneName = "iPhone 5",
                ScreenSize =4,
                Res = "1136*640",
                ScreenMaterial = @"视网膜Retina技术,In-Cell全贴合
技术",
                OtherScreenParameter = "无",
                ScreenProportion =60.85,
                NetWorkType = "单卡",
                OperatingSystem = "iOS 6.0",
                RearCamera =800,
                FrontFacingCamera =120,
                TH = "无",
                Sensors = @"重力感应器,加速传感器,光线传感
器,距离传感器,陀螺仪",
                Memory =1,
                PhoneColor = "",
                PhoneLamp = "LED",
                BatteryCapacity =1440,
                Cores = "双",
                PhoneCPU = "苹果 A6",
                PhoneCPUFrequency =1,
                PhoneROM = "16GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/IPhone/I5.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 14,
                PhoneCategoryName = "sanxing",
                PhoneName = "三星 C5",
                ScreenSize =5.2,
                Res = "192*1080",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "屏幕色彩:1600万色",
                ScreenProportion =70.95,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "Android OS 6.0",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,霍尔传感器,指纹识别,加速
感应器",
                Memory =4,
                PhoneColor = "枫叶金,蔷薇粉,皎洁银,烟雨灰",
                PhoneLamp = "LED",
                BatteryCapacity =2600,
                Cores = "八",
                PhoneCPU = "高通 骁龙617",
                PhoneCPUFrequency =1.5,
                PhoneROM = "32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Samsung/C5.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 15,
                PhoneCategoryName = "sanxing",
                PhoneName = "三星C7",
                ScreenSize =5.7,
                Res = "1920*1080",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "无",
                ScreenProportion =0,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android OS 6.0",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,指纹识别",
                Memory =4,
                PhoneColor = "枫叶金,蔷薇粉,皎洁银,烟雨灰",
                PhoneLamp = "LED",
                BatteryCapacity =3300,
                Cores = "八",
                PhoneCPU = "高通 骁龙625",
                PhoneCPUFrequency =0,
                PhoneROM = "32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Samsung/C7.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 16,
                PhoneCategoryName = "sanxing",
                PhoneName = "三星A9",
                ScreenSize =6,
                Res = "1920*1080",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "双面2.5D玻璃",
                ScreenProportion =75.88,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android OS 5.1",
                RearCamera =1300,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,线传感器,距离传感器
,指纹识别,霍尔传感器",
                Memory =3,
                PhoneColor = "金色,白色,粉色",
                PhoneLamp = "LED",
                BatteryCapacity =4000,
                Cores = "真八",
                PhoneCPU = "高通 骁龙Snapdragon MSM8976",
                PhoneCPUFrequency =1.8,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Samsung/A9.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 17,
                PhoneCategoryName = "nokia",
                PhoneName = "Lumia 920",
                ScreenSize =4.5,
                Res = "1280x768",
                ScreenMaterial = "IPS",
                OtherScreenParameter = "超灵敏触摸,悦幕技术",
                ScreenProportion =62.49,
                NetWorkType = "单卡",
                OperatingSystem = "Windows phone 8",
                RearCamera =870,
                FrontFacingCamera =120,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,陀螺仪,加速传感器",
                Memory =1,
                PhoneColor = "黑色,白色,黄色,红色,蓝色",
                PhoneLamp = "LED",
                BatteryCapacity =2000,
                Cores = "双",
                PhoneCPU = "高通 骁龙Snapdragon MSM8260A",
                PhoneCPUFrequency =1.5,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Nokia/920.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 18,
                PhoneCategoryName = "nokia",
                PhoneName = "Lumia 830",
                ScreenSize =5,
                Res = "1280*720",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = @"屏幕功能:亮度控制,耐磨玻璃,强
光可视性增强,便于清洁,高亮度
模式,Lumia颜色配置,诺基亚Glanc
eScreen,超大观看角度,双击唤醒",
                ScreenProportion =69.92,
                NetWorkType = "单卡",
                OperatingSystem = "Windows phone 8.1",
                RearCamera =1000,
                FrontFacingCamera =90,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,地磁传感器,陀螺仪",
                Memory =1,
                PhoneColor = "黑色,白色,橙色,绿色,金色",
                PhoneLamp = "LED",
                BatteryCapacity =2200,
                Cores = "四",
                PhoneCPU = "高通 骁龙400(MSM8926)",
                PhoneCPUFrequency =1.2,
                PhoneROM = "16GB",
                BatteryType = "可",
                PhoneImage = "/Images/PhoneImage/Nokia/830.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 19,
                PhoneCategoryName = "nokia",
                PhoneName = "Lumia 925",
                ScreenSize =4.5,
                Res = "1280*768",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = @"超灵敏触摸,悦幕技术,康宁大猩
猩2代",
                ScreenProportion =63.3,
                NetWorkType = @"HSPA+,联通3G(WCDMA),联通2G/移
动2G(GSM)",
                OperatingSystem = "Windows phone 8 ",
                RearCamera =870,
                FrontFacingCamera =130,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,陀螺仪,加速传感器",
                Memory =1,
                PhoneColor = "黑色,白色,灰色 ",
                PhoneLamp = "LED",
                BatteryCapacity =2000,
                Cores = "双",
                PhoneCPU = "高通 骁龙Snapdragon MSM8260A",
                PhoneCPUFrequency =1.5,
                PhoneROM = "16GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Nokia/925.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 20,
                PhoneCategoryName = "nokia",
                PhoneName = "Lumia 730",
                ScreenSize =4.7,
                Res = "1280*720",
                ScreenMaterial = "无",
                OtherScreenParameter = "无",
                ScreenProportion =66,
                NetWorkType = "双卡",
                OperatingSystem = "Windows phone 8.1",
                RearCamera =670,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,陀螺仪,加速传感器",
                Memory =1,
                PhoneColor = "黑色,白色,绿色,橙色",
                PhoneLamp = "LED",
                BatteryCapacity =2220,
                Cores = "四",
                PhoneCPU = "高通 骁龙400(MSM8926)",
                PhoneCPUFrequency =1.2,
                PhoneROM = "8GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Nokia/730.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 21,
                PhoneCategoryName = "nokia",
                PhoneName = "Lumia 1520",
                ScreenSize =6,
                Res = "1920*1080",
                ScreenMaterial = "IPS LCD",
                OtherScreenParameter = "超灵敏触摸,悦幕技术",
                ScreenProportion =71.39,
                NetWorkType = "单卡",
                OperatingSystem = "Windows phone 8 GDR3",
                RearCamera =2000,
                FrontFacingCamera =120,
                TH = "无",
                Sensors = @"光线传感器,距离传感器,加速传
感器,地磁传感器,陀螺仪",
                Memory =2,
                PhoneColor = "黑色,白色,红色,黄色",
                PhoneLamp = "LED",
                BatteryCapacity =3400,
                Cores = "四",
                PhoneCPU = "高通 骁龙800(MSM8974)",
                PhoneCPUFrequency =2.2,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Nokia/1520.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 22,
                PhoneCategoryName = "nokia",
                PhoneName = "Lumia 930",
                ScreenSize =5,
                Res = "1920*1080",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = @"超灵敏触摸,第三代康宁大猩猩玻
璃",
                ScreenProportion =70.84,
                NetWorkType = "单卡",
                OperatingSystem = "Windows phone 8.1",
                RearCamera =2000,
                FrontFacingCamera =120,
                TH = "无",
                Sensors = @"光线传感器,距离传感器,加速传
感器,陀螺仪,地磁传感器",
                Memory =2,
                PhoneColor = "黑色,白色,橙色,绿色,金色",
                PhoneLamp = "LED",
                BatteryCapacity =2420,
                Cores = "四",
                PhoneCPU = "高通 骁龙800",
                PhoneCPUFrequency =2.2,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Nokia/930.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 23,
                PhoneCategoryName = "nokia",
                PhoneName = "Lumia 929",
                ScreenSize =5,
                Res = "1920*1080",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "暂无数据",
                ScreenProportion =71,
                NetWorkType = "LTE",
                OperatingSystem = "Windows phone 8 GDR3",
                RearCamera =2000,
                FrontFacingCamera =120,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器",
                Memory =2,
                PhoneColor = "黑色,白色",
                PhoneLamp = "LED",
                BatteryCapacity =2420,
                Cores = "四",
                PhoneCPU = "高通 骁龙800",
                PhoneCPUFrequency =2.2,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Nokia/929.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 24,
                PhoneCategoryName = "nokia",
                PhoneName = "Lumia 1320",
                ScreenSize =6,
                Res = "1280*720",
                ScreenMaterial = "IPS",
                OtherScreenParameter = @"超灵敏触摸,康宁大猩猩玻璃,悦
幕技术",
                ScreenProportion =70.37,
                NetWorkType = "单卡",
                OperatingSystem = "Windows phone 8",
                RearCamera =500,
                FrontFacingCamera =30,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器",
                Memory =1,
                PhoneColor = "黑色,白色,黄色,橙色",
                PhoneLamp = "LED",
                BatteryCapacity =3400,
                Cores = "双",
                PhoneCPU = "高通 骁龙Snapdragon S4",
                PhoneCPUFrequency =1.7,
                PhoneROM = "8GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Nokia/1320.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 25,
                PhoneCategoryName = "microsoft",
                PhoneName = "Lumia 950XL",
                ScreenSize =5.7,
                Res = "2560*1440",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "超灵敏触摸,悦幕技术",
                ScreenProportion =75.21,
                NetWorkType = "双卡",
                OperatingSystem = "Windows 10 Mobile",
                RearCamera =2000,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,加速传感器,气压计,陀螺仪
,磁力计",
                Memory =3,
                PhoneColor = "黑色,白色",
                PhoneLamp = "LED",
                BatteryCapacity =3340,
                Cores = "八",
                PhoneCPU = "高通 骁龙810",
                PhoneCPUFrequency =3340,
                PhoneROM = "32GB",
                BatteryType = "可",
                PhoneImage = "/Images/PhoneImage/Microsoft/950xl.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 26,
                PhoneCategoryName = "microsoft",
                PhoneName = "Lumia 950",
                ScreenSize =5.2,
                Res = "2560*1440",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "Glance屏幕",
                ScreenProportion =70.22,
                NetWorkType = "双卡,双4G",
                OperatingSystem = "Windows 10 Mobile",
                RearCamera =2000,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,加速传感器,气压计,陀螺仪
,磁力计",
                Memory =3,
                PhoneColor = "黑色,白色",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "六",
                PhoneCPU = "高通 骁龙808",
                PhoneCPUFrequency =1.8,
                PhoneROM = "32GB",
                BatteryType = "可",
                PhoneImage = "/Images/PhoneImage/Microsoft/950.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 27,
                PhoneCategoryName = "microsoft",
                PhoneName = "Lumia 640",
                ScreenSize =5,
                Res = "1280*720",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "强光可视性增强",
                ScreenProportion =67.55,
                NetWorkType = "双卡,双4G",
                OperatingSystem = "Windows phone 8.1",
                RearCamera =800,
                FrontFacingCamera =90,
                TH = "无",
                Sensors = @"光线传感器,距离传感器,加速传
感器,地磁传感器",
                Memory =1,
                PhoneColor = "黑色,白色,橙色,蓝色,绿色",
                PhoneLamp = "LED",
                BatteryCapacity =2500,
                Cores = "四",
                PhoneCPU = "高通 骁龙400",
                PhoneCPUFrequency =1.2,
                PhoneROM = "8GB",
                BatteryType = "可",
                PhoneImage = "/Images/PhoneImage/Microsoft/640.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 28,
                PhoneCategoryName = "microsoft",
                PhoneName = "Lumia 640XL",
                ScreenSize =5.7,
                Res = "1280*720",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "暂无数据",
                ScreenProportion =69.6,
                NetWorkType = "双卡,双4G",
                OperatingSystem = "Windows phone 8.1",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"光线传感器,距离传感器,加速传
感器,地磁传感器",
                Memory =1,
                PhoneColor = @"黑色,白色,灰色,蓝色,橙色,青色
,绿色",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "四",
                PhoneCPU = "高通 骁龙400",
                PhoneCPUFrequency =1.2,
                PhoneROM = "8GB",
                BatteryType = "可",
                PhoneImage = "/Images/PhoneImage/Microsoft/640xl.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 29,
                PhoneCategoryName = "microsoft",
                PhoneName = "Lumia 650",
                ScreenSize =5,
                Res = "1280*720",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "暂无数据",
                ScreenProportion =68.45,
                NetWorkType = "双卡,双4G",
                OperatingSystem = "Windows 10 Mobile",
                RearCamera =800,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"光线传感器,距离传感器,加速传
感器",
                Memory =1,
                PhoneColor = "黑色,白色",
                PhoneLamp = "LED",
                BatteryCapacity =2000,
                Cores = "四",
                PhoneCPU = "高通 骁龙212",
                PhoneCPUFrequency =1.3,
                PhoneROM = "16GB",
                BatteryType = "可",
                PhoneImage = "/Images/PhoneImage/Microsoft/650.jpg"
            });
            #endregion

            phones.Add(new FindPhone
            {
                Id = 30,
                PhoneCategoryName = "motorola",
                PhoneName = "Moto Z",
                ScreenSize =5.5,
                Res = "2560*1440",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "暂无数据",
                ScreenProportion =0.0,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "暂无数据",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,指纹识别",
                Memory =4,
                PhoneColor = "黑色,金色",
                PhoneLamp = "LED",
                BatteryCapacity =0,
                Cores = "四",
                PhoneCPU = "高通 骁龙820",
                PhoneCPUFrequency =1.2,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Motorola/z.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 31,
                PhoneCategoryName = "motorola",
                PhoneName = "Moto X Pro",
                ScreenSize =5.96,
                Res = "2560*1440",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "第三代康宁大猩猩玻璃",
                ScreenProportion =74.07,
                NetWorkType = "全网通",
                OperatingSystem = "Android OS 5.0",
                RearCamera =1300,
                FrontFacingCamera =200,
                TH = "无",
                Sensors = @"加速传感器,磁力传感器,陀螺仪,
光线传感器,接近传感器,指南针,
电池温度传感器,1个红外发射器,
3个红外线LED",
                Memory =3,
                PhoneColor = "黑色",
                PhoneLamp = "环形LED",
                BatteryCapacity =3220,
                Cores = "四",
                PhoneCPU = "高通 骁龙805",
                PhoneCPUFrequency =2.7,
                PhoneROM = "32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Motorola/xpro.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 32,
                PhoneCategoryName = "motorola",
                PhoneName = "Moto X Style",
                ScreenSize =5.7,
                Res = "2560*1440",
                ScreenMaterial = "暂无数据",
                OtherScreenParameter = "暂无数据",
                ScreenProportion =76.38,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android OS 5.1",
                RearCamera =2100,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,电子罗盘,陀螺仪",
                Memory =3,
                PhoneColor = "黑色,白色",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "六",
                PhoneCPU = "高通 骁龙808",
                PhoneCPUFrequency =1.8,
                PhoneROM = "16GB/32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Motorola/xpro.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 33,
                PhoneCategoryName = "motorola",
                PhoneName = "Moto X",
                ScreenSize =5.2,
                Res = "1920*1080",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "暂无数据",
                ScreenProportion =73.12,
                NetWorkType = "全网通",
                OperatingSystem = "Android OS 5.0",
                RearCamera =1300,
                FrontFacingCamera =200,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,红外传感器",
                Memory =2,
                PhoneColor = @"雅典黑色,绿松蓝色,蔓越粉色,天
然竹,黑檀木,本色皮",
                PhoneLamp = "LED",
                BatteryCapacity =2300,
                Cores = "四",
                PhoneCPU = "高通 骁龙801",
                PhoneCPUFrequency =2.5,
                PhoneROM = "16GB/32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Motorola/x.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 34,
                PhoneCategoryName = "motorola",
                PhoneName = "Nexus 6",
                ScreenSize =5.96,
                Res = "2560*1080",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "暂无数据",
                ScreenProportion =74.07,
                NetWorkType = "LTE",
                OperatingSystem = "Android OS 5.0",
                RearCamera =1300,
                FrontFacingCamera =200,
                TH = "无",
                Sensors = "加速传感器,电子罗盘,陀螺仪",
                Memory =3,
                PhoneColor = "午夜蓝色,云白色",
                PhoneLamp = "双LED",
                BatteryCapacity =3220,
                Cores = "四",
                PhoneCPU = "高通 骁龙805",
                PhoneCPUFrequency =2.7,
                PhoneROM = "32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Motorola/nexus6.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 35,
                PhoneCategoryName = "motorola",
                PhoneName = "Moto X 极",
                ScreenSize =5.4,
                Res = "2560*1440",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "Moto ShatterShield™ 极御技术",
                ScreenProportion =68.79,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android OS 5.1",
                RearCamera =2100,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,加速传感器,地磁传感器,
霍尔传感器,陀螺仪",
                Memory =3,
                PhoneColor = "玛雅黑,梵帝白",
                PhoneLamp = "LED",
                BatteryCapacity =3760,
                Cores = "真八",
                PhoneCPU = "高通 骁龙810",
                PhoneCPUFrequency =2.0,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Motorola/x极.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 36,
                PhoneCategoryName = "motorola",
                PhoneName = "Moto Z Force",
                ScreenSize =5.5,
                Res = "2560*1440",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "暂无数据",
                ScreenProportion =0.0,
                NetWorkType = "暂无数据",
                OperatingSystem = "Android OS 6.0",
                RearCamera =1200,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,指纹识别",
                Memory =4,
                PhoneColor = "黑色,金色",
                PhoneLamp = "LED",
                BatteryCapacity =3500,
                Cores = "四",
                PhoneCPU = "高通 骁龙820",
                PhoneCPUFrequency =2.2,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Motorola/zf.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 37,
                PhoneCategoryName = "motorola",
                PhoneName = "Moto G",
                ScreenSize =5,
                Res = "1280*720",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "第三代康宁大猩猩玻璃 ",
                ScreenProportion =68.88,
                NetWorkType = "双卡,双4G",
                OperatingSystem = "Android OS 5.0",
                RearCamera =800,
                FrontFacingCamera =200,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,霍尔效应传感器,加速传感
器,电子罗盘,陀螺仪",
                Memory =1,
                PhoneColor = "黑色,白色",
                PhoneLamp = "LED",
                BatteryCapacity =2390,
                Cores = "四",
                PhoneCPU = "高通 骁龙400",
                PhoneCPUFrequency =1.2,
                PhoneROM = "8GB/16GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Motorola/g.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 38,
                PhoneCategoryName = "blackberry",
                PhoneName = "黑莓Priv",
                ScreenSize =5.4,
                Res = "2560*1440",
                ScreenMaterial = "暂无数据",
                OtherScreenParameter = "暂无数据",
                ScreenProportion =0.0,
                NetWorkType = "暂无数据",
                OperatingSystem = "Android OS 5.0",
                RearCamera =1800,
                FrontFacingCamera =200,
                TH = "无",
                Sensors = "暂无数据",
                Memory =3,
                PhoneColor = "暂无数据",
                PhoneLamp = "双LED",
                BatteryCapacity =3410,
                Cores = "六",
                PhoneCPU = "高通 骁龙808",
                PhoneCPUFrequency =1.8,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/BlackBerry/priv.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 39,
                PhoneCategoryName = "blackberry",
                PhoneName = "黑莓PSE",
                ScreenSize =4.5,
                Res = "1440*1440",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "暂无数据",
                ScreenProportion =0.0,
                NetWorkType = "暂无数据",
                OperatingSystem = "BlackBerry OS 10.3",
                RearCamera =1300,
                FrontFacingCamera =200,
                TH = "暂无",
                Sensors = "暂无",
                Memory =3,
                PhoneColor = "银色",
                PhoneLamp = "LED",
                BatteryCapacity =3450,
                Cores = "暂无数据",
                PhoneCPU = "高通 骁龙801",
                PhoneCPUFrequency =2.2,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/BlackBerry/PSE.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 40,
                PhoneCategoryName = "blackberry",
                PhoneName = "黑莓Leap",
                ScreenSize =5,
                Res = "1280*720",
                ScreenMaterial = "暂无",
                OtherScreenParameter = "暂无",
                ScreenProportion =65.73,
                NetWorkType = "暂无",
                OperatingSystem = "BlackBerry OS 10.3",
                RearCamera =800,
                FrontFacingCamera =120,
                TH = "无",
                Sensors = "暂无数据",
                Memory =2,
                PhoneColor = "黑色,白色",
                PhoneLamp = "LED",
                BatteryCapacity =2800,
                Cores = "暂无数据",
                PhoneCPU = "高通 骁龙Snapdragon MSM8960",
                PhoneCPUFrequency =1.5,
                PhoneROM = "16GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/BlackBerry/Leap.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 41,
                PhoneCategoryName = "blackberry",
                PhoneName = "黑莓P9983",
                ScreenSize =3.1,
                Res = "720*720",
                ScreenMaterial = "暂无",
                OtherScreenParameter = "暂无",
                ScreenProportion =38.83,
                NetWorkType = "LTE",
                OperatingSystem = "BlackBerry OS 10.3",
                RearCamera =800,
                FrontFacingCamera =200,
                TH = "无",
                Sensors = "暂无",
                Memory =2,
                PhoneColor = "黑色",
                PhoneLamp = "暂无数据",
                BatteryCapacity =2100,
                Cores = "双",
                PhoneCPU = "高通 骁龙Snapdragon",
                PhoneCPUFrequency =1.5,
                PhoneROM = "64GB",
                BatteryType = "可",
                PhoneImage = "/Images/PhoneImage/BlackBerry/p9983.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 42,
                PhoneCategoryName = "blackberry",
                PhoneName = "黑莓Passport",
                ScreenSize =4.5,
                Res = "1440*1440",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "第三代康宁大猩猩玻璃",
                ScreenProportion =56.51,
                NetWorkType = "单卡",
                OperatingSystem = "BlackBerry OS 10.3",
                RearCamera =1300,
                FrontFacingCamera =200,
                TH = "无",
                Sensors = "无",
                Memory =3,
                PhoneColor = "暂无",
                PhoneLamp = "LED",
                BatteryCapacity =3450,
                Cores = "四",
                PhoneCPU = "高通 骁龙800",
                PhoneCPUFrequency =2.2,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/BlackBerry/passport.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 43,
                PhoneCategoryName = "blackberry",
                PhoneName = "黑莓Z3",
                ScreenSize =5,
                Res = "960*540",
                ScreenMaterial = "暂无",
                OtherScreenParameter = "暂无",
                ScreenProportion =0.0,
                NetWorkType = @"联通3G(WCDMA),联通2G/移动2G(G
SM)",
                OperatingSystem = "BlackBerry OS 10.2",
                RearCamera =500,
                FrontFacingCamera =110,
                TH = "无",
                Sensors = "暂无",
                Memory =1,
                PhoneColor = "黑色",
                PhoneLamp = "LED",
                BatteryCapacity =2650,
                Cores = "双",
                PhoneCPU = "高通 骁龙400",
                PhoneCPUFrequency =1.2,
                PhoneROM = "64GB",
                BatteryType = "暂无",
                PhoneImage = "/Images/PhoneImage/BlackBerry/z3.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 44,
                PhoneCategoryName = "htc",
                PhoneName = "HTC 10",
                ScreenSize =5.2,
                Res = "2560*1440",
                ScreenMaterial = "Super LCD",
                OtherScreenParameter = "2.5D屏幕",
                ScreenProportion =71.01,
                NetWorkType = "移动TD-LTE,联通TD-LTE,联通FDD-LTE",
                OperatingSystem = "Android OS 6.0",
                RearCamera =1200,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,地磁传感器,电容式指纹识
别,陀螺仪",
                Memory =4,
                PhoneColor = "鎏光金,炫光银,夜光灰",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "四",
                PhoneCPU = "高通 骁龙820",
                PhoneCPUFrequency =0.0,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/HTC/10.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 45,
                PhoneCategoryName = "htc",
                PhoneName = "HTC One M9",
                ScreenSize =5,
                Res = "1920*1080",
                ScreenMaterial = "Super LCD3",
                OtherScreenParameter = "康宁大猩猩玻璃",
                ScreenProportion =68.37,
                NetWorkType = "联通TD-LTE,联通FDD-LTE",
                OperatingSystem = "Android OS 5.0",
                RearCamera =2000,
                FrontFacingCamera =400,
                TH = "无",
                Sensors = @"重力感应器,加速传感器,光线传
感器,距离传感器,陀螺仪,磁感
传感器,电子罗盘",
                Memory =3,
                PhoneColor = "乌金灰,金银汇,金尚金",
                PhoneLamp = "LED",
                BatteryCapacity =2840,
                Cores = "真八",
                PhoneCPU = "高通 骁龙810",
                PhoneCPUFrequency =2.0,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/HTC/m9.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 46,
                PhoneCategoryName = "huawei",
                PhoneName = "华为P9",
                ScreenSize =5.2,
                Res = "1920*1080",
                ScreenMaterial = "暂无",
                OtherScreenParameter = @"2.5D弧面玻璃,1670万色,色彩饱
和度(NTSC):96%",
                ScreenProportion =72.5,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "Android OS 6.0",
                RearCamera =1200,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,霍尔传感器,陀螺仪,指南针
,指纹识别",
                Memory =4,
                PhoneColor = "琥珀金,陶瓷白,玫瑰金",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "真八",
                PhoneCPU = "海思 Kirin 955",
                PhoneCPUFrequency =2.5,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Huawei/p9.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 47,
                PhoneCategoryName = "sony",
                PhoneName = "Xperia Z5 Premium",
                ScreenSize =5.5,
                Res = "3840*2160",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "暂无",
                ScreenProportion =71.25,
                NetWorkType = "双卡(仅主卡支持4G),双4G",
                OperatingSystem = "Android OS 5.1",
                RearCamera =2300,
                FrontFacingCamera =510,
                TH = "IP65等级防水,IP68等级防尘",
                Sensors = @"重力感应器,光线传感器,距离传
感器,指纹识别",
                Memory =3,
                PhoneColor = "黑色，金色，银色",
                PhoneLamp = "LED",
                BatteryCapacity =3430,
                Cores = "真八",
                PhoneCPU = "高通 骁龙810",
                PhoneCPUFrequency =2.0,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Sony/z5p.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 48,
                PhoneCategoryName = "oneplus",
                PhoneName = "OnePlus 3",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "2.5D玻璃",
                ScreenProportion =73.11,
                NetWorkType = "双卡，全网通",
                OperatingSystem = "H2 OS 1.4(基于Android OS 6.0)",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"指纹传感器,霍尔感应器,加速度传
感器,陀螺仪,距离感应器,环境光
传感器,电子罗盘",
                Memory =6,
                PhoneColor = "薄荷金,冰川灰",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "四",
                PhoneCPU = "高通 骁龙820",
                PhoneCPUFrequency =2.2,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/OnePlus/3.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 49,
                PhoneCategoryName = "smartisan",
                PhoneName = "Smartisan T2",
                ScreenSize =4.95,
                Res = "1920*1080",
                ScreenMaterial = "JDI(Pixel Eyes技术)",
                OtherScreenParameter = @"正反面2.5D玻璃面板,ID无边框设
计",
                ScreenProportion =65.96,
                NetWorkType = "全网通",
                OperatingSystem = "SmartisanOS(基于AndroidOS5.1)",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,地磁传感器,陀螺仪",
                Memory =3,
                PhoneColor = "黑色",
                PhoneLamp = "LED",
                BatteryCapacity =2670,
                Cores = "六",
                PhoneCPU = "高通 骁龙808",
                PhoneCPUFrequency =1.82,
                PhoneROM = "16GB/32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Smartisan/t2.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 50,
                PhoneCategoryName = "nubia",
                PhoneName = "Nubia Z11",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "暂无数据",
                OtherScreenParameter = @"无边框设计,2.5D玻璃,96%NTSC色
域,1500:1对比度",
                ScreenProportion =75.98,
                NetWorkType = "双卡（均可支持4G），全网通",
                OperatingSystem = "nubia UI 4.0(基于Android 6.0)",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,指纹识别,霍尔传感器,陀螺
仪,电子罗盘",
                Memory =6,
                PhoneColor = "咖啡金",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "四",
                PhoneCPU = "高通 骁龙820",
                PhoneCPUFrequency =2.15,
                PhoneROM = "128GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Nubia/z11.jpg"
            });

            #region
            phones.Add(new FindPhone
            {
                Id = 51,
                PhoneCategoryName = "lenovo",
                PhoneName = "VIBE Z2 Pro",
                ScreenSize =6,
                Res = "2560*1440",
                ScreenMaterial = "TFT材质(IPS/LTPS+技术)",
                OtherScreenParameter = "超灵敏触摸",
                ScreenProportion =78.26,
                NetWorkType = "双卡",
                OperatingSystem = "Android OS 4.4",
                RearCamera =1600,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,陀螺仪",
                Memory =3,
                PhoneColor = "银色",
                PhoneLamp = "LED",
                BatteryCapacity =4000,
                Cores = "四",
                PhoneCPU = "高通 骁龙801",
                PhoneCPUFrequency =2.5,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Lenovo/z2pro.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 52,
                PhoneCategoryName = "oppo",
                PhoneName = "OPPO R9",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "暂无",
                OtherScreenParameter = "暂无",
                ScreenProportion =73.94,
                NetWorkType = "双卡,全网通2.0",
                OperatingSystem = "ColorOS 3.0(基于Android OS5.1)",
                RearCamera =1300,
                FrontFacingCamera =1600,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,地磁感应,霍尔感应器,指纹
识别陀螺仪,支持微信计步",
                Memory =4,
                PhoneColor = "金色,玫瑰金",
                PhoneLamp = "LED",
                BatteryCapacity =2850,
                Cores = "真八",
                PhoneCPU = "联发科 MT6755",
                PhoneCPUFrequency =2.0,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Oppo/r9.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 53,
                PhoneCategoryName = "mi",
                PhoneName = "小米5",
                ScreenSize =5.15,
                Res = "1920*1080",
                ScreenMaterial = "暂无",
                OtherScreenParameter = @"支持阳光屏,强烈阳光下清晰可见
屏幕内容支持夜光屏支持护眼模式
支持色温调节支持标准模式,颜色
更准确",
                ScreenProportion =73.09,
                NetWorkType = "双卡（均可支持4G），全网通",
                OperatingSystem = "MIUI 7",
                RearCamera =1600,
                FrontFacingCamera =400,
                TH = "无",
                Sensors = @"红外感应器,光线传感器,距离传
感器,陀螺仪,霍尔感应器,加速传
感器,气压传感器,电子罗盘,指纹
识别",
                Memory =3,
                PhoneColor = "黑色,白色,金色,淡紫色",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "四",
                PhoneCPU = "高通 骁龙820",
                PhoneCPUFrequency =1.8,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Mi/m5.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 54,
                PhoneCategoryName = "honor",
                PhoneName = "荣耀8",
                ScreenSize =5.2,
                Res = "1920x1080",
                ScreenMaterial = "暂无",
                OtherScreenParameter = @"1670万色,色彩饱和度(NTSC)96%,
LTPS负向液晶显示屏",
                ScreenProportion =72.15,
                NetWorkType = "双卡（均可支持4G），全网通",
                OperatingSystem = "华为EMUI4.1(基于AndroidOS 6.0)",
                RearCamera =1200,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,接近传
感器,指纹识别,霍尔传感器,陀螺
仪,指南针",
                Memory =3,
                PhoneColor = "幻夜黑,珠光白,流光金",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "真八",
                PhoneCPU = "海思 Kirin 950",
                PhoneCPUFrequency =2.3,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Honor/8.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 55,
                PhoneCategoryName = "lg",
                PhoneName = "LG G5",
                ScreenSize =5.3,
                Res = "2560*1440",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = @"always on持续唤醒屏幕
Magic Slot模块化设计",
                ScreenProportion =70.14,
                NetWorkType = "全网通",
                OperatingSystem = "Android OS 6.0",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,加速传感器,电子罗盘,陀螺仪,
指纹识别",
                Memory =4,
                PhoneColor = "灰色,银色,金色,粉色",
                PhoneLamp = "双LED",
                BatteryCapacity =2700,
                Cores = "四",
                PhoneCPU = "高通 骁龙820",
                PhoneCPUFrequency =2.1,
                PhoneROM = "32GB",
                BatteryType = "可",
                PhoneImage = "/Images/PhoneImage/LG/g5.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 56,
                PhoneCategoryName = "tcl",
                PhoneName = "TCL 750",
                ScreenSize =5.2,
                Res = "1920*1080",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "支持阳光屏,支持护眼模式",
                ScreenProportion =71.6,
                NetWorkType = "全网通",
                OperatingSystem = "美心UI(基于Android OS 6.0)",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"距离感应器,指纹识别,陀螺仪,环
境光传感器,加速感应器,电子罗盘",
                Memory =3,
                PhoneColor = "月白,雅金,黛蓝",
                PhoneLamp = "LED",
                BatteryCapacity =2800,
                Cores = "真八",
                PhoneCPU = "Helio P10",
                PhoneCPUFrequency =1.8,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/TCL/750.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 57,
                PhoneCategoryName = "letv",
                PhoneName = "乐视2",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "暂无",
                OtherScreenParameter = @"ID无边框3.0色域:80%的超高NTSC
亮度:500nit最低:1nit",
                ScreenProportion =74.38,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "Android M",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,指纹识别,电子罗盘,霍尔感应器
,三轴陀螺仪",
                Memory =3,
                PhoneColor = "金,银,原力金",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "十",
                PhoneCPU = "联发科 Helio X20",
                PhoneCPUFrequency =2.3,
                PhoneROM = "16GB/32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Letv/2.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 58,
                PhoneCategoryName = "vivo",
                PhoneName = "XPlay5",
                ScreenSize =5.43,
                Res = "2560*1440",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "双曲面屏",
                ScreenProportion =69.49,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "Android OS 5.1",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,陀螺仪,指纹识别",
                Memory =4,
                PhoneColor = "玫瑰金,香槟金",
                PhoneLamp = "LED",
                BatteryCapacity =3600,
                Cores = "真八",
                PhoneCPU = "高通 骁龙Snapdragon MSM8976",
                PhoneCPUFrequency =1.8,
                PhoneROM = "128GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Vivo/xplay5.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 59,
                PhoneCategoryName = "zte",
                PhoneName = "中兴天机7",
                ScreenSize =5.5,
                Res = "2560*1440",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "3D压力屏,1600万色",
                ScreenProportion =73.3,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "Android OS 6.0",
                RearCamera =2000,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力传感器,光线传感器,距离传感
器,指纹识别,电子罗盘,陀螺仪",
                Memory =6,
                PhoneColor = "金色",
                PhoneLamp = "双LED",
                BatteryCapacity =3250,
                Cores = "四",
                PhoneCPU = "高通 骁龙820",
                PhoneCPUFrequency =2.3,
                PhoneROM = "128GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/ZTE/7.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 60,
                PhoneCategoryName = "zuk",
                PhoneName = "ZUK Z2Pro",
                ScreenSize =5.2,
                Res = "1920*1080",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = @"2.5D弧面玻璃,暗光护眼,日光屏,
蓝光护眼",
                ScreenProportion =72.71,
                NetWorkType = "双卡，全网通",
                OperatingSystem = "ZUI2.0",
                RearCamera =1300,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"指纹识别,血氧心率传感器,紫外线
传感器,环境光感应器,距离感应器,
气压式高度计,三轴加速度,三轴陀
螺仪,三轴电子罗盘,霍尔感应器",
                Memory =4,
                PhoneColor = "陶瓷白",
                PhoneLamp = "LED",
                BatteryCapacity =3100,
                Cores = "四",
                PhoneCPU = "高通 骁龙820",
                PhoneCPUFrequency =2.15,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/ZUK/z2pro.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 61,
                PhoneCategoryName = "360",
                PhoneName = "360 Q5",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "2.5D弧面屏",
                ScreenProportion =75.24,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "360 OS 2.0",
                RearCamera =1300,
                FrontFacingCamera =1300,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,霍尔传感器,指纹识别,电子
罗盘",
                Memory =4,
                PhoneColor = "流光金",
                PhoneLamp = "LED",
                BatteryCapacity =3200,
                Cores = "八",
                PhoneCPU = "高通 骁龙652",
                PhoneCPUFrequency =1.8,
                PhoneROM = "128GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/360/q5.jpg"
            });
            #endregion
            #region
            phones.Add(new FindPhone
            {
                Id = 62,
                PhoneCategoryName = "gionee",
                PhoneName = "金立M6",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "2.5D弧面屏,1600万色",
                ScreenProportion =72.72,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "amigo 3.5(基于Android OS 6.0)",
                RearCamera =1300,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,指纹识别,电子罗盘,陀螺仪",
                Memory =4,
                PhoneColor = "香槟金,摩卡金",
                PhoneLamp = "LED",
                BatteryCapacity =5000,
                Cores = "真八",
                PhoneCPU = "联发科 MT6755M",
                PhoneCPUFrequency =1.8,
                PhoneROM = "64GB/128GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Gionee/m6.jpg"
            });
            #endregion
            #endregion

            phones.Add(new FindPhone
            {
                Id = 63,
                PhoneCategoryName = "meizu",
                PhoneName = "魅族PRO 6",
                ScreenSize =5.2,
                Res = "1920*1080",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = @"压力感应屏幕对比度10000:1亮度
350cd/m2(典型值)制造工艺  On-
cell",
                ScreenProportion =71.28,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "Flyme OS",
                RearCamera =2116,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,霍尔磁传感器,触摸感应,电子罗
盘,气压计,指纹识别,陀螺仪",
                Memory =4,
                PhoneColor = @"香槟金,星空黑,月光银,玫瑰金,
烈焰红",
                PhoneLamp = "LED",
                BatteryCapacity =2560,
                Cores = "十",
                PhoneCPU = "联发科 Helio X25 ",
                PhoneCPUFrequency =1.4,
                PhoneROM = "32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/MeiZu/pro6.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 64,
                PhoneCategoryName = "lg",
                PhoneName = "LG G5 SE",
                ScreenSize =5.3,
                Res = "2560*1080",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "暂无",
                ScreenProportion =70.14,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android OS 6.0",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,电子罗盘,陀螺仪,指纹识别",
                Memory =3,
                PhoneColor = "流光金,苍穹灰,冰月银,花漾粉",
                PhoneLamp = "LED",
                BatteryCapacity =2700,
                Cores = "真八",
                PhoneCPU = "高通 骁龙652",
                PhoneCPUFrequency =1.8,
                PhoneROM = "32GB",
                BatteryType = "可",
                PhoneImage = "/Images/PhoneImage/LG/g5se.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 65,
                PhoneCategoryName = "lg",
                PhoneName = "LG Nexus 5",
                ScreenSize =4.95,
                Res = "1920*1080",
                ScreenMaterial = "IPS",
                OtherScreenParameter = "康宁大猩猩玻璃,OGS全贴合技术",
                ScreenProportion =70.84,
                NetWorkType = "FDD-LTE",
                OperatingSystem = "Android OS 4.4",
                RearCamera =800,
                FrontFacingCamera =130,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,气压感应器,陀螺仪",
                Memory =2,
                PhoneColor = "黑色,白色",
                PhoneLamp = "LED",
                BatteryCapacity =2300,
                Cores = "四",
                PhoneCPU = "高通 骁龙800(MSM8974)",
                PhoneCPUFrequency =2.3,
                PhoneROM = "16GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/LG/nexus5.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 66,
                PhoneCategoryName = "meizu",
                PhoneName = "魅族MX6",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "In-Cell全贴合技术",
                OtherScreenParameter = @"窄边框设计2.5D玻璃TDDI技术:大
幅提升触控稳定性对比度1500:1,
最高亮度500cd/㎡",
                ScreenProportion =72.2,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "Android OS 6.0",
                RearCamera =1200,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,指纹触摸
传感器,霍尔磁感应传感器,红外距
离感应器,电子罗盘,陀螺仪,指纹
识别",
                Memory =4,
                PhoneColor = "香槟金,星空灰,月光银,玫瑰金",
                PhoneLamp = "LED",
                BatteryCapacity =3060,
                Cores = "十",
                PhoneCPU = "联发科 Helio X20",
                PhoneCPUFrequency =2.3,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/MeiZu/mx6.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 67,
                PhoneCategoryName = "meizu",
                PhoneName = "魅族MX4 Pro",
                ScreenSize =5.5,
                Res = "2560*1536",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = @"单玻璃全贴合技术,第三代康宁大
猩猩玻璃,Nega负液晶",
                ScreenProportion =74.51,
                NetWorkType = "联通TD-LTE,联通FDD-LTE",
                OperatingSystem = "Android OS 4.4",
                RearCamera =2070,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,指纹触摸传感器,霍尔磁感
应传感器,环境色温感应器,电子
罗盘,陀螺仪",
                Memory =3,
                PhoneColor = "灰色,金色,银白色,银黑色",
                PhoneLamp = "LED",
                BatteryCapacity =3350,
                Cores = "真八",
                PhoneCPU = "三星 Exynos 5430",
                PhoneCPUFrequency =2.0,
                PhoneROM = "16GB/32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/MeiZu/mx4pro.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 68,
                PhoneCategoryName = "zte",
                PhoneName = "中兴AXON Mini",
                ScreenSize =5.2,
                Res = "1920*1080",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "2.5D弧面设计",
                ScreenProportion =74.2,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android OS 5.1",
                RearCamera =1300,
                FrontFacingCamera =800,
                TH = "",
                Sensors = @"重力感应器,光线传感器,距离传
感器,地磁传感器,霍尔传感器,电
子罗盘,陀螺仪",
                Memory =3,
                PhoneColor = "华尔金,睿银,玫瑰金",
                PhoneLamp = "LED",
                BatteryCapacity =2800,
                Cores = "真八",
                PhoneCPU = "高通 骁龙616(MSM8939)",
                PhoneCPUFrequency =1.5,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/ZTE/axon mini.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 69,
                PhoneCategoryName = "zte",
                PhoneName = "中兴AXON天机",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "2.5D边界悬浮",
                ScreenProportion =71.68,
                NetWorkType = "全网通",
                OperatingSystem = "Android OS 5.0",
                RearCamera =1300,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力传感器,光线传感器,距离传感
器,眼纹识别,指纹识别(国行),声纹
识别,加速传感器,电子罗盘,陀螺仪",
                Memory =3,
                PhoneColor = "华尔金,银色,蓝色",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "真八",
                PhoneCPU = "高通 骁龙810(MSM8994)",
                PhoneCPUFrequency =2.0,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/ZTE/axon.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 70,
                PhoneCategoryName = "vivo",
                PhoneName = "Vivo X7",
                ScreenSize =5.2,
                Res = "1920*1080",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "2.5D弧面屏,超窄边框",
                ScreenProportion =70.42,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android OS 5.1",
                RearCamera =1300,
                FrontFacingCamera =1600,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,指纹识别,陀螺仪",
                Memory =4,
                PhoneColor = "金色,玫瑰金,星空灰",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "真八",
                PhoneCPU = "高通 骁龙Snapdragon MSM8976",
                PhoneCPUFrequency =1.8,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Vivo/x7.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 71,
                PhoneCategoryName = "vivo",
                PhoneName = "Vivo X7 Plus",
                ScreenSize =5.7,
                Res = "1920*1080",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "暂无",
                ScreenProportion =72.34,
                NetWorkType = "双卡,全网通 ",
                OperatingSystem = "Android OS 5.1",
                RearCamera =1600,
                FrontFacingCamera =1600,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,陀螺仪,指纹识别",
                Memory =4,
                PhoneColor = "金色,玫瑰金",
                PhoneLamp = "双LED",
                BatteryCapacity =4000,
                Cores = "真八",
                PhoneCPU = "高通 骁龙Snapdragon MSM8976",
                PhoneCPUFrequency =1.8,
                PhoneROM = "64GB/128GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Vivo/x7p.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 72,
                PhoneCategoryName = "vivo",
                PhoneName = "Vivo X6S",
                ScreenSize =5.2,
                Res = "1920*1080",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "2.5D弧面屏",
                ScreenProportion =68.33,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android OS 5.1",
                RearCamera =1300,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,指纹识别",
                Memory =4,
                PhoneColor = "金色,玫瑰金",
                PhoneLamp = "LED",
                BatteryCapacity =2400,
                Cores = "八",
                PhoneCPU = "高通 骁龙Snapdragon MSM8976",
                PhoneCPUFrequency = 1.8,
                PhoneROM = "64GB/128GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Vivo/x6s.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 73,
                PhoneCategoryName = "oneplus",
                PhoneName = "一加手机2",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "TFT材质(IPS-NEO技术)",
                OtherScreenParameter = "无",
                ScreenProportion = 73.35,
                NetWorkType = "双卡,双4G",
                OperatingSystem = "Android OS 5.1",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,加速传感器,陀螺仪,电子罗
盘,霍尔感应器,电容式指纹识别,
触摸识别 ",
                Memory =4,
                PhoneColor = @"砂岩黑,竹质版,酸枝版,黑杏版,
凯夫拉版",
                PhoneLamp = "双LED",
                BatteryCapacity =3300,
                Cores = "真八",
                PhoneCPU = "高通 骁龙810(MSM8994)",
                PhoneCPUFrequency =0.0,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/OnePlus/op2.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 74,
                PhoneCategoryName = "oneplus",
                PhoneName = "一加手机X",
                ScreenSize =5,
                Res = "1920*1080",
                ScreenMaterial = "Super AMOLED",
                OtherScreenParameter = "2.5D玻璃手机,0.9毫米的玻璃",
                ScreenProportion =71.33,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "H2 OS 2.0(基于AndroidOS 5.1)",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,红外距离
传感器,加速传感器,电子罗盘,霍
尔传感器,陀螺仪",
                Memory =3,
                PhoneColor = "暗夜黑",
                PhoneLamp = "LED",
                BatteryCapacity =2525,
                Cores = "无",
                PhoneCPU = "无",
                PhoneCPUFrequency =0.0,
                PhoneROM = "16GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/OnePlus/x.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 75,
                PhoneCategoryName = "sony",
                PhoneName = "Xperia Z5",
                ScreenSize =5.2,
                Res = "1920*1080",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "暂无",
                ScreenProportion =70.9,
                NetWorkType = "双卡(仅主卡支持4G),双4G",
                OperatingSystem = "Android OS 5.1",
                RearCamera =2300,
                FrontFacingCamera =500,
                TH = "IP65/68等级",
                Sensors = @"重力感应器,光线传感器,距离传
感器,指纹识别",
                Memory =3,
                PhoneColor = "白色,黑色,金色,绿色,粉色",
                PhoneLamp = "LED",
                BatteryCapacity =2900,
                Cores = "真八",
                PhoneCPU = "高通 骁龙810(MSM8994)",
                PhoneCPUFrequency =2.0,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Sony/z5.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 76,
                PhoneCategoryName = "oneplus",
                PhoneName = "一加手机1",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = @"无",
                OtherScreenParameter = @"悬浮屏幕,CABC背光亮度调节,Ram
自动省电刷新",
                ScreenProportion =71.86,
                NetWorkType = "单卡",
                OperatingSystem = "Color OS",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,加速传感器,陀螺仪,电子罗盘",
                Memory =3,
                PhoneColor = "Baby Skin白色,砂岩黑色",
                PhoneLamp = "LED",
                BatteryCapacity = 3100,
                Cores = "四",
                PhoneCPU = "高通 骁龙801(MSM8974AC)",
                PhoneCPUFrequency =2.5,
                PhoneROM = "16GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/OnePlus/o1.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 77,
                PhoneCategoryName = "nubia",
                PhoneName = "Nubia Z9",
                ScreenSize =5.2,
                Res = "1920*1080",
                ScreenMaterial = "CGS连续粒状结晶硅屏幕技术",
                OtherScreenParameter = "无",
                ScreenProportion =74.03,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android OS 5.0",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,陀螺仪,电子罗盘,双霍尔
感应器",
                Memory =3,
                PhoneColor = "黑色,金色",
                PhoneLamp = "LED",
                BatteryCapacity = 2900,
                Cores = "真八",
                PhoneCPU = "高通 骁龙810(MSM8994)",
                PhoneCPUFrequency = 2.0,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Nubia/z9.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 78,
                PhoneCategoryName = "smartisan",
                PhoneName = "Smartisan T1",
                ScreenSize =4.95,
                Res = "1920*1080",
                ScreenMaterial = "无",
                OtherScreenParameter = @"In-Cell全贴合技术,康宁大猩猩
玻璃,防指纹涂层",
                ScreenProportion =70.72,
                NetWorkType = "双4G",
                OperatingSystem = "Smartisan OS(基于Android OS 4.4)",
                RearCamera =1278,
                FrontFacingCamera =503,
                TH = "无",
                Sensors = @"光线传感器,距离传感器,加速传感
器,陀螺仪,电子罗盘",
                Memory =2,
                PhoneColor = "",
                PhoneLamp = "LED",
                BatteryCapacity =2570,
                Cores = "四",
                PhoneCPU = "高通 骁龙801(MSM8974AC)",
                PhoneCPUFrequency =2.5,
                PhoneROM = "16GB/32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Smartisan/t1.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 79,
                PhoneCategoryName = "smartisan",
                PhoneName = "坚果",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "TFT材质",
                OtherScreenParameter = @"第三代康宁大猩猩玻璃,GFF全贴合
技术",
                ScreenProportion =70.92,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "SmartisanOS2.0(基于AndroidOS4.4)",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传
感器,地磁传感器,陀螺仪",
                Memory =2,
                PhoneColor = @"红色,橙色,黄色,绿色,青色,蓝
色,紫色 ",
                PhoneLamp = "LED",
                BatteryCapacity =2900,
                Cores = "真八",
                PhoneCPU = "高通 骁龙615(MSM8939)",
                PhoneCPUFrequency =1.5,
                PhoneROM = "16GB/32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Smartisan/jg.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 80,
                PhoneCategoryName = "zuk",
                PhoneName = "ZUK Z2",
                ScreenSize =5,
                Res = "1920*1080",
                ScreenMaterial = "TFT材质(LTPS技术)",
                OtherScreenParameter = @"双面2.5D玻璃400nit最高亮度
1000:1对比度70%NTSC",
                ScreenProportion =70.63,
                NetWorkType = "双卡(仅主卡支持4G),全网通",
                OperatingSystem = "ZUI 2.0(基于Android OS 6.0)",
                RearCamera =1300,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"光线传感器,距离传感器,加速传感
器,霍尔传感器,陀螺仪,电子罗盘",
                Memory =4,
                PhoneColor = "黑色,白色",
                PhoneLamp = "LED",
                BatteryCapacity =3500,
                Cores = "四",
                PhoneCPU = "高通 骁龙820",
                PhoneCPUFrequency =2.15,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/ZUK/z2.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 81,
                PhoneCategoryName = "zuk",
                PhoneName = "ZUK Z1",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = @"防指纹涂层,屏偏光镜涂层1500:1
对比度(标准)100%NTSC450cd/m2
最大亮度(标准)",
                ScreenProportion =69.29,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android OS 5.1",
                RearCamera =1300,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,加速传感器,霍尔传感器,指纹识
别,电子罗盘,陀螺仪 ",
                Memory =3,
                PhoneColor = "白色,深空灰,橡木,檀木",
                PhoneLamp = "双LED",
                BatteryCapacity =4100,
                Cores = "四",
                PhoneCPU = "高通 骁龙801(MSM8974AC)",
                PhoneCPUFrequency =2.5,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/ZUK/z1.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 82,
                PhoneCategoryName = "letv",
                PhoneName = "乐视乐1S",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "无",
                OtherScreenParameter = "In-Cell全贴合技术",
                ScreenProportion =74.38,
                NetWorkType = "双卡(均可支持4G),双4G",
                OperatingSystem = "eUI 5.5(基于Android OS 5.1)",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,指纹识别,电子罗盘",
                Memory =3,
                PhoneColor = "金色,银色",
                PhoneLamp = "LED",
                BatteryCapacity = 3000,
                Cores = "真八",
                PhoneCPU = "联发科 Helio X10(MT6795)",
                PhoneCPUFrequency =2.2,
                PhoneROM = "16GB/32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Letv/1s.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 83,
                PhoneCategoryName = "letv",
                PhoneName = "乐视乐Max 2",
                ScreenSize =5.7,
                Res = "2560*1440",
                ScreenMaterial = "无",
                OtherScreenParameter = @"ID无边框3.0色域:95%的超高NTSC
亮度:450nit",
                ScreenProportion =0,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "Android M",
                RearCamera =2100,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,超声波指纹,红外遥控器,霍尔感
应器,电子罗盘,陀螺仪",
                Memory =4,
                PhoneColor = "原力金,金色,银色,灰色",
                PhoneLamp = "LED",
                BatteryCapacity =3100,
                Cores = "四",
                PhoneCPU = "高通 骁龙820",
                PhoneCPUFrequency =2.15,
                PhoneROM = "32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Letv/max2.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 84,
                PhoneCategoryName = "letv",
                PhoneName = "乐视乐2 Pro",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "无",
                OtherScreenParameter = "ID无边框3.0色域:80%的超高NTSC",
                ScreenProportion =74.38,
                NetWorkType = "双卡(均可支持4G),全网通 ",
                OperatingSystem = "Android M",
                RearCamera =2100,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,指纹识别,电子罗盘,霍尔感应器
,三轴陀螺仪 ",
                Memory =4,
                PhoneColor = "金,银,灰",
                PhoneLamp = "LED",
                BatteryCapacity =3000,
                Cores = "十",
                PhoneCPU = "联发科 Helio X20",
                PhoneCPUFrequency =2.3,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Letv/2pro.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 85,
                PhoneCategoryName = "mi",
                PhoneName = "小米Max",
                ScreenSize =6.44,
                Res = "1920*1080",
                ScreenMaterial = "",
                OtherScreenParameter = @"2.5D玻璃,450nit高亮度,1000:1对
比度,72%NTSC色域支持阳光屏,强
烈阳光下清晰可见屏幕内容支持夜
光屏支持护眼模式支持色温调节",
                ScreenProportion =74.79,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "MIUI 8",
                RearCamera =1600,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,加速传感器,霍尔传感器,指纹
识别,陀螺仪",
                Memory =3,
                PhoneColor = "银色,金色,浅灰",
                PhoneLamp = "LED",
                BatteryCapacity =4850,
                Cores = "六",
                PhoneCPU = "高通 骁龙650",
                PhoneCPUFrequency =1.8,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Mi/max.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 86,
                PhoneCategoryName = "mi",
                PhoneName = "小米Note",
                ScreenSize =5.7,
                Res = "1920*1080",
                ScreenMaterial = "JDI",
                OtherScreenParameter = @"阳光屏,护眼模式,大屏优化,双曲
面玻璃",
                ScreenProportion =74.42,
                NetWorkType = "双卡,双4G",
                OperatingSystem = "MIUI 6(基于Android OS 4.4)",
                RearCamera =1300,
                FrontFacingCamera =400,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,地磁传感器,霍尔传感器,陀螺
仪,气压计,电子罗盘",
                Memory =3,
                PhoneColor = "黑色,白色",
                PhoneLamp = "LED",
                BatteryCapacity = 3000,
                Cores = "四",
                PhoneCPU = "高通 骁龙801",
                PhoneCPUFrequency =2.5,
                PhoneROM = "16GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Mi/note.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 87,
                PhoneCategoryName = "mi",
                PhoneName = "小米4S",
                ScreenSize =5,
                Res = "1920*1080",
                ScreenMaterial = "LED背光显示屏",
                OtherScreenParameter = @"支持阳光屏,强烈阳光下清晰可见
屏幕内容,支持夜光屏,95%NTSC色
域,支持护眼模式,支持色温调节",
                ScreenProportion =69.93,
                NetWorkType = "全网通2.0",
                OperatingSystem = "MIUI 7",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,陀螺仪,霍尔感应器,电子罗盘,
指纹识别",
                Memory =3,
                PhoneColor = "黑色,白色,金色,淡紫色",
                PhoneLamp = "LED",
                BatteryCapacity =3260,
                Cores = "六",
                PhoneCPU = "高通 骁龙808",
                PhoneCPUFrequency =0.1,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Mi/4s.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 88,
                PhoneCategoryName = "mi",
                PhoneName = "小米4",
                ScreenSize =5,
                Res = "1920*1080",
                ScreenMaterial = "无",
                OtherScreenParameter = "超灵敏触摸,OGS全贴合技术",
                ScreenProportion =72.27,
                NetWorkType = "单卡",
                OperatingSystem = "MIUI 6(基于Android OS 4.4)",
                RearCamera =1300,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,陀螺仪,霍尔感应器,气压传感
器,电子罗盘",
                Memory =3,
                PhoneColor = "黑色,白色",
                PhoneLamp = "LED",
                BatteryCapacity = 3080,
                Cores = "四",
                PhoneCPU = "高通 骁龙801(MSM8974AC)",
                PhoneCPUFrequency =2.5,
                PhoneROM = "16GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Mi/4.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 89,
                PhoneCategoryName = "mi",
                PhoneName = "红米Note4",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "无",
                OtherScreenParameter = @"2.5D弧面玻璃阳光屏,夜光屏,护眼
模式和色温调节",
                ScreenProportion =72.67,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "MIUI 8",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,霍尔感应器,陀螺仪,指纹识别",
                Memory =3,
                PhoneColor = "灰色,银色,金色",
                PhoneLamp = "LED",
                BatteryCapacity = 4100,
                Cores = "十",
                PhoneCPU = "联发科 Helio X20",
                PhoneCPUFrequency =2.1,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Mi/hmnote4.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 90,
                PhoneCategoryName = "mi",
                PhoneName = "红米 3X",
                ScreenSize =5,
                Res = "1280*720",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "护眼模式,降低屏幕蓝光,色温调节",
                ScreenProportion =71.08,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "MIUI 7",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,电子罗盘,指纹识别,陀螺仪",
                Memory =2,
                PhoneColor = "银白,金色",
                PhoneLamp = "LED",
                BatteryCapacity =4100,
                Cores = "真八",
                PhoneCPU = "高通 骁龙430",
                PhoneCPUFrequency =1.4,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Mi/3x.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 91,
                PhoneCategoryName = "mi",
                PhoneName = "红米Pro",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "OLED",
                OtherScreenParameter = @"2.5D玻璃100%NTSC色域非常艳丽支
持阳光屏,夜光屏,护眼模式,色温
调节",
                ScreenProportion =72.24,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "MIUI 7",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,霍尔感应器,陀螺仪,指纹识别",
                Memory =3,
                PhoneColor = "金色,银色,灰色",
                PhoneLamp = "LED",
                BatteryCapacity = 4050,
                Cores = "十",
                PhoneCPU = "联发科 Helio X20",
                PhoneCPUFrequency =2.1,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Mi/hmpro.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 92,
                PhoneCategoryName = "mi",
                PhoneName = "红米3S",
                ScreenSize =5,
                Res = "1280x720",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "护眼模式,降低屏幕蓝光,色温调节",
                ScreenProportion =71.08,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "MIUI 7",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,电子罗盘,指纹识别,陀螺仪",
                Memory =3,
                PhoneColor = "深灰,银白,金色",
                PhoneLamp = "LED",
                BatteryCapacity = 4100,
                Cores = "真八",
                PhoneCPU = "高通 骁龙430",
                PhoneCPUFrequency =1.4,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Mi/3s.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 93,
                PhoneCategoryName = "mi",
                PhoneName = " 小米4C",
                ScreenSize =5,
                Res = "1920*1080",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = @"阳光屏,夜光屏,支持护眼模式,色
温调节,动态帧率调节",
                ScreenProportion = 71.69,
                NetWorkType = "移动TD-LTE",
                OperatingSystem = "MIUI 6(基于Android OS 5.1)",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,陀螺仪,霍尔感应器,电子罗盘",
                Memory =2,
                PhoneColor = "白色,金属灰,桃粉色,柠檬黄,湖蓝色",
                PhoneLamp = "LED",
                BatteryCapacity = 3080,
                Cores = "六",
                PhoneCPU = "高通 骁龙808",
                PhoneCPUFrequency =1.8,
                PhoneROM = "16GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Mi/4c.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 94,
                PhoneCategoryName = "mi",
                PhoneName = "红米3",
                ScreenSize =5,
                Res = "1280*720",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "阳光屏,夜光屏",
                ScreenProportion =71.08,
                NetWorkType = "移动TD-LTE",
                OperatingSystem = "MIUI 7",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,电子罗盘,陀螺仪",
                Memory =2,
                PhoneColor = @"时尚金色,时尚深灰,时尚银白,经
典金色",
                PhoneLamp = "LED",
                BatteryCapacity = 4100,
                Cores = "真八",
                PhoneCPU = "高通 骁龙616",
                PhoneCPUFrequency = 1.5,
                PhoneROM = "16GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Mi/hm3.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 95,
                PhoneCategoryName = "mi",
                PhoneName = "红米Note3",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "无",
                OtherScreenParameter = "阳光屏高级版,夜光屏",
                ScreenProportion =73.15,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "Android 5.1.1",
                RearCamera =1600,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,指纹识别,霍尔感应器,电子罗
盘,陀螺仪,红外遥控",
                Memory =3,
                PhoneColor = "银白色,金色,深灰色",
                PhoneLamp = "LED",
                BatteryCapacity =4050,
                Cores = "六",
                PhoneCPU = "高通 骁龙650",
                PhoneCPUFrequency =1.8,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Mi/hmnote3.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 96,
                PhoneCategoryName = "mi",
                PhoneName = "红米2A",
                ScreenSize =4.7,
                Res = "1280*720",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "全贴合技术",
                ScreenProportion =67.63,
                NetWorkType = "双卡",
                OperatingSystem = "MIUI 7",
                RearCamera =800,
                FrontFacingCamera =200,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,陀螺仪,电子罗盘",
                Memory =2,
                PhoneColor = @"白色,深灰,明黄,浅绿,淡粉",
                PhoneLamp = "LED",
                BatteryCapacity =2200,
                Cores = "四",
                PhoneCPU = "高通 骁龙410(MSM8916)",
                PhoneCPUFrequency =1.2,
                PhoneROM = "16GB",
                BatteryType = "可",
                PhoneImage = "/Images/PhoneImage/Mi/2a.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 97,
                PhoneCategoryName = "mi",
                PhoneName = "红米Note",
                ScreenSize =5.5,
                Res = "1280*720",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "GFF全贴合技术",
                ScreenProportion = 68.81,
                NetWorkType = "双卡",
                OperatingSystem = "MIUI 6(支持Android4.4)",
                RearCamera =1300,
                FrontFacingCamera =500,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,陀螺仪,电子罗盘",
                Memory =2,
                PhoneColor = "象牙白色",
                PhoneLamp = "LED",
                BatteryCapacity = 3100,
                Cores = "四",
                PhoneCPU = "高通 骁龙410(MSM8916)",
                PhoneCPUFrequency =1.2,
                PhoneROM = "16GB",
                BatteryType = "可",
                PhoneImage = "/Images/PhoneImage/Mi/hmnote.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 98,
                PhoneCategoryName = "huawei",
                PhoneName = "Mate 8",
                ScreenSize =6,
                Res = "1920*1080",
                ScreenMaterial = "TFT材质(IPS技术)",
                OtherScreenParameter = "2.5D玻璃",
                ScreenProportion =78.39,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "EMUI 4.0(兼容Android OS 6.0)",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,霍尔传感器,指纹识别,陀螺仪,
指南针",
                Memory =4,
                PhoneColor = "摩卡金,香槟金",
                PhoneLamp = "LED",
                BatteryCapacity = 4000,
                Cores = "真八",
                PhoneCPU = "海思 Kirin 950+微智核I5",
                PhoneCPUFrequency =2.3,
                PhoneROM = "64GB/128GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Huawei/mate8.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 99,
                PhoneCategoryName = "huawei",
                PhoneName = "麦芒5",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "无",
                OtherScreenParameter = "2.5D弧面玻璃",
                ScreenProportion =0,
                NetWorkType = "双卡,全网通",
                OperatingSystem = "EMUI4.1(基于Android OS 6.0)",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,霍尔传感器,指南针,指纹识别",
                Memory =4,
                PhoneColor = "香槟金,玫瑰金",
                PhoneLamp = "LED",
                BatteryCapacity =3340,
                Cores = "真八",
                PhoneCPU = "高通 骁龙625(MSM8953)",
                PhoneCPUFrequency =2.0,
                PhoneROM = "64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Huawei/mm5.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 100,
                PhoneCategoryName = "huawei",
                PhoneName = "P9 Plus",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "2.5D弧面玻璃,两级压感",
                ScreenProportion =0,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "Android OS 6.0",
                RearCamera =1200,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,加速传感器,光线传感
器,距离传感器,指南针,指纹识别",
                Memory =4,
                PhoneColor = "陶瓷白,玫瑰金,琥珀灰,琥珀金",
                PhoneLamp = "LED",
                BatteryCapacity =3400,
                Cores = "真八",
                PhoneCPU = "海思 Kirin 955",
                PhoneCPUFrequency =2.5,
                PhoneROM = "128GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Huawei/p9p.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 101,
                PhoneCategoryName = "huawei",
                PhoneName = "华为G9",
                ScreenSize =5.2,
                Res = "1920*1080",
                ScreenMaterial = "IPS",
                OtherScreenParameter = @"1670万色,色彩饱和度(NTSC):85%,
IPS液晶显示屏,对比度1500:1(Ty
pe)",
                ScreenProportion =69.93,
                NetWorkType = "双卡(均可支持4G),全网通",
                OperatingSystem = "Android OS 6.0",
                RearCamera =1300,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,指纹识别,指南针",
                Memory =3,
                PhoneColor = "白色,金色,黑色,玫瑰金",
                PhoneLamp = "LED",
                BatteryCapacity = 3000,
                Cores = "真八",
                PhoneCPU = "高通 骁龙Snapdragon MSM8952",
                PhoneCPUFrequency =1.5,
                PhoneROM = "16GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Huawei/g9.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 102,
                PhoneCategoryName = "huawei",
                PhoneName = "华为G9 Plus",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "无",
                OtherScreenParameter = "无",
                ScreenProportion =72.57,
                NetWorkType = "双卡(均可支持4G)",
                OperatingSystem = "Android OS 6.0",
                RearCamera =1600,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,指纹识别
,霍尔传感器,指南针",
                Memory =3,
                PhoneColor = "金色",
                PhoneLamp = "LED",
                BatteryCapacity =3340,
                Cores = "八",
                PhoneCPU = "高通 骁龙Snapdragon MSM8953",
                PhoneCPUFrequency =2.0,
                PhoneROM = "32GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Huawei/g9p.jpg"
            });

            phones.Add(new FindPhone
            {
                Id = 103,
                PhoneCategoryName = "huawei",
                PhoneName = "华为Mate S",
                ScreenSize =5.5,
                Res = "1920*1080",
                ScreenMaterial = "AMOLED",
                OtherScreenParameter = "2.5D玻璃",
                ScreenProportion =73.84,
                NetWorkType = "双卡(均可支持4G),双4G",
                OperatingSystem = "EMUI 3.1(基于Android OS 5.1)",
                RearCamera =1300,
                FrontFacingCamera =800,
                TH = "无",
                Sensors = @"重力感应器,光线传感器,距离传感
器,亮度传感器,温度传感器,霍尔
传感器,陀螺仪,指纹识别,指南针",
                Memory =3,
                PhoneColor = "极昼金,星辰银,苍山灰,玫瑰金",
                PhoneLamp = "LED",
                BatteryCapacity =2700,
                Cores = "真八",
                PhoneCPU = "海思kirin 935",
                PhoneCPUFrequency =2.2,
                PhoneROM = "32GB/64GB",
                BatteryType = "不可",
                PhoneImage = "/Images/PhoneImage/Huawei/mates.jpg"
            });

            return phones;
        }
    }
}
