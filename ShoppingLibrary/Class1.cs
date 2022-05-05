using System;

namespace ShoppingLibrary
{
    public class Class1
    {
        public int Id { get; set; }

        public string Name { get; set; }
       [DisplayName("Dispaly Order")] 

       public int DisplayOrder { get; set; }

        public DateTime createDateTime { get; set; } = DateTime.Now;    
    }

    internal class DisplayNameAttribute : Attribute
    {
        public DisplayNameAttribute(string v)
        {
            V = v;
        }

        public string V { get; }
    }

    internal class DisplayName
    {
    }
}
