using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.UI
{
	// Token: 0x02000035 RID: 53
	[StructLayout(2)]
	public struct UIAnchor
	{
		// Token: 0x060003EE RID: 1006 RVA: 0x0003CBA8 File Offset: 0x0003ADA8
		// Note: this type is marked as 'beforefieldinit'.
		static UIAnchor()
		{
			Il2CppClassPointerStore<UIAnchor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.UI", "UIAnchor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr);
			UIAnchor.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, "min");
			UIAnchor.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, "max");
			UIAnchor.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663961);
			UIAnchor.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663962);
			UIAnchor.NativeMethodInfoPtr_get_TopLeft_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663963);
			UIAnchor.NativeMethodInfoPtr_get_TopCenter_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663964);
			UIAnchor.NativeMethodInfoPtr_get_TopRight_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663965);
			UIAnchor.NativeMethodInfoPtr_get_MiddleLeft_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663966);
			UIAnchor.NativeMethodInfoPtr_get_MiddleCenter_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663967);
			UIAnchor.NativeMethodInfoPtr_get_MiddleRight_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663968);
			UIAnchor.NativeMethodInfoPtr_get_BottomLeft_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663969);
			UIAnchor.NativeMethodInfoPtr_get_BottomCenter_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663970);
			UIAnchor.NativeMethodInfoPtr_get_BottomRight_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663971);
			UIAnchor.NativeMethodInfoPtr_get_TopHStretch_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663972);
			UIAnchor.NativeMethodInfoPtr_get_MiddleHStretch_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663973);
			UIAnchor.NativeMethodInfoPtr_get_BottomHStretch_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663974);
			UIAnchor.NativeMethodInfoPtr_get_LeftVStretch_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663975);
			UIAnchor.NativeMethodInfoPtr_get_CenterVStretch_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663976);
			UIAnchor.NativeMethodInfoPtr_get_RightVStretch_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663977);
			UIAnchor.NativeMethodInfoPtr_get_Stretch_Public_Static_get_UIAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100663978);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0003CD68 File Offset: 0x0003AF68
		[CallerCount(0)]
		public unsafe UIAnchor(float minX, float minY, float maxX, float maxY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0003CDC4 File Offset: 0x0003AFC4
		[CallerCount(0)]
		public unsafe UIAnchor(Vector2 min, Vector2 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0003CE04 File Offset: 0x0003B004
		public unsafe static UIAnchor TopLeft
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_TopLeft_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0003CE34 File Offset: 0x0003B034
		public unsafe static UIAnchor TopCenter
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_TopCenter_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0003CE64 File Offset: 0x0003B064
		public unsafe static UIAnchor TopRight
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_TopRight_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0003CE94 File Offset: 0x0003B094
		public unsafe static UIAnchor MiddleLeft
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_MiddleLeft_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0003CEC4 File Offset: 0x0003B0C4
		public unsafe static UIAnchor MiddleCenter
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_MiddleCenter_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0003CEF4 File Offset: 0x0003B0F4
		public unsafe static UIAnchor MiddleRight
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_MiddleRight_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0003CF24 File Offset: 0x0003B124
		public unsafe static UIAnchor BottomLeft
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_BottomLeft_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0003CF54 File Offset: 0x0003B154
		public unsafe static UIAnchor BottomCenter
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_BottomCenter_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0003CF84 File Offset: 0x0003B184
		public unsafe static UIAnchor BottomRight
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_BottomRight_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0003CFB4 File Offset: 0x0003B1B4
		public unsafe static UIAnchor TopHStretch
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_TopHStretch_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0003CFE4 File Offset: 0x0003B1E4
		public unsafe static UIAnchor MiddleHStretch
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_MiddleHStretch_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0003D014 File Offset: 0x0003B214
		public unsafe static UIAnchor BottomHStretch
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_BottomHStretch_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0003D044 File Offset: 0x0003B244
		public unsafe static UIAnchor LeftVStretch
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_LeftVStretch_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0003D074 File Offset: 0x0003B274
		public unsafe static UIAnchor CenterVStretch
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_CenterVStretch_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0003D0A4 File Offset: 0x0003B2A4
		public unsafe static UIAnchor RightVStretch
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_RightVStretch_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0003D0D4 File Offset: 0x0003B2D4
		public unsafe static UIAnchor Stretch
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_get_Stretch_Public_Static_get_UIAnchor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00003419 File Offset: 0x00001619
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, ref this));
		}

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_get_TopLeft_Public_Static_get_UIAnchor_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_get_TopCenter_Public_Static_get_UIAnchor_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_get_TopRight_Public_Static_get_UIAnchor_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_get_MiddleLeft_Public_Static_get_UIAnchor_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_get_MiddleCenter_Public_Static_get_UIAnchor_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_get_MiddleRight_Public_Static_get_UIAnchor_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomLeft_Public_Static_get_UIAnchor_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomCenter_Public_Static_get_UIAnchor_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomRight_Public_Static_get_UIAnchor_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_get_TopHStretch_Public_Static_get_UIAnchor_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_get_MiddleHStretch_Public_Static_get_UIAnchor_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomHStretch_Public_Static_get_UIAnchor_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftVStretch_Public_Static_get_UIAnchor_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_get_CenterVStretch_Public_Static_get_UIAnchor_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_get_RightVStretch_Public_Static_get_UIAnchor_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_get_Stretch_Public_Static_get_UIAnchor_0;

		// Token: 0x04000373 RID: 883
		[FieldOffset(0)]
		public Vector2 min;

		// Token: 0x04000374 RID: 884
		[FieldOffset(8)]
		public Vector2 max;
	}
}
