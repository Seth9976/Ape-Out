using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000016 RID: 22
	public class ResonanceAudioMaterialMap : ScriptableObject
	{
		// Token: 0x0600034D RID: 845 RVA: 0x0003D188 File Offset: 0x0003B388
		// Note: this type is marked as 'beforefieldinit'.
		static ResonanceAudioMaterialMap()
		{
			Il2CppClassPointerStore<ResonanceAudioMaterialMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResonanceAudioMaterialMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioMaterialMap>.NativeClassPtr);
			ResonanceAudioMaterialMap.NativeFieldInfoPtr_surfaceMaterialColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioMaterialMap>.NativeClassPtr, "surfaceMaterialColors");
			ResonanceAudioMaterialMap.NativeFieldInfoPtr_surfaceMaterialFromGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioMaterialMap>.NativeClassPtr, "surfaceMaterialFromGuid");
			ResonanceAudioMaterialMap.NativeFieldInfoPtr_defaultSurfaceMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioMaterialMap>.NativeClassPtr, "defaultSurfaceMaterial");
			ResonanceAudioMaterialMap.NativeMethodInfoPtr_GuidList_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMap>.NativeClassPtr, 100663498);
			ResonanceAudioMaterialMap.NativeMethodInfoPtr_GetMaterialFromGuid_Public_SurfaceMaterial_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMap>.NativeClassPtr, 100663499);
			ResonanceAudioMaterialMap.NativeMethodInfoPtr_AddDefaultMaterialIfGuidUnmapped_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMap>.NativeClassPtr, 100663500);
			ResonanceAudioMaterialMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMap>.NativeClassPtr, 100663501);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0003D244 File Offset: 0x0003B444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33595, XrefRangeEnd = 33603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GuidList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMap.NativeMethodInfoPtr_GuidList_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0003D284 File Offset: 0x0003B484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33603, XrefRangeEnd = 33607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial GetMaterialFromGuid(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMap.NativeMethodInfoPtr_GetMaterialFromGuid_Public_SurfaceMaterial_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0003D2D4 File Offset: 0x0003B4D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33611, RefRangeEnd = 33613, XrefRangeStart = 33607, XrefRangeEnd = 33611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaultMaterialIfGuidUnmapped(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMap.NativeMethodInfoPtr_AddDefaultMaterialIfGuidUnmapped_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0003D318 File Offset: 0x0003B518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResonanceAudioMaterialMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioMaterialMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00004467 File Offset: 0x00002667
		public ResonanceAudioMaterialMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0003D354 File Offset: 0x0003B554
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00004470 File Offset: 0x00002670
		public unsafe static Il2CppStructArray<Color> surfaceMaterialColors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudioMaterialMap.NativeFieldInfoPtr_surfaceMaterialColors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudioMaterialMap.NativeFieldInfoPtr_surfaceMaterialColors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0003D37C File Offset: 0x0003B57C
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00004482 File Offset: 0x00002682
		public unsafe ResonanceAudioRoomManager.SurfaceMaterialDictionary surfaceMaterialFromGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMap.NativeFieldInfoPtr_surfaceMaterialFromGuid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceAudioRoomManager.SurfaceMaterialDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMap.NativeFieldInfoPtr_surfaceMaterialFromGuid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0003D3AC File Offset: 0x0003B5AC
		// (set) Token: 0x06000358 RID: 856 RVA: 0x000044A1 File Offset: 0x000026A1
		public unsafe static ResonanceAudioRoomManager.SurfaceMaterial defaultSurfaceMaterial
		{
			get
			{
				ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudioMaterialMap.NativeFieldInfoPtr_defaultSurfaceMaterial, (void*)(&surfaceMaterial));
				return surfaceMaterial;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudioMaterialMap.NativeFieldInfoPtr_defaultSurfaceMaterial, (void*)(&value));
			}
		}

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeFieldInfoPtr_surfaceMaterialColors;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr_surfaceMaterialFromGuid;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_defaultSurfaceMaterial;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_GuidList_Public_List_1_String_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterialFromGuid_Public_SurfaceMaterial_String_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultMaterialIfGuidUnmapped_Public_Void_String_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
