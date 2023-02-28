using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gigachelick
{
    internal class BasaChelov
    {
        private Random _random = new Random();
        private int RandKoor
        {
            get => _random.Next(-100,100);
        }

        private int RandGol
        {
            get => _random.Next(5,20); 
        }

        private int RandBody
        {
            get => _random.Next(20, 80);
        }

        private int RandRazm
        {
            get => _random.Next(30, 100);
        }

        private int RandAng
        {
            get => _random.Next(0,360);
        }

        internal List<Chel> chels { get; private set; }

        public void Initialize()
        {
            chels = new List<Chel>
            {
                new Chel(Names.Боб, new Head(RandKoor, RandKoor, RandGol), new Body(RandKoor, RandKoor, RandBody, RandBody), new Hands(RandRazm, RandAng), new Legs(RandRazm, RandAng)),
                new Chel(Names.Горислава, new Head(RandKoor, RandKoor, RandGol), new Body(RandKoor, RandKoor, RandBody, RandBody), new Hands(RandRazm, RandAng), new Legs(RandRazm, RandAng)),
                new Chel(Names.Джонс, new Head(RandKoor, RandKoor, RandGol), new Body(RandKoor, RandKoor, RandBody, RandBody), new Hands(RandRazm, RandAng), new Legs(RandRazm, RandAng)),
                new Chel(Names.Жужа, new Head(RandKoor, RandKoor, RandGol), new Body(RandKoor, RandKoor, RandBody, RandBody), new Hands(RandRazm, RandAng), new Legs(RandRazm, RandAng)),
                new Chel(Names.Игорь, new Head(RandKoor, RandKoor, RandGol), new Body(RandKoor, RandKoor, RandBody, RandBody), new Hands(RandRazm, RandAng), new Legs(RandRazm, RandAng)),
                new Chel(Names.Паша, new Head(RandKoor, RandKoor, RandGol), new Body(RandKoor, RandKoor, RandBody, RandBody), new Hands(RandRazm, RandAng), new Legs(RandRazm, RandAng)),
                new Chel(Names.Рогнеда, new Head(RandKoor, RandKoor, RandGol), new Body(RandKoor, RandKoor, RandBody, RandBody), new Hands(RandRazm, RandAng), new Legs(RandRazm, RandAng)),
                new Chel(Names.Саша, new Head(RandKoor, RandKoor, RandGol), new Body(RandKoor, RandKoor, RandBody, RandBody), new Hands(RandRazm, RandAng), new Legs(RandRazm, RandAng)),
            };
        }
    }
}
