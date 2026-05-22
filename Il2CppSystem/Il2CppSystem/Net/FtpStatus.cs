using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x0200012C RID: 300
	public class FtpStatus : Object
	{
		// Token: 0x060010DC RID: 4316 RVA: 0x0005019C File Offset: 0x0004E39C
		// Note: this type is marked as 'beforefieldinit'.
		static FtpStatus()
		{
			Il2CppClassPointerStore<FtpStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr);
			FtpStatus.NativeFieldInfoPtr_statusCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr, "statusCode");
			FtpStatus.NativeFieldInfoPtr_statusDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr, "statusDescription");
			FtpStatus.NativeMethodInfoPtr__ctor_Public_Void_FtpStatusCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr, 100665709);
			FtpStatus.NativeMethodInfoPtr_get_StatusCode_Public_get_FtpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr, 100665710);
			FtpStatus.NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr, 100665711);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00050230 File Offset: 0x0004E430
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106068, RefRangeEnd = 106070, XrefRangeStart = 106068, XrefRangeEnd = 106070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpStatus(FtpStatusCode statusCode, string statusDescription)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref statusCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(statusDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpStatus.NativeMethodInfoPtr__ctor_Public_Void_FtpStatusCode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x0005028C File Offset: 0x0004E48C
		public unsafe FtpStatusCode StatusCode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpStatus.NativeMethodInfoPtr_get_StatusCode_Public_get_FtpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x000502C8 File Offset: 0x0004E4C8
		public unsafe string StatusDescription
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpStatus.NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00008A30 File Offset: 0x00006C30
		public FtpStatus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00050300 File Offset: 0x0004E500
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x00008A39 File Offset: 0x00006C39
		public unsafe FtpStatusCode statusCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpStatus.NativeFieldInfoPtr_statusCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpStatus.NativeFieldInfoPtr_statusCode)) = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x00050328 File Offset: 0x0004E528
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x00008A54 File Offset: 0x00006C54
		public unsafe string statusDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpStatus.NativeFieldInfoPtr_statusDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpStatus.NativeFieldInfoPtr_statusDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeFieldInfoPtr_statusCode;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeFieldInfoPtr_statusDescription;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FtpStatusCode_String_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_get_FtpStatusCode_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0;
	}
}
