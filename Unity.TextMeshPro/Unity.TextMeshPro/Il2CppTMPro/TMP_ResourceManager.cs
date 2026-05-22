using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppTMPro
{
	// Token: 0x02000034 RID: 52
	public class TMP_ResourceManager : Object
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x0001D7B0 File Offset: 0x0001B9B0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_ResourceManager()
		{
			Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_ResourceManager");
			TMP_ResourceManager.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_instance");
			TMP_ResourceManager.NativeFieldInfoPtr_s_TextSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_TextSettings");
			TMP_ResourceManager.NativeFieldInfoPtr_s_FontAssetReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_FontAssetReferences");
			TMP_ResourceManager.NativeFieldInfoPtr_s_FontAssetReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_FontAssetReferenceLookup");
			TMP_ResourceManager.NativeMethodInfoPtr_GetTextSettings_Internal_Static_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664014);
			TMP_ResourceManager.NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664015);
			TMP_ResourceManager.NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664016);
			TMP_ResourceManager.NativeMethodInfoPtr_RebuildFontAssetCache_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664017);
			TMP_ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664018);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0001D88C File Offset: 0x0001BA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 457982, XrefRangeEnd = 458009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Settings GetTextSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ResourceManager.NativeMethodInfoPtr_GetTextSettings_Internal_Static_TMP_Settings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr3) : null;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0001D8C0 File Offset: 0x0001BAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458009, XrefRangeEnd = 458024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddFontAsset(TMP_FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ResourceManager.NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0001D8F8 File Offset: 0x0001BAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458024, XrefRangeEnd = 458032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashcode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_ResourceManager.NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			fontAsset = ((intPtr4 == 0) ? null : new TMP_FontAsset(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0001D958 File Offset: 0x0001BB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458032, XrefRangeEnd = 458044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RebuildFontAssetCache(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ResourceManager.NativeMethodInfoPtr_RebuildFontAssetCache_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0001D98C File Offset: 0x0001BB8C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ResourceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00004893 File Offset: 0x00002A93
		public TMP_ResourceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0001D9C8 File Offset: 0x0001BBC8
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x0000489C File Offset: 0x00002A9C
		public unsafe static TMP_ResourceManager s_instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_ResourceManager.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ResourceManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ResourceManager.NativeFieldInfoPtr_s_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0001D9F0 File Offset: 0x0001BBF0
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x000048AE File Offset: 0x00002AAE
		public unsafe static TMP_Settings s_TextSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_ResourceManager.NativeFieldInfoPtr_s_TextSettings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ResourceManager.NativeFieldInfoPtr_s_TextSettings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0001DA18 File Offset: 0x0001BC18
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x000048C0 File Offset: 0x00002AC0
		public unsafe static List<TMP_FontAsset> s_FontAssetReferences
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_ResourceManager.NativeFieldInfoPtr_s_FontAssetReferences, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ResourceManager.NativeFieldInfoPtr_s_FontAssetReferences, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0001DA40 File Offset: 0x0001BC40
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x000048D2 File Offset: 0x00002AD2
		public unsafe static Dictionary<int, TMP_FontAsset> s_FontAssetReferenceLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_ResourceManager.NativeFieldInfoPtr_s_FontAssetReferenceLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ResourceManager.NativeFieldInfoPtr_s_FontAssetReferenceLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_s_instance;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_s_TextSettings;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_s_FontAssetReferences;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr_s_FontAssetReferenceLookup;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_GetTextSettings_Internal_Static_TMP_Settings_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_TMP_FontAsset_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_TMP_FontAsset_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_RebuildFontAssetCache_Internal_Static_Void_Int32_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
