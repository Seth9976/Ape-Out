using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200005A RID: 90
	public static class ColorUtilities : Object
	{
		// Token: 0x060004B8 RID: 1208 RVA: 0x000151E0 File Offset: 0x000133E0
		// Note: this type is marked as 'beforefieldinit'.
		static ColorUtilities()
		{
			Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ColorUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr);
			ColorUtilities.NativeFieldInfoPtr_logC_cut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, "logC_cut");
			ColorUtilities.NativeFieldInfoPtr_logC_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, "logC_a");
			ColorUtilities.NativeFieldInfoPtr_logC_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, "logC_b");
			ColorUtilities.NativeFieldInfoPtr_logC_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, "logC_c");
			ColorUtilities.NativeFieldInfoPtr_logC_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, "logC_d");
			ColorUtilities.NativeFieldInfoPtr_logC_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, "logC_e");
			ColorUtilities.NativeFieldInfoPtr_logC_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, "logC_f");
			ColorUtilities.NativeMethodInfoPtr_StandardIlluminantY_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663743);
			ColorUtilities.NativeMethodInfoPtr_CIExyToLMS_Public_Static_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663744);
			ColorUtilities.NativeMethodInfoPtr_ComputeColorBalance_Public_Static_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663745);
			ColorUtilities.NativeMethodInfoPtr_ColorToLift_Public_Static_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663746);
			ColorUtilities.NativeMethodInfoPtr_ColorToInverseGamma_Public_Static_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663747);
			ColorUtilities.NativeMethodInfoPtr_ColorToGain_Public_Static_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663748);
			ColorUtilities.NativeMethodInfoPtr_LogCToLinear_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663749);
			ColorUtilities.NativeMethodInfoPtr_LinearToLogC_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663750);
			ColorUtilities.NativeMethodInfoPtr_ToHex_Public_Static_UInt32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663751);
			ColorUtilities.NativeMethodInfoPtr_ToRGBA_Public_Static_Color_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663752);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00015364 File Offset: 0x00013564
		[CallerCount(0)]
		public unsafe static float StandardIlluminantY(float x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtilities.NativeMethodInfoPtr_StandardIlluminantY_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000153A4 File Offset: 0x000135A4
		[CallerCount(0)]
		public unsafe static Vector3 CIExyToLMS(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtilities.NativeMethodInfoPtr_CIExyToLMS_Public_Static_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000153F0 File Offset: 0x000135F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 448400, RefRangeEnd = 448403, XrefRangeStart = 448399, XrefRangeEnd = 448400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ComputeColorBalance(float temperature, float tint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref temperature;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtilities.NativeMethodInfoPtr_ComputeColorBalance_Public_Static_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0001543C File Offset: 0x0001363C
		[CallerCount(0)]
		public unsafe static Vector3 ColorToLift(Vector4 color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtilities.NativeMethodInfoPtr_ColorToLift_Public_Static_Vector3_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0001547C File Offset: 0x0001367C
		[CallerCount(0)]
		public unsafe static Vector3 ColorToInverseGamma(Vector4 color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtilities.NativeMethodInfoPtr_ColorToInverseGamma_Public_Static_Vector3_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000154BC File Offset: 0x000136BC
		[CallerCount(0)]
		public unsafe static Vector3 ColorToGain(Vector4 color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtilities.NativeMethodInfoPtr_ColorToGain_Public_Static_Vector3_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000154FC File Offset: 0x000136FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448403, XrefRangeEnd = 448404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float LogCToLinear(float x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtilities.NativeMethodInfoPtr_LogCToLinear_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001553C File Offset: 0x0001373C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448404, XrefRangeEnd = 448405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float LinearToLogC(float x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtilities.NativeMethodInfoPtr_LinearToLogC_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0001557C File Offset: 0x0001377C
		[CallerCount(0)]
		public unsafe static uint ToHex(Color c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtilities.NativeMethodInfoPtr_ToHex_Public_Static_UInt32_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000155BC File Offset: 0x000137BC
		[CallerCount(0)]
		public unsafe static Color ToRGBA(uint hex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtilities.NativeMethodInfoPtr_ToRGBA_Public_Static_Color_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00004924 File Offset: 0x00002B24
		public ColorUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x000155FC File Offset: 0x000137FC
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x0000492D File Offset: 0x00002B2D
		public unsafe static float logC_cut
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ColorUtilities.NativeFieldInfoPtr_logC_cut, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorUtilities.NativeFieldInfoPtr_logC_cut, (void*)(&value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00015618 File Offset: 0x00013818
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x0000493B File Offset: 0x00002B3B
		public unsafe static float logC_a
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ColorUtilities.NativeFieldInfoPtr_logC_a, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorUtilities.NativeFieldInfoPtr_logC_a, (void*)(&value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00015634 File Offset: 0x00013834
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00004949 File Offset: 0x00002B49
		public unsafe static float logC_b
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ColorUtilities.NativeFieldInfoPtr_logC_b, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorUtilities.NativeFieldInfoPtr_logC_b, (void*)(&value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00015650 File Offset: 0x00013850
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00004957 File Offset: 0x00002B57
		public unsafe static float logC_c
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ColorUtilities.NativeFieldInfoPtr_logC_c, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorUtilities.NativeFieldInfoPtr_logC_c, (void*)(&value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0001566C File Offset: 0x0001386C
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00004965 File Offset: 0x00002B65
		public unsafe static float logC_d
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ColorUtilities.NativeFieldInfoPtr_logC_d, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorUtilities.NativeFieldInfoPtr_logC_d, (void*)(&value));
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00015688 File Offset: 0x00013888
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00004973 File Offset: 0x00002B73
		public unsafe static float logC_e
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ColorUtilities.NativeFieldInfoPtr_logC_e, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorUtilities.NativeFieldInfoPtr_logC_e, (void*)(&value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x000156A4 File Offset: 0x000138A4
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00004981 File Offset: 0x00002B81
		public unsafe static float logC_f
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ColorUtilities.NativeFieldInfoPtr_logC_f, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorUtilities.NativeFieldInfoPtr_logC_f, (void*)(&value));
			}
		}

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_logC_cut;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr_logC_a;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_logC_b;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_logC_c;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeFieldInfoPtr_logC_d;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeFieldInfoPtr_logC_e;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeFieldInfoPtr_logC_f;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_StandardIlluminantY_Public_Static_Single_Single_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_CIExyToLMS_Public_Static_Vector3_Single_Single_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_ComputeColorBalance_Public_Static_Vector3_Single_Single_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_ColorToLift_Public_Static_Vector3_Vector4_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_ColorToInverseGamma_Public_Static_Vector3_Vector4_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_ColorToGain_Public_Static_Vector3_Vector4_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_LogCToLinear_Public_Static_Single_Single_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_LinearToLogC_Public_Static_Single_Single_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_ToHex_Public_Static_UInt32_Color_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_ToRGBA_Public_Static_Color_UInt32_0;
	}
}
