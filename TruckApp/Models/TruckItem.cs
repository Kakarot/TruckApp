using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace TruckApp.Models
{
    public class TruckItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }


        public float AmountToMultiplyBy { get; set; }

        [MaxLength(255)]
        public string ItemSection { get; set; }

       
    }
}
