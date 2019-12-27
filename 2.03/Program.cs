using System;
namespace Program 
{ 
    public class MyClass 
    { 
        public static int SumDigits(int number)
        { 
            string s = number.ToString(); 
            if (s.Length == 1) 
                s = s.Insert(0, "00"); 
            else 
            if (s.Length == 2) 
                s = s.Insert(0, "0"); 
            return Convert.ToInt32(s[0].ToString()) + Convert.ToInt32(s[1].ToString()) + Convert.ToInt32(s[2].ToString()); 
        } 
        
        public bool IsLuckyTicket(string ticket) 
        { 
            if (ticket.Length != 6) return false; 
            int number; 
            if (!Int32.TryParse(ticket, out number)) 
                return false; 
            return (SumDigits(number / 1000) == SumDigits(number % 1000)); 
        } 
    } 
}