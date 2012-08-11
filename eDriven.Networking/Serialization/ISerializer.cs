#region License

/*
 
Copyright (c) 2012 Danko Kozar

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
 
*/

#endregion License

using System;

namespace eDriven.Networking.Serialization
{
    /// <summary>
    /// The interface that should be implemented by custom serializer or 3rd party serializer wrapper
    /// </summary>
    public interface ISerializer
    {
        /// <summary>
        /// Serializes object to string
        /// </summary>
        /// <param name="o">Object to serialize</param>
        /// <returns>Serialized string</returns>
        string Serialize(object o);

        /// <summary>
        /// Deserializes string to object
        /// </summary>
        /// <param name="s">String to deserialize</param>
        /// <param name="type">Type to which a string should be deserialized</param>
        /// <returns>Deserialized object</returns>
        object Deserialize(string s, Type type);
    }

    /// <summary>
    /// The interface that should be implemented by custom serializer or 3rd party serializer wrapper
    /// </summary>
    public interface ISerializer<T>
    {
        /// <summary>
        /// Serializes object to string
        /// </summary>
        /// <param name="o">Object to serialize</param>
        /// <returns>Serialized string</returns>
        string Serialize(T o);

        /// <summary>
        /// Deserializes string to object
        /// </summary>
        /// <param name="s">String to deserialize</param>
        /// <param name="type">Type to which a string should be deserialized</param>
        /// <returns>Deserialized object</returns>
        object Deserialize(string s, T type);
    }
}