﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternSample
{
    public interface ICarFactory
    {
        ISedan CreateSedan();

        ISUV CreateSUV();
    }
}
