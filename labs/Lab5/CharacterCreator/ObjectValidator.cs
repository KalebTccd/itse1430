/*
 * Charcter Creator
 * ITSE 1430
 * Spring 2021
 * Kaleb Dreier
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator
{
    /// <summary>Validates an object.</summary>
    public static class ObjectValidator
    {
        public static List<ValidationResult> TryValidate ( IValidatableObject value )
        {
            var context = new ValidationContext(value);
            var errors = new List<ValidationResult>();

            Validator.TryValidateObject(value, context, errors, true);

            return errors;
        }

        public static void Validate ( IValidatableObject value )
        {
            var context = new ValidationContext(value);

            Validator.ValidateObject(value, context, true);
        }
    }
}