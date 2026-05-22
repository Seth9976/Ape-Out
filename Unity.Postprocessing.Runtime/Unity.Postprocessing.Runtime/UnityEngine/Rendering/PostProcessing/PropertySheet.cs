using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200005F RID: 95
	public sealed class PropertySheet : Object
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x00016330 File Offset: 0x00014530
		// Note: this type is marked as 'beforefieldinit'.
		static PropertySheet()
		{
			Il2CppClassPointerStore<PropertySheet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PropertySheet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr);
			PropertySheet.NativeFieldInfoPtr__properties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr, "<properties>k__BackingField");
			PropertySheet.NativeFieldInfoPtr__material_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr, "<material>k__BackingField");
			PropertySheet.NativeMethodInfoPtr_get_properties_Public_get_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr, 100663789);
			PropertySheet.NativeMethodInfoPtr_set_properties_Private_set_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr, 100663790);
			PropertySheet.NativeMethodInfoPtr_get_material_Internal_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr, 100663791);
			PropertySheet.NativeMethodInfoPtr_set_material_Private_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr, 100663792);
			PropertySheet.NativeMethodInfoPtr__ctor_Internal_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr, 100663793);
			PropertySheet.NativeMethodInfoPtr_ClearKeywords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr, 100663794);
			PropertySheet.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr, 100663795);
			PropertySheet.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr, 100663796);
			PropertySheet.NativeMethodInfoPtr_Release_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr, 100663797);
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0001643C File Offset: 0x0001463C
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x0001647C File Offset: 0x0001467C
		public unsafe MaterialPropertyBlock properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheet.NativeMethodInfoPtr_get_properties_Public_get_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheet.NativeMethodInfoPtr_set_properties_Private_set_Void_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x000164C0 File Offset: 0x000146C0
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00016500 File Offset: 0x00014700
		public unsafe Material material
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheet.NativeMethodInfoPtr_get_material_Internal_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheet.NativeMethodInfoPtr_set_material_Private_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00016544 File Offset: 0x00014744
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 448569, RefRangeEnd = 448571, XrefRangeStart = 448564, XrefRangeEnd = 448569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertySheet(Material material)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertySheet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheet.NativeMethodInfoPtr__ctor_Internal_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00016590 File Offset: 0x00014790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 448576, RefRangeEnd = 448577, XrefRangeStart = 448571, XrefRangeEnd = 448576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearKeywords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheet.NativeMethodInfoPtr_ClearKeywords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000165C4 File Offset: 0x000147C4
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 448582, RefRangeEnd = 448606, XrefRangeStart = 448577, XrefRangeEnd = 448582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheet.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00016608 File Offset: 0x00014808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448606, XrefRangeEnd = 448611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheet.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001664C File Offset: 0x0001484C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448611, XrefRangeEnd = 448615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySheet.NativeMethodInfoPtr_Release_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00004B03 File Offset: 0x00002D03
		public PropertySheet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00016680 File Offset: 0x00014880
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00004B0C File Offset: 0x00002D0C
		public unsafe MaterialPropertyBlock _properties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySheet.NativeFieldInfoPtr__properties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySheet.NativeFieldInfoPtr__properties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x000166B0 File Offset: 0x000148B0
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00004B2B File Offset: 0x00002D2B
		public unsafe Material _material_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySheet.NativeFieldInfoPtr__material_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySheet.NativeFieldInfoPtr__material_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr__properties_k__BackingField;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeFieldInfoPtr__material_k__BackingField;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_get_properties_Public_get_MaterialPropertyBlock_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_set_properties_Private_set_Void_MaterialPropertyBlock_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Internal_get_Material_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Private_set_Void_Material_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Material_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_ClearKeywords_Public_Void_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_Release_Internal_Void_0;
	}
}
