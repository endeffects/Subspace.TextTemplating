﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Subspace" file="FragmentType.cs">
//   Copyright (c) Subspace. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Subspace.TextTemplating
{
    /// <summary>
    ///     An enumeration used to specify a fragment type.
    /// </summary>
    internal enum FragmentType
    {
        /// <summary>
        ///     A markup fragment.
        /// </summary>
        Markup,

        /// <summary>
        ///     A script fragment.
        /// </summary>
        Script,

        /// <summary>
        ///     A script expression of which the result is automatically written to the output.
        /// </summary>
        AutoWriteScript,

        /// <summary>
        ///     A script, such as a method definition, that will end up in the class body.
        /// </summary>
        ClassBody,

        /// <summary>
        ///     A template directive.
        /// </summary>
        Template,

        /// <summary>
        ///     An include directive.
        /// </summary>
        Include,

        /// <summary>
        ///     A namespace import directive.
        /// </summary>
        NamespaceImport,

        /// <summary>
        ///     A property directive.
        /// </summary>
        Property
    }
}
