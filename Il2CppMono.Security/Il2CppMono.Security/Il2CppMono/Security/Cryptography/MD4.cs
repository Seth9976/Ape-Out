using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002C RID: 44
	public class MD4 : HashAlgorithm
	{
		// Token: 0x06000234 RID: 564 RVA: 0x0000BC48 File Offset: 0x00009E48
		// Note: this type is marked as 'beforefieldinit'.
		static MD4()
		{
			Il2CppClassPointerStore<MD4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "MD4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD4>.NativeClassPtr);
			MD4.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4>.NativeClassPtr, 100663588);
			MD4.NativeMethodInfoPtr_Create_Public_Static_MD4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4>.NativeClassPtr, 100663589);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[CallerCount(0)]
		public unsafe MD4()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD4>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000BCDC File Offset: 0x00009EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129827, XrefRangeEnd = 129831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD4 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4.NativeMethodInfoPtr_Create_Public_Static_MD4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD4>(intPtr3) : null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002F6B File Offset: 0x0000116B
		public MD4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD4_0;
	}
}
