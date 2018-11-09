using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TruckApp.Models
{
    public class TruckItemList
    {
        public List<TruckItem> truckItemList = new List<TruckItem>();

            private string[] items = new string[2];

            private string frozenFoodFile = "C:\\ProjectLocation\\TruckApp\\TruckApp\\TruckApp\\TruckList\\FrozenFoodFile.txt";
            private string refrigeratorFoodFile = "C:\\ProjectLocation\\TruckApp\\TruckApp\\TruckApp\\TruckList\\RefrigeratorFoodFile.txt";

            //on instantiation class populates truckItemList
            public TruckItemList(string itemSection)
            {
                GetItemSection(itemSection);

            }

            //Gets the section to read for file
            private void GetItemSection(string itemSection)
            {
                if (itemSection == "Frozen Food")
                {
                    string truckFile = frozenFoodFile;
                    ReadFile(truckFile);
                }

                if (itemSection == "Refrigerator Food")
                {
                    string truckFile = refrigeratorFoodFile;
                    ReadFile(truckFile);
                }
            }

            //Gets the file and parse into list
            private void ReadFile(string itemSection)
            {


                using (StreamReader truckFile = new StreamReader(itemSection))
                {
                    //string to hold the line to be parsed
                    string line;

                    //reads each line until null
                    while ((line = truckFile.ReadLine()) != null)
                    {
                        //parses each line into an array then stores into list
                        ParseFile(line);

                    }
                }
            }

            //parses the file
            private void ParseFile(string line)
            {
                //splits line to store into array
                items = line.Split(',');

                //stores items into class object so they can be added to a list
                TruckItem truckItem = new TruckItem();
                truckItem.Id = Int32.Parse(items[0]);
                truckItem.Name = items[1];
                truckItem.AmountToMultiplyBy = float.Parse(items[2]);

                //adding to the list
                truckItemList.Add(truckItem);

            }


        
    }
}
