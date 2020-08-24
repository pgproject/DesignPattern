﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class MenuIngridient
    {
        public virtual void Add(MenuIngridient menuIngridient) 
        {
            throw new NotSupportedException();
        }
        public virtual void Remove(MenuIngridient menuIngridient)
        {
            throw new NotSupportedException();
        }
        public virtual MenuIngridient GetDescendant(int i)
        {
            throw new NotSupportedException();
        }
        public virtual string GetName()
        {
            throw new NotSupportedException();
        }
        public virtual string GetDescription()
        {
            throw new NotSupportedException();
        }
        public virtual double GetPrice()
        {
            throw new NotSupportedException();
        }
        public virtual bool IsVegeterian()
        {
            throw new NotSupportedException();
        }
        public virtual void Print()
        {
            throw new NotSupportedException();
        }
        public virtual IEnumerator CreateIterator()
        {
            throw new NotSupportedException();
        }
    }
}
