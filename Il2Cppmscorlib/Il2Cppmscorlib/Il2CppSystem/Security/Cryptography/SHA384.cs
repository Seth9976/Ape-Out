using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000305 RID: 773
	public class SHA384 : HashAlgorithm
	{
		// Token: 0x06003369 RID: 13161 RVA: 0x000FFB28 File Offset: 0x000FDD28
		// Note: this type is marked as 'beforefieldinit'.
		static SHA384()
		{
			Il2CppClassPointerStore<SHA384>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA384");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA384>.NativeClassPtr);
			SHA384.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384>.NativeClassPtr, 100671360);
			SHA384.NativeMethodInfoPtr_Create_Public_Static_SHA384_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384>.NativeClassPtr, 100671361);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x000FFB80 File Offset: 0x000FDD80
		[CallerCount(0)]
		public unsafe SHA384()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA384>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x000FFBBC File Offset: 0x000FDDBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211568, RefRangeEnd = 211570, XrefRangeStart = 211564, XrefRangeEnd = 211568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SHA384 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384.NativeMethodInfoPtr_Create_Public_Static_SHA384_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SHA384>(intPtr3) : null;
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00012152 File Offset: 0x00010352
		public SHA384(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002BD1 RID: 11217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002BD2 RID: 11218
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA384_0;
	}
}
