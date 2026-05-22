using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001E0 RID: 480
	public sealed class MonoPropertyInfo : ValueType
	{
		// Token: 0x06001F0F RID: 7951 RVA: 0x000AFD78 File Offset: 0x000ADF78
		// Note: this type is marked as 'beforefieldinit'.
		static MonoPropertyInfo()
		{
			Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoPropertyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr);
			MonoPropertyInfo.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "parent");
			MonoPropertyInfo.NativeFieldInfoPtr_declaring_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "declaring_type");
			MonoPropertyInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "name");
			MonoPropertyInfo.NativeFieldInfoPtr_get_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "get_method");
			MonoPropertyInfo.NativeFieldInfoPtr_set_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "set_method");
			MonoPropertyInfo.NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "attrs");
			MonoPropertyInfo.NativeMethodInfoPtr_get_property_info_Internal_Static_Void_MonoProperty_byref_MonoPropertyInfo_PInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, 100668511);
			MonoPropertyInfo.NativeMethodInfoPtr_GetTypeModifiers_Internal_Static_Il2CppReferenceArray_1_Type_MonoProperty_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, 100668512);
			MonoPropertyInfo.NativeMethodInfoPtr_get_default_value_Internal_Static_Object_MonoProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, 100668513);
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x000AFE5C File Offset: 0x000AE05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188533, XrefRangeEnd = 188534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_property_info(MonoProperty prop, ref MonoPropertyInfo info, PInfo req_info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref req_info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoPropertyInfo.NativeMethodInfoPtr_get_property_info_Internal_Static_Void_MonoProperty_byref_MonoPropertyInfo_PInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x000AFEB8 File Offset: 0x000AE0B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188535, RefRangeEnd = 188537, XrefRangeStart = 188534, XrefRangeEnd = 188535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Type> GetTypeModifiers(MonoProperty prop, bool optional)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optional;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoPropertyInfo.NativeMethodInfoPtr_GetTypeModifiers_Internal_Static_Il2CppReferenceArray_1_Type_MonoProperty_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x000AFF0C File Offset: 0x000AE10C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 131113, RefRangeEnd = 131119, XrefRangeStart = 131113, XrefRangeEnd = 131119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object get_default_value(MonoProperty prop)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoPropertyInfo.NativeMethodInfoPtr_get_default_value_Internal_Static_Object_MonoProperty_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x0000A7F6 File Offset: 0x000089F6
		public MonoPropertyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x0000A7FF File Offset: 0x000089FF
		public MonoPropertyInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x000AFF50 File Offset: 0x000AE150
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x0000A811 File Offset: 0x00008A11
		public unsafe Type parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x000AFF80 File Offset: 0x000AE180
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x0000A830 File Offset: 0x00008A30
		public unsafe Type declaring_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_declaring_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_declaring_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x000AFFB0 File Offset: 0x000AE1B0
		// (set) Token: 0x06001F1A RID: 7962 RVA: 0x0000A84F File Offset: 0x00008A4F
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x000AFFD8 File Offset: 0x000AE1D8
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x0000A86E File Offset: 0x00008A6E
		public unsafe MethodInfo get_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_get_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_get_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x000B0008 File Offset: 0x000AE208
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x0000A88D File Offset: 0x00008A8D
		public unsafe MethodInfo set_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_set_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_set_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x000B0038 File Offset: 0x000AE238
		// (set) Token: 0x06001F20 RID: 7968 RVA: 0x0000A8AC File Offset: 0x00008AAC
		public unsafe PropertyAttributes attrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_attrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_attrs)) = value;
			}
		}

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeFieldInfoPtr_declaring_type;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeFieldInfoPtr_get_method;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeFieldInfoPtr_set_method;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeFieldInfoPtr_attrs;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeMethodInfoPtr_get_property_info_Internal_Static_Void_MonoProperty_byref_MonoPropertyInfo_PInfo_0;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeModifiers_Internal_Static_Il2CppReferenceArray_1_Type_MonoProperty_Boolean_0;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeMethodInfoPtr_get_default_value_Internal_Static_Object_MonoProperty_0;
	}
}
