using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200030B RID: 779
	public class RSAPKCS1SHA1SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x060033BD RID: 13245 RVA: 0x00012337 File Offset: 0x00010537
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SHA1SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SHA1SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA1SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA1SignatureDescription>.NativeClassPtr);
			RSAPKCS1SHA1SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA1SignatureDescription>.NativeClassPtr, 100671404);
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00100EE0 File Offset: 0x000FF0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211848, XrefRangeEnd = 211853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SHA1SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA1SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SHA1SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00012370 File Offset: 0x00010570
		public RSAPKCS1SHA1SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C0A RID: 11274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
