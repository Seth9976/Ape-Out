using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200030D RID: 781
	public class RSAPKCS1SHA384SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x060033C3 RID: 13251 RVA: 0x000123BB File Offset: 0x000105BB
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SHA384SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SHA384SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA384SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA384SignatureDescription>.NativeClassPtr);
			RSAPKCS1SHA384SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA384SignatureDescription>.NativeClassPtr, 100671406);
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00100F58 File Offset: 0x000FF158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211858, XrefRangeEnd = 211863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SHA384SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA384SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SHA384SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x000123F4 File Offset: 0x000105F4
		public RSAPKCS1SHA384SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C0C RID: 11276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
