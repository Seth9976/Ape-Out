using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000114 RID: 276
	[Serializable]
	public class DelegateSerializationHolder : Object
	{
		// Token: 0x0600149B RID: 5275 RVA: 0x00082A0C File Offset: 0x00080C0C
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateSerializationHolder()
		{
			Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DelegateSerializationHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr);
			DelegateSerializationHolder.NativeFieldInfoPtr__delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, "_delegate");
			DelegateSerializationHolder.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, 100666878);
			DelegateSerializationHolder.NativeMethodInfoPtr_GetDelegateData_Public_Static_Void_Delegate_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, 100666879);
			DelegateSerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, 100666880);
			DelegateSerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, 100666881);
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00082AA0 File Offset: 0x00080CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175501, XrefRangeEnd = 175522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegateSerializationHolder(SerializationInfo info, StreamingContext ctx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00082B04 File Offset: 0x00080D04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175565, RefRangeEnd = 175567, XrefRangeStart = 175522, XrefRangeEnd = 175565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.NativeMethodInfoPtr_GetDelegateData_Public_Static_Void_Delegate_SerializationInfo_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00082B64 File Offset: 0x00080D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175567, XrefRangeEnd = 175572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00082BC0 File Offset: 0x00080DC0
		[CallerCount(0)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00007157 File Offset: 0x00005357
		public DelegateSerializationHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x00082C18 File Offset: 0x00080E18
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x00007160 File Offset: 0x00005360
		public unsafe Delegate _delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.NativeFieldInfoPtr__delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.NativeFieldInfoPtr__delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeFieldInfoPtr__delegate;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegateData_Public_Static_Void_Delegate_SerializationInfo_StreamingContext_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0;

		// Token: 0x020005AC RID: 1452
		[Serializable]
		public class DelegateEntry : Object
		{
			// Token: 0x06005147 RID: 20807 RVA: 0x00170638 File Offset: 0x0016E838
			// Note: this type is marked as 'beforefieldinit'.
			static DelegateEntry()
			{
				Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelegateSerializationHolder>.NativeClassPtr, "DelegateEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr);
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "type");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "assembly");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "target");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "targetTypeAssembly");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "targetTypeName");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "methodName");
				DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_delegateEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, "delegateEntry");
				DelegateSerializationHolder.DelegateEntry.NativeMethodInfoPtr__ctor_Public_Void_Delegate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, 100666882);
				DelegateSerializationHolder.DelegateEntry.NativeMethodInfoPtr_DeserializeDelegate_Public_Delegate_SerializationInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr, 100666883);
			}

			// Token: 0x06005148 RID: 20808 RVA: 0x00170718 File Offset: 0x0016E918
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 175463, RefRangeEnd = 175464, XrefRangeStart = 175461, XrefRangeEnd = 175463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DelegateEntry(Delegate del, string targetLabel)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateSerializationHolder.DelegateEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(del);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetLabel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.DelegateEntry.NativeMethodInfoPtr__ctor_Public_Void_Delegate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005149 RID: 20809 RVA: 0x00170778 File Offset: 0x0016E978
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 175500, RefRangeEnd = 175501, XrefRangeStart = 175464, XrefRangeEnd = 175500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Delegate DeserializeDelegate(SerializationInfo info, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateSerializationHolder.DelegateEntry.NativeMethodInfoPtr_DeserializeDelegate_Public_Delegate_SerializationInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}

			// Token: 0x0600514A RID: 20810 RVA: 0x0001E76A File Offset: 0x0001C96A
			public DelegateEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014C3 RID: 5315
			// (get) Token: 0x0600514B RID: 20811 RVA: 0x001707D8 File Offset: 0x0016E9D8
			// (set) Token: 0x0600514C RID: 20812 RVA: 0x0001E773 File Offset: 0x0001C973
			public unsafe string type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_type);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014C4 RID: 5316
			// (get) Token: 0x0600514D RID: 20813 RVA: 0x00170800 File Offset: 0x0016EA00
			// (set) Token: 0x0600514E RID: 20814 RVA: 0x0001E792 File Offset: 0x0001C992
			public unsafe string assembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_assembly);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_assembly), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014C5 RID: 5317
			// (get) Token: 0x0600514F RID: 20815 RVA: 0x00170828 File Offset: 0x0016EA28
			// (set) Token: 0x06005150 RID: 20816 RVA: 0x0001E7B1 File Offset: 0x0001C9B1
			public unsafe Object target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014C6 RID: 5318
			// (get) Token: 0x06005151 RID: 20817 RVA: 0x00170858 File Offset: 0x0016EA58
			// (set) Token: 0x06005152 RID: 20818 RVA: 0x0001E7D0 File Offset: 0x0001C9D0
			public unsafe string targetTypeAssembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeAssembly);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeAssembly), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014C7 RID: 5319
			// (get) Token: 0x06005153 RID: 20819 RVA: 0x00170880 File Offset: 0x0016EA80
			// (set) Token: 0x06005154 RID: 20820 RVA: 0x0001E7EF File Offset: 0x0001C9EF
			public unsafe string targetTypeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_targetTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014C8 RID: 5320
			// (get) Token: 0x06005155 RID: 20821 RVA: 0x001708A8 File Offset: 0x0016EAA8
			// (set) Token: 0x06005156 RID: 20822 RVA: 0x0001E80E File Offset: 0x0001CA0E
			public unsafe string methodName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_methodName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_methodName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014C9 RID: 5321
			// (get) Token: 0x06005157 RID: 20823 RVA: 0x001708D0 File Offset: 0x0016EAD0
			// (set) Token: 0x06005158 RID: 20824 RVA: 0x0001E82D File Offset: 0x0001CA2D
			public unsafe DelegateSerializationHolder.DelegateEntry delegateEntry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_delegateEntry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateSerializationHolder.DelegateEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateSerializationHolder.DelegateEntry.NativeFieldInfoPtr_delegateEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004230 RID: 16944
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04004231 RID: 16945
			private static readonly IntPtr NativeFieldInfoPtr_assembly;

			// Token: 0x04004232 RID: 16946
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04004233 RID: 16947
			private static readonly IntPtr NativeFieldInfoPtr_targetTypeAssembly;

			// Token: 0x04004234 RID: 16948
			private static readonly IntPtr NativeFieldInfoPtr_targetTypeName;

			// Token: 0x04004235 RID: 16949
			private static readonly IntPtr NativeFieldInfoPtr_methodName;

			// Token: 0x04004236 RID: 16950
			private static readonly IntPtr NativeFieldInfoPtr_delegateEntry;

			// Token: 0x04004237 RID: 16951
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Delegate_String_0;

			// Token: 0x04004238 RID: 16952
			private static readonly IntPtr NativeMethodInfoPtr_DeserializeDelegate_Public_Delegate_SerializationInfo_Int32_0;
		}
	}
}
