﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8670
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_SimpleCollection_1_System_ObjectArray_Serializer : MsgPack.Serialization.CollectionSerializers.CollectionMessagePackSerializer<MsgPack.Serialization.SimpleCollection<object[]>, object[]> {
        
        public MsgPack_Serialization_SimpleCollection_1_System_ObjectArray_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, MsgPack_Serialization_SimpleCollection_1_System_ObjectArray_Serializer.RestoreSchema()) {
        }
        
        protected override MsgPack.Serialization.SimpleCollection<object[]> CreateInstance(int initialCapacity) {
            MsgPack.Serialization.SimpleCollection<object[]> collection = default(MsgPack.Serialization.SimpleCollection<object[]>);
            collection = new MsgPack.Serialization.SimpleCollection<object[]>();
            return collection;
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
        }
    }
}
