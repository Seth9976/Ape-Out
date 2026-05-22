using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct TMP_Vertex
	{
		// Token: 0x06000080 RID: 128 RVA: 0x0000BC28 File Offset: 0x00009E28
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Vertex()
		{
			Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Vertex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr);
			TMP_Vertex.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "position");
			TMP_Vertex.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "uv");
			TMP_Vertex.NativeFieldInfoPtr_uv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "uv2");
			TMP_Vertex.NativeFieldInfoPtr_uv4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "uv4");
			TMP_Vertex.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "color");
			TMP_Vertex.NativeFieldInfoPtr_k_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "k_Zero");
			TMP_Vertex.NativeMethodInfoPtr_get_zero_Public_Static_get_TMP_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, 100663346);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000BCE4 File Offset: 0x00009EE4
		public unsafe static TMP_Vertex zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450436, XrefRangeEnd = 450440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Vertex.NativeMethodInfoPtr_get_zero_Public_Static_get_TMP_Vertex_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002430 File Offset: 0x00000630
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, ref this));
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000BD14 File Offset: 0x00009F14
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002442 File Offset: 0x00000642
		public unsafe static TMP_Vertex k_Zero
		{
			get
			{
				TMP_Vertex tmp_Vertex;
				IL2CPP.il2cpp_field_static_get_value(TMP_Vertex.NativeFieldInfoPtr_k_Zero, (void*)(&tmp_Vertex));
				return tmp_Vertex;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Vertex.NativeFieldInfoPtr_k_Zero, (void*)(&value));
			}
		}

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_uv2;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_uv4;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_k_Zero;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_TMP_Vertex_0;

		// Token: 0x04000055 RID: 85
		[FieldOffset(0)]
		public Vector3 position;

		// Token: 0x04000056 RID: 86
		[FieldOffset(12)]
		public Vector2 uv;

		// Token: 0x04000057 RID: 87
		[FieldOffset(20)]
		public Vector2 uv2;

		// Token: 0x04000058 RID: 88
		[FieldOffset(28)]
		public Vector2 uv4;

		// Token: 0x04000059 RID: 89
		[FieldOffset(36)]
		public Color32 color;
	}
}
