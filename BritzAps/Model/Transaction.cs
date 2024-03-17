using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BritzAps.Model
{
    public class Transaction
    {
        // Transaction fields defineres
        public int TransactionId { get; set; }
        public double TotalPrice { get; set; }
        public int MaterialId { get; set; }

        //Konstruktor for transaction objekter når de loades ind fra databasen
        public Transaction(int transactionId, double totalPrice, int materialId)
        {
            TransactionId = transactionId;
            TotalPrice = totalPrice;
            MaterialId = materialId;
        }

        //Konstruktor for transaction objekter når de laves i programmet og gemmes i en database
        public Transaction(double totalPrice, int materialId)
        {
            TransactionId++;
            TotalPrice = totalPrice;
            MaterialId = materialId;
        }
    }
}
