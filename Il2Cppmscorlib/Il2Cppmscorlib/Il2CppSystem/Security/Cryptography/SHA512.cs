using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000307 RID: 775
	public class SHA512 : HashAlgorithm
	{
		// Token: 0x06003389 RID: 13193 RVA: 0x0010032C File Offset: 0x000FE52C
		// Note: this type is marked as 'beforefieldinit'.
		static SHA512()
		{
			Il2CppClassPointerStore<SHA512>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA512");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA512>.NativeClassPtr);
			SHA512.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512>.NativeClassPtr, 100671379);
			SHA512.NativeMethodInfoPtr_Create_Public_Static_SHA512_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512>.NativeClassPtr, 100671380);
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x00100384 File Offset: 0x000FE584
		[CallerCount(0)]
		public unsafe SHA512()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA512>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x001003C0 File Offset: 0x000FE5C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211705, RefRangeEnd = 211707, XrefRangeStart = 211701, XrefRangeEnd = 211705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SHA512 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512.NativeMethodInfoPtr_Create_Public_Static_SHA512_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SHA512>(intPtr3) : null;
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x000121EE File Offset: 0x000103EE
		public SHA512(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002BE8 RID: 11240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002BE9 RID: 11241
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA512_0;
	}
}
