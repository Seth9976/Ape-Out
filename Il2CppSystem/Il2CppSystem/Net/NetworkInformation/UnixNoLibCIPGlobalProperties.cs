using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000166 RID: 358
	public sealed class UnixNoLibCIPGlobalProperties : UnixIPGlobalProperties
	{
		// Token: 0x06001695 RID: 5781 RVA: 0x00065CB8 File Offset: 0x00063EB8
		// Note: this type is marked as 'beforefieldinit'.
		static UnixNoLibCIPGlobalProperties()
		{
			Il2CppClassPointerStore<UnixNoLibCIPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "UnixNoLibCIPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnixNoLibCIPGlobalProperties>.NativeClassPtr);
			UnixNoLibCIPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixNoLibCIPGlobalProperties>.NativeClassPtr, 100666506);
			UnixNoLibCIPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixNoLibCIPGlobalProperties>.NativeClassPtr, 100666507);
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x00065D10 File Offset: 0x00063F10
		public unsafe override string DomainName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388574, XrefRangeEnd = 388576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixNoLibCIPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00065D48 File Offset: 0x00063F48
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnixNoLibCIPGlobalProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnixNoLibCIPGlobalProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixNoLibCIPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0000B32B File Offset: 0x0000952B
		public UnixNoLibCIPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
