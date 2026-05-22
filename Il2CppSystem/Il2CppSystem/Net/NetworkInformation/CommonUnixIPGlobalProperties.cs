using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000164 RID: 356
	public class CommonUnixIPGlobalProperties : IPGlobalProperties
	{
		// Token: 0x0600168D RID: 5773 RVA: 0x00065B40 File Offset: 0x00063D40
		// Note: this type is marked as 'beforefieldinit'.
		static CommonUnixIPGlobalProperties()
		{
			Il2CppClassPointerStore<CommonUnixIPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "CommonUnixIPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonUnixIPGlobalProperties>.NativeClassPtr);
			CommonUnixIPGlobalProperties.NativeMethodInfoPtr_getdomainname_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonUnixIPGlobalProperties>.NativeClassPtr, 100666502);
			CommonUnixIPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonUnixIPGlobalProperties>.NativeClassPtr, 100666503);
			CommonUnixIPGlobalProperties.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonUnixIPGlobalProperties>.NativeClassPtr, 100666504);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00065BAC File Offset: 0x00063DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388564, XrefRangeEnd = 388566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int getdomainname(Il2CppStructArray<byte> name, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonUnixIPGlobalProperties.NativeMethodInfoPtr_getdomainname_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x00065BFC File Offset: 0x00063DFC
		public unsafe override string DomainName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388566, XrefRangeEnd = 388574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommonUnixIPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00065C40 File Offset: 0x00063E40
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommonUnixIPGlobalProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommonUnixIPGlobalProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonUnixIPGlobalProperties.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x0000B2E0 File Offset: 0x000094E0
		public CommonUnixIPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr_getdomainname_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
