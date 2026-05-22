using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200004A RID: 74
	public static class SECTR_Geometry : global::Il2CppSystem.Object
	{
		// Token: 0x06000B00 RID: 2816 RVA: 0x00054B30 File Offset: 0x00052D30
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_Geometry()
		{
			Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_Geometry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr);
			SECTR_Geometry.NativeFieldInfoPtr_kVERTEX_EPSILON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr, "kVERTEX_EPSILON");
			SECTR_Geometry.NativeFieldInfoPtr_kBOUNDS_CHEAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr, "kBOUNDS_CHEAT");
			SECTR_Geometry.NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr, 100664214);
			SECTR_Geometry.NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr, 100664215);
			SECTR_Geometry.NativeMethodInfoPtr_FrustumIntersectsBounds_Public_Static_Boolean_Bounds_List_1_Plane_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr, 100664216);
			SECTR_Geometry.NativeMethodInfoPtr_FrustumContainsBounds_Public_Static_Boolean_Bounds_List_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr, 100664217);
			SECTR_Geometry.NativeMethodInfoPtr_BoundsContainsBounds_Public_Static_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr, 100664218);
			SECTR_Geometry.NativeMethodInfoPtr_BoundsIntersectsSphere_Public_Static_Boolean_Bounds_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr, 100664219);
			SECTR_Geometry.NativeMethodInfoPtr_ProjectBounds_Public_Static_Bounds_Bounds_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr, 100664220);
			SECTR_Geometry.NativeMethodInfoPtr_IsPointInFrontOfPlane_Public_Static_Boolean_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr, 100664221);
			SECTR_Geometry.NativeMethodInfoPtr_IsPolygonConvex_Public_Static_Boolean_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr, 100664222);
			SECTR_Geometry.NativeMethodInfoPtr_CompareVectorsCW_Public_Static_Int32_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Geometry>.NativeClassPtr, 100664223);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00054C50 File Offset: 0x00052E50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40703, RefRangeEnd = 40704, XrefRangeStart = 40662, XrefRangeEnd = 40703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds ComputeBounds(Light light)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Geometry.NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00054C94 File Offset: 0x00052E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40708, RefRangeEnd = 40709, XrefRangeStart = 40704, XrefRangeEnd = 40708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds ComputeBounds(Terrain terrain)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Geometry.NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Terrain_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00054CD8 File Offset: 0x00052ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40709, XrefRangeEnd = 40710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FrustumIntersectsBounds(Bounds bounds, List<Plane> frustum, int inMask, out int outMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bounds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frustum);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Geometry.NativeMethodInfoPtr_FrustumIntersectsBounds_Public_Static_Boolean_Bounds_List_1_Plane_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00054D44 File Offset: 0x00052F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40710, XrefRangeEnd = 40712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FrustumContainsBounds(Bounds bounds, List<Plane> frustum)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bounds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frustum);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Geometry.NativeMethodInfoPtr_FrustumContainsBounds_Public_Static_Boolean_Bounds_List_1_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00054D94 File Offset: 0x00052F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40712, XrefRangeEnd = 40714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BoundsContainsBounds(Bounds container, Bounds contained)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref container;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contained;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Geometry.NativeMethodInfoPtr_BoundsContainsBounds_Public_Static_Boolean_Bounds_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00054DE0 File Offset: 0x00052FE0
		[CallerCount(0)]
		public unsafe static bool BoundsIntersectsSphere(Bounds bounds, Vector3 sphereCenter, float sphereRadius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bounds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereCenter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereRadius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Geometry.NativeMethodInfoPtr_BoundsIntersectsSphere_Public_Static_Boolean_Bounds_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00054E3C File Offset: 0x0005303C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40716, RefRangeEnd = 40718, XrefRangeStart = 40714, XrefRangeEnd = 40716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds ProjectBounds(Bounds bounds, Vector3 projection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bounds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Geometry.NativeMethodInfoPtr_ProjectBounds_Public_Static_Bounds_Bounds_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00054E88 File Offset: 0x00053088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40718, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPointInFrontOfPlane(Vector3 position, Vector3 center, Vector3 normal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref center;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Geometry.NativeMethodInfoPtr_IsPointInFrontOfPlane_Public_Static_Boolean_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00054EE4 File Offset: 0x000530E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40731, RefRangeEnd = 40732, XrefRangeStart = 40722, XrefRangeEnd = 40731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPolygonConvex(Il2CppStructArray<Vector3> verts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Geometry.NativeMethodInfoPtr_IsPolygonConvex_Public_Static_Boolean_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00054F28 File Offset: 0x00053128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40732, XrefRangeEnd = 40734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareVectorsCW(Vector3 a, Vector3 b, Vector3 centroid, Vector3 normal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref centroid;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Geometry.NativeMethodInfoPtr_CompareVectorsCW_Public_Static_Int32_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00008DEB File Offset: 0x00006FEB
		public SECTR_Geometry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x00054F90 File Offset: 0x00053190
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00008DF4 File Offset: 0x00006FF4
		public unsafe static float kVERTEX_EPSILON
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Geometry.NativeFieldInfoPtr_kVERTEX_EPSILON, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Geometry.NativeFieldInfoPtr_kVERTEX_EPSILON, (void*)(&value));
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00054FAC File Offset: 0x000531AC
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00008E02 File Offset: 0x00007002
		public unsafe static float kBOUNDS_CHEAT
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Geometry.NativeFieldInfoPtr_kBOUNDS_CHEAT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Geometry.NativeFieldInfoPtr_kBOUNDS_CHEAT, (void*)(&value));
			}
		}

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeFieldInfoPtr_kVERTEX_EPSILON;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeFieldInfoPtr_kBOUNDS_CHEAT;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Light_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Terrain_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_FrustumIntersectsBounds_Public_Static_Boolean_Bounds_List_1_Plane_Int32_byref_Int32_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_FrustumContainsBounds_Public_Static_Boolean_Bounds_List_1_Plane_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_BoundsContainsBounds_Public_Static_Boolean_Bounds_Bounds_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_BoundsIntersectsSphere_Public_Static_Boolean_Bounds_Vector3_Single_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_ProjectBounds_Public_Static_Bounds_Bounds_Vector3_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInFrontOfPlane_Public_Static_Boolean_Vector3_Vector3_Vector3_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_IsPolygonConvex_Public_Static_Boolean_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_CompareVectorsCW_Public_Static_Int32_Vector3_Vector3_Vector3_Vector3_0;
	}
}
