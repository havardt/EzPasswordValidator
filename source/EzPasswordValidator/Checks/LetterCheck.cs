﻿using System.Text.RegularExpressions;

namespace EzPasswordValidator.Checks
{
    /// <inheritdoc />
    /// <summary>
    /// A class checking for letters in passwords.
    /// </summary>
    /// <seealso cref="EzPasswordValidator.Checks.Check" />
    public class LetterCheck : Check
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="EzPasswordValidator.Checks.LetterCheck" /> class.
        /// </summary>
        public LetterCheck() 
            : base(CheckTypes.Letters)
        {

        }

        /// <inheritdoc />
        /// <summary>
        /// Checks that the password contains at least one letter.
        /// </summary>
        protected override bool OnExecute(string password) => 
            Regex.IsMatch(password, "^.*[A-Za-z]+.*$");
    }
}