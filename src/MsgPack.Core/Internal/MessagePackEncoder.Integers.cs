// Copyright (c) FUJIWARA, Yusuke and all contributors.
// This file is licensed under Apache2 license.
// See the LICENSE in the project root for more information.

// <auto-generated /> 
// This file is generated from acompanying .tt file.
// DO NOT edit this file directly, edit .tt file instead.

using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace MsgPack.Internal
{
	partial class MessagePackEncoder
	{
		/// <inheritdoc />
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public sealed override void EncodeInt32(Int32 value, IBufferWriter<byte> buffer)
		{
			buffer = Ensure.NotNull(buffer);

			var leastByte = value & 0x000000FF;
			if (leastByte == value || (value ^ 0xFFFFFF00) == leastByte)
			{
				var span = buffer.GetSpan(1);
				span[0] = unchecked((byte)(leastByte));
				buffer.Advance(1);
			}
			else
			{
				this.EncodeSlow(value, buffer);
			}
		}

		/// <inheritdoc />
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public sealed override void EncodeUInt32(UInt32 value, IBufferWriter<byte> buffer)
		{
			buffer = Ensure.NotNull(buffer);

			var leastByte = value & 0x000000FF;
			if (leastByte == value || (value ^ 0xFFFFFF00) == leastByte)
			{
				var span = buffer.GetSpan(1);
				span[0] = unchecked((byte)(leastByte));
				buffer.Advance(1);
			}
			else
			{
				this.EncodeSlow(value, buffer);
			}
		}

		/// <inheritdoc />
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public sealed override void EncodeInt64(Int64 value, IBufferWriter<byte> buffer)
		{
			buffer = Ensure.NotNull(buffer);

			var leastByte = value & 0x000000FF;
			if (leastByte == value || (value ^ 0xFFFFFF00) == leastByte)
			{
				var span = buffer.GetSpan(1);
				span[0] = unchecked((byte)(leastByte));
				buffer.Advance(1);
			}
			else
			{
				this.EncodeSlow(value, buffer);
			}
		}

		/// <inheritdoc />
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public sealed override void EncodeUInt64(UInt64 value, IBufferWriter<byte> buffer)
		{
			buffer = Ensure.NotNull(buffer);

			var leastByte = value & 0x000000FF;
			if (leastByte == value || (value ^ 0xFFFFFF00) == leastByte)
			{
				var span = buffer.GetSpan(1);
				span[0] = unchecked((byte)(leastByte));
				buffer.Advance(1);
			}
			else
			{
				this.EncodeSlow(value, buffer);
			}
		}

		private void EncodeSlow(int value, IBufferWriter<byte> buffer)
		{
			if (value >= SByte.MinValue && value <= SByte.MaxValue)
			{
				// SingedInt8 (SByte)
				var span = buffer.GetSpan(2);
				span[1] = unchecked((byte)(sbyte)value);
				span[0] = MessagePackCode.SignedInt8;
				buffer.Advance(2);
			}
			else if (value >= Int16.MinValue && value <= Int16.MaxValue)
			{
				// SignedInt16 (Int16)
				var span = buffer.GetSpan(3);
				span[0] = MessagePackCode.SignedInt16;
				span = span.Slice(1);
				BinaryPrimitives.WriteInt16BigEndian(span, unchecked((Int16)value));
				buffer.Advance(3);
			}
			else
			{
				// SignedInt32 (Int32)
				var span = buffer.GetSpan(5);
				span[0] = MessagePackCode.SignedInt32;
				span = span.Slice(1);
				BinaryPrimitives.WriteInt32BigEndian(span, unchecked((Int32)value));
				buffer.Advance(5);
			}
		} // EncodeSlow(int)

		private void EncodeSlow(uint value, IBufferWriter<byte> buffer)
		{
			if (value <= Byte.MaxValue)
			{
				// UnsingedInt8 (Byte)
				var span = buffer.GetSpan(2);
				span[1] = unchecked((byte)value);
				span[0] = MessagePackCode.UnsignedInt8;
				buffer.Advance(2);
			}
			else if (value <= UInt16.MaxValue)
			{
				// UnsignedInt16 (UInt16)
				var span = buffer.GetSpan(3);
				span[0] = MessagePackCode.UnsignedInt16;
				span = span.Slice(1);
				BinaryPrimitives.WriteUInt16BigEndian(span, unchecked((UInt16)value));
				buffer.Advance(3);
			}
			else
			{
				// UnsignedInt32 (UInt32)
				var span = buffer.GetSpan(5);
				span[0] = MessagePackCode.UnsignedInt32;
				span = span.Slice(1);
				BinaryPrimitives.WriteUInt32BigEndian(span, unchecked((UInt32)value));
				buffer.Advance(5);
			}
		} // EncodeSlow(uint)

		private void EncodeSlow(long value, IBufferWriter<byte> buffer)
		{
			if (value <= Int32.MaxValue && value >= Int32.MinValue)
			{
				this.EncodeSlow(unchecked((int)value), buffer);
			}
			else
			{
				// SignedInt64 (Int64)
				var span = buffer.GetSpan(9);
				span[0] = MessagePackCode.SignedInt64;
				span = span.Slice(1);
				BinaryPrimitives.WriteInt64BigEndian(span, unchecked((Int64)value));
				buffer.Advance(9);
			}
		} // EncodeSlow(long)

		private void EncodeSlow(ulong value, IBufferWriter<byte> buffer)
		{
			if (value <= UInt32.MaxValue)
			{
				this.EncodeSlow(unchecked((uint)value), buffer);
			}
			else
			{
				// UnsignedInt64 (UInt64)
				var span = buffer.GetSpan(9);
				span[0] = MessagePackCode.UnsignedInt64;
				span = span.Slice(1);
				BinaryPrimitives.WriteUInt64BigEndian(span, unchecked((UInt64)value));
				buffer.Advance(9);
			}
		} // EncodeSlow(ulong)

	}
}
