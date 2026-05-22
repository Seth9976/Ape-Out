using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000061 RID: 97
	public class kSxyOZmmwwWWvbNbQDBfHzTOMgP : ZcXVgQcPnAsgxXoELmnIFHlJIzV<MaEgfvevdVIfQCtrIJMLQCQzDLz, EasRdIRBXAqiQabQurBpwEyKSgi, TxHnvbmwTppikNfVuKSVxRIpqoB>
	{
		// Token: 0x0600082E RID: 2094 RVA: 0x000059CC File Offset: 0x00003BCC
		// Note: this type is marked as 'beforefieldinit'.
		static kSxyOZmmwwWWvbNbQDBfHzTOMgP()
		{
			Il2CppClassPointerStore<kSxyOZmmwwWWvbNbQDBfHzTOMgP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "kSxyOZmmwwWWvbNbQDBfHzTOMgP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<kSxyOZmmwwWWvbNbQDBfHzTOMgP>.NativeClassPtr);
			kSxyOZmmwwWWvbNbQDBfHzTOMgP.NativeMethodInfoPtr__ctor_Public_Void_lYzRVWAYwwjqOQjIKypoKfLheCI_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<kSxyOZmmwwWWvbNbQDBfHzTOMgP>.NativeClassPtr, 100664722);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00027DF4 File Offset: 0x00025FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358861, RefRangeEnd = 358862, XrefRangeStart = 358855, XrefRangeEnd = 358861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe kSxyOZmmwwWWvbNbQDBfHzTOMgP(lYzRVWAYwwjqOQjIKypoKfLheCI directInput, Guid deviceGuid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<kSxyOZmmwwWWvbNbQDBfHzTOMgP>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(directInput);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(kSxyOZmmwwWWvbNbQDBfHzTOMgP.NativeMethodInfoPtr__ctor_Public_Void_lYzRVWAYwwjqOQjIKypoKfLheCI_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00005A05 File Offset: 0x00003C05
		public kSxyOZmmwwWWvbNbQDBfHzTOMgP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_lYzRVWAYwwjqOQjIKypoKfLheCI_Guid_0;
	}
}
