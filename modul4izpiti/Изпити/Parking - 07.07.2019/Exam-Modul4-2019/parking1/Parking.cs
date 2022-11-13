using System;
using System.Collections.Generic;
using System.Text;

namespace parking1
{
    class Parking
    {
        private Car head;
        private Car tail;
        private int count;

        public int Count { get => count; set => count = value; }
        internal Car Head { get => head; set => head = value; }
        internal Car Tail { get => tail; set => tail = value; }
        public Parking()

        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        public void AddCar(string carNumber)
        {
            Car car = new Car(carNumber);
            Car fCar = this.Head;
            if (this.Count == 0)
            {
                this.head = this.tail = car;
            }
            else
            {
            Car aCar = null;
                while (aCar == null)
                {
                    if (fCar.Next == null)
                    {
                        fCar.Next = car;
                        aCar = fCar;
                    }
                    else
                    {
                        fCar = fCar.Next;
                    }
                }
             this.Tail = car;
            }
            this.Count++;
        }

        public void AddFancyCar(string carNumber)

        {
            Car car = new Car(carNumber);
            if (this.Count == 0)
            {
                this.Head = this.Tail = car;
            }
            else
            {
                car.Next = this.Head;
                this.Head = car;
            }
            this.Count++;
        }

        public Car CheckCarIsPresent(string carNumber)
        {
            Car car = this.Head;
            for (int i = 0; i < this.Count; i++)
            {
                if (car.CarNumber==carNumber)
                {
                    return car;
                    
                }
                else
                {
                    car = car.Next;
                }
            }
            return null;
        }

        public bool ReleaseCar(string carNumber)

        {
            Car car = this.Head;
            for (int i = 0; i < this.Count; i++)
            {
                if (car.CarNumber == carNumber)
                {
                    RemoveCar(car);
                    return true;
                }
                else
                {
                    car = car.Next;
                }
            }
            return false;
        }

        public bool ReleaseCar(int index)
        {
            Car car = this.Head;
             for (int i = 0; i < this.Count; i++)
             {
                 if (i==index)
                 {
                     RemoveCar(car);
                     return true;
                 }
                 car = car.Next;
             }
             return false;
        }

        public Car FindPrevious(Car car)
        {
            Car vCar = this.Head;
            Car tCar = null;
            for (int i = 0; i < this.Count; i++)
            {
                if (vCar.Next == car)
                {
                    tCar = vCar;
                    return tCar;
                }
                else
                {
                    vCar = vCar.Next;
                }
            }
            return tCar;
        }

        public void RemoveCar(Car car)
        {
            Car nCar = FindPrevious(car);
            if (this.Head == car)
            {
                this.Head = this.Head.Next;
            }
            else
            {
                nCar.Next = car.Next;
            }
            if(car == this.Tail)
            {
                nCar = this.Tail;
            }
            this.Count--;
        }

        public StringBuilder ParkingInformation()
        {
            var car = this.Head;
            StringBuilder sb = new StringBuilder();
            while (car != null)
            {
                sb.AppendLine(car.ToString());
                car = car.Next;
            }
            return sb;
        }
    }
}
