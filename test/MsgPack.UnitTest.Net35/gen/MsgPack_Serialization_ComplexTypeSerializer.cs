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
    public class MsgPack_Serialization_ComplexTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexType> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Uri> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType> this_PackValueOfSourcePackValueOfSourceDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer1;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType> this_PackValueOfDataPackValueOfDataDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer2;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType> this_PackValueOfTimeStampPackValueOfTimeStampDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>> _serializer3;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType> this_PackValueOfHistoryPackValueOfHistoryDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.List<int>> _serializer4;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType> this_PackValueOfPointsPackValueOfPointsDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.ComplexType, System.Uri> this_SetUnpackedValueOfSourceSetUnpackedValueOfSourceDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int> this_UnpackValueOfSourceUnpackValueOfSourceDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexType, byte[]> this_SetUnpackedValueOfDataSetUnpackedValueOfDataDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, byte[]> MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueUnpackBinaryValueDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int> this_UnpackValueOfDataUnpackValueOfDataDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexType, System.DateTime> this_SetUnpackedValueOfTimeStampSetUnpackedValueOfTimeStampDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int> this_UnpackValueOfTimeStampUnpackValueOfTimeStampDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexType, System.Collections.Generic.Dictionary<System.DateTime, string>> this_SetUnpackedValueOfHistorySetUnpackedValueOfHistoryDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int> this_UnpackValueOfHistoryUnpackValueOfHistoryDelegate;
        
        private System.Reflection.MethodBase _methodBaseComplexType_set_Points0;
        
        private System.Action<MsgPack.Serialization.ComplexType, System.Collections.Generic.List<int>> this_SetUnpackedValueOfPointsSetUnpackedValueOfPointsDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int> this_UnpackValueOfPointsUnpackValueOfPointsDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_ComplexTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Uri>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<byte[]>(schema1);
            this._serializer2 = context.GetSerializer<System.DateTime>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer3 = context.GetSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>>(schema2);
            MsgPack.Serialization.PolymorphismSchema schema3 = default(MsgPack.Serialization.PolymorphismSchema);
            schema3 = null;
            this._serializer4 = context.GetSerializer<System.Collections.Generic.List<int>>(schema3);
            this._methodBaseComplexType_set_Points0 = typeof(MsgPack.Serialization.ComplexType).GetMethod("set_Points", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)), null, new System.Type[] {
                        typeof(System.Collections.Generic.List<int>)}, null);
            System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>[5];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfSource);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfData);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfTimeStamp);
            packOperationList[3] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfHistory);
            packOperationList[4] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfPoints);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>>(5);
            packOperationTable["Source"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfSource);
            packOperationTable["Data"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfData);
            packOperationTable["TimeStamp"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfTimeStamp);
            packOperationTable["History"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfHistory);
            packOperationTable["Points"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfPoints);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>[5];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfSource);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfData);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfTimeStamp);
            unpackOperationList[3] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfHistory);
            unpackOperationList[4] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfPoints);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>>(5);
            unpackOperationTable["Source"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfSource);
            unpackOperationTable["Data"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfData);
            unpackOperationTable["TimeStamp"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfTimeStamp);
            unpackOperationTable["History"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfHistory);
            unpackOperationTable["Points"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfPoints);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Source",
                    "Data",
                    "TimeStamp",
                    "History",
                    "Points"};
            this.this_PackValueOfSourcePackValueOfSourceDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfSource);
            this.this_PackValueOfDataPackValueOfDataDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfData);
            this.this_PackValueOfTimeStampPackValueOfTimeStampDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfTimeStamp);
            this.this_PackValueOfHistoryPackValueOfHistoryDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfHistory);
            this.this_PackValueOfPointsPackValueOfPointsDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexType>(this.PackValueOfPoints);
            this.this_SetUnpackedValueOfSourceSetUnpackedValueOfSourceDelegate = new System.Action<MsgPack.Serialization.ComplexType, System.Uri>(this.SetUnpackedValueOfSource);
            this.this_UnpackValueOfSourceUnpackValueOfSourceDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfSource);
            this.this_SetUnpackedValueOfDataSetUnpackedValueOfDataDelegate = new System.Action<MsgPack.Serialization.ComplexType, byte[]>(this.SetUnpackedValueOfData);
            this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueUnpackBinaryValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, byte[]>(MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue);
            this.this_UnpackValueOfDataUnpackValueOfDataDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfData);
            this.this_SetUnpackedValueOfTimeStampSetUnpackedValueOfTimeStampDelegate = new System.Action<MsgPack.Serialization.ComplexType, System.DateTime>(this.SetUnpackedValueOfTimeStamp);
            this.this_UnpackValueOfTimeStampUnpackValueOfTimeStampDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfTimeStamp);
            this.this_SetUnpackedValueOfHistorySetUnpackedValueOfHistoryDelegate = new System.Action<MsgPack.Serialization.ComplexType, System.Collections.Generic.Dictionary<System.DateTime, string>>(this.SetUnpackedValueOfHistory);
            this.this_UnpackValueOfHistoryUnpackValueOfHistoryDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfHistory);
            this.this_SetUnpackedValueOfPointsSetUnpackedValueOfPointsDelegate = new System.Action<MsgPack.Serialization.ComplexType, System.Collections.Generic.List<int>>(this.SetUnpackedValueOfPoints);
            this.this_UnpackValueOfPointsUnpackValueOfPointsDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexType, int, int>(this.UnpackValueOfPoints);
        }
        
        private void PackValueOfSource(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer0.PackTo(packer, objectTree.Source);
        }
        
        private void PackValueOfData(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer1.PackTo(packer, objectTree.Data);
        }
        
        private void PackValueOfTimeStamp(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer2.PackTo(packer, objectTree.TimeStamp);
        }
        
        private void PackValueOfHistory(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer3.PackTo(packer, objectTree.History);
        }
        
        private void PackValueOfPoints(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            this._serializer4.PackTo(packer, objectTree.Points);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexType objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfSource(MsgPack.Serialization.ComplexType unpackingContext, System.Uri unpackedValue) {
            unpackingContext.Source = unpackedValue;
        }
        
        private void UnpackValueOfSource(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Uri), "Source", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfSourceSetUnpackedValueOfSourceDelegate);
        }
        
        private void SetUnpackedValueOfData(MsgPack.Serialization.ComplexType unpackingContext, byte[] unpackedValue) {
            unpackingContext.Data = unpackedValue;
        }
        
        private void UnpackValueOfData(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer1, itemsCount, indexOfItem, typeof(byte[]), "Data", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueUnpackBinaryValueDelegate, this.this_SetUnpackedValueOfDataSetUnpackedValueOfDataDelegate);
        }
        
        private void SetUnpackedValueOfTimeStamp(MsgPack.Serialization.ComplexType unpackingContext, System.DateTime unpackedValue) {
            unpackingContext.TimeStamp = unpackedValue;
        }
        
        private void UnpackValueOfTimeStamp(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(unpacker, unpackingContext, this._serializer2, itemsCount, indexOfItem, typeof(System.DateTime), "TimeStamp", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTimeStampSetUnpackedValueOfTimeStampDelegate);
        }
        
        private void SetUnpackedValueOfHistory(MsgPack.Serialization.ComplexType unpackingContext, System.Collections.Generic.Dictionary<System.DateTime, string> unpackedValue) {
            System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<System.DateTime, string> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    unpackingContext.History.Add(current.Key, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfHistory(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer3, itemsCount, indexOfItem, typeof(System.Collections.Generic.Dictionary<System.DateTime, string>), "History", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfHistorySetUnpackedValueOfHistoryDelegate);
        }
        
        private void SetUnpackedValueOfPoints(MsgPack.Serialization.ComplexType unpackingContext, System.Collections.Generic.List<int> unpackedValue) {
            if ((unpackingContext.Points == null)) {
                this._methodBaseComplexType_set_Points0.Invoke(unpackingContext, new object[] {
                            unpackedValue});
            }
            else {
                System.Collections.Generic.List<int>.Enumerator enumerator0 = unpackedValue.GetEnumerator();
                int current0;
                try {
                    for (
                    ; enumerator0.MoveNext(); 
                    ) {
                        current0 = enumerator0.Current;
                        unpackingContext.Points.Add(current0);
                    }
                }
                finally {
                    enumerator0.Dispose();
                }
            }
        }
        
        private void UnpackValueOfPoints(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexType unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer4, itemsCount, indexOfItem, typeof(System.Collections.Generic.List<int>), "Points", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfPointsSetUnpackedValueOfPointsDelegate);
        }
        
        protected internal override MsgPack.Serialization.ComplexType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexType result = default(MsgPack.Serialization.ComplexType);
            result = new MsgPack.Serialization.ComplexType();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexType>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexType>(), this._unpackOperationTable);
            }
        }
    }
}
