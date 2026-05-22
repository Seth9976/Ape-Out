using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000303 RID: 771
	public class SHA256 : HashAlgorithm
	{
		// Token: 0x06003349 RID: 13129 RVA: 0x000FF324 File Offset: 0x000FD524
		// Note: this type is marked as 'beforefieldinit'.
		static SHA256()
		{
			Il2CppClassPointerStore<SHA256>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA256");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA256>.NativeClassPtr);
			SHA256.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256>.NativeClassPtr, 100671341);
			SHA256.NativeMethodInfoPtr_Create_Public_Static_SHA256_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256>.NativeClassPtr, 100671342);
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x000FF37C File Offset: 0x000FD57C
		[CallerCount(0)]
		public unsafe SHA256()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA256>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x000FF3B8 File Offset: 0x000FD5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211427, XrefRangeEnd = 211431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SHA256 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256.NativeMethodInfoPtr_Create_Public_Static_SHA256_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SHA256>(intPtr3) : null;
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x000120B6 File Offset: 0x000102B6
		public SHA256(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002BBA RID: 11194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002BBB RID: 11195
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA256_0;
	}
}
