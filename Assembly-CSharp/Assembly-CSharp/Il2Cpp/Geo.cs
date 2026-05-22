using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000E5 RID: 229
	public class Geo : MonoBehaviour
	{
		// Token: 0x06001A36 RID: 6710 RVA: 0x0007E22C File Offset: 0x0007C42C
		// Note: this type is marked as 'beforefieldinit'.
		static Geo()
		{
			Il2CppClassPointerStore<Geo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Geo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Geo>.NativeClassPtr);
			Geo.NativeFieldInfoPtr_vct3List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Geo>.NativeClassPtr, "vct3List");
			Geo.NativeFieldInfoPtr_pt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Geo>.NativeClassPtr, "pt");
			Geo.NativeMethodInfoPtr_SetVert_Public_Static_Void_NativeSlice_1_MeshPt_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665444);
			Geo.NativeMethodInfoPtr_DuplicateVerts_Public_Static_Void_NativeSlice_1_MeshPt_NativeSlice_1_MeshPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665445);
			Geo.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665446);
			Geo.NativeMethodInfoPtr_CosLaw_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665447);
			Geo.NativeMethodInfoPtr_SnapTo_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665448);
			Geo.NativeMethodInfoPtr_RndTo_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665449);
			Geo.NativeMethodInfoPtr_ToAng_Public_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665450);
			Geo.NativeMethodInfoPtr_ToAng_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665451);
			Geo.NativeMethodInfoPtr_ToAngNoDegreed_Public_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665452);
			Geo.NativeMethodInfoPtr_ToAng_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665453);
			Geo.NativeMethodInfoPtr_AddDegrees_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665454);
			Geo.NativeMethodInfoPtr_ToVect_Public_Static_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665455);
			Geo.NativeMethodInfoPtr_ToVect3_Public_Static_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665456);
			Geo.NativeMethodInfoPtr_MoveTowardClockwise_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665457);
			Geo.NativeMethodInfoPtr_MoveTowardAntiClockwise_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665458);
			Geo.NativeMethodInfoPtr_fastabs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665459);
			Geo.NativeMethodInfoPtr_AngDist_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665460);
			Geo.NativeMethodInfoPtr_MidPoint_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665461);
			Geo.NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665462);
			Geo.NativeMethodInfoPtr_ToV2_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665463);
			Geo.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665464);
			Geo.NativeMethodInfoPtr_AngleNoDegreed_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665465);
			Geo.NativeMethodInfoPtr_Angle_Public_Static_Single_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665466);
			Geo.NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665467);
			Geo.NativeMethodInfoPtr_StringifyTime_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665468);
			Geo.NativeMethodInfoPtr_IsBetween_Public_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665469);
			Geo.NativeMethodInfoPtr_IsBetweenNoDegreed_Public_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665470);
			Geo.NativeMethodInfoPtr_IsNumBetween_Public_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665471);
			Geo.NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665472);
			Geo.NativeMethodInfoPtr_Mod_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665473);
			Geo.NativeMethodInfoPtr_Degreed_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665474);
			Geo.NativeMethodInfoPtr_IsLeft_Public_Static_Boolean_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665475);
			Geo.NativeMethodInfoPtr_PerpVectL_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665476);
			Geo.NativeMethodInfoPtr_PerpVectR_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665477);
			Geo.NativeMethodInfoPtr_PerpVect_Public_Static_Vector3_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665478);
			Geo.NativeMethodInfoPtr_PerpVect_Public_Static_Vector2_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665479);
			Geo.NativeMethodInfoPtr_SideMostIndex_Public_Static_Int32_Il2CppStructArray_1_Vector3_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665480);
			Geo.NativeMethodInfoPtr_SideMost_Public_Static_Vector3_Il2CppStructArray_1_Vector3_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665481);
			Geo.NativeMethodInfoPtr_SideMost_Public_Static_Vector3_MeshFilter_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665482);
			Geo.NativeMethodInfoPtr_SideMost_Public_Static_Vector2_Il2CppStructArray_1_Vector2_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665483);
			Geo.NativeMethodInfoPtr_SideMostIndex_Public_Static_Int32_Il2CppStructArray_1_Vector2_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665484);
			Geo.NativeMethodInfoPtr_ClosestPoint_Public_Static_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665485);
			Geo.NativeMethodInfoPtr_LineLineIntersection_Public_Static_Vector2_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665486);
			Geo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geo>.NativeClassPtr, 100665487);
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 60261, RefRangeEnd = 60268, XrefRangeStart = 60255, XrefRangeEnd = 60261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVert(NativeSlice<MeshPt> arr, int index, Vector3 pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arr));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_SetVert_Public_Static_Void_NativeSlice_1_MeshPt_Int32_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0007E64C File Offset: 0x0007C84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60268, XrefRangeEnd = 60283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DuplicateVerts(NativeSlice<MeshPt> from, NativeSlice<MeshPt> to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(from));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(to));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_DuplicateVerts_Public_Static_Void_NativeSlice_1_MeshPt_NativeSlice_1_MeshPt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0007E6A0 File Offset: 0x0007C8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60283, XrefRangeEnd = 60292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0007E6D4 File Offset: 0x0007C8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60296, RefRangeEnd = 60297, XrefRangeStart = 60292, XrefRangeEnd = 60296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CosLaw(float a, float b, float c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_CosLaw_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0007E730 File Offset: 0x0007C930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60297, XrefRangeEnd = 60302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 SnapTo(Vector2 a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_SnapTo_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0007E77C File Offset: 0x0007C97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60302, XrefRangeEnd = 60303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RndTo(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_RndTo_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0007E7C8 File Offset: 0x0007C9C8
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 60312, RefRangeEnd = 60373, XrefRangeStart = 60303, XrefRangeEnd = 60312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToAng(Vector2 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_ToAng_Public_Static_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0007E808 File Offset: 0x0007CA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60373, XrefRangeEnd = 60382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToAng(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_ToAng_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0007E854 File Offset: 0x0007CA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60382, XrefRangeEnd = 60383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToAngNoDegreed(Vector2 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_ToAngNoDegreed_Public_Static_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0007E894 File Offset: 0x0007CA94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60387, RefRangeEnd = 60389, XrefRangeStart = 60383, XrefRangeEnd = 60387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToAng(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_ToAng_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0007E8E0 File Offset: 0x0007CAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60389, XrefRangeEnd = 60395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 AddDegrees(Vector2 a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_AddDegrees_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0007E92C File Offset: 0x0007CB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60395, XrefRangeEnd = 60397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ToVect(float a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_ToVect_Public_Static_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0007E96C File Offset: 0x0007CB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60397, XrefRangeEnd = 60399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ToVect3(float a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_ToVect3_Public_Static_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0007E9AC File Offset: 0x0007CBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60399, XrefRangeEnd = 60403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float MoveTowardClockwise(float a, float b, float dist)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_MoveTowardClockwise_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0007EA08 File Offset: 0x0007CC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60403, XrefRangeEnd = 60407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float MoveTowardAntiClockwise(float a, float b, float dist)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_MoveTowardAntiClockwise_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0007EA64 File Offset: 0x0007CC64
		[CallerCount(0)]
		public unsafe static float fastabs(float x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_fastabs_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0007EAA4 File Offset: 0x0007CCA4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 60421, RefRangeEnd = 60430, XrefRangeStart = 60407, XrefRangeEnd = 60421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float AngDist(float ang0, float ang1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ang0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ang1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_AngDist_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0007EAF0 File Offset: 0x0007CCF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60436, RefRangeEnd = 60438, XrefRangeStart = 60430, XrefRangeEnd = 60436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 MidPoint(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_MidPoint_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0007EB3C File Offset: 0x0007CD3C
		[CallerCount(0)]
		public unsafe static Vector3 ToV3(Vector2 v2)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0007EB7C File Offset: 0x0007CD7C
		[CallerCount(0)]
		public unsafe static Vector2 ToV2(Vector3 v3)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v3;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_ToV2_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0007EBBC File Offset: 0x0007CDBC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 60447, RefRangeEnd = 60455, XrefRangeStart = 60438, XrefRangeEnd = 60447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Angle(Vector2 v0, Vector2 v1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0007EC08 File Offset: 0x0007CE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60455, XrefRangeEnd = 60456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float AngleNoDegreed(Vector2 v0, Vector2 v1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_AngleNoDegreed_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0007EC54 File Offset: 0x0007CE54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60477, RefRangeEnd = 60479, XrefRangeStart = 60456, XrefRangeEnd = 60477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Angle(GameObject a, GameObject b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_Angle_Public_Static_Single_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0007ECA8 File Offset: 0x0007CEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60479, XrefRangeEnd = 60484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0007ED04 File Offset: 0x0007CF04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 60575, RefRangeEnd = 60579, XrefRangeStart = 60484, XrefRangeEnd = 60575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StringifyTime(float time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_StringifyTime_Public_Static_String_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0007ED3C File Offset: 0x0007CF3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 60598, RefRangeEnd = 60601, XrefRangeStart = 60579, XrefRangeEnd = 60598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBetween(float a, float b, float c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_IsBetween_Public_Static_Boolean_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0007ED98 File Offset: 0x0007CF98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60616, RefRangeEnd = 60617, XrefRangeStart = 60601, XrefRangeEnd = 60616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBetweenNoDegreed(float a, float b, float c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_IsBetweenNoDegreed_Public_Static_Boolean_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0007EDF4 File Offset: 0x0007CFF4
		[CallerCount(0)]
		public unsafe static bool IsNumBetween(float a, float b, float c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_IsNumBetween_Public_Static_Boolean_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0007EE50 File Offset: 0x0007D050
		[CallerCount(0)]
		public unsafe static int Mod(int x, int m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x0007EE9C File Offset: 0x0007D09C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 60629, RefRangeEnd = 60652, XrefRangeStart = 60617, XrefRangeEnd = 60629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Mod(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_Mod_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x0007EEE8 File Offset: 0x0007D0E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 60656, RefRangeEnd = 60662, XrefRangeStart = 60652, XrefRangeEnd = 60656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Degreed(float a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_Degreed_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0007EF28 File Offset: 0x0007D128
		[CallerCount(0)]
		public unsafe static bool IsLeft(Vector2 a, Vector2 b, Vector2 c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_IsLeft_Public_Static_Boolean_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x0007EF84 File Offset: 0x0007D184
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 60664, RefRangeEnd = 60670, XrefRangeStart = 60662, XrefRangeEnd = 60664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 PerpVectL(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_PerpVectL_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0007EFD0 File Offset: 0x0007D1D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 60672, RefRangeEnd = 60677, XrefRangeStart = 60670, XrefRangeEnd = 60672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 PerpVectR(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_PerpVectR_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0007F01C File Offset: 0x0007D21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60677, XrefRangeEnd = 60679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 PerpVect(Vector2 v, bool right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_PerpVect_Public_Static_Vector3_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0007F068 File Offset: 0x0007D268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60679, XrefRangeEnd = 60686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 PerpVect(Vector2 a, Vector2 b, bool right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_PerpVect_Public_Static_Vector2_Vector2_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0007F0C4 File Offset: 0x0007D2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60686, XrefRangeEnd = 60701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SideMostIndex(Il2CppStructArray<Vector3> vts, Vector2 viewPos, Vector2 myPos, bool right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref myPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_SideMostIndex_Public_Static_Int32_Il2CppStructArray_1_Vector3_Vector2_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0007F130 File Offset: 0x0007D330
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 60724, RefRangeEnd = 60732, XrefRangeStart = 60701, XrefRangeEnd = 60724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SideMost(Il2CppStructArray<Vector3> vts, Vector2 viewPos, Vector2 myPos, bool right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref myPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_SideMost_Public_Static_Vector3_Il2CppStructArray_1_Vector3_Vector2_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0007F19C File Offset: 0x0007D39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60732, XrefRangeEnd = 60773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SideMost(MeshFilter msh, Vector2 viewPos, Vector2 myPos, bool right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref myPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_SideMost_Public_Static_Vector3_MeshFilter_Vector2_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0007F208 File Offset: 0x0007D408
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 60788, RefRangeEnd = 60792, XrefRangeStart = 60773, XrefRangeEnd = 60788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 SideMost(Il2CppStructArray<Vector2> vts, Vector2 viewPos, Vector2 myPos, bool right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref myPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_SideMost_Public_Static_Vector2_Il2CppStructArray_1_Vector2_Vector2_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0007F274 File Offset: 0x0007D474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60792, XrefRangeEnd = 60807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SideMostIndex(Il2CppStructArray<Vector2> vts, Vector2 viewPos, Vector2 myPos, bool right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref myPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_SideMostIndex_Public_Static_Int32_Il2CppStructArray_1_Vector2_Vector2_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0007F2E0 File Offset: 0x0007D4E0
		[CallerCount(0)]
		public unsafe static Vector2 ClosestPoint(Vector2 v0, Vector2 v1, Vector2 v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_ClosestPoint_Public_Static_Vector2_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0007F33C File Offset: 0x0007D53C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60817, RefRangeEnd = 60819, XrefRangeStart = 60807, XrefRangeEnd = 60817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 LineLineIntersection(Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref linePoint1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineVec1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePoint2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineVec2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr_LineLineIntersection_Public_Static_Vector2_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0007F3A4 File Offset: 0x0007D5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Geo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Geo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x000128B4 File Offset: 0x00010AB4
		public Geo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0007F3E0 File Offset: 0x0007D5E0
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x000128BD File Offset: 0x00010ABD
		public unsafe static List<Vector3> vct3List
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Geo.NativeFieldInfoPtr_vct3List, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Geo.NativeFieldInfoPtr_vct3List, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x0007F408 File Offset: 0x0007D608
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x000128CF File Offset: 0x00010ACF
		public unsafe static Vector3 pt
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(Geo.NativeFieldInfoPtr_pt, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Geo.NativeFieldInfoPtr_pt, (void*)(&value));
			}
		}

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeFieldInfoPtr_vct3List;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeFieldInfoPtr_pt;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_SetVert_Public_Static_Void_NativeSlice_1_MeshPt_Int32_Vector3_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateVerts_Public_Static_Void_NativeSlice_1_MeshPt_NativeSlice_1_MeshPt_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_CosLaw_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_SnapTo_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_RndTo_Public_Static_Single_Single_Single_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_ToAng_Public_Static_Single_Vector2_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_ToAng_Public_Static_Single_Single_Single_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_ToAngNoDegreed_Public_Static_Single_Vector2_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_ToAng_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_AddDegrees_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_ToVect_Public_Static_Vector2_Single_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_ToVect3_Public_Static_Vector3_Single_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_MoveTowardClockwise_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_MoveTowardAntiClockwise_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_fastabs_Public_Static_Single_Single_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr_AngDist_Public_Static_Single_Single_Single_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr_MidPoint_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Vector2_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_ToV2_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_AngleNoDegreed_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_GameObject_GameObject_0;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_StringifyTime_Public_Static_String_Single_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr_IsBetween_Public_Static_Boolean_Single_Single_Single_0;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_IsBetweenNoDegreed_Public_Static_Boolean_Single_Single_Single_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_IsNumBetween_Public_Static_Boolean_Single_Single_Single_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr_Mod_Public_Static_Single_Single_Single_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr_Degreed_Public_Static_Single_Single_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr_IsLeft_Public_Static_Boolean_Vector2_Vector2_Vector2_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr_PerpVectL_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr_PerpVectR_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr_PerpVect_Public_Static_Vector3_Vector2_Boolean_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr_PerpVect_Public_Static_Vector2_Vector2_Vector2_Boolean_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_SideMostIndex_Public_Static_Int32_Il2CppStructArray_1_Vector3_Vector2_Vector2_Boolean_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr_SideMost_Public_Static_Vector3_Il2CppStructArray_1_Vector3_Vector2_Vector2_Boolean_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr_SideMost_Public_Static_Vector3_MeshFilter_Vector2_Vector2_Boolean_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_SideMost_Public_Static_Vector2_Il2CppStructArray_1_Vector2_Vector2_Vector2_Boolean_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr_SideMostIndex_Public_Static_Int32_Il2CppStructArray_1_Vector2_Vector2_Vector2_Boolean_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr_ClosestPoint_Public_Static_Vector2_Vector2_Vector2_Vector2_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_LineLineIntersection_Public_Static_Vector2_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
