using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOconcepts
{
    public class Invoice : IPay
    {
        private float _quantity;
        private decimal _value; 
        public Invoice(int id, string description, Date date, float quantity, decimal value)
        { 
            Id = id; 
            Description = description;
            Date = date;
            Value = ValidateValue(value);
            Quantity = ValidateQuantity(quantity);
        }
        public string Description
        { get; set; } = null!;
        public int Id { get; set; }
        public Date Date { get; set; } = null!;
        public decimal Value { get => _value; set => _value = ValidateValue(value); } 
        public float Quantity { get => _quantity; set => _quantity = ValidateQuantity(value); } 
        public override string ToString() 
        { 
            return $"{Id}\t{Description}\n\t" +
                $"Date...........: { Date,20}\n\t"+
                $"Quantity.......: {_quantity,20:N2}\n\t" + 
                $"Value..........: {_value,20:C2}\n\t" + 
                $"To pay.........: {GetValueToPay(),20:C2}"; 
        } 
        public decimal GetValueToPay() 
        { 
            return _value * (decimal)Quantity; 
        }
        private float ValidateQuantity(float quantity) 
        { 
            if (quantity < 0) 
            { 
                throw new ArgumentOutOfRangeException($"The quantity: {quantity}, is not valid."); 
            } 
            return quantity; 
        } private decimal ValidateValue(decimal value) 
        { 
            if (value < 0) 
            { 
                throw new ArgumentOutOfRangeException($"The value: {value}, is not valid."); 
            } return value; 
        }

       
    }
}
