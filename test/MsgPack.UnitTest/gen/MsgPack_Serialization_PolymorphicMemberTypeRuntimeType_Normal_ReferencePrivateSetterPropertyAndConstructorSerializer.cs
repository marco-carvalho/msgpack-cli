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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Version> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor> this_PackValueOfReferencePackValueOfReferenceDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>> _packOperationTable;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor_set_Reference0;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, System.Version> this_SetUnpackedValueOfReferenceSetUnpackedValueOfReferenceDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, int, int> this_UnpackValueOfReferenceUnpackValueOfReferenceDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Version>(schema0);
            this._methodBasePolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor_set_Reference0 = typeof(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor).GetMethod("set_Reference", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)), null, new System.Type[] {
                        typeof(System.Version)}, null);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>(this.PackValueOfReference);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>>(1);
            packOperationTable["Reference"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>(this.PackValueOfReference);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, int, int>(this.UnpackValueOfReference);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, int, int>>(1);
            unpackOperationTable["Reference"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, int, int>(this.UnpackValueOfReference);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Reference"};
            this.this_PackValueOfReferencePackValueOfReferenceDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>(this.PackValueOfReference);
            this.this_SetUnpackedValueOfReferenceSetUnpackedValueOfReferenceDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, System.Version>(this.SetUnpackedValueOfReference);
            this.this_UnpackValueOfReferenceUnpackValueOfReferenceDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor, int, int>(this.UnpackValueOfReference);
        }
        
        private void PackValueOfReference(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Reference);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfReference(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor unpackingContext, System.Version unpackedValue) {
            this._methodBasePolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor_set_Reference0.Invoke(unpackingContext, new object[] {
                        unpackedValue});
        }
        
        private void UnpackValueOfReference(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Version), "Reference", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfReferenceSetUnpackedValueOfReferenceDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_ReferencePrivateSetterPropertyAndConstructor>(), this._unpackOperationTable);
            }
        }
    }
}
