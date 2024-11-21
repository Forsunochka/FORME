using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_4._1
{
    class Wallet
    {

        public List<Koupon> Koupons { get; set; }

        public Wallet()
        {
            Koupons = new List<Koupon>();
        }

        public void AddToWallet(Koupon k)
        {
            if (DateTime.Now.Year - k.IssueDate.Year <= 10)
            {
                Koupons.Add(k);
            }
            else
            {
                throw new Exception("The banknote is older than 10 years.");
            }
        }

        public void RemoveFromWallet(Koupon k)
        {
            Koupons.Remove(k);
            
        }

        public double SumInUSD()
        {
            double sum = 0;
            foreach (var koupon in Koupons)
            {
                if (koupon is IConvertable convertable)
                {
                    sum += koupon.Denomination * convertable.Course;
                }
            }
            return sum;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, Koupons);
        }

        public static bool operator ==(Wallet wallet1, Wallet wallet2)
        {
            if (ReferenceEquals(wallet1, wallet2))
            {
                return true;
            }
            if (wallet1 is null || wallet2 is null)
            {
                return false;
            }
            return Math.Abs(wallet1.SumInUSD() - wallet2.SumInUSD()) < 0.000001;
        }

        public static bool operator !=(Wallet wallet1, Wallet wallet2)
        {
            return !(wallet1 == wallet2);
        }

    }
}
