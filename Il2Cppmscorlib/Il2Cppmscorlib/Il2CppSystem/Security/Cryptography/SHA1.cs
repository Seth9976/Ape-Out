using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000301 RID: 769
	public class SHA1 : HashAlgorithm
	{
		// Token: 0x06003332 RID: 13106 RVA: 0x000FEDEC File Offset: 0x000FCFEC
		// Note: this type is marked as 'beforefieldinit'.
		static SHA1()
		{
			Il2CppClassPointerStore<SHA1>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA1>.NativeClassPtr);
			SHA1.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1>.NativeClassPtr, 100671330);
			SHA1.NativeMethodInfoPtr_Create_Public_Static_SHA1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1>.NativeClassPtr, 100671331);
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x000FEE44 File Offset: 0x000FD044
		[CallerCount(0)]
		public unsafe SHA1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x000FEE80 File Offset: 0x000FD080
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211372, RefRangeEnd = 211375, XrefRangeStart = 211368, XrefRangeEnd = 211372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SHA1 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1.NativeMethodInfoPtr_Create_Public_Static_SHA1_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SHA1>(intPtr3) : null;
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x0001202C File Offset: 0x0001022C
		public SHA1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002BAB RID: 11179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002BAC RID: 11180
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA1_0;
	}
}
