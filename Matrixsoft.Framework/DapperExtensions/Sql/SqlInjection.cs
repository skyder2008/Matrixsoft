﻿using System;

namespace Matrixsoft.Framework.DapperExtensions.Sql
{
    public class SqlInjection
    {
        public Type EntityType { get; set; }
        public string Property { get; set; }
        public string Sql { get; set; }
    }
}
