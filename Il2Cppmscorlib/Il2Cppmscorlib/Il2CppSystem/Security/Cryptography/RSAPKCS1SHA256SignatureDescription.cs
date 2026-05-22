using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200030C RID: 780
	public class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x060033C0 RID: 13248 RVA: 0x00012379 File Offset: 0x00010579
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SHA256SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA256SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr);
			RSAPKCS1SHA256SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr, 100671405);
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00100F1C File Offset: 0x000FF11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211853, XrefRangeEnd = 211858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SHA256SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SHA256SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x000123B2 File Offset: 0x000105B2
		public RSAPKCS1SHA256SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C0B RID: 11275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
