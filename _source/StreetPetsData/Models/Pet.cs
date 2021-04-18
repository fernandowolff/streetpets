﻿using StreetPetsData.Interfaces;
using StreetPetsData.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreetPetsData.Models
{
    public class Pet : IDateRegistry
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public string Notes { get; set; }

        public int BreedId { get; set; }

        [ForeignKey(nameof(BreedId))]
        public Breed Breed { get; set; }

        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; }

        public bool IsBeingFed { get; set; }

        public PetStatus PetStatus { get; set; }

        public string Picture { get; set; }

        public string MoreDetailsUrl { get; set; }

        public EntityStatus EntityStatus { get; set; }


        #region IDateRegistry

        public DateTime CreatedDate { get; set; }

        public int CreatedById { get; set; }

        [ForeignKey(nameof(CreatedById))]
        public Person? CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int UpdatedById { get; set; }

        [ForeignKey(nameof(UpdatedById))]
        public Person? UpdatedBy { get; set; }

        public DateTime? DeactivatedDate { get; set; }

        public int DeactivatedById { get; set; }

        [ForeignKey(nameof(DeactivatedById))]
        public Person? DeactivatedBy { get; set; }

        #endregion
    }
}
