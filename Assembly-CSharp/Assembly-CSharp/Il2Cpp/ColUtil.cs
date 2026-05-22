using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000A9 RID: 169
	public class ColUtil : MonoBehaviour
	{
		// Token: 0x06001452 RID: 5202 RVA: 0x0006DF9C File Offset: 0x0006C19C
		// Note: this type is marked as 'beforefieldinit'.
		static ColUtil()
		{
			Il2CppClassPointerStore<ColUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ColUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColUtil>.NativeClassPtr);
			ColUtil.NativeFieldInfoPtr_opaqueLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, "opaqueLayers");
			ColUtil.NativeFieldInfoPtr_pathLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, "pathLayers");
			ColUtil.NativeFieldInfoPtr_opaqueNoSmokeLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, "opaqueNoSmokeLayers");
			ColUtil.NativeFieldInfoPtr_bndVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, "bndVect");
			ColUtil.NativeFieldInfoPtr_bndVect2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, "bndVect2");
			ColUtil.NativeFieldInfoPtr_contactPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, "contactPt");
			ColUtil.NativeFieldInfoPtr_obstacleMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, "obstacleMask");
			ColUtil.NativeFieldInfoPtr_ignoreLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, "ignoreLayer");
			ColUtil.NativeMethodInfoPtr_RaycastSolid_Public_Static_RaycastHit2D_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665022);
			ColUtil.NativeMethodInfoPtr_MaxBounds_Public_Static_Bounds_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665023);
			ColUtil.NativeMethodInfoPtr_MaxBounds_Public_Static_Void_byref_Bounds_Bounds_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665024);
			ColUtil.NativeMethodInfoPtr_MaxBounds_Public_Static_Void_byref_Bounds_Il2CppStructArray_1_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665025);
			ColUtil.NativeMethodInfoPtr_MaxBounds_Public_Static_Void_byref_Bounds_Il2CppReferenceArray_1_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665026);
			ColUtil.NativeMethodInfoPtr_RaycastSolid_Public_Static_RaycastHit2D_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665027);
			ColUtil.NativeMethodInfoPtr_GetBoxPoints_Public_Static_Il2CppStructArray_1_Vector2_BoxCollider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665028);
			ColUtil.NativeMethodInfoPtr_GetBoxPoints_Public_Static_Void_BoxCollider2D_byref_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665029);
			ColUtil.NativeMethodInfoPtr_GetBoxPoints_Public_Static_Il2CppStructArray_1_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665030);
			ColUtil.NativeMethodInfoPtr_LOS_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665031);
			ColUtil.NativeMethodInfoPtr_LOSSearch_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665032);
			ColUtil.NativeMethodInfoPtr_LOSNoSmoke_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665033);
			ColUtil.NativeMethodInfoPtr_LOS_Public_Static_Boolean_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665034);
			ColUtil.NativeMethodInfoPtr_LOS_Public_Static_Boolean_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665035);
			ColUtil.NativeMethodInfoPtr_ClearPath_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665036);
			ColUtil.NativeMethodInfoPtr_ClearPath_Public_Static_Boolean_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665037);
			ColUtil.NativeMethodInfoPtr_ChangeLayerAll_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665038);
			ColUtil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColUtil>.NativeClassPtr, 100665039);
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0006E1D4 File Offset: 0x0006C3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52294, XrefRangeEnd = 52302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D RaycastSolid(Vector2 pt, Vector2 dir, float dist)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_RaycastSolid_Public_Static_RaycastHit2D_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0006E230 File Offset: 0x0006C430
		[CallerCount(0)]
		public unsafe static Bounds MaxBounds(Bounds bnd1, Bounds bnd2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bnd1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bnd2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_MaxBounds_Public_Static_Bounds_Bounds_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0006E27C File Offset: 0x0006C47C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52309, RefRangeEnd = 52310, XrefRangeStart = 52302, XrefRangeEnd = 52309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MaxBounds(ref Bounds bnd1, Bounds bnd2, float j)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &bnd1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bnd2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_MaxBounds_Public_Static_Void_byref_Bounds_Bounds_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0006E2CC File Offset: 0x0006C4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52310, XrefRangeEnd = 52320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MaxBounds(ref Bounds bnd, Il2CppStructArray<Bounds> bnds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &bnd;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bnds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_MaxBounds_Public_Static_Void_byref_Bounds_Il2CppStructArray_1_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0006E310 File Offset: 0x0006C510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52349, RefRangeEnd = 52350, XrefRangeStart = 52320, XrefRangeEnd = 52349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MaxBounds(ref Bounds bnd, Il2CppReferenceArray<Renderer> bnds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &bnd;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bnds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_MaxBounds_Public_Static_Void_byref_Bounds_Il2CppReferenceArray_1_Renderer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0006E354 File Offset: 0x0006C554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52350, XrefRangeEnd = 52362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastHit2D RaycastSolid(Vector2 pt, Vector2 dir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_RaycastSolid_Public_Static_RaycastHit2D_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0006E3A0 File Offset: 0x0006C5A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 52372, RefRangeEnd = 52377, XrefRangeStart = 52362, XrefRangeEnd = 52372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector2> GetBoxPoints(BoxCollider2D o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_GetBoxPoints_Public_Static_Il2CppStructArray_1_Vector2_BoxCollider2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0006E3E4 File Offset: 0x0006C5E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52384, RefRangeEnd = 52385, XrefRangeStart = 52377, XrefRangeEnd = 52384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetBoxPoints(BoxCollider2D o, ref Il2CppStructArray<Vector2> points)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_GetBoxPoints_Public_Static_Void_BoxCollider2D_byref_Il2CppStructArray_1_Vector2_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			points = ((intPtr4 == 0) ? null : new Il2CppStructArray<Vector2>(intPtr4));
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0006E444 File Offset: 0x0006C644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52385, XrefRangeEnd = 52388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector2> GetBoxPoints(Vector2 center, Vector2 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_GetBoxPoints_Public_Static_Il2CppStructArray_1_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0006E494 File Offset: 0x0006C694
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 52415, RefRangeEnd = 52432, XrefRangeStart = 52388, XrefRangeEnd = 52415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LOS(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_LOS_Public_Static_Boolean_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0006E4E0 File Offset: 0x0006C6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52459, RefRangeEnd = 52460, XrefRangeStart = 52432, XrefRangeEnd = 52459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LOSSearch(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_LOSSearch_Public_Static_Boolean_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0006E52C File Offset: 0x0006C72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52460, XrefRangeEnd = 52547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LOSNoSmoke(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_LOSNoSmoke_Public_Static_Boolean_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0006E578 File Offset: 0x0006C778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 52567, RefRangeEnd = 52569, XrefRangeStart = 52547, XrefRangeEnd = 52567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LOS(Vector2 a, Vector2 b, float r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_LOS_Public_Static_Boolean_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0006E5D4 File Offset: 0x0006C7D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 52590, RefRangeEnd = 52594, XrefRangeStart = 52569, XrefRangeEnd = 52590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LOS(GameObject a, GameObject b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_LOS_Public_Static_Boolean_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0006E628 File Offset: 0x0006C828
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 52621, RefRangeEnd = 52627, XrefRangeStart = 52594, XrefRangeEnd = 52621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClearPath(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_ClearPath_Public_Static_Boolean_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0006E674 File Offset: 0x0006C874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 52647, RefRangeEnd = 52649, XrefRangeStart = 52627, XrefRangeEnd = 52647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClearPath(Vector2 a, Vector2 b, float r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_ClearPath_Public_Static_Boolean_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0006E6D0 File Offset: 0x0006C8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52649, XrefRangeEnd = 52662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangeLayerAll(GameObject obj, int layer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr_ChangeLayerAll_Public_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0006E714 File Offset: 0x0006C914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColUtil()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColUtil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColUtil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0000ECEB File Offset: 0x0000CEEB
		public ColUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0006E750 File Offset: 0x0006C950
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
		public unsafe static int opaqueLayers
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ColUtil.NativeFieldInfoPtr_opaqueLayers, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColUtil.NativeFieldInfoPtr_opaqueLayers, (void*)(&value));
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0006E76C File Offset: 0x0006C96C
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x0000ED02 File Offset: 0x0000CF02
		public unsafe static int pathLayers
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ColUtil.NativeFieldInfoPtr_pathLayers, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColUtil.NativeFieldInfoPtr_pathLayers, (void*)(&value));
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0006E788 File Offset: 0x0006C988
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x0000ED10 File Offset: 0x0000CF10
		public unsafe static int opaqueNoSmokeLayers
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ColUtil.NativeFieldInfoPtr_opaqueNoSmokeLayers, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColUtil.NativeFieldInfoPtr_opaqueNoSmokeLayers, (void*)(&value));
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0006E7A4 File Offset: 0x0006C9A4
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x0000ED1E File Offset: 0x0000CF1E
		public unsafe static Vector3 bndVect
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(ColUtil.NativeFieldInfoPtr_bndVect, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColUtil.NativeFieldInfoPtr_bndVect, (void*)(&value));
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x0006E7C0 File Offset: 0x0006C9C0
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x0000ED2C File Offset: 0x0000CF2C
		public unsafe static Vector3 bndVect2
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(ColUtil.NativeFieldInfoPtr_bndVect2, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColUtil.NativeFieldInfoPtr_bndVect2, (void*)(&value));
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x0006E7DC File Offset: 0x0006C9DC
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x0000ED3A File Offset: 0x0000CF3A
		public unsafe static ContactPoint2D contactPt
		{
			get
			{
				ContactPoint2D contactPoint2D;
				IL2CPP.il2cpp_field_static_get_value(ColUtil.NativeFieldInfoPtr_contactPt, (void*)(&contactPoint2D));
				return contactPoint2D;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColUtil.NativeFieldInfoPtr_contactPt, (void*)(&value));
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x0006E7F8 File Offset: 0x0006C9F8
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x0000ED48 File Offset: 0x0000CF48
		public unsafe static int obstacleMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ColUtil.NativeFieldInfoPtr_obstacleMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColUtil.NativeFieldInfoPtr_obstacleMask, (void*)(&value));
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x0006E814 File Offset: 0x0006CA14
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x0000ED56 File Offset: 0x0000CF56
		public unsafe static int ignoreLayer
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ColUtil.NativeFieldInfoPtr_ignoreLayer, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColUtil.NativeFieldInfoPtr_ignoreLayer, (void*)(&value));
			}
		}

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeFieldInfoPtr_opaqueLayers;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeFieldInfoPtr_pathLayers;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeFieldInfoPtr_opaqueNoSmokeLayers;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeFieldInfoPtr_bndVect;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeFieldInfoPtr_bndVect2;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeFieldInfoPtr_contactPt;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeFieldInfoPtr_obstacleMask;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeFieldInfoPtr_ignoreLayer;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_RaycastSolid_Public_Static_RaycastHit2D_Vector2_Vector2_Single_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_MaxBounds_Public_Static_Bounds_Bounds_Bounds_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_MaxBounds_Public_Static_Void_byref_Bounds_Bounds_Single_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_MaxBounds_Public_Static_Void_byref_Bounds_Il2CppStructArray_1_Bounds_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_MaxBounds_Public_Static_Void_byref_Bounds_Il2CppReferenceArray_1_Renderer_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_RaycastSolid_Public_Static_RaycastHit2D_Vector2_Vector2_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_GetBoxPoints_Public_Static_Il2CppStructArray_1_Vector2_BoxCollider2D_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_GetBoxPoints_Public_Static_Void_BoxCollider2D_byref_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_GetBoxPoints_Public_Static_Il2CppStructArray_1_Vector2_Vector2_Vector2_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_LOS_Public_Static_Boolean_Vector2_Vector2_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_LOSSearch_Public_Static_Boolean_Vector2_Vector2_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_LOSNoSmoke_Public_Static_Boolean_Vector2_Vector2_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_LOS_Public_Static_Boolean_Vector2_Vector2_Single_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_LOS_Public_Static_Boolean_GameObject_GameObject_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_ClearPath_Public_Static_Boolean_Vector2_Vector2_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_ClearPath_Public_Static_Boolean_Vector2_Vector2_Single_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLayerAll_Public_Static_Void_GameObject_Int32_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
