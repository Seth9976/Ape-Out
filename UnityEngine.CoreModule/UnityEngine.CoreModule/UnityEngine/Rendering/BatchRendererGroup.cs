using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	// Token: 0x02000171 RID: 369
	public class BatchRendererGroup : Object
	{
		// Token: 0x06001BBD RID: 7101 RVA: 0x00067F78 File Offset: 0x00066178
		// Note: this type is marked as 'beforefieldinit'.
		static BatchRendererGroup()
		{
			Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchRendererGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr);
			BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "m_GroupHandle");
			BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "m_PerformCulling");
			BatchRendererGroup.NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100665801);
			BatchRendererGroup.SetBatchFlagsDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetBatchFlagsDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetBatchFlags");
			BatchRendererGroup.InternalSetBatchPropertyMetadataDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.InternalSetBatchPropertyMetadataDelegate>("UnityEngine.Rendering.BatchRendererGroup::InternalSetBatchPropertyMetadata");
			BatchRendererGroup.SetInstancingDataDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetInstancingDataDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetInstancingData");
			BatchRendererGroup.GetNumBatchesDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetNumBatchesDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetNumBatches");
			BatchRendererGroup.RemoveBatchDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RemoveBatchDelegate>("UnityEngine.Rendering.BatchRendererGroup::RemoveBatch");
			BatchRendererGroup.GetBatchMatricesDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchMatricesDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchMatrices");
			BatchRendererGroup.GetBatchScalarArrayDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchScalarArrayDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchScalarArray");
			BatchRendererGroup.GetBatchVectorArrayDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchVectorArrayDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchVectorArray");
			BatchRendererGroup.GetBatchMatrixArrayDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchMatrixArrayDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchMatrixArray");
			BatchRendererGroup.GetBatchScalarArray_InternalDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchScalarArray_InternalDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchScalarArray_Internal");
			BatchRendererGroup.GetBatchVectorArray_InternalDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchVectorArray_InternalDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchVectorArray_Internal");
			BatchRendererGroup.GetBatchMatrixArray_InternalDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchMatrixArray_InternalDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchMatrixArray_Internal");
			BatchRendererGroup.EnableVisibleIndicesYArrayDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.EnableVisibleIndicesYArrayDelegate>("UnityEngine.Rendering.BatchRendererGroup::EnableVisibleIndicesYArray");
			BatchRendererGroup.CreateDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.CreateDelegate>("UnityEngine.Rendering.BatchRendererGroup::Create");
			BatchRendererGroup.DestroyDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.DestroyDelegate>("UnityEngine.Rendering.BatchRendererGroup::Destroy");
			BatchRendererGroup.AddBatch_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.AddBatch_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::AddBatch_Injected");
			BatchRendererGroup.SetBatchBounds_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetBatchBounds_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetBatchBounds_Injected");
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000680E4 File Offset: 0x000662E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502972, XrefRangeEnd = 502979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lodParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0000EE18 File Offset: 0x0000D018
		public BatchRendererGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x00068138 File Offset: 0x00066338
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x0000EE21 File Offset: 0x0000D021
		public unsafe IntPtr m_GroupHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle)) = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00068160 File Offset: 0x00066360
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x0000EE3C File Offset: 0x0000D03C
		public unsafe BatchRendererGroup.OnPerformCulling m_PerformCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchRendererGroup.OnPerformCulling>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0000EE5B File Offset: 0x0000D05B
		public void Dispose()
		{
			BatchRendererGroup.Destroy(this.m_GroupHandle);
			this.m_GroupHandle = IntPtr.Zero;
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00068190 File Offset: 0x00066390
		public int AddBatch(Mesh mesh, int subMeshIndex, Material material, int layer, ShadowCastingMode castShadows, bool receiveShadows, bool invertCulling, Bounds bounds, int instanceCount, MaterialPropertyBlock customProps, GameObject associatedSceneObject)
		{
			return this.AddBatch(mesh, subMeshIndex, material, layer, castShadows, receiveShadows, invertCulling, bounds, instanceCount, customProps, associatedSceneObject, 9223372036854775808UL, uint.MaxValue);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000681C8 File Offset: 0x000663C8
		public int AddBatch(Mesh mesh, int subMeshIndex, Material material, int layer, ShadowCastingMode castShadows, bool receiveShadows, bool invertCulling, Bounds bounds, int instanceCount, MaterialPropertyBlock customProps, GameObject associatedSceneObject, ulong sceneCullingMask)
		{
			return this.AddBatch(mesh, subMeshIndex, material, layer, castShadows, receiveShadows, invertCulling, bounds, instanceCount, customProps, associatedSceneObject, sceneCullingMask, uint.MaxValue);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000681F8 File Offset: 0x000663F8
		public int AddBatch(Mesh mesh, int subMeshIndex, Material material, int layer, ShadowCastingMode castShadows, bool receiveShadows, bool invertCulling, Bounds bounds, int instanceCount, MaterialPropertyBlock customProps, GameObject associatedSceneObject, ulong sceneCullingMask, uint renderingLayerMask)
		{
			return this.AddBatch_Injected(mesh, subMeshIndex, material, layer, castShadows, receiveShadows, invertCulling, ref bounds, instanceCount, customProps, associatedSceneObject, sceneCullingMask, renderingLayerMask);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0000EE75 File Offset: 0x0000D075
		public void SetBatchFlags(int batchIndex, ulong flags)
		{
			BatchRendererGroup.SetBatchFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, flags);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0000EE89 File Offset: 0x0000D089
		public void SetBatchPropertyMetadata(int batchIndex, Unity.Collections.NativeArray<int> cbufferLengths, Unity.Collections.NativeArray<int> cbufferMetadata)
		{
			this.InternalSetBatchPropertyMetadata(batchIndex, (IntPtr)cbufferLengths.GetUnsafeReadOnlyPtr<int>(), cbufferLengths.Length, (IntPtr)cbufferMetadata.GetUnsafeReadOnlyPtr<int>(), cbufferMetadata.Length);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0000EEB8 File Offset: 0x0000D0B8
		public void InternalSetBatchPropertyMetadata(int batchIndex, IntPtr cbufferLengths, int cbufferLengthsCount, IntPtr cbufferMetadata, int cbufferMetadataCount)
		{
			BatchRendererGroup.InternalSetBatchPropertyMetadataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, cbufferLengths, cbufferLengthsCount, cbufferMetadata, cbufferMetadataCount);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0000EED1 File Offset: 0x0000D0D1
		public void SetInstancingData(int batchIndex, int instanceCount, MaterialPropertyBlock customProps)
		{
			BatchRendererGroup.SetInstancingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(customProps));
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00068224 File Offset: 0x00066424
		public unsafe Unity.Collections.NativeArray<Matrix4x4> GetBatchMatrices(int batchIndex)
		{
			int num = 0;
			void* batchMatrices = this.GetBatchMatrices(batchIndex, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>(batchMatrices, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0006824C File Offset: 0x0006644C
		public unsafe Unity.Collections.NativeArray<int> GetBatchScalarArrayInt(int batchIndex, string propertyName)
		{
			int num = 0;
			void* batchScalarArray = this.GetBatchScalarArray(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>(batchScalarArray, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00068278 File Offset: 0x00066478
		public unsafe Unity.Collections.NativeArray<float> GetBatchScalarArray(int batchIndex, string propertyName)
		{
			int num = 0;
			void* batchScalarArray = this.GetBatchScalarArray(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float>(batchScalarArray, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x000682A4 File Offset: 0x000664A4
		public unsafe Unity.Collections.NativeArray<int> GetBatchVectorArrayInt(int batchIndex, string propertyName)
		{
			int num = 0;
			void* batchVectorArray = this.GetBatchVectorArray(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>(batchVectorArray, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x000682D0 File Offset: 0x000664D0
		public unsafe Unity.Collections.NativeArray<Vector4> GetBatchVectorArray(int batchIndex, string propertyName)
		{
			int num = 0;
			void* batchVectorArray = this.GetBatchVectorArray(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector4>(batchVectorArray, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x000682FC File Offset: 0x000664FC
		public unsafe Unity.Collections.NativeArray<Matrix4x4> GetBatchMatrixArray(int batchIndex, string propertyName)
		{
			int num = 0;
			void* batchMatrixArray = this.GetBatchMatrixArray(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>(batchMatrixArray, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00068328 File Offset: 0x00066528
		public unsafe Unity.Collections.NativeArray<int> GetBatchScalarArrayInt(int batchIndex, int propertyName)
		{
			int num = 0;
			void* batchScalarArray_Internal = this.GetBatchScalarArray_Internal(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>(batchScalarArray_Internal, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00068354 File Offset: 0x00066554
		public unsafe Unity.Collections.NativeArray<float> GetBatchScalarArray(int batchIndex, int propertyName)
		{
			int num = 0;
			void* batchScalarArray_Internal = this.GetBatchScalarArray_Internal(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float>(batchScalarArray_Internal, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00068380 File Offset: 0x00066580
		public unsafe Unity.Collections.NativeArray<int> GetBatchVectorArrayInt(int batchIndex, int propertyName)
		{
			int num = 0;
			void* batchVectorArray_Internal = this.GetBatchVectorArray_Internal(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>(batchVectorArray_Internal, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x000683AC File Offset: 0x000665AC
		public unsafe Unity.Collections.NativeArray<Vector4> GetBatchVectorArray(int batchIndex, int propertyName)
		{
			int num = 0;
			void* batchVectorArray_Internal = this.GetBatchVectorArray_Internal(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector4>(batchVectorArray_Internal, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x000683D8 File Offset: 0x000665D8
		public unsafe Unity.Collections.NativeArray<Matrix4x4> GetBatchMatrixArray(int batchIndex, int propertyName)
		{
			int num = 0;
			void* batchMatrixArray_Internal = this.GetBatchMatrixArray_Internal(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>(batchMatrixArray_Internal, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0000EEEB File Offset: 0x0000D0EB
		public void SetBatchBounds(int batchIndex, Bounds bounds)
		{
			this.SetBatchBounds_Injected(batchIndex, ref bounds);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0000EEF6 File Offset: 0x0000D0F6
		public int GetNumBatches()
		{
			return BatchRendererGroup.GetNumBatchesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0000EF08 File Offset: 0x0000D108
		public void RemoveBatch(int index)
		{
			BatchRendererGroup.RemoveBatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0000EF1B File Offset: 0x0000D11B
		public unsafe void* GetBatchMatrices(int batchIndex, out int matrixCount)
		{
			return BatchRendererGroup.GetBatchMatricesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, out matrixCount);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0000EF2F File Offset: 0x0000D12F
		public unsafe void* GetBatchScalarArray(int batchIndex, string propertyName, out int elementCount)
		{
			return BatchRendererGroup.GetBatchScalarArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, IL2CPP.ManagedStringToIl2Cpp(propertyName), out elementCount);
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0000EF49 File Offset: 0x0000D149
		public unsafe void* GetBatchVectorArray(int batchIndex, string propertyName, out int elementCount)
		{
			return BatchRendererGroup.GetBatchVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, IL2CPP.ManagedStringToIl2Cpp(propertyName), out elementCount);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0000EF63 File Offset: 0x0000D163
		public unsafe void* GetBatchMatrixArray(int batchIndex, string propertyName, out int elementCount)
		{
			return BatchRendererGroup.GetBatchMatrixArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, IL2CPP.ManagedStringToIl2Cpp(propertyName), out elementCount);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0000EF7D File Offset: 0x0000D17D
		public unsafe void* GetBatchScalarArray_Internal(int batchIndex, int propertyName, out int elementCount)
		{
			return BatchRendererGroup.GetBatchScalarArray_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, propertyName, out elementCount);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0000EF92 File Offset: 0x0000D192
		public unsafe void* GetBatchVectorArray_Internal(int batchIndex, int propertyName, out int elementCount)
		{
			return BatchRendererGroup.GetBatchVectorArray_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, propertyName, out elementCount);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0000EFA7 File Offset: 0x0000D1A7
		public unsafe void* GetBatchMatrixArray_Internal(int batchIndex, int propertyName, out int elementCount)
		{
			return BatchRendererGroup.GetBatchMatrixArray_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, propertyName, out elementCount);
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0000EFBC File Offset: 0x0000D1BC
		public void EnableVisibleIndicesYArray(bool enabled)
		{
			BatchRendererGroup.EnableVisibleIndicesYArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), enabled);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0000EFCF File Offset: 0x0000D1CF
		public static IntPtr Create(BatchRendererGroup group)
		{
			return BatchRendererGroup.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(group));
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0000EFE1 File Offset: 0x0000D1E1
		public static void Destroy(IntPtr groupHandle)
		{
			BatchRendererGroup.DestroyDelegateField(groupHandle);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00068404 File Offset: 0x00066604
		public int AddBatch_Injected(Mesh mesh, int subMeshIndex, Material material, int layer, ShadowCastingMode castShadows, bool receiveShadows, bool invertCulling, ref Bounds bounds, int instanceCount, MaterialPropertyBlock customProps, GameObject associatedSceneObject, ulong sceneCullingMask, uint renderingLayerMask)
		{
			return BatchRendererGroup.AddBatch_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), subMeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), layer, castShadows, receiveShadows, invertCulling, ref bounds, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(customProps), IL2CPP.Il2CppObjectBaseToPtr(associatedSceneObject), sceneCullingMask, renderingLayerMask);
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0000EFEE File Offset: 0x0000D1EE
		public void SetBatchBounds_Injected(int batchIndex, ref Bounds bounds)
		{
			BatchRendererGroup.SetBatchBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, ref bounds);
		}

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeFieldInfoPtr_m_GroupHandle;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeFieldInfoPtr_m_PerformCulling;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_0;

		// Token: 0x040015A3 RID: 5539
		private static readonly BatchRendererGroup.SetBatchFlagsDelegate SetBatchFlagsDelegateField;

		// Token: 0x040015A4 RID: 5540
		private static readonly BatchRendererGroup.InternalSetBatchPropertyMetadataDelegate InternalSetBatchPropertyMetadataDelegateField;

		// Token: 0x040015A5 RID: 5541
		private static readonly BatchRendererGroup.SetInstancingDataDelegate SetInstancingDataDelegateField;

		// Token: 0x040015A6 RID: 5542
		private static readonly BatchRendererGroup.GetNumBatchesDelegate GetNumBatchesDelegateField;

		// Token: 0x040015A7 RID: 5543
		private static readonly BatchRendererGroup.RemoveBatchDelegate RemoveBatchDelegateField;

		// Token: 0x040015A8 RID: 5544
		private static readonly BatchRendererGroup.GetBatchMatricesDelegate GetBatchMatricesDelegateField;

		// Token: 0x040015A9 RID: 5545
		private static readonly BatchRendererGroup.GetBatchScalarArrayDelegate GetBatchScalarArrayDelegateField;

		// Token: 0x040015AA RID: 5546
		private static readonly BatchRendererGroup.GetBatchVectorArrayDelegate GetBatchVectorArrayDelegateField;

		// Token: 0x040015AB RID: 5547
		private static readonly BatchRendererGroup.GetBatchMatrixArrayDelegate GetBatchMatrixArrayDelegateField;

		// Token: 0x040015AC RID: 5548
		private static readonly BatchRendererGroup.GetBatchScalarArray_InternalDelegate GetBatchScalarArray_InternalDelegateField;

		// Token: 0x040015AD RID: 5549
		private static readonly BatchRendererGroup.GetBatchVectorArray_InternalDelegate GetBatchVectorArray_InternalDelegateField;

		// Token: 0x040015AE RID: 5550
		private static readonly BatchRendererGroup.GetBatchMatrixArray_InternalDelegate GetBatchMatrixArray_InternalDelegateField;

		// Token: 0x040015AF RID: 5551
		private static readonly BatchRendererGroup.EnableVisibleIndicesYArrayDelegate EnableVisibleIndicesYArrayDelegateField;

		// Token: 0x040015B0 RID: 5552
		private static readonly BatchRendererGroup.CreateDelegate CreateDelegateField;

		// Token: 0x040015B1 RID: 5553
		private static readonly BatchRendererGroup.DestroyDelegate DestroyDelegateField;

		// Token: 0x040015B2 RID: 5554
		private static readonly BatchRendererGroup.AddBatch_InjectedDelegate AddBatch_InjectedDelegateField;

		// Token: 0x040015B3 RID: 5555
		private static readonly BatchRendererGroup.SetBatchBounds_InjectedDelegate SetBatchBounds_InjectedDelegateField;

		// Token: 0x020009C4 RID: 2500
		public sealed class OnPerformCulling : MulticastDelegate
		{
			// Token: 0x0600321C RID: 12828 RVA: 0x0007F510 File Offset: 0x0007D710
			// Note: this type is marked as 'beforefieldinit'.
			static OnPerformCulling()
			{
				Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "OnPerformCulling");
				BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr, 100665802);
				BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr, 100665803);
				BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BatchRendererGroup_BatchCullingContext_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr, 100665804);
				BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_JobHandle_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr, 100665805);
			}

			// Token: 0x0600321D RID: 12829 RVA: 0x0007F584 File Offset: 0x0007D784
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnPerformCulling(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600321E RID: 12830 RVA: 0x0007F5E0 File Offset: 0x0007D7E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 502967, RefRangeEnd = 502968, XrefRangeStart = 502967, XrefRangeEnd = 502967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Unity.Jobs.JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererGroup);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cullingContext));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600321F RID: 12831 RVA: 0x0007F644 File Offset: 0x0007D844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502968, XrefRangeEnd = 502972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererGroup);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cullingContext));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BatchRendererGroup_BatchCullingContext_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06003220 RID: 12832 RVA: 0x0007F6D0 File Offset: 0x0007D8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Unity.Jobs.JobHandle EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_JobHandle_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003221 RID: 12833 RVA: 0x000156A4 File Offset: 0x000138A4
			public OnPerformCulling(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003222 RID: 12834 RVA: 0x000156AD File Offset: 0x000138AD
			public static implicit operator BatchRendererGroup.OnPerformCulling(Func<BatchRendererGroup, BatchCullingContext, Unity.Jobs.JobHandle> A_0)
			{
				return DelegateSupport.ConvertDelegate<BatchRendererGroup.OnPerformCulling>(A_0);
			}

			// Token: 0x06003223 RID: 12835 RVA: 0x000156B5 File Offset: 0x000138B5
			public static BatchRendererGroup.OnPerformCulling operator +(BatchRendererGroup.OnPerformCulling A_0, BatchRendererGroup.OnPerformCulling A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<BatchRendererGroup.OnPerformCulling>();
			}

			// Token: 0x06003224 RID: 12836 RVA: 0x000156C3 File Offset: 0x000138C3
			public static BatchRendererGroup.OnPerformCulling operator -(BatchRendererGroup.OnPerformCulling A_0, BatchRendererGroup.OnPerformCulling A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<BatchRendererGroup.OnPerformCulling>();
				}
				return delegate2;
			}

			// Token: 0x04001FC2 RID: 8130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001FC3 RID: 8131
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_0;

			// Token: 0x04001FC4 RID: 8132
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BatchRendererGroup_BatchCullingContext_AsyncCallback_Object_0;

			// Token: 0x04001FC5 RID: 8133
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_JobHandle_IAsyncResult_0;
		}

		// Token: 0x020009C5 RID: 2501
		// (Invoke) Token: 0x06003226 RID: 12838
		private delegate void SetBatchFlagsDelegate(IntPtr @this, int batchIndex, ulong flags);

		// Token: 0x020009C6 RID: 2502
		// (Invoke) Token: 0x06003228 RID: 12840
		private delegate void InternalSetBatchPropertyMetadataDelegate(IntPtr @this, int batchIndex, IntPtr cbufferLengths, int cbufferLengthsCount, IntPtr cbufferMetadata, int cbufferMetadataCount);

		// Token: 0x020009C7 RID: 2503
		// (Invoke) Token: 0x0600322A RID: 12842
		private delegate void SetInstancingDataDelegate(IntPtr @this, int batchIndex, int instanceCount, IntPtr customProps);

		// Token: 0x020009C8 RID: 2504
		// (Invoke) Token: 0x0600322C RID: 12844
		private delegate int GetNumBatchesDelegate(IntPtr @this);

		// Token: 0x020009C9 RID: 2505
		// (Invoke) Token: 0x0600322E RID: 12846
		private delegate void RemoveBatchDelegate(IntPtr @this, int index);

		// Token: 0x020009CA RID: 2506
		// (Invoke) Token: 0x06003230 RID: 12848
		private delegate IntPtr GetBatchMatricesDelegate(IntPtr @this, int batchIndex, [Out] IntPtr matrixCount);

		// Token: 0x020009CB RID: 2507
		// (Invoke) Token: 0x06003232 RID: 12850
		private delegate IntPtr GetBatchScalarArrayDelegate(IntPtr @this, int batchIndex, IntPtr propertyName, [Out] IntPtr elementCount);

		// Token: 0x020009CC RID: 2508
		// (Invoke) Token: 0x06003234 RID: 12852
		private delegate IntPtr GetBatchVectorArrayDelegate(IntPtr @this, int batchIndex, IntPtr propertyName, [Out] IntPtr elementCount);

		// Token: 0x020009CD RID: 2509
		// (Invoke) Token: 0x06003236 RID: 12854
		private delegate IntPtr GetBatchMatrixArrayDelegate(IntPtr @this, int batchIndex, IntPtr propertyName, [Out] IntPtr elementCount);

		// Token: 0x020009CE RID: 2510
		// (Invoke) Token: 0x06003238 RID: 12856
		private delegate IntPtr GetBatchScalarArray_InternalDelegate(IntPtr @this, int batchIndex, int propertyName, [Out] IntPtr elementCount);

		// Token: 0x020009CF RID: 2511
		// (Invoke) Token: 0x0600323A RID: 12858
		private delegate IntPtr GetBatchVectorArray_InternalDelegate(IntPtr @this, int batchIndex, int propertyName, [Out] IntPtr elementCount);

		// Token: 0x020009D0 RID: 2512
		// (Invoke) Token: 0x0600323C RID: 12860
		private delegate IntPtr GetBatchMatrixArray_InternalDelegate(IntPtr @this, int batchIndex, int propertyName, [Out] IntPtr elementCount);

		// Token: 0x020009D1 RID: 2513
		// (Invoke) Token: 0x0600323E RID: 12862
		private delegate void EnableVisibleIndicesYArrayDelegate(IntPtr @this, bool enabled);

		// Token: 0x020009D2 RID: 2514
		// (Invoke) Token: 0x06003240 RID: 12864
		private delegate IntPtr CreateDelegate(IntPtr group);

		// Token: 0x020009D3 RID: 2515
		// (Invoke) Token: 0x06003242 RID: 12866
		private delegate void DestroyDelegate(IntPtr groupHandle);

		// Token: 0x020009D4 RID: 2516
		// (Invoke) Token: 0x06003244 RID: 12868
		private delegate int AddBatch_InjectedDelegate(IntPtr @this, IntPtr mesh, int subMeshIndex, IntPtr material, int layer, ShadowCastingMode castShadows, bool receiveShadows, bool invertCulling, IntPtr bounds, int instanceCount, IntPtr customProps, IntPtr associatedSceneObject, ulong sceneCullingMask, uint renderingLayerMask);

		// Token: 0x020009D5 RID: 2517
		// (Invoke) Token: 0x06003246 RID: 12870
		private delegate void SetBatchBounds_InjectedDelegate(IntPtr @this, int batchIndex, IntPtr bounds);
	}
}
