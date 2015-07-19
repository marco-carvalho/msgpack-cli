﻿#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2015 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;

namespace MsgPack
{
	/// <summary>
	///		Defines known ext type name for MessagePack for CLI.
	/// </summary>
	/// <remarks>
	///		Note that values in this class are not guaranteed as interoperable with other implementations.
	///		These are just known by MessagePack for CLI implementation.
	/// </remarks>
	public static class KnownExtTypeName
	{
		/// <summary>
		///		Gets the ext type name which represents "Library Defined Type".
		/// </summary>
		/// <value>
		///		"LibraryDefinedType".
		/// </value>
		/// <remarks>
		///		"Library Defined Type" will be used to embed native or coded type information in MessagePack stream.
		/// </remarks>
		public static string LibraryDefinedType
		{
			get { return "LibraryDefinedType"; }
		}

		/// <summary>
		///		Gets the ext type name which represents multidimensional array.
		/// </summary>
		/// <value>
		///		"MultidimensionalArray".
		/// </value>
		public static string MultidimensionalArray
		{
			get { return "MultidimensionalArray"; }
		}
	}
}
