﻿using System;
using System.ComponentModel.DataAnnotations;
using Armin.Dunnhumby.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace Armin.Dunnhumby.Web.Models
{
    public class ProductInputModel
    {
        public Product ToEntity()
        {
            return new Product
            {
                Name = Name,
                Price = Price,
                Description = Description
            };
        }


        [Required] public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(0.0, (double)decimal.MaxValue)]
        public decimal Price { get; set; }
    }


    public class ProductOutputModel
    {
        public static ProductOutputModel FromEntity(Product p)
        {
            return new ProductOutputModel
            {
                Id = p.Id,
                LastUpdate = p.LastUpdate,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description
            };
        }

        public string Description { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Photo { get; set; }

        public decimal Price { get; set; }

        public DateTime? LastUpdate { get; set; }
    }
}