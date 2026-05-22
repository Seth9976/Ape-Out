using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x02000043 RID: 67
	[Serializable]
	public class TMP_StyleSheet : ScriptableObject
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x00022360 File Offset: 0x00020560
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_StyleSheet()
		{
			Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_StyleSheet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr);
			TMP_StyleSheet.NativeFieldInfoPtr_m_StyleList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, "m_StyleList");
			TMP_StyleSheet.NativeFieldInfoPtr_m_StyleLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, "m_StyleLookupDictionary");
			TMP_StyleSheet.NativeMethodInfoPtr_get_styles_Internal_get_List_1_TMP_Style_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664148);
			TMP_StyleSheet.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664149);
			TMP_StyleSheet.NativeMethodInfoPtr_GetStyle_Public_TMP_Style_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664150);
			TMP_StyleSheet.NativeMethodInfoPtr_GetStyle_Public_TMP_Style_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664151);
			TMP_StyleSheet.NativeMethodInfoPtr_RefreshStyles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664152);
			TMP_StyleSheet.NativeMethodInfoPtr_LoadStyleDictionaryInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664153);
			TMP_StyleSheet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664154);
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00022444 File Offset: 0x00020644
		public unsafe List<TMP_Style> styles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr_get_styles_Internal_get_List_1_TMP_Style_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_Style>>(intPtr3) : null;
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00022484 File Offset: 0x00020684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459712, XrefRangeEnd = 459713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000224B8 File Offset: 0x000206B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 459716, RefRangeEnd = 459718, XrefRangeStart = 459713, XrefRangeEnd = 459716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Style GetStyle(int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr_GetStyle_Public_TMP_Style_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr3) : null;
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00022504 File Offset: 0x00020704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459718, XrefRangeEnd = 459725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Style GetStyle(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr_GetStyle_Public_TMP_Style_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr3) : null;
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00022554 File Offset: 0x00020754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshStyles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr_RefreshStyles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00022588 File Offset: 0x00020788
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 459760, RefRangeEnd = 459764, XrefRangeStart = 459725, XrefRangeEnd = 459760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadStyleDictionaryInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr_LoadStyleDictionaryInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000225BC File Offset: 0x000207BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459764, XrefRangeEnd = 459774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_StyleSheet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000055A2 File Offset: 0x000037A2
		public TMP_StyleSheet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x000225F8 File Offset: 0x000207F8
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x000055AB File Offset: 0x000037AB
		public unsafe List<TMP_Style> m_StyleList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_StyleSheet.NativeFieldInfoPtr_m_StyleList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Style>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_StyleSheet.NativeFieldInfoPtr_m_StyleList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00022628 File Offset: 0x00020828
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x000055CA File Offset: 0x000037CA
		public unsafe Dictionary<int, TMP_Style> m_StyleLookupDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_StyleSheet.NativeFieldInfoPtr_m_StyleLookupDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TMP_Style>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_StyleSheet.NativeFieldInfoPtr_m_StyleLookupDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleList;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleLookupDictionary;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_get_styles_Internal_get_List_1_TMP_Style_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Public_TMP_Style_Int32_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Public_TMP_Style_String_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_RefreshStyles_Public_Void_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_LoadStyleDictionaryInternal_Private_Void_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
