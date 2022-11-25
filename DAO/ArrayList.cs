using DTO;
using System;
using System.Collections;

namespace DAO
{
    public class ArrayList<T>
    {
        internal void Add(CustomerDTO customer)
        {
            throw new NotImplementedException();
        }

        internal void Add(ProductDTO pro)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ArrayList<T>(ArrayList v)
        {
            throw new NotImplementedException();
        }
    }
}