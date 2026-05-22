using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200008E RID: 142
	public class MeshRenderer : Renderer
	{
		// Token: 0x06000B08 RID: 2824 RVA: 0x0002F5B0 File Offset: 0x0002D7B0
		// Note: this type is marked as 'beforefieldinit'.
		static MeshRenderer()
		{
			Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MeshRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr);
			MeshRenderer.NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100664024);
			MeshRenderer.get_additionalVertexStreamsDelegateField = IL2CPP.ResolveICall<MeshRenderer.get_additionalVertexStreamsDelegate>("UnityEngine.MeshRenderer::get_additionalVertexStreams");
			MeshRenderer.set_additionalVertexStreamsDelegateField = IL2CPP.ResolveICall<MeshRenderer.set_additionalVertexStreamsDelegate>("UnityEngine.MeshRenderer::set_additionalVertexStreams");
			MeshRenderer.get_enlightenVertexStreamDelegateField = IL2CPP.ResolveICall<MeshRenderer.get_enlightenVertexStreamDelegate>("UnityEngine.MeshRenderer::get_enlightenVertexStream");
			MeshRenderer.set_enlightenVertexStreamDelegateField = IL2CPP.ResolveICall<MeshRenderer.set_enlightenVertexStreamDelegate>("UnityEngine.MeshRenderer::set_enlightenVertexStream");
			MeshRenderer.get_subMeshStartIndexDelegateField = IL2CPP.ResolveICall<MeshRenderer.get_subMeshStartIndexDelegate>("UnityEngine.MeshRenderer::get_subMeshStartIndex");
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0002F640 File Offset: 0x0002D840
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DontStripMeshRenderer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRenderer.NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x000081B3 File Offset: 0x000063B3
		public MeshRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0002F674 File Offset: 0x0002D874
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x000081BC File Offset: 0x000063BC
		public Mesh additionalVertexStreams
		{
			get
			{
				IntPtr intPtr = MeshRenderer.get_additionalVertexStreamsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				MeshRenderer.set_additionalVertexStreamsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0002F6A0 File Offset: 0x0002D8A0
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x000081D4 File Offset: 0x000063D4
		public Mesh enlightenVertexStream
		{
			get
			{
				IntPtr intPtr = MeshRenderer.get_enlightenVertexStreamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				MeshRenderer.set_enlightenVertexStreamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000081EC File Offset: 0x000063EC
		public int subMeshStartIndex
		{
			get
			{
				return MeshRenderer.get_subMeshStartIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0;

		// Token: 0x04000851 RID: 2129
		private static readonly MeshRenderer.get_additionalVertexStreamsDelegate get_additionalVertexStreamsDelegateField;

		// Token: 0x04000852 RID: 2130
		private static readonly MeshRenderer.set_additionalVertexStreamsDelegate set_additionalVertexStreamsDelegateField;

		// Token: 0x04000853 RID: 2131
		private static readonly MeshRenderer.get_enlightenVertexStreamDelegate get_enlightenVertexStreamDelegateField;

		// Token: 0x04000854 RID: 2132
		private static readonly MeshRenderer.set_enlightenVertexStreamDelegate set_enlightenVertexStreamDelegateField;

		// Token: 0x04000855 RID: 2133
		private static readonly MeshRenderer.get_subMeshStartIndexDelegate get_subMeshStartIndexDelegateField;

		// Token: 0x02000657 RID: 1623
		// (Invoke) Token: 0x06002AD8 RID: 10968
		private delegate IntPtr get_additionalVertexStreamsDelegate(IntPtr @this);

		// Token: 0x02000658 RID: 1624
		// (Invoke) Token: 0x06002ADA RID: 10970
		private delegate void set_additionalVertexStreamsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000659 RID: 1625
		// (Invoke) Token: 0x06002ADC RID: 10972
		private delegate IntPtr get_enlightenVertexStreamDelegate(IntPtr @this);

		// Token: 0x0200065A RID: 1626
		// (Invoke) Token: 0x06002ADE RID: 10974
		private delegate void set_enlightenVertexStreamDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200065B RID: 1627
		// (Invoke) Token: 0x06002AE0 RID: 10976
		private delegate int get_subMeshStartIndexDelegate(IntPtr @this);
	}
}
