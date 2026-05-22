using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A2 RID: 418
	[Serializable]
	public sealed class DefaultMemberAttribute : Attribute
	{
		// Token: 0x06001C00 RID: 7168 RVA: 0x000A28FC File Offset: 0x000A0AFC
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultMemberAttribute()
		{
			Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "DefaultMemberAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr);
			DefaultMemberAttribute.NativeFieldInfoPtr_m_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr, "m_memberName");
			DefaultMemberAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr, 100668040);
			DefaultMemberAttribute.NativeMethodInfoPtr_get_MemberName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr, 100668041);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x000A2968 File Offset: 0x000A0B68
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultMemberAttribute(string memberName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(memberName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultMemberAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x000A29B4 File Offset: 0x000A0BB4
		public unsafe string MemberName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultMemberAttribute.NativeMethodInfoPtr_get_MemberName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00009885 File Offset: 0x00007A85
		public DefaultMemberAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x000A29EC File Offset: 0x000A0BEC
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x0000988E File Offset: 0x00007A8E
		public unsafe string m_memberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultMemberAttribute.NativeFieldInfoPtr_m_memberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultMemberAttribute.NativeFieldInfoPtr_m_memberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeFieldInfoPtr_m_memberName;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberName_Public_get_String_0;
	}
}
