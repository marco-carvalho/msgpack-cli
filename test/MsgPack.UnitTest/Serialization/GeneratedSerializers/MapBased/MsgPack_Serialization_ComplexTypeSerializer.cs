﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34011
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.5.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_ComplexTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexType> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Uri> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer2;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer3;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>> _serializer4;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.DateTime>> _serializer5;
        
        public MsgPack_Serialization_ComplexTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            this._serializer0 = this.OwnerContext.GetSerializer<string>();
            this._serializer1 = this.OwnerContext.GetSerializer<System.Uri>();
            this._serializer2 = this.OwnerContext.GetSerializer<byte[]>();
            this._serializer3 = this.OwnerContext.GetSerializer<System.DateTime>();
            this._serializer4 = this.OwnerContext.GetSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>>();
            this._serializer5 = this.OwnerContext.GetSerializer<System.Nullable<System.DateTime>>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            packer.PackMapHeader(4);
            this._serializer0.PackTo(packer, "Source");
            this._serializer1.PackTo(packer, objectTree.Source);
            this._serializer0.PackTo(packer, "Data");
            this._serializer2.PackTo(packer, objectTree.Data);
            this._serializer0.PackTo(packer, "TimeStamp");
            this._serializer3.PackTo(packer, objectTree.TimeStamp);
            this._serializer0.PackTo(packer, "History");
            this._serializer4.PackTo(packer, objectTree.History);
        }
        
        protected internal override MsgPack.Serialization.ComplexType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexType result = default(MsgPack.Serialization.ComplexType);
            result = new MsgPack.Serialization.ComplexType();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                System.Uri nullable = default(System.Uri);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(0);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable = this._serializer1.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (((nullable == null) 
                            == false)) {
                    result.Source = nullable;
                }
                unpacked = (unpacked + 1);
                byte[] nullable0 = default(byte[]);
                if ((unpacked < itemsCount)) {
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue(unpacker, typeof(MsgPack.Serialization.ComplexType), "Byte[] Data");
                }
                if (((nullable0 == null) 
                            == false)) {
                    result.Data = nullable0;
                }
                unpacked = (unpacked + 1);
                System.Nullable<System.DateTime> nullable1 = default(System.Nullable<System.DateTime>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(2);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable1 = this._serializer5.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                        disposable0 = unpacker.ReadSubtree();
                        try {
                            nullable1 = this._serializer5.UnpackFrom(disposable0);
                        }
                        finally {
                            if (((disposable0 == null) 
                                        == false)) {
                                disposable0.Dispose();
                            }
                        }
                    }
                }
                if (nullable1.HasValue) {
                    result.TimeStamp = nullable1.Value;
                }
                unpacked = (unpacked + 1);
                System.Collections.Generic.Dictionary<System.DateTime, string> nullable2 = default(System.Collections.Generic.Dictionary<System.DateTime, string>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(3);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable2 = this._serializer4.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable1 = default(MsgPack.Unpacker);
                        disposable1 = unpacker.ReadSubtree();
                        try {
                            nullable2 = this._serializer4.UnpackFrom(disposable1);
                        }
                        finally {
                            if (((disposable1 == null) 
                                        == false)) {
                                disposable1.Dispose();
                            }
                        }
                    }
                }
                if (((nullable2 == null) 
                            == false)) {
                    System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator = nullable2.GetEnumerator();
                    System.Collections.Generic.KeyValuePair<System.DateTime, string> current;
                    try {
                        for (
                        ; enumerator.MoveNext(); 
                        ) {
                            current = enumerator.Current;
                            result.History.Add(current.Key, current.Value);
                        }
                    }
                    finally {
                        enumerator.Dispose();
                    }
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable3 = default(string);
                    nullable3 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexType), "MemberName");
                    if (((nullable3 == null) 
                                == false)) {
                        key = nullable3;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "History")) {
                        System.Collections.Generic.Dictionary<System.DateTime, string> nullable7 = default(System.Collections.Generic.Dictionary<System.DateTime, string>);
                        if ((unpacker.Read() == false)) {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false) 
                                    && (unpacker.IsMapHeader == false))) {
                            nullable7 = this._serializer4.UnpackFrom(unpacker);
                        }
                        else {
                            MsgPack.Unpacker disposable4 = default(MsgPack.Unpacker);
                            disposable4 = unpacker.ReadSubtree();
                            try {
                                nullable7 = this._serializer4.UnpackFrom(disposable4);
                            }
                            finally {
                                if (((disposable4 == null) 
                                            == false)) {
                                    disposable4.Dispose();
                                }
                            }
                        }
                        if (((nullable7 == null) 
                                    == false)) {
                            System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator0 = nullable7.GetEnumerator();
                            System.Collections.Generic.KeyValuePair<System.DateTime, string> current0;
                            try {
                                for (
                                ; enumerator0.MoveNext(); 
                                ) {
                                    current0 = enumerator0.Current;
                                    result.History.Add(current0.Key, current0.Value);
                                }
                            }
                            finally {
                                enumerator0.Dispose();
                            }
                        }
                    }
                    else {
                        if ((key == "TimeStamp")) {
                            System.Nullable<System.DateTime> nullable6 = default(System.Nullable<System.DateTime>);
                            if ((unpacker.Read() == false)) {
                                throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                            }
                            if (((unpacker.IsArrayHeader == false) 
                                        && (unpacker.IsMapHeader == false))) {
                                nullable6 = this._serializer5.UnpackFrom(unpacker);
                            }
                            else {
                                MsgPack.Unpacker disposable3 = default(MsgPack.Unpacker);
                                disposable3 = unpacker.ReadSubtree();
                                try {
                                    nullable6 = this._serializer5.UnpackFrom(disposable3);
                                }
                                finally {
                                    if (((disposable3 == null) 
                                                == false)) {
                                        disposable3.Dispose();
                                    }
                                }
                            }
                            if (nullable6.HasValue) {
                                result.TimeStamp = nullable6.Value;
                            }
                        }
                        else {
                            if ((key == "Data")) {
                                byte[] nullable5 = default(byte[]);
                                nullable5 = MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue(unpacker, typeof(MsgPack.Serialization.ComplexType), "Byte[] Data");
                                if (((nullable5 == null) 
                                            == false)) {
                                    result.Data = nullable5;
                                }
                            }
                            else {
                                if ((key == "Source")) {
                                    System.Uri nullable4 = default(System.Uri);
                                    if ((unpacker.Read() == false)) {
                                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                    }
                                    if (((unpacker.IsArrayHeader == false) 
                                                && (unpacker.IsMapHeader == false))) {
                                        nullable4 = this._serializer1.UnpackFrom(unpacker);
                                    }
                                    else {
                                        MsgPack.Unpacker disposable2 = default(MsgPack.Unpacker);
                                        disposable2 = unpacker.ReadSubtree();
                                        try {
                                            nullable4 = this._serializer1.UnpackFrom(disposable2);
                                        }
                                        finally {
                                            if (((disposable2 == null) 
                                                        == false)) {
                                                disposable2.Dispose();
                                            }
                                        }
                                    }
                                    if (((nullable4 == null) 
                                                == false)) {
                                        result.Source = nullable4;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
