using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst.Intrinsics
{
	// Token: 0x0200000D RID: 13
	public static class Common : Object
	{
		// Token: 0x0600005C RID: 92 RVA: 0x000022BB File Offset: 0x000004BB
		// Note: this type is marked as 'beforefieldinit'.
		static Common()
		{
			Il2CppClassPointerStore<Common>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.Intrinsics", "Common");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Common>.NativeClassPtr);
			Common.NativeMethodInfoPtr_umul128_Public_Static_UInt64_UInt64_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Common>.NativeClassPtr, 100663355);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003834 File Offset: 0x00001A34
		[CallerCount(0)]
		public unsafe static ulong umul128(ulong x, ulong y, out ulong high)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &high;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Common.NativeMethodInfoPtr_umul128_Public_Static_UInt64_UInt64_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000022F4 File Offset: 0x000004F4
		public Common(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_umul128_Public_Static_UInt64_UInt64_UInt64_byref_UInt64_0;
	}
}
