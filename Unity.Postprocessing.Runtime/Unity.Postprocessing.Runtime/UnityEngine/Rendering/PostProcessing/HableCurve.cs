using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200005B RID: 91
	public class HableCurve : Object
	{
		// Token: 0x060004D2 RID: 1234 RVA: 0x000156C0 File Offset: 0x000138C0
		// Note: this type is marked as 'beforefieldinit'.
		static HableCurve()
		{
			Il2CppClassPointerStore<HableCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "HableCurve");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HableCurve>.NativeClassPtr);
			HableCurve.NativeFieldInfoPtr__whitePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "<whitePoint>k__BackingField");
			HableCurve.NativeFieldInfoPtr__inverseWhitePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "<inverseWhitePoint>k__BackingField");
			HableCurve.NativeFieldInfoPtr__x0_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "<x0>k__BackingField");
			HableCurve.NativeFieldInfoPtr__x1_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "<x1>k__BackingField");
			HableCurve.NativeFieldInfoPtr_m_Segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "m_Segments");
			HableCurve.NativeFieldInfoPtr_uniforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "uniforms");
			HableCurve.NativeMethodInfoPtr_get_whitePoint_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663753);
			HableCurve.NativeMethodInfoPtr_set_whitePoint_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663754);
			HableCurve.NativeMethodInfoPtr_get_inverseWhitePoint_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663755);
			HableCurve.NativeMethodInfoPtr_set_inverseWhitePoint_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663756);
			HableCurve.NativeMethodInfoPtr_get_x0_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663757);
			HableCurve.NativeMethodInfoPtr_set_x0_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663758);
			HableCurve.NativeMethodInfoPtr_get_x1_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663759);
			HableCurve.NativeMethodInfoPtr_set_x1_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663760);
			HableCurve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663761);
			HableCurve.NativeMethodInfoPtr_Eval_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663762);
			HableCurve.NativeMethodInfoPtr_Init_Public_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663763);
			HableCurve.NativeMethodInfoPtr_InitSegments_Private_Void_DirectParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663764);
			HableCurve.NativeMethodInfoPtr_SolveAB_Private_Void_byref_Single_byref_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663765);
			HableCurve.NativeMethodInfoPtr_AsSlopeIntercept_Private_Void_byref_Single_byref_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663766);
			HableCurve.NativeMethodInfoPtr_EvalDerivativeLinearGamma_Private_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100663767);
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00015894 File Offset: 0x00013A94
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x000158D0 File Offset: 0x00013AD0
		public unsafe float whitePoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_get_whitePoint_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_set_whitePoint_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00015910 File Offset: 0x00013B10
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x0001594C File Offset: 0x00013B4C
		public unsafe float inverseWhitePoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_get_inverseWhitePoint_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_set_inverseWhitePoint_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0001598C File Offset: 0x00013B8C
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x000159C8 File Offset: 0x00013BC8
		public unsafe float x0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_get_x0_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_set_x0_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00015A08 File Offset: 0x00013C08
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00015A44 File Offset: 0x00013C44
		public unsafe float x1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_get_x1_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_set_x1_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00015A84 File Offset: 0x00013C84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 448418, RefRangeEnd = 448419, XrefRangeStart = 448407, XrefRangeEnd = 448418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HableCurve()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HableCurve>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00015AC0 File Offset: 0x00013CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448419, XrefRangeEnd = 448423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Eval(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_Eval_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00015B0C File Offset: 0x00013D0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 448433, RefRangeEnd = 448435, XrefRangeStart = 448423, XrefRangeEnd = 448433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref toeStrength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toeLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shoulderStrength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shoulderLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shoulderAngle;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gamma;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_Init_Public_Void_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00015B90 File Offset: 0x00013D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 448448, RefRangeEnd = 448449, XrefRangeStart = 448435, XrefRangeEnd = 448448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSegments(HableCurve.DirectParams srcParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref srcParams;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_InitSegments_Private_Void_DirectParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00015BD0 File Offset: 0x00013DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448449, XrefRangeEnd = 448451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SolveAB(out float lnA, out float B, float x0, float y0, float m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lnA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &B;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y0;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_SolveAB_Private_Void_byref_Single_byref_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00015C48 File Offset: 0x00013E48
		[CallerCount(0)]
		public unsafe void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &m;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y0;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_AsSlopeIntercept_Private_Void_byref_Single_byref_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00015CCC File Offset: 0x00013ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448451, XrefRangeEnd = 448452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float EvalDerivativeLinearGamma(float m, float b, float g, float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_EvalDerivativeLinearGamma_Private_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0000498F File Offset: 0x00002B8F
		public HableCurve(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00015D40 File Offset: 0x00013F40
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00004998 File Offset: 0x00002B98
		public unsafe float _whitePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__whitePoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__whitePoint_k__BackingField)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00015D68 File Offset: 0x00013F68
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x000049B3 File Offset: 0x00002BB3
		public unsafe float _inverseWhitePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__inverseWhitePoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__inverseWhitePoint_k__BackingField)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00015D90 File Offset: 0x00013F90
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x000049CE File Offset: 0x00002BCE
		public unsafe float _x0_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__x0_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__x0_k__BackingField)) = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00015DB8 File Offset: 0x00013FB8
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x000049E9 File Offset: 0x00002BE9
		public unsafe float _x1_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__x1_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__x1_k__BackingField)) = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00015DE0 File Offset: 0x00013FE0
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00004A04 File Offset: 0x00002C04
		public unsafe Il2CppReferenceArray<HableCurve.Segment> m_Segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr_m_Segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HableCurve.Segment>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr_m_Segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00015E10 File Offset: 0x00014010
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00004A23 File Offset: 0x00002C23
		public unsafe HableCurve.Uniforms uniforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr_uniforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HableCurve.Uniforms>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr_uniforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeFieldInfoPtr__whitePoint_k__BackingField;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeFieldInfoPtr__inverseWhitePoint_k__BackingField;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeFieldInfoPtr__x0_k__BackingField;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeFieldInfoPtr__x1_k__BackingField;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeFieldInfoPtr_m_Segments;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeFieldInfoPtr_uniforms;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_get_whitePoint_Public_get_Single_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_set_whitePoint_Private_set_Void_Single_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_get_inverseWhitePoint_Public_get_Single_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_set_inverseWhitePoint_Private_set_Void_Single_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_get_x0_Internal_get_Single_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_set_x0_Private_set_Void_Single_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_get_x1_Internal_get_Single_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_set_x1_Private_set_Void_Single_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Single_Single_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_InitSegments_Private_Void_DirectParams_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_SolveAB_Private_Void_byref_Single_byref_Single_Single_Single_Single_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_AsSlopeIntercept_Private_Void_byref_Single_byref_Single_Single_Single_Single_Single_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_EvalDerivativeLinearGamma_Private_Single_Single_Single_Single_Single_0;

		// Token: 0x02000091 RID: 145
		public class Segment : Object
		{
			// Token: 0x06000789 RID: 1929 RVA: 0x0001C6A0 File Offset: 0x0001A8A0
			// Note: this type is marked as 'beforefieldinit'.
			static Segment()
			{
				Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "Segment");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr);
				HableCurve.Segment.NativeFieldInfoPtr_offsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, "offsetX");
				HableCurve.Segment.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, "offsetY");
				HableCurve.Segment.NativeFieldInfoPtr_scaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, "scaleX");
				HableCurve.Segment.NativeFieldInfoPtr_scaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, "scaleY");
				HableCurve.Segment.NativeFieldInfoPtr_lnA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, "lnA");
				HableCurve.Segment.NativeFieldInfoPtr_B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, "B");
				HableCurve.Segment.NativeMethodInfoPtr_Eval_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, 100663768);
				HableCurve.Segment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, 100663769);
			}

			// Token: 0x0600078A RID: 1930 RVA: 0x0001C76C File Offset: 0x0001A96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448405, XrefRangeEnd = 448407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float Eval(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Segment.NativeMethodInfoPtr_Eval_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600078B RID: 1931 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Segment()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Segment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600078C RID: 1932 RVA: 0x00005DA5 File Offset: 0x00003FA5
			public Segment(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700027F RID: 639
			// (get) Token: 0x0600078D RID: 1933 RVA: 0x0001C7F4 File Offset: 0x0001A9F4
			// (set) Token: 0x0600078E RID: 1934 RVA: 0x00005DAE File Offset: 0x00003FAE
			public unsafe float offsetX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_offsetX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_offsetX)) = value;
				}
			}

			// Token: 0x17000280 RID: 640
			// (get) Token: 0x0600078F RID: 1935 RVA: 0x0001C81C File Offset: 0x0001AA1C
			// (set) Token: 0x06000790 RID: 1936 RVA: 0x00005DC9 File Offset: 0x00003FC9
			public unsafe float offsetY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_offsetY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_offsetY)) = value;
				}
			}

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x06000791 RID: 1937 RVA: 0x0001C844 File Offset: 0x0001AA44
			// (set) Token: 0x06000792 RID: 1938 RVA: 0x00005DE4 File Offset: 0x00003FE4
			public unsafe float scaleX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_scaleX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_scaleX)) = value;
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x06000793 RID: 1939 RVA: 0x0001C86C File Offset: 0x0001AA6C
			// (set) Token: 0x06000794 RID: 1940 RVA: 0x00005DFF File Offset: 0x00003FFF
			public unsafe float scaleY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_scaleY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_scaleY)) = value;
				}
			}

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x06000795 RID: 1941 RVA: 0x0001C894 File Offset: 0x0001AA94
			// (set) Token: 0x06000796 RID: 1942 RVA: 0x00005E1A File Offset: 0x0000401A
			public unsafe float lnA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_lnA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_lnA)) = value;
				}
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x06000797 RID: 1943 RVA: 0x0001C8BC File Offset: 0x0001AABC
			// (set) Token: 0x06000798 RID: 1944 RVA: 0x00005E35 File Offset: 0x00004035
			public unsafe float B
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_B);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_B)) = value;
				}
			}

			// Token: 0x04000525 RID: 1317
			private static readonly IntPtr NativeFieldInfoPtr_offsetX;

			// Token: 0x04000526 RID: 1318
			private static readonly IntPtr NativeFieldInfoPtr_offsetY;

			// Token: 0x04000527 RID: 1319
			private static readonly IntPtr NativeFieldInfoPtr_scaleX;

			// Token: 0x04000528 RID: 1320
			private static readonly IntPtr NativeFieldInfoPtr_scaleY;

			// Token: 0x04000529 RID: 1321
			private static readonly IntPtr NativeFieldInfoPtr_lnA;

			// Token: 0x0400052A RID: 1322
			private static readonly IntPtr NativeFieldInfoPtr_B;

			// Token: 0x0400052B RID: 1323
			private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Single_Single_0;

			// Token: 0x0400052C RID: 1324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000092 RID: 146
		[StructLayout(2)]
		public struct DirectParams
		{
			// Token: 0x06000799 RID: 1945 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
			// Note: this type is marked as 'beforefieldinit'.
			static DirectParams()
			{
				Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "DirectParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr);
				HableCurve.DirectParams.NativeFieldInfoPtr_x0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "x0");
				HableCurve.DirectParams.NativeFieldInfoPtr_y0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "y0");
				HableCurve.DirectParams.NativeFieldInfoPtr_x1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "x1");
				HableCurve.DirectParams.NativeFieldInfoPtr_y1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "y1");
				HableCurve.DirectParams.NativeFieldInfoPtr_W = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "W");
				HableCurve.DirectParams.NativeFieldInfoPtr_overshootX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "overshootX");
				HableCurve.DirectParams.NativeFieldInfoPtr_overshootY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "overshootY");
				HableCurve.DirectParams.NativeFieldInfoPtr_gamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "gamma");
			}

			// Token: 0x0600079A RID: 1946 RVA: 0x00005E50 File Offset: 0x00004050
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, ref this));
			}

			// Token: 0x0400052D RID: 1325
			private static readonly IntPtr NativeFieldInfoPtr_x0;

			// Token: 0x0400052E RID: 1326
			private static readonly IntPtr NativeFieldInfoPtr_y0;

			// Token: 0x0400052F RID: 1327
			private static readonly IntPtr NativeFieldInfoPtr_x1;

			// Token: 0x04000530 RID: 1328
			private static readonly IntPtr NativeFieldInfoPtr_y1;

			// Token: 0x04000531 RID: 1329
			private static readonly IntPtr NativeFieldInfoPtr_W;

			// Token: 0x04000532 RID: 1330
			private static readonly IntPtr NativeFieldInfoPtr_overshootX;

			// Token: 0x04000533 RID: 1331
			private static readonly IntPtr NativeFieldInfoPtr_overshootY;

			// Token: 0x04000534 RID: 1332
			private static readonly IntPtr NativeFieldInfoPtr_gamma;

			// Token: 0x04000535 RID: 1333
			[FieldOffset(0)]
			public float x0;

			// Token: 0x04000536 RID: 1334
			[FieldOffset(4)]
			public float y0;

			// Token: 0x04000537 RID: 1335
			[FieldOffset(8)]
			public float x1;

			// Token: 0x04000538 RID: 1336
			[FieldOffset(12)]
			public float y1;

			// Token: 0x04000539 RID: 1337
			[FieldOffset(16)]
			public float W;

			// Token: 0x0400053A RID: 1338
			[FieldOffset(20)]
			public float overshootX;

			// Token: 0x0400053B RID: 1339
			[FieldOffset(24)]
			public float overshootY;

			// Token: 0x0400053C RID: 1340
			[FieldOffset(28)]
			public float gamma;
		}

		// Token: 0x02000093 RID: 147
		public class Uniforms : Object
		{
			// Token: 0x0600079B RID: 1947 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr);
				HableCurve.Uniforms.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, "parent");
				HableCurve.Uniforms.NativeMethodInfoPtr__ctor_Internal_Void_HableCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100663770);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_curve_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100663771);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_toeSegmentA_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100663772);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_toeSegmentB_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100663773);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_midSegmentA_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100663774);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_midSegmentB_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100663775);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_shoSegmentA_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100663776);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_shoSegmentB_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100663777);
			}

			// Token: 0x0600079C RID: 1948 RVA: 0x0001CA90 File Offset: 0x0001AC90
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Uniforms(HableCurve parent)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr__ctor_Internal_Void_HableCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000286 RID: 646
			// (get) Token: 0x0600079D RID: 1949 RVA: 0x0001CADC File Offset: 0x0001ACDC
			public unsafe Vector4 curve
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_curve_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x0600079E RID: 1950 RVA: 0x0001CB18 File Offset: 0x0001AD18
			public unsafe Vector4 toeSegmentA
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_toeSegmentA_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x0600079F RID: 1951 RVA: 0x0001CB54 File Offset: 0x0001AD54
			public unsafe Vector4 toeSegmentB
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_toeSegmentB_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0001CB90 File Offset: 0x0001AD90
			public unsafe Vector4 midSegmentA
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_midSegmentA_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0001CBCC File Offset: 0x0001ADCC
			public unsafe Vector4 midSegmentB
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_midSegmentB_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0001CC08 File Offset: 0x0001AE08
			public unsafe Vector4 shoSegmentA
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_shoSegmentA_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700028C RID: 652
			// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0001CC44 File Offset: 0x0001AE44
			public unsafe Vector4 shoSegmentB
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_shoSegmentB_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060007A4 RID: 1956 RVA: 0x00005E62 File Offset: 0x00004062
			public Uniforms(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0001CC80 File Offset: 0x0001AE80
			// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00005E6B File Offset: 0x0000406B
			public unsafe HableCurve parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Uniforms.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HableCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Uniforms.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400053D RID: 1341
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x0400053E RID: 1342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HableCurve_0;

			// Token: 0x0400053F RID: 1343
			private static readonly IntPtr NativeMethodInfoPtr_get_curve_Public_get_Vector4_0;

			// Token: 0x04000540 RID: 1344
			private static readonly IntPtr NativeMethodInfoPtr_get_toeSegmentA_Public_get_Vector4_0;

			// Token: 0x04000541 RID: 1345
			private static readonly IntPtr NativeMethodInfoPtr_get_toeSegmentB_Public_get_Vector4_0;

			// Token: 0x04000542 RID: 1346
			private static readonly IntPtr NativeMethodInfoPtr_get_midSegmentA_Public_get_Vector4_0;

			// Token: 0x04000543 RID: 1347
			private static readonly IntPtr NativeMethodInfoPtr_get_midSegmentB_Public_get_Vector4_0;

			// Token: 0x04000544 RID: 1348
			private static readonly IntPtr NativeMethodInfoPtr_get_shoSegmentA_Public_get_Vector4_0;

			// Token: 0x04000545 RID: 1349
			private static readonly IntPtr NativeMethodInfoPtr_get_shoSegmentB_Public_get_Vector4_0;
		}
	}
}
