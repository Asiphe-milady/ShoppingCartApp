using System;


namespace ShoppingCartItem_
{
    internal class ItemsList
    {
        private string _ProductName;
        private int _Price;
        private string _Color; 

        public ItemsList()
        {
            string Headphones = null;
            _ProductName= Headphones;
            _Price = 200;
            string White = null;
            _Color =White ;

            string Cable = null;
            _ProductName = Cable;
            _Price = 300;
            string Pink = null;
            _Color = Pink;

            string PhoneCover = null;
            _ProductName = PhoneCover;
            _Price = 150;
            _Color = Pink;

            string Speaker = null;
            _ProductName = Speaker;
            _Price = 150;
            _Color = Pink;


        }
        public ItemsList( string _ProductName , int _Price , string _Color)
        {
            this._ProductName = _ProductName;
            this._Price = _Price;
            this._Color = _Color;
        }
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        public int Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public string Color
        {
            get { return _Color; }  
            set { _Color = value; }
        }

        

    }
}
