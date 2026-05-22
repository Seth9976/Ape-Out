using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x0200016F RID: 367
	public sealed class BatchCullingContext : ValueType
	{
		// Token: 0x06001BA9 RID: 7081 RVA: 0x00067BB0 File Offset: 0x00065DB0
		// Note: this type is marked as 'beforefieldinit'.
		static BatchCullingContext()
		{
			Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchCullingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr);
			BatchCullingContext.NativeFieldInfoPtr_cullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingPlanes");
			BatchCullingContext.NativeFieldInfoPtr_batchVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "batchVisibility");
			BatchCullingContext.NativeFieldInfoPtr_visibleIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "visibleIndices");
			BatchCullingContext.NativeFieldInfoPtr_visibleIndicesY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "visibleIndicesY");
			BatchCullingContext.NativeFieldInfoPtr_lodParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "lodParameters");
			BatchCullingContext.NativeFieldInfoPtr_cullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingMatrix");
			BatchCullingContext.NativeFieldInfoPtr_nearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "nearPlane");
			BatchCullingContext.NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_BatchVisibility_NativeArray_1_Int32_NativeArray_1_Int32_LODParameters_Matrix4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, 100665800);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00067C80 File Offset: 0x00065E80
		[CallerCount(0)]
		public unsafe BatchCullingContext(Unity.Collections.NativeArray<Plane> inCullingPlanes, Unity.Collections.NativeArray<BatchVisibility> inOutBatchVisibility, Unity.Collections.NativeArray<int> outVisibleIndices, Unity.Collections.NativeArray<int> outVisibleIndicesY, LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inCullingPlanes));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inOutBatchVisibility));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(outVisibleIndices));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(outVisibleIndicesY));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLodParameters;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inCullingMatrix;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inNearPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchCullingContext.NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_BatchVisibility_NativeArray_1_Int32_NativeArray_1_Int32_LODParameters_Matrix4x4_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0000ECE2 File Offset: 0x0000CEE2
		public BatchCullingContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0000ECEB File Offset: 0x0000CEEB
		public BatchCullingContext()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr))
		{
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x00067D48 File Offset: 0x00065F48
		// (set) Token: 0x06001BAE RID: 7086 RVA: 0x0000ECFD File Offset: 0x0000CEFD
		public Unity.Collections.NativeArray<Plane> cullingPlanes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingPlanes);
				return new Unity.Collections.NativeArray<Plane>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<Plane>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingPlanes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<Plane>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x00067D78 File Offset: 0x00065F78
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x0000ED2B File Offset: 0x0000CF2B
		public Unity.Collections.NativeArray<BatchVisibility> batchVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_batchVisibility);
				return new Unity.Collections.NativeArray<BatchVisibility>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<BatchVisibility>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_batchVisibility), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<BatchVisibility>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x00067DA8 File Offset: 0x00065FA8
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x0000ED59 File Offset: 0x0000CF59
		public Unity.Collections.NativeArray<int> visibleIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_visibleIndices);
				return new Unity.Collections.NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_visibleIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x00067DD8 File Offset: 0x00065FD8
		// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x0000ED87 File Offset: 0x0000CF87
		public Unity.Collections.NativeArray<int> visibleIndicesY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_visibleIndicesY);
				return new Unity.Collections.NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_visibleIndicesY), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x00067E08 File Offset: 0x00066008
		// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x0000EDB5 File Offset: 0x0000CFB5
		public unsafe LODParameters lodParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_lodParameters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_lodParameters)) = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x00067E30 File Offset: 0x00066030
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x0000EDD0 File Offset: 0x0000CFD0
		public unsafe Matrix4x4 cullingMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingMatrix)) = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00067E58 File Offset: 0x00066058
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x0000EDEB File Offset: 0x0000CFEB
		public unsafe float nearPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_nearPlane);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_nearPlane)) = value;
			}
		}

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlanes;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeFieldInfoPtr_batchVisibility;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeFieldInfoPtr_visibleIndices;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeFieldInfoPtr_visibleIndicesY;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeFieldInfoPtr_lodParameters;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeFieldInfoPtr_cullingMatrix;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeFieldInfoPtr_nearPlane;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_BatchVisibility_NativeArray_1_Int32_NativeArray_1_Int32_LODParameters_Matrix4x4_Single_0;
	}
}
