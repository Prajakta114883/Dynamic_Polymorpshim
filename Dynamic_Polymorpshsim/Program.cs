using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorpshsim
{
     abstract class Account
    {
        public abstract void AcDetails();
        public abstract void Withdrwal();
        public abstract void Deposite();
        public void Bankdetails()
        {
            Console.WriteLine("calling bank details");
        }
        class SavingAc : Account
        {
            public override void AcDetails()
            {
                Console.WriteLine("Calling Account Details of saving account");
            }
            public override void Withdrwal()
            {
                Console.WriteLine("calling withdrwal of saving account");
            }
            public override void Deposite()
            {
                Console.WriteLine("calling withdwral of saving account");
            }
        }
        class SallaryAv : Account
        {
            public override void AcDetails()
            {
                Console.WriteLine("Calling Account Details of saving account");
            }
            public override void Withdrwal()
            {
                Console.WriteLine("calling withdrwal of saving account");
            }
            public override void Deposite()
            {
                Console.WriteLine("calling withdwral of saving account");
            }

        }
        static void Main(string[] args)
        {
            SavingAc sv = new SavingAc();
            sv.Bankdetails();
            sv.AcDetails();
            sv.Withdrwal();
            sv.Bankdetails();
            sv.Deposite();
            

            SallaryAv sa = new SallaryAv();
            sa.Bankdetails();
            sa.AcDetails();
            sa.Withdrwal();
            sa.Bankdetails();
            sa.Deposite();
            Console.ReadLine();

        }
    }
}
