﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Pet
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de Mascota")]
        [MaxLength(50, ErrorMessage = "No se permiten mas de 50 digitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Foto Mascota")]
        public string ImageUrl { get; set; }

        [Display(Name = "Raza")]
        [MaxLength(50, ErrorMessage = "No se permiten mas de 50 digitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Race { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime Born { get; set; }

        public string Remarks { get; set; }


        public Owner Owner { get; set; }
        public PetType PetType { get; set; }


        public ICollection<History> Histories { get; set; }
        public ICollection<Agenda> Agendas { get; set; }


    }
}
