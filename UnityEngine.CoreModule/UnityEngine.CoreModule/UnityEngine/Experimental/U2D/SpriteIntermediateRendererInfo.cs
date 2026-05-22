using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.U2D
{
	// Token: 0x02000192 RID: 402
	[StructLayout(2)]
	public struct SpriteIntermediateRendererInfo
	{
		// Token: 0x06001EC6 RID: 7878 RVA: 0x00071244 File Offset: 0x0006F444
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteIntermediateRendererInfo()
		{
			Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.U2D", "SpriteIntermediateRendererInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr);
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SpriteID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SpriteID");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_TextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "TextureID");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_MaterialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "MaterialID");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Color");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Transform");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Bounds");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Layer");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SortingLayer");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SortingOrder");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SceneCullingMask");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_IndexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "IndexData");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_VertexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "VertexData");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "IndexCount");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_VertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "VertexCount");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_ShaderChannelMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "ShaderChannelMask");
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x0001009C File Offset: 0x0000E29C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeFieldInfoPtr_SpriteID;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeFieldInfoPtr_TextureID;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeFieldInfoPtr_MaterialID;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeFieldInfoPtr_Transform;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeFieldInfoPtr_Bounds;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeFieldInfoPtr_Layer;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeFieldInfoPtr_SortingLayer;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeFieldInfoPtr_SortingOrder;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeFieldInfoPtr_SceneCullingMask;

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeFieldInfoPtr_IndexData;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeFieldInfoPtr_VertexData;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeFieldInfoPtr_IndexCount;

		// Token: 0x040017A1 RID: 6049
		private static readonly IntPtr NativeFieldInfoPtr_VertexCount;

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeFieldInfoPtr_ShaderChannelMask;

		// Token: 0x040017A3 RID: 6051
		[FieldOffset(0)]
		public int SpriteID;

		// Token: 0x040017A4 RID: 6052
		[FieldOffset(4)]
		public int TextureID;

		// Token: 0x040017A5 RID: 6053
		[FieldOffset(8)]
		public int MaterialID;

		// Token: 0x040017A6 RID: 6054
		[FieldOffset(12)]
		public Color Color;

		// Token: 0x040017A7 RID: 6055
		[FieldOffset(28)]
		public Matrix4x4 Transform;

		// Token: 0x040017A8 RID: 6056
		[FieldOffset(92)]
		public Bounds Bounds;

		// Token: 0x040017A9 RID: 6057
		[FieldOffset(116)]
		public int Layer;

		// Token: 0x040017AA RID: 6058
		[FieldOffset(120)]
		public int SortingLayer;

		// Token: 0x040017AB RID: 6059
		[FieldOffset(124)]
		public int SortingOrder;

		// Token: 0x040017AC RID: 6060
		[FieldOffset(128)]
		public ulong SceneCullingMask;

		// Token: 0x040017AD RID: 6061
		[FieldOffset(136)]
		public IntPtr IndexData;

		// Token: 0x040017AE RID: 6062
		[FieldOffset(144)]
		public IntPtr VertexData;

		// Token: 0x040017AF RID: 6063
		[FieldOffset(152)]
		public int IndexCount;

		// Token: 0x040017B0 RID: 6064
		[FieldOffset(156)]
		public int VertexCount;

		// Token: 0x040017B1 RID: 6065
		[FieldOffset(160)]
		public int ShaderChannelMask;
	}
}
