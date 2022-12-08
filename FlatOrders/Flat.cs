using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatOrders
{
    public class Flat
    {
        public int amountOfRoom { get; private set; }
        public int floor { get; private set; }
        public bool washMachine { get; private set; }
        public int height { get; private set; }
        public double area { get; private set; }

        List<Room> rooms = new List<Room>();
        public Kitchen kitchen { get; private set; }

        public Flat(int amountOfRoom, int floor, bool washMachine, int height)
        {
            this.amountOfRoom = amountOfRoom;
            this.floor = floor;
            this.washMachine = washMachine;
            this.height = height;
        }  

        public void SetFlat(int floor, bool wash, int height)
        {
            this.floor = floor;
            washMachine = wash;
            this.height = height;
        }

        public void SetRoom(Room room)
        {
            room.SetPrice(height);
            rooms.Add(room);
            SetArea();
        }

        public void SetKitchen(Kitchen kitchen)
        {
            this.kitchen = kitchen;
            SetArea();
        }

        private void SetArea()
        {
            area = 0;
            foreach(Room room in rooms)
            {
                area += room.area;
            }
            if(kitchen != null) area += kitchen.area;
        }


    }
}
