using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x02000111 RID: 273
	[Serializable]
	public class CookieCollection : Object
	{
		// Token: 0x06000F27 RID: 3879 RVA: 0x000494F8 File Offset: 0x000476F8
		// Note: this type is marked as 'beforefieldinit'.
		static CookieCollection()
		{
			Il2CppClassPointerStore<CookieCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr);
			CookieCollection.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_version");
			CookieCollection.NativeFieldInfoPtr_m_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_list");
			CookieCollection.NativeFieldInfoPtr_m_TimeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_TimeStamp");
			CookieCollection.NativeFieldInfoPtr_m_has_other_versions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_has_other_versions");
			CookieCollection.NativeFieldInfoPtr_m_IsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_IsReadOnly");
			CookieCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665469);
			CookieCollection.NativeMethodInfoPtr_get_Item_Public_get_Cookie_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665470);
			CookieCollection.NativeMethodInfoPtr_Add_Public_Void_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665471);
			CookieCollection.NativeMethodInfoPtr_Add_Public_Void_CookieCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665472);
			CookieCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665473);
			CookieCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665474);
			CookieCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665475);
			CookieCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665476);
			CookieCollection.NativeMethodInfoPtr_TimeStamp_Internal_DateTime_Stamp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665477);
			CookieCollection.NativeMethodInfoPtr_get_IsOtherVersionSeen_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665478);
			CookieCollection.NativeMethodInfoPtr_InternalAdd_Internal_Int32_Cookie_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665479);
			CookieCollection.NativeMethodInfoPtr_IndexOf_Internal_Int32_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665480);
			CookieCollection.NativeMethodInfoPtr_RemoveAt_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665481);
			CookieCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665482);
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x000496A4 File Offset: 0x000478A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 378725, RefRangeEnd = 378728, XrefRangeStart = 378717, XrefRangeEnd = 378725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700049A RID: 1178
		public unsafe Cookie this[int index]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 378730, RefRangeEnd = 378733, XrefRangeStart = 378728, XrefRangeEnd = 378730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_Item_Public_get_Cookie_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cookie>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0004972C File Offset: 0x0004792C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378733, XrefRangeEnd = 378741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Cookie cookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_Add_Public_Void_Cookie_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00049770 File Offset: 0x00047970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378760, RefRangeEnd = 378761, XrefRangeStart = 378741, XrefRangeEnd = 378760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(CookieCollection cookies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookies);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_Add_Public_Void_CookieCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x000497B4 File Offset: 0x000479B4
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000497F0 File Offset: 0x000479F0
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x0004982C File Offset: 0x00047A2C
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0004986C File Offset: 0x00047A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378761, XrefRangeEnd = 378762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x000498BC File Offset: 0x00047ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378762, XrefRangeEnd = 378766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime TimeStamp(CookieCollection.Stamp how)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref how;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_TimeStamp_Internal_DateTime_Stamp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00049908 File Offset: 0x00047B08
		public unsafe bool IsOtherVersionSeen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_IsOtherVersionSeen_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00049944 File Offset: 0x00047B44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 378788, RefRangeEnd = 378791, XrefRangeStart = 378766, XrefRangeEnd = 378788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalAdd(Cookie cookie, bool isStrict)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStrict;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_InternalAdd_Internal_Int32_Cookie_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x000499A0 File Offset: 0x00047BA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 378812, RefRangeEnd = 378815, XrefRangeStart = 378791, XrefRangeEnd = 378812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(Cookie cookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_IndexOf_Internal_Int32_Cookie_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x000499F0 File Offset: 0x00047BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378815, XrefRangeEnd = 378816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_RemoveAt_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00049A30 File Offset: 0x00047C30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 378819, RefRangeEnd = 378822, XrefRangeStart = 378816, XrefRangeEnd = 378819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00007F64 File Offset: 0x00006164
		public CookieCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00049A70 File Offset: 0x00047C70
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x00007F6D File Offset: 0x0000616D
		public unsafe int m_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_version)) = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x00049A98 File Offset: 0x00047C98
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x00007F88 File Offset: 0x00006188
		public unsafe ArrayList m_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00049AC8 File Offset: 0x00047CC8
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00007FA7 File Offset: 0x000061A7
		public unsafe DateTime m_TimeStamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_TimeStamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_TimeStamp)) = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00049AF0 File Offset: 0x00047CF0
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00007FC2 File Offset: 0x000061C2
		public unsafe bool m_has_other_versions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_has_other_versions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_has_other_versions)) = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00049B18 File Offset: 0x00047D18
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00007FDD File Offset: 0x000061DD
		public unsafe bool m_IsReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_IsReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_IsReadOnly)) = value;
			}
		}

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeFieldInfoPtr_m_version;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeFieldInfoPtr_m_list;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeStamp;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeFieldInfoPtr_m_has_other_versions;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeFieldInfoPtr_m_IsReadOnly;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Cookie_Int32_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Cookie_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_CookieCollection_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_TimeStamp_Internal_DateTime_Stamp_0;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOtherVersionSeen_Internal_get_Boolean_0;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr_InternalAdd_Internal_Int32_Cookie_Boolean_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Int32_Cookie_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Internal_Void_Int32_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x020001DB RID: 475
		[OriginalName("System.dll", "", "Stamp")]
		public enum Stamp
		{
			// Token: 0x04001491 RID: 5265
			Check,
			// Token: 0x04001492 RID: 5266
			Set,
			// Token: 0x04001493 RID: 5267
			SetToUnused,
			// Token: 0x04001494 RID: 5268
			SetToMaxUsed
		}

		// Token: 0x020001DC RID: 476
		public class CookieCollectionEnumerator : Object
		{
			// Token: 0x06001A2F RID: 6703 RVA: 0x0006FC64 File Offset: 0x0006DE64
			// Note: this type is marked as 'beforefieldinit'.
			static CookieCollectionEnumerator()
			{
				Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "CookieCollectionEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr);
				CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_cookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, "m_cookies");
				CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, "m_count");
				CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, "m_index");
				CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, "m_version");
				CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_CookieCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, 100665483);
				CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, 100665484);
				CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, 100665485);
				CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, 100665486);
			}

			// Token: 0x06001A30 RID: 6704 RVA: 0x0006FD30 File Offset: 0x0006DF30
			[CallerCount(0)]
			public unsafe CookieCollectionEnumerator(CookieCollection cookies)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookies);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_CookieCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000859 RID: 2137
			// (get) Token: 0x06001A31 RID: 6705 RVA: 0x0006FD7C File Offset: 0x0006DF7C
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378701, XrefRangeEnd = 378717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A32 RID: 6706 RVA: 0x0006FDBC File Offset: 0x0006DFBC
			[CallerCount(0)]
			public unsafe virtual bool System_Collections_IEnumerator_MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001A33 RID: 6707 RVA: 0x0006FDF8 File Offset: 0x0006DFF8
			[CallerCount(0)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A34 RID: 6708 RVA: 0x0000D715 File Offset: 0x0000B915
			public CookieCollectionEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000855 RID: 2133
			// (get) Token: 0x06001A35 RID: 6709 RVA: 0x0006FE2C File Offset: 0x0006E02C
			// (set) Token: 0x06001A36 RID: 6710 RVA: 0x0000D71E File Offset: 0x0000B91E
			public unsafe CookieCollection m_cookies
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_cookies);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_cookies), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000856 RID: 2134
			// (get) Token: 0x06001A37 RID: 6711 RVA: 0x0006FE5C File Offset: 0x0006E05C
			// (set) Token: 0x06001A38 RID: 6712 RVA: 0x0000D73D File Offset: 0x0000B93D
			public unsafe int m_count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_count)) = value;
				}
			}

			// Token: 0x17000857 RID: 2135
			// (get) Token: 0x06001A39 RID: 6713 RVA: 0x0006FE84 File Offset: 0x0006E084
			// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0000D758 File Offset: 0x0000B958
			public unsafe int m_index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_index)) = value;
				}
			}

			// Token: 0x17000858 RID: 2136
			// (get) Token: 0x06001A3B RID: 6715 RVA: 0x0006FEAC File Offset: 0x0006E0AC
			// (set) Token: 0x06001A3C RID: 6716 RVA: 0x0000D773 File Offset: 0x0000B973
			public unsafe int m_version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_version)) = value;
				}
			}

			// Token: 0x04001495 RID: 5269
			private static readonly IntPtr NativeFieldInfoPtr_m_cookies;

			// Token: 0x04001496 RID: 5270
			private static readonly IntPtr NativeFieldInfoPtr_m_count;

			// Token: 0x04001497 RID: 5271
			private static readonly IntPtr NativeFieldInfoPtr_m_index;

			// Token: 0x04001498 RID: 5272
			private static readonly IntPtr NativeFieldInfoPtr_m_version;

			// Token: 0x04001499 RID: 5273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CookieCollection_0;

			// Token: 0x0400149A RID: 5274
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400149B RID: 5275
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400149C RID: 5276
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
