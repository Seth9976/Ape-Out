using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000C1 RID: 193
	public sealed class X509ChainStatus : ValueType
	{
		// Token: 0x06000A87 RID: 2695 RVA: 0x000376F4 File Offset: 0x000358F4
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainStatus()
		{
			Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr);
			X509ChainStatus.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, "status");
			X509ChainStatus.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, "info");
			X509ChainStatus.NativeMethodInfoPtr__ctor_Internal_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100664766);
			X509ChainStatus.NativeMethodInfoPtr_GetInformation_Internal_Static_String_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100664767);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00037774 File Offset: 0x00035974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374503, RefRangeEnd = 374504, XrefRangeStart = 374499, XrefRangeEnd = 374503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainStatus(X509ChainStatusFlags flag)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainStatus.NativeMethodInfoPtr__ctor_Internal_Void_X509ChainStatusFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000377C0 File Offset: 0x000359C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374504, XrefRangeEnd = 374508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetInformation(X509ChainStatusFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainStatus.NativeMethodInfoPtr_GetInformation_Internal_Static_String_X509ChainStatusFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00006462 File Offset: 0x00004662
		public X509ChainStatus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0000646B File Offset: 0x0000466B
		public X509ChainStatus()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr))
		{
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x000377F8 File Offset: 0x000359F8
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x0000647D File Offset: 0x0000467D
		public unsafe X509ChainStatusFlags status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainStatus.NativeFieldInfoPtr_status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainStatus.NativeFieldInfoPtr_status)) = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00037820 File Offset: 0x00035A20
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x00006498 File Offset: 0x00004698
		public unsafe string info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainStatus.NativeFieldInfoPtr_info);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainStatus.NativeFieldInfoPtr_info), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509ChainStatusFlags_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_GetInformation_Internal_Static_String_X509ChainStatusFlags_0;
	}
}
