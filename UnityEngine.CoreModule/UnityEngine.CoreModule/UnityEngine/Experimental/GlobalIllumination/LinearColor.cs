using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000198 RID: 408
	[StructLayout(2)]
	public struct LinearColor
	{
		// Token: 0x06001ECD RID: 7885 RVA: 0x000713F0 File Offset: 0x0006F5F0
		// Note: this type is marked as 'beforefieldinit'.
		static LinearColor()
		{
			Il2CppClassPointerStore<LinearColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LinearColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinearColor>.NativeClassPtr);
			LinearColor.NativeFieldInfoPtr_m_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_red");
			LinearColor.NativeFieldInfoPtr_m_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_green");
			LinearColor.NativeFieldInfoPtr_m_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_blue");
			LinearColor.NativeFieldInfoPtr_m_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_intensity");
			LinearColor.NativeMethodInfoPtr_get_red_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100666115);
			LinearColor.NativeMethodInfoPtr_set_red_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100666116);
			LinearColor.NativeMethodInfoPtr_get_green_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100666117);
			LinearColor.NativeMethodInfoPtr_set_green_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100666118);
			LinearColor.NativeMethodInfoPtr_get_blue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100666119);
			LinearColor.NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100666120);
			LinearColor.NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100666121);
			LinearColor.NativeMethodInfoPtr_Black_Public_Static_LinearColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100666122);
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x00071510 File Offset: 0x0006F710
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x00071540 File Offset: 0x0006F740
		public unsafe float red
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 485970, RefRangeEnd = 485974, XrefRangeStart = 485970, XrefRangeEnd = 485974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_red_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 504443, RefRangeEnd = 504454, XrefRangeStart = 504443, XrefRangeEnd = 504443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_red_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x00071574 File Offset: 0x0006F774
		// (set) Token: 0x06001ED1 RID: 7889 RVA: 0x000715A4 File Offset: 0x0006F7A4
		public unsafe float green
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 487401, RefRangeEnd = 487407, XrefRangeStart = 487401, XrefRangeEnd = 487407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_green_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 504454, RefRangeEnd = 504465, XrefRangeStart = 504454, XrefRangeEnd = 504454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_green_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x000715D8 File Offset: 0x0006F7D8
		// (set) Token: 0x06001ED3 RID: 7891 RVA: 0x00071608 File Offset: 0x0006F808
		public unsafe float blue
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 487407, RefRangeEnd = 487411, XrefRangeStart = 487407, XrefRangeEnd = 487411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_blue_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 504465, RefRangeEnd = 504476, XrefRangeStart = 504465, XrefRangeEnd = 504465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x0007163C File Offset: 0x0006F83C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 504483, RefRangeEnd = 504489, XrefRangeStart = 504476, XrefRangeEnd = 504483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LinearColor Convert(Color color, float intensity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00071688 File Offset: 0x0006F888
		[CallerCount(0)]
		public unsafe static LinearColor Black()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_Black_Public_Static_LinearColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x000100E9 File Offset: 0x0000E2E9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, ref this));
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x000716B8 File Offset: 0x0006F8B8
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x000716D0 File Offset: 0x0006F8D0
		public float intensity
		{
			get
			{
				return this.m_intensity;
			}
			set
			{
				bool flag = value < 0f;
				if (flag)
				{
					throw new ArgumentOutOfRangeException(String.Concat("Intensity (", value.ToString(), ") must be positive."));
				}
				this.m_intensity = value;
			}
		}

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeFieldInfoPtr_m_red;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeFieldInfoPtr_m_green;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeFieldInfoPtr_m_blue;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeFieldInfoPtr_m_intensity;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeMethodInfoPtr_get_red_Public_get_Single_0;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeMethodInfoPtr_set_red_Public_set_Void_Single_0;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr_get_green_Public_get_Single_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeMethodInfoPtr_set_green_Public_set_Void_Single_0;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr_get_blue_Public_get_Single_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_Black_Public_Static_LinearColor_0;

		// Token: 0x040017D6 RID: 6102
		[FieldOffset(0)]
		public float m_red;

		// Token: 0x040017D7 RID: 6103
		[FieldOffset(4)]
		public float m_green;

		// Token: 0x040017D8 RID: 6104
		[FieldOffset(8)]
		public float m_blue;

		// Token: 0x040017D9 RID: 6105
		[FieldOffset(12)]
		public float m_intensity;
	}
}
