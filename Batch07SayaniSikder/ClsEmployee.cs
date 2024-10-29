using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch07SayaniSikder
{
    internal class ClsEmployee
    {
        protected int EmpId, EAge;
        protected string EName, EAddress;
        public virtual void GetEmpData()
        {
            Console.WriteLine("Enter Employee Details:-");
            this.EmpId =
           Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.EAddress = Console.ReadLine();
            this.EAge = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void DisplayEmpData()
        {
            Console.WriteLine("Employee id is:" + this.EmpId);
            Console.WriteLine("Employee Name is:-" + this.EName);
            Console.WriteLine("Employee address is:- "+this.EAddress);
           
            Console.WriteLine("Employee Age is:- "+this.EAge);
        }
    }
    
class ClsManager : ClsEmployee
    {
        double Bonus, CA;
        public override void GetEmpData()
        {
            Console.Write("Enter the manager Details:-");
            EmpId = Convert.ToInt32(Console.ReadLine());
            EName = Console.ReadLine();
            Bonus = Convert.ToInt32(Console.ReadLine());
            CA = Convert.ToInt32(Console.ReadLine());
            //base.GetEmpData();
        }
        public override void DisplayEmpData()
        {
            Console.WriteLine("Manager id is:-" + EmpId);
            Console.WriteLine("Manager Name is:-" + EName);
            Console.WriteLine("Manager Bonus is:-" + Bonus);
            Console.WriteLine("manager CA is:-" + CA);
            //base.DisplayEmpData();
        }
    }
}
