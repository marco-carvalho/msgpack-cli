﻿#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2010 FUJIWARA, Yusuke
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

namespace MsgPack.Serialization.DefaultMarshalers
{
	internal sealed class System_ObjectMessageMarshaler : MessageMarshaler<object>
	{
		protected sealed override void MarshalToCore( Packer packer, object value )
		{
			packer.PackObject( value );
		}

		protected sealed override object UnmarshalFromCore( Unpacker unpacker )
		{
			var result = unpacker.Data.Value;
			return result.IsNil ? null : ( object )result;
		}
	}
}