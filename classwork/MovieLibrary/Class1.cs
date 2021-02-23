using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    // Naming rules for types
    //   Noun, no abbreviations or acronyms
    //   Pascal cased

    // this keyword is only usable inside a type
    //   it represents the current instance/object
    //   it is used to distinguish class members from local identifiers

    // Accessibility - compile time access given to code (type, member, function, etc) for something
    //   public - usable by anyone
    //   private - only usable by defining type (default for members of a class)
    //   internal - (default for types): only usable in defining assembly

    // class-declaration ::= [modifiers] class identifier { class-members* }
    // class-members ::= field
    // field ::= [modifiers] T identifier [ = E ];
    // modifiers ::= [public | internal]

    /// <summary>Represents a movie.</summary>
    /// <remarks>
    /// Where you put additional comments that may be useful to someone.
    /// </remarks>
    public class Movie
    {
        //Fields - variables that store data
        // fields should always start with underscore and be camel cased
        // fields are initialized early in the process to 0, can be changed to another value
        // fields are initialized in an undefined order
        // fields cannot be initialized to another field's value

        void IsBlackAndWhite()
        {
            var isOld = releaseYear < 1940;
        }

        /// <summary>Gets or sets the title.</summary>
        public string title = "";

        public string description = "";
        public int releaseYear = 1900;
        public int runLength;
        public string rating = "";
        public bool isClassic;
    }
}