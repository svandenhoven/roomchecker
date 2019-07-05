﻿using Microsoft.Graph;
using RoomChecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftGraphAspNetCoreConnectSample.Models
{
    public class Node
    {
        public string Id { get; set; }
    }
    public class Room
    {
        public Room(int hours)
        {
            DaySchedule = new int[hours];
            for (int i = 0; i < hours; i++)
            {
                DaySchedule[i] = 0;
            }
        }

        public string Id { get; set; }
        public bGridIsland Island { get; set; }
        public bool HasMailBox { get; set; }
        public string Name { get; set; }
        public string ReservedBy { get; set; }
        public bool Available { get; set; }
        public int Floor { get; set; }
        public string RoomType { get; set; }
        public string Type { get; set; }
        public DateTime FreeAt { get; set; }
        public DateTime FreeUntil { get; set; }
        public string Features { get; set; }
        public int Occupied { get; set; }
        public int[] DaySchedule { get; set; }
        public List<Node> Nodes { get; set; }
        public int Capacity { get; set; }
        public string AudioVideo { get; set; }
        public decimal Temperature { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
