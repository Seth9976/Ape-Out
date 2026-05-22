using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020000A5 RID: 165
	public sealed class OidEnumerator : Object
	{
		// Token: 0x06000958 RID: 2392 RVA: 0x00033180 File Offset: 0x00031380
		// Note: this type is marked as 'beforefieldinit'.
		static OidEnumerator()
		{
			Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "OidEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr);
			OidEnumerator.NativeFieldInfoPtr_m_oids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, "m_oids");
			OidEnumerator.NativeFieldInfoPtr_m_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, "m_current");
			OidEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_OidCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100664610);
			OidEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100664611);
			OidEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100664612);
			OidEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100664613);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00033228 File Offset: 0x00031428
		[CallerCount(0)]
		public unsafe OidEnumerator(OidCollection oids)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oids);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_OidCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00033274 File Offset: 0x00031474
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373181, XrefRangeEnd = 373183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x000332B4 File Offset: 0x000314B4
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000332F0 File Offset: 0x000314F0
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00005CDD File Offset: 0x00003EDD
		public OidEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00033324 File Offset: 0x00031524
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00005CE6 File Offset: 0x00003EE6
		public unsafe OidCollection m_oids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidEnumerator.NativeFieldInfoPtr_m_oids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidEnumerator.NativeFieldInfoPtr_m_oids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00033354 File Offset: 0x00031554
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x00005D05 File Offset: 0x00003F05
		public unsafe int m_current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidEnumerator.NativeFieldInfoPtr_m_current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidEnumerator.NativeFieldInfoPtr_m_current)) = value;
			}
		}

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr_m_oids;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr_m_current;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_OidCollection_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
