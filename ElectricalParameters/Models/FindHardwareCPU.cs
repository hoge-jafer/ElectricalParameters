using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalParameters.Models
{
   public class FindHardwareCPU
    {
        public int Id { get; set; }
        //芯片类型
        public string CPUCategory { get; set; }
        //芯片名称
        public string CPUName { get; set; }
        //CPU主频
        public int CPUFrequency { get; set; }
        //最大睿频
        public double MaximumCoreFrequency { get; set; }
        //核心数量
        public double NumberOfCores { get; set; }
        //芯片图片
        public string CPUImage { get; set; }
    }
}
