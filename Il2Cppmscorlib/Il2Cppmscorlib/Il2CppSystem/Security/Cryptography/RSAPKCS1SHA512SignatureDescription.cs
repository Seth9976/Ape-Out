using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200030E RID: 782
	public class RSAPKCS1SHA512SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x060033C6 RID: 13254 RVA: 0x000123FD File Offset: 0x000105FD
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SHA512SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SHA512SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA512SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA512SignatureDescription>.NativeClassPtr);
			RSAPKCS1SHA512SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA512SignatureDescription>.NativeClassPtr, 100671407);
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x00100F94 File Offset: 0x000FF194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211863, XrefRangeEnd = 211868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SHA512SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA512SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SHA512SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x00012436 File Offset: 0x00010636
		public RSAPKCS1SHA512SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C0D RID: 11277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
