using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x020000AD RID: 173
	public static class EXJFuhZQnIgikJlcJdXgnXsepAV : Object
	{
		// Token: 0x06000BB3 RID: 2995 RVA: 0x00006E41 File Offset: 0x00005041
		// Note: this type is marked as 'beforefieldinit'.
		static EXJFuhZQnIgikJlcJdXgnXsepAV()
		{
			Il2CppClassPointerStore<EXJFuhZQnIgikJlcJdXgnXsepAV>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "EXJFuhZQnIgikJlcJdXgnXsepAV");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EXJFuhZQnIgikJlcJdXgnXsepAV>.NativeClassPtr);
			EXJFuhZQnIgikJlcJdXgnXsepAV.NativeMethodInfoPtr_kwfsNdJQjmTFVNPvVoSecgamVXr_Public_Static_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EXJFuhZQnIgikJlcJdXgnXsepAV>.NativeClassPtr, 100665086);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x000337D0 File Offset: 0x000319D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 361300, RefRangeEnd = 361302, XrefRangeStart = 361283, XrefRangeEnd = 361300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string kwfsNdJQjmTFVNPvVoSecgamVXr(IntPtr A_0, int A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EXJFuhZQnIgikJlcJdXgnXsepAV.NativeMethodInfoPtr_kwfsNdJQjmTFVNPvVoSecgamVXr_Public_Static_String_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00006E7A File Offset: 0x0000507A
		public EXJFuhZQnIgikJlcJdXgnXsepAV(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_kwfsNdJQjmTFVNPvVoSecgamVXr_Public_Static_String_IntPtr_Int32_0;
	}
}
