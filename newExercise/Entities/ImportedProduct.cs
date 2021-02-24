using System;
using System.Collections.Generic;
using System.Text;

namespace newExercise.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; protected set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFree ) : base( name, price)
        {
            CustomsFree = customsFree;
        }

        public double TotalPrice()
        {
            return Price + CustomsFree; 
        }

        public override string PriceTag()
        {

            return base.PriceTag() + 
                "(Customs free: $20.00)"
                +CustomsFree; 
        }
    }
}
