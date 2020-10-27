using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            BBQ ssu = new BBQ();

            ssu.addChicken(10);
            ssu.addOil(1);
            ssu.addSource(8);

            if (!ssu.checkStock())
            {
                Console.WriteLine("we need stock management");
            }
            Console.ReadLine();
        }
    }

    class BBQ
    {
        public int chicken;
        public int oil;
        public int source;
        public BBQ()
        {
            chicken = 0;
            oil = 0;
            source = 0;
        }
        public BBQ(int chicken, int oil, int source)
        {
            this.chicken = chicken;
            this.oil = oil;
            this.source = source;
        }
        public virtual bool checkStock()
        {
            if (Math.Abs(chicken - source) > 2)
            {
                return false;
            }
            if (Math.Abs(chicken - oil * 2) > 2)
            {
                return false;
            }
            return true;
        }
        public void addChicken(int iChicken)
        {
            chicken = iChicken;
        }
        public void addOil(int iOil)
        {
            oil = iOil;
        }
        public void addSource(int iSource)
        {
            source = iSource;
        }
    }
    class BBQ_Pizza : BBQ
    {
        int powder;
        int cheese;
        int meat;

        public BBQ_Pizza()
        {
            powder = 0;
            cheese = 0;
            meat = 0;
        }
        public BBQ_Pizza(int powder, int cheese, int meat)
        {
            this.powder = powder;
            this.cheese = cheese;
            this.meat = meat;
        }

        public BBQ_Pizza(params int[] args) : base(args[0], args[1], args[2])
        {
            this.powder = args[3];
            this.cheese = args[4];
            this.meat = args[5];

            //main -> BBQ_Pizza ssu = new BBQ_Pizza(10, 1, 8, 9, 1, 1); 
        }

        
        public new bool checkStock()
        {
            if(Math.Abs(chicken - source) > 2)
            {
                return false;
            }
            if(Math.Abs(chicken - oil * 2) > 2)
            {
                return false;
            }
            if(Math.Abs(powder - cheese * 3) > 2)
            {
                return false;
            }
            if(Math.Abs(powder - meat * 3) >2)
            {
                return false;
            }
            return true;
        }
        
        /*
        public override bool checkStock()
        {
            base.checkStock();
            if(Math.Abs(powder - cheese * 3) > 2)
            {
                return false;
            }
            if(Math.Abs(powder - meat * 3) > 2)
            {
                return false;
            }
            return true;
        }
        */

    }
}
