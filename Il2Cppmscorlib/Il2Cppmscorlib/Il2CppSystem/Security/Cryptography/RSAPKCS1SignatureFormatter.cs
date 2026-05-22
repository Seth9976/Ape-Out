using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200031B RID: 795
	public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
	{
		// Token: 0x060034A4 RID: 13476 RVA: 0x000129A7 File Offset: 0x00010BA7
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SignatureFormatter()
		{
			Il2CppClassPointerStore<RSAPKCS1SignatureFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SignatureFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SignatureFormatter>.NativeClassPtr);
			RSAPKCS1SignatureFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SignatureFormatter>.NativeClassPtr, 100671513);
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x001040E4 File Offset: 0x001022E4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SignatureFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SignatureFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SignatureFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x000129E0 File Offset: 0x00010BE0
		public RSAPKCS1SignatureFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002CA1 RID: 11425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
