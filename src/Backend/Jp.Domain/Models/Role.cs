﻿using System;

namespace Jp.Domain.Models
{
    public class Role
    {
        public Role(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public long Id { get; private set; }
        public string Name { get; private set; }
    }
}
