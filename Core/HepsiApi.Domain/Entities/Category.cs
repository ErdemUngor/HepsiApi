﻿using System;
using HepsiApi.Domain.Common;
using HepsiApi.Domain.Entities;

namespace HepsiApi.Domain.Entities
{
	public class Category : EntityBase
	{
        public Category()
        {

        }

        public Category(int parentId, string name, int priority)
        {
            ParentId = parentId;
            Name = name;
            Priority = priority;
        }

        public required int ParentId { get; set; }

		public required string Name { get; set; }

		public required int Priority { get; set; }

        public ICollection<Detail> Details { get; set; }

        public ICollection<Product> Products { get; set; }


    }
}



