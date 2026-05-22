using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000F8 RID: 248
	public class LowerResBlitTexture : Object
	{
		// Token: 0x0600148C RID: 5260 RVA: 0x0000B876 File Offset: 0x00009A76
		// Note: this type is marked as 'beforefieldinit'.
		static LowerResBlitTexture()
		{
			Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LowerResBlitTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr);
			LowerResBlitTexture.NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr, 100665086);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x000521D0 File Offset: 0x000503D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LowerResBlitTextureDontStripMe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowerResBlitTexture.NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0000B8AF File Offset: 0x00009AAF
		public LowerResBlitTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0;
	}
}
