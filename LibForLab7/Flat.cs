using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibForLab7
{
    public class Flat
    {
        public Flat (int amountOfRoom, int height, bool washingMachine)
        {
            this.amountOfRoom = amountOfRoom;
            this.height = height;
            this.washingMachine = washingMachine;
        }
        public int amountOfRoom { get; private set; }
        public int height { get; private set; }
        public double area { get; private set; }
        public bool washingMachine { get; private set; }
        public List<Room> rooms;
        public Kitchen kitchen;

        public List<Room> GetRooms()
        {
            List<Room> rooms = new List<Room>();
            foreach(Room room in this.rooms)
            {
                rooms.Add(room);
            }
            rooms.Add(this.kitchen);
            return rooms;
        }

        public void CreateRoom(string name, double area, double height, double amountOfWindow, bool furniture)
        {
            Room room = new Room(name, area, height, amountOfWindow, furniture);
            rooms.Add(room);
        }
    }
}
