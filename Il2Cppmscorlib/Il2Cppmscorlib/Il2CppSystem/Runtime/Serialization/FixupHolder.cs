using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000336 RID: 822
	[Serializable]
	public class FixupHolder : Object
	{
		// Token: 0x0600361E RID: 13854 RVA: 0x0010A260 File Offset: 0x00108460
		// Note: this type is marked as 'beforefieldinit'.
		static FixupHolder()
		{
			Il2CppClassPointerStore<FixupHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FixupHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr);
			FixupHolder.NativeFieldInfoPtr_m_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, "m_id");
			FixupHolder.NativeFieldInfoPtr_m_fixupInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, "m_fixupInfo");
			FixupHolder.NativeFieldInfoPtr_m_fixupType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, "m_fixupType");
			FixupHolder.NativeMethodInfoPtr__ctor_Internal_Void_Int64_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, 100671730);
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x0010A2E0 File Offset: 0x001084E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214239, RefRangeEnd = 214242, XrefRangeStart = 214239, XrefRangeEnd = 214239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixupHolder(long id, Object fixupInfo, int fixupType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fixupInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixupType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixupHolder.NativeMethodInfoPtr__ctor_Internal_Void_Int64_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x0001321D File Offset: 0x0001141D
		public FixupHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06003621 RID: 13857 RVA: 0x0010A348 File Offset: 0x00108548
		// (set) Token: 0x06003622 RID: 13858 RVA: 0x00013226 File Offset: 0x00011426
		public unsafe long m_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_id)) = value;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06003623 RID: 13859 RVA: 0x0010A370 File Offset: 0x00108570
		// (set) Token: 0x06003624 RID: 13860 RVA: 0x00013241 File Offset: 0x00011441
		public unsafe Object m_fixupInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_fixupInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_fixupInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x0010A3A0 File Offset: 0x001085A0
		// (set) Token: 0x06003626 RID: 13862 RVA: 0x00013260 File Offset: 0x00011460
		public unsafe int m_fixupType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_fixupType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_fixupType)) = value;
			}
		}

		// Token: 0x04002DC1 RID: 11713
		private static readonly IntPtr NativeFieldInfoPtr_m_id;

		// Token: 0x04002DC2 RID: 11714
		private static readonly IntPtr NativeFieldInfoPtr_m_fixupInfo;

		// Token: 0x04002DC3 RID: 11715
		private static readonly IntPtr NativeFieldInfoPtr_m_fixupType;

		// Token: 0x04002DC4 RID: 11716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int64_Object_Int32_0;
	}
}
