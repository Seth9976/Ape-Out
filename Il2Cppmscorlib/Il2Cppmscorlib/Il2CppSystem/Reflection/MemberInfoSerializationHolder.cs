using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001AF RID: 431
	[Serializable]
	public class MemberInfoSerializationHolder : Object
	{
		// Token: 0x06001C3C RID: 7228 RVA: 0x000A3828 File Offset: 0x000A1A28
		// Note: this type is marked as 'beforefieldinit'.
		static MemberInfoSerializationHolder()
		{
			Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MemberInfoSerializationHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr);
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_memberName");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_reflectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_reflectedType");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_signature");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_signature2");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_memberType");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_info");
			MemberInfoSerializationHolder.NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100668073);
			MemberInfoSerializationHolder.NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_String_MemberTypes_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100668074);
			MemberInfoSerializationHolder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100668075);
			MemberInfoSerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100668076);
			MemberInfoSerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100668077);
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x000A3934 File Offset: 0x000A1B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186146, XrefRangeEnd = 186147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedClass);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfoSerializationHolder.NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_MemberTypes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x000A39B0 File Offset: 0x000A1BB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 186268, RefRangeEnd = 186274, XrefRangeStart = 186147, XrefRangeEnd = 186268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Il2CppReferenceArray<Type> genericArguments)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedClass);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfoSerializationHolder.NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_String_MemberTypes_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x000A3A50 File Offset: 0x000A1C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186274, XrefRangeEnd = 186308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberInfoSerializationHolder(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfoSerializationHolder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x000A3AB4 File Offset: 0x000A1CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186308, XrefRangeEnd = 186315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfoSerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x000A3B18 File Offset: 0x000A1D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186315, XrefRangeEnd = 186355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfoSerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x000099D4 File Offset: 0x00007BD4
		public MemberInfoSerializationHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x000A3B78 File Offset: 0x000A1D78
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x000099DD File Offset: 0x00007BDD
		public unsafe string m_memberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x000A3BA0 File Offset: 0x000A1DA0
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x000099FC File Offset: 0x00007BFC
		public unsafe RuntimeType m_reflectedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_reflectedType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_reflectedType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x000A3BD0 File Offset: 0x000A1DD0
		// (set) Token: 0x06001C48 RID: 7240 RVA: 0x00009A1B File Offset: 0x00007C1B
		public unsafe string m_signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x000A3BF8 File Offset: 0x000A1DF8
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x00009A3A File Offset: 0x00007C3A
		public unsafe string m_signature2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature2);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature2), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x000A3C20 File Offset: 0x000A1E20
		// (set) Token: 0x06001C4C RID: 7244 RVA: 0x00009A59 File Offset: 0x00007C59
		public unsafe MemberTypes m_memberType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberType)) = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x000A3C48 File Offset: 0x000A1E48
		// (set) Token: 0x06001C4E RID: 7246 RVA: 0x00009A74 File Offset: 0x00007C74
		public unsafe SerializationInfo m_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019CC RID: 6604
		private static readonly IntPtr NativeFieldInfoPtr_m_memberName;

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeFieldInfoPtr_m_reflectedType;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeFieldInfoPtr_m_signature;

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeFieldInfoPtr_m_signature2;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeFieldInfoPtr_m_memberType;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeFieldInfoPtr_m_info;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_MemberTypes_0;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_String_MemberTypes_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0;
	}
}
