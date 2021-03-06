﻿using Microsoft.Graph;
using RoomChecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomChecker.Models
{
    public class KnowAsset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class PBIConfig
    {
        public string WorkspaceId { get; set; }
        public string ReportId { get; set; }
    }
    public class TenantConfig
    {
        public string ImageContainer { get; set; }
        public string PreferredRoomList { get; set; }
        public bGridConfig bGridConfig { get; set; }
        public PBIConfig PBIConfig { get; set; }
        public List<Room> Rooms { get; set; }
        public string TenantId { get; set; }
        public List<KnowAsset> KnownAssets { get; set; }
    }

    public class bGridConfig
    {
        public string bGridUser { get; set; }
        public string bGridPW { get; set; }
        public string bGridEndPoint { get; set; }
    }

    public class Room
    {
        public Room(int hours)
        {
            var hourSchedule = new HourSchedule
            {
                Occupied = false
            };

            DaySchedule = new HourSchedule[hours];
            for (int i = 0; i < hours; i++)
            {
                DaySchedule[i] = hourSchedule;
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
        public HourSchedule[] DaySchedule { get; set; }
        public List<Node> Nodes { get; set; }
        public int Capacity { get; set; }
        public string AudioVideo { get; set; }
        public decimal Temperature { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class HourSchedule
    {
        public bool Occupied { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public String Organizer { get; set; }
    }
    public class Node
    {
        public string Id { get; set; }
    }

    public class GraphRoomList
    {
        public List<Microsoft.Graph.EmailAddress> value;
    }

    public class O365Rooms
    {
        public GraphRoomList RoomLists { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
