using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020003A5 RID: 933
	public class WellKnownClientTypeEntry : TypeEntry
	{
		// Token: 0x06003DB8 RID: 15800 RVA: 0x001241E8 File Offset: 0x001223E8
		// Note: this type is marked as 'beforefieldinit'.
		static WellKnownClientTypeEntry()
		{
			Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "WellKnownClientTypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr);
			WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, "obj_type");
			WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, "obj_url");
			WellKnownClientTypeEntry.NativeFieldInfoPtr_app_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, "app_url");
			WellKnownClientTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100672452);
			WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100672453);
			WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100672454);
			WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ObjectUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100672455);
			WellKnownClientTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100672456);
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x001242B8 File Offset: 0x001224B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221377, RefRangeEnd = 221378, XrefRangeStart = 221373, XrefRangeEnd = 221377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectUrl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownClientTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x00124328 File Offset: 0x00122528
		public unsafe string ApplicationUrl
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06003DBB RID: 15803 RVA: 0x00124360 File Offset: 0x00122560
		public unsafe Type ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06003DBC RID: 15804 RVA: 0x001243A0 File Offset: 0x001225A0
		public unsafe string ObjectUrl
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ObjectUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x001243D8 File Offset: 0x001225D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221378, XrefRangeEnd = 221380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WellKnownClientTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x00017034 File Offset: 0x00015234
		public WellKnownClientTypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06003DBF RID: 15807 RVA: 0x0012441C File Offset: 0x0012261C
		// (set) Token: 0x06003DC0 RID: 15808 RVA: 0x0001703D File Offset: 0x0001523D
		public unsafe Type obj_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06003DC1 RID: 15809 RVA: 0x0012444C File Offset: 0x0012264C
		// (set) Token: 0x06003DC2 RID: 15810 RVA: 0x0001705C File Offset: 0x0001525C
		public unsafe string obj_url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06003DC3 RID: 15811 RVA: 0x00124474 File Offset: 0x00122674
		// (set) Token: 0x06003DC4 RID: 15812 RVA: 0x0001707B File Offset: 0x0001527B
		public unsafe string app_url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_app_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_app_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400331E RID: 13086
		private static readonly IntPtr NativeFieldInfoPtr_obj_type;

		// Token: 0x0400331F RID: 13087
		private static readonly IntPtr NativeFieldInfoPtr_obj_url;

		// Token: 0x04003320 RID: 13088
		private static readonly IntPtr NativeFieldInfoPtr_app_url;

		// Token: 0x04003321 RID: 13089
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x04003322 RID: 13090
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0;

		// Token: 0x04003323 RID: 13091
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x04003324 RID: 13092
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectUrl_Public_get_String_0;

		// Token: 0x04003325 RID: 13093
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
