using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000063 RID: 99
	[Serializable]
	public sealed class Spline : Object
	{
		// Token: 0x06000681 RID: 1665 RVA: 0x00019A08 File Offset: 0x00017C08
		// Note: this type is marked as 'beforefieldinit'.
		static Spline()
		{
			Il2CppClassPointerStore<Spline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "Spline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spline>.NativeClassPtr);
			Spline.NativeFieldInfoPtr_k_Precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "k_Precision");
			Spline.NativeFieldInfoPtr_k_Step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "k_Step");
			Spline.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "curve");
			Spline.NativeFieldInfoPtr_m_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "m_Loop");
			Spline.NativeFieldInfoPtr_m_ZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "m_ZeroValue");
			Spline.NativeFieldInfoPtr_m_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "m_Range");
			Spline.NativeFieldInfoPtr_m_InternalLoopingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "m_InternalLoopingCurve");
			Spline.NativeFieldInfoPtr_frameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "frameCount");
			Spline.NativeFieldInfoPtr_cachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "cachedData");
			Spline.NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_Single_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100663874);
			Spline.NativeMethodInfoPtr_Cache_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100663875);
			Spline.NativeMethodInfoPtr_Evaluate_Public_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100663876);
			Spline.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100663877);
			Spline.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100663878);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00019B50 File Offset: 0x00017D50
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 449856, RefRangeEnd = 449864, XrefRangeStart = 449852, XrefRangeEnd = 449856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spline(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spline>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spline.NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_Single_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00019BC8 File Offset: 0x00017DC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 449887, RefRangeEnd = 449891, XrefRangeStart = 449864, XrefRangeEnd = 449887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cache(int frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref frame;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spline.NativeMethodInfoPtr_Cache_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00019C08 File Offset: 0x00017E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449891, XrefRangeEnd = 449893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Evaluate(float t, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spline.NativeMethodInfoPtr_Evaluate_Public_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00019C60 File Offset: 0x00017E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449893, XrefRangeEnd = 449897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Evaluate(float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spline.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00019CAC File Offset: 0x00017EAC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spline.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000053C0 File Offset: 0x000035C0
		public Spline(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00019CE8 File Offset: 0x00017EE8
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x000053C9 File Offset: 0x000035C9
		public unsafe static int k_Precision
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Spline.NativeFieldInfoPtr_k_Precision, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spline.NativeFieldInfoPtr_k_Precision, (void*)(&value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00019D04 File Offset: 0x00017F04
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x000053D7 File Offset: 0x000035D7
		public unsafe static float k_Step
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Spline.NativeFieldInfoPtr_k_Step, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spline.NativeFieldInfoPtr_k_Step, (void*)(&value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00019D20 File Offset: 0x00017F20
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x000053E5 File Offset: 0x000035E5
		public unsafe AnimationCurve curve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_curve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00019D50 File Offset: 0x00017F50
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00005404 File Offset: 0x00003604
		public unsafe bool m_Loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_m_Loop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_m_Loop)) = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00019D78 File Offset: 0x00017F78
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x0000541F File Offset: 0x0000361F
		public unsafe float m_ZeroValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_m_ZeroValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_m_ZeroValue)) = value;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00019DA0 File Offset: 0x00017FA0
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x0000543A File Offset: 0x0000363A
		public unsafe float m_Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_m_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_m_Range)) = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00019DC8 File Offset: 0x00017FC8
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00005455 File Offset: 0x00003655
		public unsafe AnimationCurve m_InternalLoopingCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_m_InternalLoopingCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_m_InternalLoopingCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00019DF8 File Offset: 0x00017FF8
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00005474 File Offset: 0x00003674
		public unsafe int frameCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_frameCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_frameCount)) = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00019E20 File Offset: 0x00018020
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x0000548F File Offset: 0x0000368F
		public unsafe Il2CppStructArray<float> cachedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_cachedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spline.NativeFieldInfoPtr_cachedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeFieldInfoPtr_k_Precision;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeFieldInfoPtr_k_Step;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeFieldInfoPtr_curve;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr_m_Loop;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr_m_ZeroValue;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_m_Range;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalLoopingCurve;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr_frameCount;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeFieldInfoPtr_cachedData;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_Single_Boolean_Vector2_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_Cache_Public_Void_Int32_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_Int32_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
