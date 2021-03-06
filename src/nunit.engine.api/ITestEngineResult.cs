﻿// ***********************************************************************
// Copyright (c) 2011 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Xml;

namespace NUnit.Engine
{
    /// <summary>
    /// Interface implemented by classes that return results from
    /// the test engine. The result info is represented as XML.
    /// </summary>
    public interface ITestEngineResult
    {
        /// <summary>
        /// Gets a flag indicating whether this result contains any
        /// general errors, excluding test errors or failures.
        /// </summary>
        bool HasErrors { get; }

        /// <summary>
        /// Gets a list of errors from the result. These are general
        /// execution errors and don't include test errors or failures.
        /// </summary>
        IList<TestEngineError> Errors { get; }

        /// <summary>
        /// Gets the XML representing a single test result.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// If the result is empty or has multiple XML nodes.
        /// </exception>
        XmlNode Xml { get; }
    }
}
