﻿using System.Collections.Generic;

namespace HelpApp.Domain.Entities
{
    public class Category
    {
        #region Atributos
        public int Id { get; set; }
        public string Name { get; set; }

        #endregion

        #region Constructors

        public Category(string name)
        {
            Name = name;
            
        }
        
        public ICollection<Product> Products { get; set; }
        #endregion

        #region Validação

        private void Validation(string name)
        {
            DomainExceptionValidation.When(string.isNullOrEmpty(name), "Invalid name, name required");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name, to short, minum 3 character.");

            Name = name;
)
        }
        #endregion


    }
}
