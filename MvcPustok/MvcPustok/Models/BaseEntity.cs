﻿using System;
namespace MvcPustok.Models
{
	public class BaseEntity
	{

        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}