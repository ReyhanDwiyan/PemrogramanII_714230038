using P4_1_714230038;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230038
{
    public class DVD_714230038 : Product_714230038
    {
        protected string duration;

        public DVD_714230038(string title, string duration)
        {
            MyType = "DVD";
            MyTitle = title;
            this.duration = duration;
            Console.WriteLine("ini dari class DVD");
        }
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        //implementasi metode abstrak
        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and has {2} minutes duration", MyType, MyTitle, Duration);
        }
    }
}