using System.Runtime.InteropServices;

namespace IOTWeb.Models
{
    public class AccelAndForce
    {
        public float  Timestamp { get; set; } 
        public float Acceleration { get; set; }  
        public float Force { get; set; } 
    }
}
