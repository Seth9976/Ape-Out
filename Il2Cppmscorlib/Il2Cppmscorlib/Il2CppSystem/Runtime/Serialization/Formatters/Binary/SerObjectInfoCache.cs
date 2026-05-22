using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037D RID: 893
	public sealed class SerObjectInfoCache : Object
	{
		// Token: 0x06003A18 RID: 14872 RVA: 0x00117890 File Offset: 0x00115A90
		// Note: this type is marked as 'beforefieldinit'.
		static SerObjectInfoCache()
		{
			Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerObjectInfoCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr);
			SerObjectInfoCache.NativeFieldInfoPtr_fullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "fullTypeName");
			SerObjectInfoCache.NativeFieldInfoPtr_assemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "assemblyString");
			SerObjectInfoCache.NativeFieldInfoPtr_hasTypeForwardedFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "hasTypeForwardedFrom");
			SerObjectInfoCache.NativeFieldInfoPtr_memberInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "memberInfos");
			SerObjectInfoCache.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "memberNames");
			SerObjectInfoCache.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, "memberTypes");
			SerObjectInfoCache.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, 100672086);
			SerObjectInfoCache.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr, 100672087);
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x00117960 File Offset: 0x00115B60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207526, RefRangeEnd = 207528, XrefRangeStart = 207526, XrefRangeEnd = 207528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasTypeForwardedFrom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerObjectInfoCache.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x001179CC File Offset: 0x00115BCC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 217119, RefRangeEnd = 217125, XrefRangeStart = 217115, XrefRangeEnd = 217119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerObjectInfoCache(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerObjectInfoCache>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerObjectInfoCache.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x000152CD File Offset: 0x000134CD
		public SerObjectInfoCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06003A1C RID: 14876 RVA: 0x00117A18 File Offset: 0x00115C18
		// (set) Token: 0x06003A1D RID: 14877 RVA: 0x000152D6 File Offset: 0x000134D6
		public unsafe string fullTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_fullTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_fullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06003A1E RID: 14878 RVA: 0x00117A40 File Offset: 0x00115C40
		// (set) Token: 0x06003A1F RID: 14879 RVA: 0x000152F5 File Offset: 0x000134F5
		public unsafe string assemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_assemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_assemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06003A20 RID: 14880 RVA: 0x00117A68 File Offset: 0x00115C68
		// (set) Token: 0x06003A21 RID: 14881 RVA: 0x00015314 File Offset: 0x00013514
		public unsafe bool hasTypeForwardedFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_hasTypeForwardedFrom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_hasTypeForwardedFrom)) = value;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06003A22 RID: 14882 RVA: 0x00117A90 File Offset: 0x00115C90
		// (set) Token: 0x06003A23 RID: 14883 RVA: 0x0001532F File Offset: 0x0001352F
		public unsafe Il2CppReferenceArray<MemberInfo> memberInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06003A24 RID: 14884 RVA: 0x00117AC0 File Offset: 0x00115CC0
		// (set) Token: 0x06003A25 RID: 14885 RVA: 0x0001534E File Offset: 0x0001354E
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06003A26 RID: 14886 RVA: 0x00117AF0 File Offset: 0x00115CF0
		// (set) Token: 0x06003A27 RID: 14887 RVA: 0x0001536D File Offset: 0x0001356D
		public unsafe Il2CppReferenceArray<Type> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoCache.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030C6 RID: 12486
		private static readonly IntPtr NativeFieldInfoPtr_fullTypeName;

		// Token: 0x040030C7 RID: 12487
		private static readonly IntPtr NativeFieldInfoPtr_assemblyString;

		// Token: 0x040030C8 RID: 12488
		private static readonly IntPtr NativeFieldInfoPtr_hasTypeForwardedFrom;

		// Token: 0x040030C9 RID: 12489
		private static readonly IntPtr NativeFieldInfoPtr_memberInfos;

		// Token: 0x040030CA RID: 12490
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x040030CB RID: 12491
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x040030CC RID: 12492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0;

		// Token: 0x040030CD RID: 12493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;
	}
}
