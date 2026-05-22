using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x02000065 RID: 101
	[Serializable]
	[StructLayout(2)]
	public struct VertexGradient
	{
		// Token: 0x06000C4C RID: 3148 RVA: 0x00033FB0 File Offset: 0x000321B0
		// Note: this type is marked as 'beforefieldinit'.
		static VertexGradient()
		{
			Il2CppClassPointerStore<VertexGradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "VertexGradient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr);
			VertexGradient.NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, "topLeft");
			VertexGradient.NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, "topRight");
			VertexGradient.NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, "bottomLeft");
			VertexGradient.NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, "bottomRight");
			VertexGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, 100664704);
			VertexGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, 100664705);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00034058 File Offset: 0x00032258
		[CallerCount(0)]
		public unsafe VertexGradient(Color color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0003408C File Offset: 0x0003228C
		[CallerCount(0)]
		public unsafe VertexGradient(Color color0, Color color1, Color color2, Color color3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00007ACD File Offset: 0x00005CCD
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, ref this));
		}

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeFieldInfoPtr_topLeft;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeFieldInfoPtr_topRight;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeFieldInfoPtr_bottomLeft;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeFieldInfoPtr_bottomRight;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0;

		// Token: 0x040009D9 RID: 2521
		[FieldOffset(0)]
		public Color topLeft;

		// Token: 0x040009DA RID: 2522
		[FieldOffset(16)]
		public Color topRight;

		// Token: 0x040009DB RID: 2523
		[FieldOffset(32)]
		public Color bottomLeft;

		// Token: 0x040009DC RID: 2524
		[FieldOffset(48)]
		public Color bottomRight;
	}
}
