﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandWindownsForms.repository
{
    internal interface ObjectRepo<T>
    {
        List<T> getObjects();
        T getObject(string mbid);
        Boolean addObject(T obj);
    }
}
