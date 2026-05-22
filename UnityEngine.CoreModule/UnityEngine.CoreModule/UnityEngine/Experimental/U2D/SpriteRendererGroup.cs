using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Experimental.U2D
{
	// Token: 0x02000193 RID: 403
	public class SpriteRendererGroup : Object
	{
		// Token: 0x06001EC8 RID: 7880 RVA: 0x000713A0 File Offset: 0x0006F5A0
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteRendererGroup()
		{
			Il2CppClassPointerStore<SpriteRendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.U2D", "SpriteRendererGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRendererGroup>.NativeClassPtr);
			SpriteRendererGroup.AddRenderersDelegateField = IL2CPP.ResolveICall<SpriteRendererGroup.AddRenderersDelegate>("UnityEngine.Experimental.U2D.SpriteRendererGroup::AddRenderers");
			SpriteRendererGroup.ClearDelegateField = IL2CPP.ResolveICall<SpriteRendererGroup.ClearDelegate>("UnityEngine.Experimental.U2D.SpriteRendererGroup::Clear");
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x000100AE File Offset: 0x0000E2AE
		public SpriteRendererGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x000100B7 File Offset: 0x0000E2B7
		public static void AddRenderers(Unity.Collections.NativeArray<SpriteIntermediateRendererInfo> renderers)
		{
			SpriteRendererGroup.AddRenderers(renderers.GetUnsafeReadOnlyPtr<SpriteIntermediateRendererInfo>(), renderers.Length);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x000100CF File Offset: 0x0000E2CF
		public unsafe static void AddRenderers(void* renderers, int count)
		{
			SpriteRendererGroup.AddRenderersDelegateField(renderers, count);
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x000100DD File Offset: 0x0000E2DD
		public static void Clear()
		{
			SpriteRendererGroup.ClearDelegateField();
		}

		// Token: 0x040017B2 RID: 6066
		private static readonly SpriteRendererGroup.AddRenderersDelegate AddRenderersDelegateField;

		// Token: 0x040017B3 RID: 6067
		private static readonly SpriteRendererGroup.ClearDelegate ClearDelegateField;

		// Token: 0x02000A43 RID: 2627
		// (Invoke) Token: 0x060032FD RID: 13053
		private delegate void AddRenderersDelegate(IntPtr renderers, int count);

		// Token: 0x02000A44 RID: 2628
		// (Invoke) Token: 0x060032FF RID: 13055
		private delegate void ClearDelegate();
	}
}
