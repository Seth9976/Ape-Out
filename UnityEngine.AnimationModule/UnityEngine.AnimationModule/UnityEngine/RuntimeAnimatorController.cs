using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	public class RuntimeAnimatorController : Object
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x0000A5A0 File Offset: 0x000087A0
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeAnimatorController()
		{
			Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "RuntimeAnimatorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr);
			RuntimeAnimatorController.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr, 100663370);
			RuntimeAnimatorController.get_animationClipsDelegateField = IL2CPP.ResolveICall<RuntimeAnimatorController.get_animationClipsDelegate>("UnityEngine.RuntimeAnimatorController::get_animationClips");
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000A5F4 File Offset: 0x000087F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483949, XrefRangeEnd = 483952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeAnimatorController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAnimatorController.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00003B20 File Offset: 0x00001D20
		public RuntimeAnimatorController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000A630 File Offset: 0x00008830
		public Il2CppReferenceArray<AnimationClip> animationClips
		{
			get
			{
				IntPtr intPtr = RuntimeAnimatorController.get_animationClipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationClip>>(intPtr2) : null;
			}
		}

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040001A0 RID: 416
		private static readonly RuntimeAnimatorController.get_animationClipsDelegate get_animationClipsDelegateField;

		// Token: 0x02000153 RID: 339
		// (Invoke) Token: 0x0600079D RID: 1949
		private delegate IntPtr get_animationClipsDelegate(IntPtr @this);
	}
}
