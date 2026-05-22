using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	[StructLayout(2)]
	public struct UIVertex
	{
		// Token: 0x06000087 RID: 135 RVA: 0x000044BC File Offset: 0x000026BC
		// Note: this type is marked as 'beforefieldinit'.
		static UIVertex()
		{
			Il2CppClassPointerStore<UIVertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "UIVertex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIVertex>.NativeClassPtr);
			UIVertex.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "position");
			UIVertex.NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "normal");
			UIVertex.NativeFieldInfoPtr_tangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "tangent");
			UIVertex.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "color");
			UIVertex.NativeFieldInfoPtr_uv0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "uv0");
			UIVertex.NativeFieldInfoPtr_uv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "uv1");
			UIVertex.NativeFieldInfoPtr_uv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "uv2");
			UIVertex.NativeFieldInfoPtr_uv3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "uv3");
			UIVertex.NativeFieldInfoPtr_s_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "s_DefaultColor");
			UIVertex.NativeFieldInfoPtr_s_DefaultTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "s_DefaultTangent");
			UIVertex.NativeFieldInfoPtr_simpleVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "simpleVert");
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000024FE File Offset: 0x000006FE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, ref this));
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000045C8 File Offset: 0x000027C8
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002510 File Offset: 0x00000710
		public unsafe static Color32 s_DefaultColor
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(UIVertex.NativeFieldInfoPtr_s_DefaultColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIVertex.NativeFieldInfoPtr_s_DefaultColor, (void*)(&value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000045E4 File Offset: 0x000027E4
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000251E File Offset: 0x0000071E
		public unsafe static Vector4 s_DefaultTangent
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(UIVertex.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIVertex.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00004600 File Offset: 0x00002800
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000252C File Offset: 0x0000072C
		public unsafe static UIVertex simpleVert
		{
			get
			{
				UIVertex uivertex;
				IL2CPP.il2cpp_field_static_get_value(UIVertex.NativeFieldInfoPtr_simpleVert, (void*)(&uivertex));
				return uivertex;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIVertex.NativeFieldInfoPtr_simpleVert, (void*)(&value));
			}
		}

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_normal;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_tangent;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_uv0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_uv1;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_uv2;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_uv3;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultColor;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTangent;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_simpleVert;

		// Token: 0x04000094 RID: 148
		[FieldOffset(0)]
		public Vector3 position;

		// Token: 0x04000095 RID: 149
		[FieldOffset(12)]
		public Vector3 normal;

		// Token: 0x04000096 RID: 150
		[FieldOffset(24)]
		public Vector4 tangent;

		// Token: 0x04000097 RID: 151
		[FieldOffset(40)]
		public Color32 color;

		// Token: 0x04000098 RID: 152
		[FieldOffset(44)]
		public Vector4 uv0;

		// Token: 0x04000099 RID: 153
		[FieldOffset(60)]
		public Vector4 uv1;

		// Token: 0x0400009A RID: 154
		[FieldOffset(76)]
		public Vector4 uv2;

		// Token: 0x0400009B RID: 155
		[FieldOffset(92)]
		public Vector4 uv3;
	}
}
