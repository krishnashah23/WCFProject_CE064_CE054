﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InventoryServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(InventoryManagementSystem.InventoryService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " +DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
