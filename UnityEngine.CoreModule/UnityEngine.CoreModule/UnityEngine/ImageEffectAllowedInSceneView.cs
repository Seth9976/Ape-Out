using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200006A RID: 106
	public sealed class ImageEffectAllowedInSceneView : Attribute
	{
		// Token: 0x0600078A RID: 1930 RVA: 0x00005E01 File Offset: 0x00004001
		// Note: this type is marked as 'beforefieldinit'.
		static ImageEffectAllowedInSceneView()
		{
			Il2CppClassPointerStore<ImageEffectAllowedInSceneView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ImageEffectAllowedInSceneView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageEffectAllowedInSceneView>.NativeClassPtr);
			ImageEffectAllowedInSceneView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageEffectAllowedInSceneView>.NativeClassPtr, 100663834);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00027DEC File Offset: 0x00025FEC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageEffectAllowedInSceneView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageEffectAllowedInSceneView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageEffectAllowedInSceneView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00005E3A File Offset: 0x0000403A
		public ImageEffectAllowedInSceneView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
