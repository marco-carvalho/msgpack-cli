﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_InterfaceDictKeyRuntimeTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.InterfaceDictKeyRuntimeType> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<MsgPack.Serialization.IFileSystemEntry, string>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType> this_PackValueOfValuePackValueOfValueDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.InterfaceDictKeyRuntimeType, System.Collections.Generic.IDictionary<MsgPack.Serialization.IFileSystemEntry, string>> this_SetUnpackedValueOfValueSetUnpackedValueOfValueDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType, int, int> this_UnpackValueOfValueUnpackValueOfValueDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_InterfaceDictKeyRuntimeTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema keysSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            keysSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.IFileSystemEntry));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.IFileSystemEntry, string>), keysSchema0, null);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<MsgPack.Serialization.IFileSystemEntry, string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType>(this.PackValueOfValue);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType>>(1);
            packOperationTable["Value"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType>(this.PackValueOfValue);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType, int, int>(this.UnpackValueOfValue);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType, int, int>>(1);
            unpackOperationTable["Value"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType, int, int>(this.UnpackValueOfValue);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Value"};
            this.this_PackValueOfValuePackValueOfValueDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType>(this.PackValueOfValue);
            this.this_SetUnpackedValueOfValueSetUnpackedValueOfValueDelegate = new System.Action<MsgPack.Serialization.InterfaceDictKeyRuntimeType, System.Collections.Generic.IDictionary<MsgPack.Serialization.IFileSystemEntry, string>>(this.SetUnpackedValueOfValue);
            this.this_UnpackValueOfValueUnpackValueOfValueDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType, int, int>(this.UnpackValueOfValue);
        }
        
        private void PackValueOfValue(MsgPack.Packer packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.InterfaceDictKeyRuntimeType objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfValue(MsgPack.Serialization.InterfaceDictKeyRuntimeType unpackingContext, System.Collections.Generic.IDictionary<MsgPack.Serialization.IFileSystemEntry, string> unpackedValue) {
            unpackingContext.Value = unpackedValue;
        }
        
        private void UnpackValueOfValue(MsgPack.Unpacker unpacker, MsgPack.Serialization.InterfaceDictKeyRuntimeType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.IFileSystemEntry, string>), "Value", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfValueSetUnpackedValueOfValueDelegate);
        }
        
        protected internal override MsgPack.Serialization.InterfaceDictKeyRuntimeType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.InterfaceDictKeyRuntimeType result = default(MsgPack.Serialization.InterfaceDictKeyRuntimeType);
            result = new MsgPack.Serialization.InterfaceDictKeyRuntimeType();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.InterfaceDictKeyRuntimeType>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.InterfaceDictKeyRuntimeType>(), this._unpackOperationTable);
            }
        }
    }
}
