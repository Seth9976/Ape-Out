using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002D7 RID: 727
	public class AsymmetricSignatureDeformatter : Object
	{
		// Token: 0x0600313F RID: 12607 RVA: 0x000112F8 File Offset: 0x0000F4F8
		// Note: this type is marked as 'beforefieldinit'.
		static AsymmetricSignatureDeformatter()
		{
			Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "AsymmetricSignatureDeformatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr);
			AsymmetricSignatureDeformatter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr, 100671104);
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x000F7D3C File Offset: 0x000F5F3C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricSignatureDeformatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricSignatureDeformatter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x00011331 File Offset: 0x0000F531
		public AsymmetricSignatureDeformatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002A51 RID: 10833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
