using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000133 RID: 307
	public sealed class MatchMakingKeyValuePair_t : ValueType
	{
		// Token: 0x06000A2A RID: 2602 RVA: 0x0003083C File Offset: 0x0002EA3C
		// Note: this type is marked as 'beforefieldinit'.
		static MatchMakingKeyValuePair_t()
		{
			Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MatchMakingKeyValuePair_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr);
			MatchMakingKeyValuePair_t.NativeFieldInfoPtr_m_szKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr, "m_szKey");
			MatchMakingKeyValuePair_t.NativeFieldInfoPtr_m_szValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr, "m_szValue");
			MatchMakingKeyValuePair_t.NativeMethodInfoPtr__ctor_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr, 100664304);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000308A8 File Offset: 0x0002EAA8
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 5426, RefRangeEnd = 5459, XrefRangeStart = 5426, XrefRangeEnd = 5426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchMakingKeyValuePair_t(string strKey, string strValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchMakingKeyValuePair_t.NativeMethodInfoPtr__ctor_Private_Void_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00006424 File Offset: 0x00004624
		public MatchMakingKeyValuePair_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0000642D File Offset: 0x0000462D
		public MatchMakingKeyValuePair_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0003090C File Offset: 0x0002EB0C
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0000643F File Offset: 0x0000463F
		public unsafe string m_szKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchMakingKeyValuePair_t.NativeFieldInfoPtr_m_szKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchMakingKeyValuePair_t.NativeFieldInfoPtr_m_szKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00030934 File Offset: 0x0002EB34
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x0000645E File Offset: 0x0000465E
		public unsafe string m_szValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchMakingKeyValuePair_t.NativeFieldInfoPtr_m_szValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchMakingKeyValuePair_t.NativeFieldInfoPtr_m_szValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeFieldInfoPtr_m_szKey;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeFieldInfoPtr_m_szValue;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_String_0;
	}
}
