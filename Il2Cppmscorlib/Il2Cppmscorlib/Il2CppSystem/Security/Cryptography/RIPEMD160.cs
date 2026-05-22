using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002FC RID: 764
	public class RIPEMD160 : HashAlgorithm
	{
		// Token: 0x060032DE RID: 13022 RVA: 0x000FDB78 File Offset: 0x000FBD78
		// Note: this type is marked as 'beforefieldinit'.
		static RIPEMD160()
		{
			Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RIPEMD160");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr);
			RIPEMD160.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr, 100671295);
			RIPEMD160.NativeMethodInfoPtr_Create_Public_Static_RIPEMD160_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr, 100671296);
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x000FDBD0 File Offset: 0x000FBDD0
		[CallerCount(0)]
		public unsafe RIPEMD160()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x000FDC0C File Offset: 0x000FBE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210719, XrefRangeEnd = 210723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RIPEMD160 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160.NativeMethodInfoPtr_Create_Public_Static_RIPEMD160_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RIPEMD160>(intPtr3) : null;
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x00011DC5 File Offset: 0x0000FFC5
		public RIPEMD160(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B75 RID: 11125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002B76 RID: 11126
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RIPEMD160_0;
	}
}
