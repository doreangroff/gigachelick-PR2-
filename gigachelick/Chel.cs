using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gigachelick
{
    public enum Names
    {
        Саша,
        Паша, 
        Боб,
        Игорь, 
        Джонс,
        Рогнеда,
        Горислава,
        Жужа
    }
    internal class Chel
    {
        private Names _names = Names.Жужа;
        public Head _head;
        public Body _body;
        public Hands _hands;
        public Legs _legs;
        
        
        
        public Names Names
        {
            get => _names;
        }

        public Head Head
        {
            get => _head;
        }

        public Body Body
        {
            get => _body;
        }

        public Hands Hands
        {
            get => _hands;
        }

        public Legs Legs
        {
            get => _legs;
        }

        public Chel(Names name, Head head, Body body, Hands hands, Legs legs)
        {
            //this._names = name;
            //this._head = head;
            //this._body = body;
            //this._hands = hands;
            //this._legs = legs;
        }
    }
}
