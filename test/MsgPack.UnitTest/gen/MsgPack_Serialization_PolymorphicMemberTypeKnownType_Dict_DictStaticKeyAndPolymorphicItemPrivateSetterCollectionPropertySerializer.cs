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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty> this_PackValueOfDictStaticKeyAndPolymorphicItemPackValueOfDictStaticKeyAndPolymorphicItemDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>> _packOperationTable;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty_set_DictStaticKeyAndPolymorphicItem0;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>> this_SetUnpackedValueOfDictStaticKeyAndPolymorphicItemSetUnpackedValueOfDictStaticKeyAndPolymorphicItemDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, int, int> this_UnpackValueOfDictStaticKeyAndPolymorphicItemUnpackValueOfDictStaticKeyAndPolymorphicItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema valuesSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> valuesSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            valuesSchemaTypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            valuesSchemaTypeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            valuesSchemaTypeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            valuesSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), valuesSchemaTypeMap0);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>), null, valuesSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>>(schema0);
            this._methodBasePolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty_set_DictStaticKeyAndPolymorphicItem0 = typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty).GetMethod("set_DictStaticKeyAndPolymorphicItem", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)), null, new System.Type[] {
                        typeof(System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>)}, null);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>(this.PackValueOfDictStaticKeyAndPolymorphicItem);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>>(1);
            packOperationTable["DictStaticKeyAndPolymorphicItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>(this.PackValueOfDictStaticKeyAndPolymorphicItem);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, int, int>(this.UnpackValueOfDictStaticKeyAndPolymorphicItem);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, int, int>>(1);
            unpackOperationTable["DictStaticKeyAndPolymorphicItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, int, int>(this.UnpackValueOfDictStaticKeyAndPolymorphicItem);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "DictStaticKeyAndPolymorphicItem"};
            this.this_PackValueOfDictStaticKeyAndPolymorphicItemPackValueOfDictStaticKeyAndPolymorphicItemDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>(this.PackValueOfDictStaticKeyAndPolymorphicItem);
            this.this_SetUnpackedValueOfDictStaticKeyAndPolymorphicItemSetUnpackedValueOfDictStaticKeyAndPolymorphicItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>>(this.SetUnpackedValueOfDictStaticKeyAndPolymorphicItem);
            this.this_UnpackValueOfDictStaticKeyAndPolymorphicItemUnpackValueOfDictStaticKeyAndPolymorphicItemDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty, int, int>(this.UnpackValueOfDictStaticKeyAndPolymorphicItem);
        }
        
        private void PackValueOfDictStaticKeyAndPolymorphicItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictStaticKeyAndPolymorphicItem);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfDictStaticKeyAndPolymorphicItem(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty unpackingContext, System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry> unpackedValue) {
            if ((unpackingContext.DictStaticKeyAndPolymorphicItem == null)) {
                this._methodBasePolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty_set_DictStaticKeyAndPolymorphicItem0.Invoke(unpackingContext, new object[] {
                            unpackedValue});
            }
            else {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, MsgPack.Serialization.FileSystemEntry>> enumerator = unpackedValue.GetEnumerator();
                System.Collections.Generic.KeyValuePair<string, MsgPack.Serialization.FileSystemEntry> current;
                try {
                    for (
                    ; enumerator.MoveNext(); 
                    ) {
                        current = enumerator.Current;
                        unpackingContext.DictStaticKeyAndPolymorphicItem.Add(current.Key, current.Value);
                    }
                }
                finally {
                    enumerator.Dispose();
                }
            }
        }
        
        private void UnpackValueOfDictStaticKeyAndPolymorphicItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>), "DictStaticKeyAndPolymorphicItem", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfDictStaticKeyAndPolymorphicItemSetUnpackedValueOfDictStaticKeyAndPolymorphicItemDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemPrivateSetterCollectionProperty>(), this._unpackOperationTable);
            }
        }
    }
}
