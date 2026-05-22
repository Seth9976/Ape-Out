using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F4 RID: 756
	public class MD5 : HashAlgorithm
	{
		// Token: 0x06003266 RID: 12902 RVA: 0x000FC158 File Offset: 0x000FA358
		// Note: this type is marked as 'beforefieldinit'.
		static MD5()
		{
			Il2CppClassPointerStore<MD5>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "MD5");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD5>.NativeClassPtr);
			MD5.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5>.NativeClassPtr, 100671247);
			MD5.NativeMethodInfoPtr_Create_Public_Static_MD5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5>.NativeClassPtr, 100671248);
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x000FC1B0 File Offset: 0x000FA3B0
		[CallerCount(0)]
		public unsafe MD5()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD5>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x000FC1EC File Offset: 0x000FA3EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210345, RefRangeEnd = 210346, XrefRangeStart = 210341, XrefRangeEnd = 210345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD5 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5.NativeMethodInfoPtr_Create_Public_Static_MD5_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD5>(intPtr3) : null;
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x00011A84 File Offset: 0x0000FC84
		public MD5(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B27 RID: 11047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002B28 RID: 11048
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD5_0;
	}
}
