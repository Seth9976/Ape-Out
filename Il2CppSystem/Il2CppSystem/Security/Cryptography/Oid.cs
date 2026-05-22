using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020000A3 RID: 163
	public sealed class Oid : Object
	{
		// Token: 0x0600093D RID: 2365 RVA: 0x00032AC8 File Offset: 0x00030CC8
		// Note: this type is marked as 'beforefieldinit'.
		static Oid()
		{
			Il2CppClassPointerStore<Oid>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "Oid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Oid>.NativeClassPtr);
			Oid.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Oid>.NativeClassPtr, "m_value");
			Oid.NativeFieldInfoPtr_m_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Oid>.NativeClassPtr, "m_friendlyName");
			Oid.NativeFieldInfoPtr_m_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Oid>.NativeClassPtr, "m_group");
			Oid.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664595);
			Oid.NativeMethodInfoPtr__ctor_Internal_Void_String_OidGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664596);
			Oid.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664597);
			Oid.NativeMethodInfoPtr__ctor_Public_Void_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664598);
			Oid.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664599);
			Oid.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664600);
			Oid.NativeMethodInfoPtr_get_FriendlyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100664601);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00032BC0 File Offset: 0x00030DC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373144, RefRangeEnd = 373147, XrefRangeStart = 373143, XrefRangeEnd = 373144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid(string oid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00032C0C File Offset: 0x00030E0C
		[CallerCount(0)]
		public unsafe Oid(string oid, OidGroup group, bool lookupFriendlyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref group;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookupFriendlyName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Internal_Void_String_OidGroup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00032C74 File Offset: 0x00030E74
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid(string value, string friendlyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00032CD4 File Offset: 0x00030ED4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 373147, RefRangeEnd = 373154, XrefRangeStart = 373147, XrefRangeEnd = 373147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid(Oid oid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Public_Void_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00032D20 File Offset: 0x00030F20
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00032D58 File Offset: 0x00030F58
		public unsafe string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00032D9C File Offset: 0x00030F9C
		public unsafe string FriendlyName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 373159, RefRangeEnd = 373161, XrefRangeStart = 373154, XrefRangeEnd = 373159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr_get_FriendlyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00005C53 File Offset: 0x00003E53
		public Oid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00032DD4 File Offset: 0x00030FD4
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00005C5C File Offset: 0x00003E5C
		public unsafe string m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr_m_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr_m_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00032DFC File Offset: 0x00030FFC
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x00005C7B File Offset: 0x00003E7B
		public unsafe string m_friendlyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr_m_friendlyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr_m_friendlyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00032E24 File Offset: 0x00031024
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x00005C9A File Offset: 0x00003E9A
		public unsafe OidGroup m_group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr_m_group);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr_m_group)) = value;
			}
		}

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr_m_friendlyName;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr_m_group;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_OidGroup_Boolean_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Oid_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_get_FriendlyName_Public_get_String_0;
	}
}
