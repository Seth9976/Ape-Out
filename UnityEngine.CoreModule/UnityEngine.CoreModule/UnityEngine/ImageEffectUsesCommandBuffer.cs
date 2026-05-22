using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200006B RID: 107
	public sealed class ImageEffectUsesCommandBuffer : Attribute
	{
		// Token: 0x0600078D RID: 1933 RVA: 0x00005E43 File Offset: 0x00004043
		// Note: this type is marked as 'beforefieldinit'.
		static ImageEffectUsesCommandBuffer()
		{
			Il2CppClassPointerStore<ImageEffectUsesCommandBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ImageEffectUsesCommandBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageEffectUsesCommandBuffer>.NativeClassPtr);
			ImageEffectUsesCommandBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageEffectUsesCommandBuffer>.NativeClassPtr, 100663835);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00027E28 File Offset: 0x00026028
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageEffectUsesCommandBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageEffectUsesCommandBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageEffectUsesCommandBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00005E7C File Offset: 0x0000407C
		public ImageEffectUsesCommandBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
