using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000160 RID: 352
	public class IPGlobalProperties : Object
	{
		// Token: 0x06001680 RID: 5760 RVA: 0x0006586C File Offset: 0x00063A6C
		// Note: this type is marked as 'beforefieldinit'.
		static IPGlobalProperties()
		{
			Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "IPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr);
			IPGlobalProperties.NativeFieldInfoPtr__PlatformNeedsLibCWorkaround_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, "<PlatformNeedsLibCWorkaround>k__BackingField");
			IPGlobalProperties.NativeMethodInfoPtr_get_PlatformNeedsLibCWorkaround_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100666495);
			IPGlobalProperties.NativeMethodInfoPtr_GetIPGlobalProperties_Public_Static_IPGlobalProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100666496);
			IPGlobalProperties.NativeMethodInfoPtr_InternalGetIPGlobalProperties_Internal_Static_IPGlobalProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100666497);
			IPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100666498);
			IPGlobalProperties.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100666499);
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00065914 File Offset: 0x00063B14
		public unsafe static bool PlatformNeedsLibCWorkaround
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388500, XrefRangeEnd = 388502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPGlobalProperties.NativeMethodInfoPtr_get_PlatformNeedsLibCWorkaround_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00065944 File Offset: 0x00063B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388502, XrefRangeEnd = 388518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPGlobalProperties GetIPGlobalProperties()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPGlobalProperties.NativeMethodInfoPtr_GetIPGlobalProperties_Public_Static_IPGlobalProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPGlobalProperties>(intPtr3) : null;
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00065978 File Offset: 0x00063B78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388543, RefRangeEnd = 388545, XrefRangeStart = 388518, XrefRangeEnd = 388543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPGlobalProperties InternalGetIPGlobalProperties()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPGlobalProperties.NativeMethodInfoPtr_InternalGetIPGlobalProperties_Internal_Static_IPGlobalProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPGlobalProperties>(intPtr3) : null;
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x000659AC File Offset: 0x00063BAC
		public unsafe virtual string DomainName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x000659F0 File Offset: 0x00063BF0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPGlobalProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPGlobalProperties.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x0000B2C0 File Offset: 0x000094C0
		public IPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x00065A2C File Offset: 0x00063C2C
		// (set) Token: 0x06001688 RID: 5768 RVA: 0x0000B2C9 File Offset: 0x000094C9
		public unsafe static bool _PlatformNeedsLibCWorkaround_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(IPGlobalProperties.NativeFieldInfoPtr__PlatformNeedsLibCWorkaround_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPGlobalProperties.NativeFieldInfoPtr__PlatformNeedsLibCWorkaround_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeFieldInfoPtr__PlatformNeedsLibCWorkaround_k__BackingField;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformNeedsLibCWorkaround_Private_Static_get_Boolean_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_GetIPGlobalProperties_Public_Static_IPGlobalProperties_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetIPGlobalProperties_Internal_Static_IPGlobalProperties_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
