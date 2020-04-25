using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netcore1.Models
{
    public class Spending 
    {
        [Key]
        public int Id{get;set;}
        [MaxLength(50)]
        public string Purpose{get;set;}
        public int Money{get;set;}
        public bool revenue_and_expenditure{get;set;}
        // true là thu, false là chi
        public bool Status {get;set;}
        public DateTime CreateTime{get;set;}

        [MaxLength(100)]
        public string Note {get;set;}
       
        //tiền mặt hay chuyển khoản( int  0/1)
        // true là tiền mặt --- false là chuyển khoản
         public int UserId{get;set;}
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get;set; }
       
        public int BankId{get;set;}

        [ForeignKey("BankId")]
        public virtual Bank Bank { get;set; }
       

    }
}