using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalParameters.Models
{
   public class FindDigital
    {
        public int Id { get; set; }
        //数码类别
        public string DigitalCategory { get; set; }
        //数码名称
        public string DigitalName { get; set; }
        //有效像素
        public int EffectivePixels { get; set; }
        //光学变焦倍数
        public int OpticalZoom { get; set; }
        //数码变焦
        public int DigitalZoom { get; set; }
        //分辨率
        public string Res { get; set; }
        //镜头类型
        public string LensType { get; set; }
        //数码图片
        public string DigitalImage { get; set; }
    }
    public class FindDigitalManager
    {
        public static void GetDigital(string digitalcategory, ObservableCollection<FindDigital> Digitals)
        {
            var allDigital = getdigital();
            var filteredDigital = allDigital.Where(p => p.DigitalCategory == digitalcategory).ToList();
            Digitals.Clear();
            filteredDigital.ForEach(p => Digitals.Add(p));
        }
        public static List<FindDigital> getdigital()
        {
            var digitals = new List<FindDigital>();
            digitals.Add(new FindDigital()
            {
                Id = 1,
                DigitalCategory = "sony",
                DigitalName = "索尼ILCE-5000套机",
                EffectivePixels=2010,
                OpticalZoom=3,
                DigitalZoom=4,
                Res= "5456*3632",
                LensType= "伸缩式",
                DigitalImage="/Images/DigitalImage/Sony/epz.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 2,
                DigitalCategory = "sony",
                DigitalName = "ILCE-6000",
                EffectivePixels = 2430,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "6000*4000",
                LensType = "翻转屏",
                DigitalImage = "/Images/DigitalImage/Sony/ceEOEGzEXPKck.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 3,
                DigitalCategory = "sony",
                DigitalName = "RX1R II",
                EffectivePixels = 4240,
                OpticalZoom = 4,
                DigitalZoom = 0,
                Res = "7952×5304",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Sony/cesFMrqodshc.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 4,
                DigitalCategory = "sony",
                DigitalName = "H400",
                EffectivePixels = 2010,
                OpticalZoom = 63,
                DigitalZoom = 126,
                Res = "5152×3864",
                LensType = "伸缩式 ",
                DigitalImage = "/Images/DigitalImage/Sony/ceM2bLfTS9o9M.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 5,
                DigitalCategory = "sony",
                DigitalName = "RX10 III",
                EffectivePixels = 2000,
                OpticalZoom = 25,
                DigitalZoom = 0,
                Res = "5472*3648",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Sony/cegLgAe2LV1Fo.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 6,
                DigitalCategory = "nikon",
                DigitalName = "D7200",
                EffectivePixels = 2416,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "6000×4000",
                LensType = "DX 镜头",
                DigitalImage = "/Images/DigitalImage/Nikon/cexL4MJcRu5hs.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 7,
                DigitalCategory = "nikon",
                DigitalName = "S9900s",
                EffectivePixels = 1605,
                OpticalZoom = 30,
                DigitalZoom = 4,
                Res = "4608×3456",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Nikon/ceaZIyEZWj9U.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 8,
                DigitalCategory = "nikon",
                DigitalName = "DL",
                EffectivePixels = 2081,
                OpticalZoom = 21,
                DigitalZoom = 4,
                Res = "5568*3712",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Nikon/cemxlILBdHjWw.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 9,
                DigitalCategory = "nikon",
                DigitalName = "Coolpix A",
                EffectivePixels = 1616,
                OpticalZoom = 1,
                DigitalZoom = 0,
                Res = "4928*3264",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Nikon/cebIdU1F2lhyY.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 10,
                DigitalCategory = "nikon",
                DigitalName = "P610s",
                EffectivePixels = 1605,
                OpticalZoom = 60,
                DigitalZoom = 4,
                Res = "4608×3456",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Nikon/ceoHEaX66Hhw.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 11,
                DigitalCategory = "casio",
                DigitalName = "ZR3500",
                EffectivePixels = 1210,
                OpticalZoom = 10,
                DigitalZoom = 4,
                Res = "4000*3000",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Casio/cexhBWs1UmNw.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 12,
                DigitalCategory = "casio",
                DigitalName = "EX-100",
                EffectivePixels = 1210,
                OpticalZoom = 12,
                DigitalZoom = 4,
                Res = "4000×3000",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Casio/cedcsy4dYMrk.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 13,
                DigitalCategory = "casio",
                DigitalName = "ZR3600",
                EffectivePixels = 1210,
                OpticalZoom = 12,
                DigitalZoom = 4,
                Res = "4000*3000",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Casio/cehnchNibeCM.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 14,
                DigitalCategory = "casio",
                DigitalName = "ZR1200",
                EffectivePixels = 1679,
                OpticalZoom = 12,
                DigitalZoom = 4,
                Res = "4608*3456",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Casio/ceCq2UoK4UH1s.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 15,
                DigitalCategory = "casio",
                DigitalName = "ZR1500",
                EffectivePixels = 1610,
                OpticalZoom = 12,
                DigitalZoom = 4,
                Res = "4608*3456",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/cemEaHZzcYppA.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 16,
                DigitalCategory = "kodak",
                DigitalName = "AZ651",
                EffectivePixels = 2068,
                OpticalZoom = 65,
                DigitalZoom = 4,
                Res = "5184*3888",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Kodak/ceO3eHbKjx8cQ.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 17,
                DigitalCategory = "kodak",
                DigitalName = "AZ522",
                EffectivePixels = 1680,
                OpticalZoom = 52,
                DigitalZoom = 0,
                Res = "暂无数据",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Kodak/ceMSBw0TuPPFY.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 18,
                DigitalCategory = "kodak",
                DigitalName = "AZ501",
                EffectivePixels = 1615,
                OpticalZoom = 50,
                DigitalZoom = 4,
                Res = "暂无数据",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Kodak/ceCYsrz7DATU.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 19,
                DigitalCategory = "kodak",
                DigitalName = "AZ361",
                EffectivePixels = 1615,
                OpticalZoom = 36,
                DigitalZoom = 4,
                Res = "4608*3456",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Kodak/ceGM16TPJ6xSI.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 20,
                DigitalCategory = "kodak",
                DigitalName = "S1套机",
                EffectivePixels = 1683,
                OpticalZoom = 3,
                DigitalZoom = 4,
                Res = "4640*3480",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Kodak/cey4u1hE6lCK6.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 21,
                DigitalCategory = "leica",
                DigitalName = "M-P(Typ 240)",
                EffectivePixels = 2400,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "5952*3976",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Leica/ceaa5fEamSZhc.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 22,
                DigitalCategory = "leica",
                DigitalName = "X Vario(Typ 107)",
                EffectivePixels = 1620,
                OpticalZoom = 2,
                DigitalZoom = 0,
                Res = "4928×3272",
                LensType = "伸缩式 ",
                DigitalImage = "/Images/DigitalImage/Leica/ceuWh6NDOadsE.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 23,
                DigitalCategory = "leica",
                DigitalName = "Q(TYP 116)",
                EffectivePixels = 2420,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "5952*3976",
                LensType = "3 个非球面镜",
                DigitalImage = "/Images/DigitalImage/Leica/ce2GVv7ERSOSo.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 24,
                DigitalCategory = "leica",
                DigitalName = "4",
                EffectivePixels = 2400,
                OpticalZoom = 3,
                DigitalZoom = 4,
                Res = "6000*4000",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Leica/ceeHQox3HIYs.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 25,
                DigitalCategory = "leica",
                DigitalName = "M-D(Typ 262)",
                EffectivePixels = 2400,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "暂无数据",
                LensType = "暂无数据",
                DigitalImage = "/Images/DigitalImage/Leica/cet5N3K7buGWI.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 26,
                DigitalCategory = "fujifilm",
                DigitalName = "X100T",
                EffectivePixels = 1630,
                OpticalZoom = 1,
                DigitalZoom = 0,
                Res = "4896×3264",
                LensType = "固定不变",
                DigitalImage = "/Images/DigitalImage/Fujifilm/cea8ls6oFsGM.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 27,
                DigitalCategory = "fujifilm",
                DigitalName = "X70",
                EffectivePixels = 1630,
                OpticalZoom = 1,
                DigitalZoom = 4,
                Res = "4896×3264",
                LensType = "固定不变",
                DigitalImage = "/Images/DigitalImage/Fujifilm/cerMai9RpsMG6.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 28,
                DigitalCategory = "fujifilm",
                DigitalName = "X100s",
                EffectivePixels = 1630,
                OpticalZoom = 1,
                DigitalZoom = 0,
                Res = "4896×3264",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Fujifilm/celbLAkuL9Lbw.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 29,
                DigitalCategory = "fujifilm",
                DigitalName = "X-T10(单机)",
                EffectivePixels = 1630,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "4896*3264",
                LensType = "单点AF,连续AF,MF",
                DigitalImage = "/Images/DigitalImage/Fujifilm/ce5ONW053Af7.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 30,
                DigitalCategory = "fujifilm",
                DigitalName = "X-T1(单机)",
                EffectivePixels = 1630,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "4896*3264",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Fujifilm/ceASVzIHzBbQ.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 31,
                DigitalCategory = "pentax",
                DigitalName = "645D套机",
                EffectivePixels = 4000,
                OpticalZoom = 1,
                DigitalZoom = 0,
                Res = "7264*5440",
                LensType = "暂无数据",
                DigitalImage = "/Images/DigitalImage/Pentax/ceJtko7hbYe4s.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 32,
                DigitalCategory = "pentax",
                DigitalName = "K-1",
                EffectivePixels = 3640,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "7360*4912",
                LensType = "暂无数据",
                DigitalImage = "/Images/DigitalImage/Pentax/ce3uCydTR5tU.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 33,
                DigitalCategory = "pentax",
                DigitalName = "K-3(单机)",
                EffectivePixels = 2435,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "6016*4000",
                LensType = "相位匹配自动对焦",
                DigitalImage = "/Images/DigitalImage/Pentax/ceE7RCn4Nbp1.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 34,
                DigitalCategory = "pentax",
                DigitalName = "K-5 IIs(单机)",
                EffectivePixels = 1628,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "4928*3264",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Pentax/ceE2yGlnDHq2.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 35,
                DigitalCategory = "pentax",
                DigitalName = "K-3II",
                EffectivePixels = 2400,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "6016*4000",
                LensType = "暂无数据",
                DigitalImage = "/Images/DigitalImage/Pentax/cep723RNnUXw.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 36,
                DigitalCategory = "samsung",
                DigitalName = "NX2000套机",
                EffectivePixels = 2030,
                OpticalZoom = 2,
                DigitalZoom = 4,
                Res = "5472*3648",
                LensType = "伸缩式 ",
                DigitalImage = "/Images/DigitalImage/Samsung/cea6RywLyInCY.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 37,
                DigitalCategory = "samsung",
                DigitalName = "NX3000套机",
                EffectivePixels = 2030,
                OpticalZoom = 2,
                DigitalZoom = 4,
                Res = "5472*3648",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Samsung/cez4F9Mdg2wI.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 38,
                DigitalCategory = "samsung",
                DigitalName = "NX3300",
                EffectivePixels = 2030,
                OpticalZoom = 3,
                DigitalZoom = 4,
                Res = "5472*3648",
                LensType = "暂无数据",
                DigitalImage = "/Images/DigitalImage/Samsung/ceY68vHKbq4M.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 39,
                DigitalCategory = "samsung",
                DigitalName = "NX500套机",
                EffectivePixels = 2820,
                OpticalZoom = 3,
                DigitalZoom = 0,
                Res = "6480*4320",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Samsung/cenrZHQHR10T2.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 40,
                DigitalCategory = "samsung",
                DigitalName = "NX300套机",
                EffectivePixels = 2030,
                OpticalZoom = 18,
                DigitalZoom = 0,
                Res = "5472*3468",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Samsung/cewFvB1mZszY.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 41,
                DigitalCategory = "canon",
                DigitalName = "80D(单机)",
                EffectivePixels = 2420,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "6000*4000",
                LensType = "佳能EF系列镜头",
                DigitalImage = "/Images/DigitalImage/Canon/ceMpEZL7rOO.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 42,
                DigitalCategory = "canon",
                DigitalName = "EOS-1D X Mark II(单机)",
                EffectivePixels = 2020,
                OpticalZoom = 0,
                DigitalZoom = 0,
                Res = "5472*3648",
                LensType = "佳能EF系列镜头",
                DigitalImage = "/Images/DigitalImage/Canon/cemK7jVOrT3I6.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 43,
                DigitalCategory = "canon",
                DigitalName = "G7X",
                EffectivePixels = 2020,
                OpticalZoom = 4,
                DigitalZoom = 0,
                Res = "5472*3648",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Canon/ceCwRka73nAr6.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 44,
                DigitalCategory = "canon",
                DigitalName = "SX720 HS",
                EffectivePixels = 2030,
                OpticalZoom = 40,
                DigitalZoom = 0,
                Res = "5184*3888",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Canon/cedELhFWS42co.jpg"
            });
            digitals.Add(new FindDigital()
            {
                Id = 45,
                DigitalCategory = "canon",
                DigitalName = "G7 X Mark II",
                EffectivePixels = 2010,
                OpticalZoom = 4,
                DigitalZoom = 0,
                Res = "5472*3648",
                LensType = "伸缩式",
                DigitalImage = "/Images/DigitalImage/Canon/ce6XhPtxnruxE.jpg"
            });
            return digitals;
        }
    }
}
