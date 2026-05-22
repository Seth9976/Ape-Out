using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002D8 RID: 728
	public class AsymmetricSignatureFormatter : Object
	{
		// Token: 0x06003142 RID: 12610 RVA: 0x0001133A File Offset: 0x0000F53A
		// Note: this type is marked as 'beforefieldinit'.
		static AsymmetricSignatureFormatter()
		{
			Il2CppClassPointerStore<AsymmetricSignatureFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "AsymmetricSignatureFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricSignatureFormatter>.NativeClassPtr);
			AsymmetricSignatureFormatter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricSignatureFormatter>.NativeClassPtr, 100671105);
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x000F7D78 File Offset: 0x000F5F78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricSignatureFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricSignatureFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricSignatureFormatter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x00011373 File Offset: 0x0000F573
		public AsymmetricSignatureFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002A52 RID: 10834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
