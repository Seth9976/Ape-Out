using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200034A RID: 842
	public sealed class SerializationEntry : ValueType
	{
		// Token: 0x06003716 RID: 14102 RVA: 0x0010DB44 File Offset: 0x0010BD44
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationEntry()
		{
			Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr);
			SerializationEntry.NativeFieldInfoPtr_m_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, "m_type");
			SerializationEntry.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, "m_value");
			SerializationEntry.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, "m_name");
			SerializationEntry.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, 100671844);
			SerializationEntry.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, 100671845);
			SerializationEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, 100671846);
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06003717 RID: 14103 RVA: 0x0010DBEC File Offset: 0x0010BDEC
		public unsafe Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEntry.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06003718 RID: 14104 RVA: 0x0010DC30 File Offset: 0x0010BE30
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEntry.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x0010DC6C File Offset: 0x0010BE6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215597, RefRangeEnd = 215599, XrefRangeStart = 215597, XrefRangeEnd = 215597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEntry(string entryName, Object entryValue, Type entryType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entryName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entryValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entryType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Object_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00013921 File Offset: 0x00011B21
		public SerializationEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x0001392A File Offset: 0x00011B2A
		public SerializationEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr))
		{
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x0600371C RID: 14108 RVA: 0x0010DCE0 File Offset: 0x0010BEE0
		// (set) Token: 0x0600371D RID: 14109 RVA: 0x0001393C File Offset: 0x00011B3C
		public unsafe Type m_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr_m_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr_m_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x0600371E RID: 14110 RVA: 0x0010DD10 File Offset: 0x0010BF10
		// (set) Token: 0x0600371F RID: 14111 RVA: 0x0001395B File Offset: 0x00011B5B
		public unsafe Object m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr_m_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr_m_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06003720 RID: 14112 RVA: 0x0010DD40 File Offset: 0x0010BF40
		// (set) Token: 0x06003721 RID: 14113 RVA: 0x0001397A File Offset: 0x00011B7A
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002E61 RID: 11873
		private static readonly IntPtr NativeFieldInfoPtr_m_type;

		// Token: 0x04002E62 RID: 11874
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04002E63 RID: 11875
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04002E64 RID: 11876
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04002E65 RID: 11877
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04002E66 RID: 11878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Object_Type_0;
	}
}
