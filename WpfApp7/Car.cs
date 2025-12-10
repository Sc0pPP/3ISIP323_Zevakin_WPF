using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    public enum engine
    {
        N50B30=30000,
        N63S63=35000,
        M30B30=15000,
        S54B32=20000,
    }
     public enum marka
    {
        m5e60=1000000,
        m5f10=800000,
        m4g82=1300000,
        m3g80=1200000
    }
    public enum color
    {
        gold=300000,
        black=150000,
        white=300000,
        pink=100000
    }
    public enum options
    {
        stove=50000,
        steering_wheel=70000,
        seat_vmesto_bytilky=150000
    }
    
    internal static class Car
    {
        public static int marka {  get; set; }
        public static int engine { get; set; }
        public static int color { get; set; }
        public static int options { get; set; }

    }
    
}
