using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200004C RID: 76
	public class SECTR_Hull : MonoBehaviour
	{
		// Token: 0x06000B1E RID: 2846 RVA: 0x000552E4 File Offset: 0x000534E4
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_Hull()
		{
			Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_Hull");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr);
			SECTR_Hull.NativeFieldInfoPtr_previousMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, "previousMesh");
			SECTR_Hull.NativeFieldInfoPtr_vertsCW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, "vertsCW");
			SECTR_Hull.NativeFieldInfoPtr_meshCentroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, "meshCentroid");
			SECTR_Hull.NativeFieldInfoPtr_meshNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, "meshNormal");
			SECTR_Hull.NativeFieldInfoPtr_HullMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, "HullMesh");
			SECTR_Hull.NativeMethodInfoPtr_get_VertsCW_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, 100664232);
			SECTR_Hull.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, 100664233);
			SECTR_Hull.NativeMethodInfoPtr_get_ReverseNormal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, 100664234);
			SECTR_Hull.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, 100664235);
			SECTR_Hull.NativeMethodInfoPtr_get_HullPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, 100664236);
			SECTR_Hull.NativeMethodInfoPtr_get_ReverseHullPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, 100664237);
			SECTR_Hull.NativeMethodInfoPtr_get_BoundingBox_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, 100664238);
			SECTR_Hull.NativeMethodInfoPtr_IsPointInHull_Public_Boolean_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, 100664239);
			SECTR_Hull.NativeMethodInfoPtr_ComputeVerts_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, 100664240);
			SECTR_Hull.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, 100664241);
			SECTR_Hull.NativeMethodInfoPtr__ComputeVerts_b__20_0_Private_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr, 100664242);
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00055454 File Offset: 0x00053654
		public unsafe Il2CppStructArray<Vector3> VertsCW
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41102, XrefRangeEnd = 41103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Hull.NativeMethodInfoPtr_get_VertsCW_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00055494 File Offset: 0x00053694
		public unsafe Vector3 Normal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41103, XrefRangeEnd = 41109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Hull.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x000554D0 File Offset: 0x000536D0
		public unsafe Vector3 ReverseNormal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41109, XrefRangeEnd = 41115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Hull.NativeMethodInfoPtr_get_ReverseNormal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0005550C File Offset: 0x0005370C
		public unsafe Vector3 Center
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 41120, RefRangeEnd = 41124, XrefRangeStart = 41115, XrefRangeEnd = 41120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Hull.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00055548 File Offset: 0x00053748
		public unsafe Plane HullPlane
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41133, RefRangeEnd = 41134, XrefRangeStart = 41124, XrefRangeEnd = 41133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Hull.NativeMethodInfoPtr_get_HullPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x00055584 File Offset: 0x00053784
		public unsafe Plane ReverseHullPlane
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41143, RefRangeEnd = 41144, XrefRangeStart = 41134, XrefRangeEnd = 41143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Hull.NativeMethodInfoPtr_get_ReverseHullPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x000555C0 File Offset: 0x000537C0
		public unsafe Bounds BoundingBox
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41160, RefRangeEnd = 41161, XrefRangeStart = 41144, XrefRangeEnd = 41160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Hull.NativeMethodInfoPtr_get_BoundingBox_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x000555FC File Offset: 0x000537FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41169, RefRangeEnd = 41170, XrefRangeStart = 41161, XrefRangeEnd = 41169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInHull(Vector3 p, float distanceTolerance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceTolerance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Hull.NativeMethodInfoPtr_IsPointInHull_Public_Boolean_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00055654 File Offset: 0x00053854
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 41269, RefRangeEnd = 41279, XrefRangeStart = 41170, XrefRangeEnd = 41269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeVerts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Hull.NativeMethodInfoPtr_ComputeVerts_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00055688 File Offset: 0x00053888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41279, XrefRangeEnd = 41286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_Hull()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_Hull>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Hull.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x000556C4 File Offset: 0x000538C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41286, XrefRangeEnd = 41288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _ComputeVerts_b__20_0(Vector3 a, Vector3 b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Hull.NativeMethodInfoPtr__ComputeVerts_b__20_0_Private_Int32_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00008E61 File Offset: 0x00007061
		public SECTR_Hull(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0005571C File Offset: 0x0005391C
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x00008E6A File Offset: 0x0000706A
		public unsafe Mesh previousMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Hull.NativeFieldInfoPtr_previousMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Hull.NativeFieldInfoPtr_previousMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0005574C File Offset: 0x0005394C
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x00008E89 File Offset: 0x00007089
		public unsafe Il2CppStructArray<Vector3> vertsCW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Hull.NativeFieldInfoPtr_vertsCW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Hull.NativeFieldInfoPtr_vertsCW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0005577C File Offset: 0x0005397C
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x00008EA8 File Offset: 0x000070A8
		public unsafe Vector3 meshCentroid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Hull.NativeFieldInfoPtr_meshCentroid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Hull.NativeFieldInfoPtr_meshCentroid)) = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x000557A4 File Offset: 0x000539A4
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00008EC3 File Offset: 0x000070C3
		public unsafe Vector3 meshNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Hull.NativeFieldInfoPtr_meshNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Hull.NativeFieldInfoPtr_meshNormal)) = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x000557CC File Offset: 0x000539CC
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00008EDE File Offset: 0x000070DE
		public unsafe Mesh HullMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Hull.NativeFieldInfoPtr_HullMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Hull.NativeFieldInfoPtr_HullMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr_previousMesh;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr_vertsCW;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr_meshCentroid;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_meshNormal;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr_HullMesh;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_get_VertsCW_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_get_ReverseNormal_Public_get_Vector3_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_get_HullPlane_Public_get_Plane_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_get_ReverseHullPlane_Public_get_Plane_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_get_BoundingBox_Public_get_Bounds_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInHull_Public_Boolean_Vector3_Single_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_ComputeVerts_Protected_Void_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr__ComputeVerts_b__20_0_Private_Int32_Vector3_Vector3_0;
	}
}
