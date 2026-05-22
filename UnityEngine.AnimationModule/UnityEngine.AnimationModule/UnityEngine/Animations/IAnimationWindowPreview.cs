using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000019 RID: 25
	public class IAnimationWindowPreview : Il2CppObjectBase
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x00003B32 File Offset: 0x00001D32
		// Note: this type is marked as 'beforefieldinit'.
		static IAnimationWindowPreview()
		{
			Il2CppClassPointerStore<IAnimationWindowPreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "IAnimationWindowPreview");
			IAnimationWindowPreview.NativeMethodInfoPtr_UpdatePreviewGraph_Public_Abstract_Virtual_New_Void_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationWindowPreview>.NativeClassPtr, 100663373);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000A754 File Offset: 0x00008954
		[CallerCount(0)]
		public unsafe virtual void UpdatePreviewGraph(PlayableGraph graph)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAnimationWindowPreview.NativeMethodInfoPtr_UpdatePreviewGraph_Public_Abstract_Virtual_New_Void_PlayableGraph_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00003B61 File Offset: 0x00001D61
		public IAnimationWindowPreview(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePreviewGraph_Public_Abstract_Virtual_New_Void_PlayableGraph_0;
	}
}
