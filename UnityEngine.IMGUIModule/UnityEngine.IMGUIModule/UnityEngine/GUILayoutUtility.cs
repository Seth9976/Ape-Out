using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public class GUILayoutUtility : Object
	{
		// Token: 0x06000274 RID: 628 RVA: 0x0000B724 File Offset: 0x00009924
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutUtility()
		{
			Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayoutUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr);
			GUILayoutUtility.NativeFieldInfoPtr_s_StoredLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "s_StoredLayouts");
			GUILayoutUtility.NativeFieldInfoPtr_s_StoredWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "s_StoredWindows");
			GUILayoutUtility.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "current");
			GUILayoutUtility.NativeFieldInfoPtr_kDummyRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "kDummyRect");
			GUILayoutUtility.NativeFieldInfoPtr_s_SpaceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "s_SpaceStyle");
			GUILayoutUtility.NativeMethodInfoPtr_Internal_GetWindowRect_Private_Static_Rect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663471);
			GUILayoutUtility.NativeMethodInfoPtr_Internal_MoveWindow_Private_Static_Void_Int32_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663472);
			GUILayoutUtility.NativeMethodInfoPtr_SelectIDList_Internal_Static_LayoutCache_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663473);
			GUILayoutUtility.NativeMethodInfoPtr_Begin_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663474);
			GUILayoutUtility.NativeMethodInfoPtr_BeginWindow_Internal_Static_Void_Int32_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663475);
			GUILayoutUtility.NativeMethodInfoPtr_Layout_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663476);
			GUILayoutUtility.NativeMethodInfoPtr_LayoutFromEditorWindow_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663477);
			GUILayoutUtility.NativeMethodInfoPtr_LayoutFreeGroup_Internal_Static_Void_GUILayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663478);
			GUILayoutUtility.NativeMethodInfoPtr_LayoutSingleGroup_Private_Static_Void_GUILayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663479);
			GUILayoutUtility.NativeMethodInfoPtr_CreateGUILayoutGroupInstanceOfType_Private_Static_GUILayoutGroup_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663480);
			GUILayoutUtility.NativeMethodInfoPtr_BeginLayoutGroup_Internal_Static_GUILayoutGroup_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663481);
			GUILayoutUtility.NativeMethodInfoPtr_EndLayoutGroup_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663482);
			GUILayoutUtility.NativeMethodInfoPtr_BeginLayoutArea_Internal_Static_GUILayoutGroup_GUIStyle_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663483);
			GUILayoutUtility.NativeMethodInfoPtr_GetRect_Public_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663484);
			GUILayoutUtility.NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663485);
			GUILayoutUtility.NativeMethodInfoPtr_GetRect_Public_Static_Rect_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663486);
			GUILayoutUtility.NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663487);
			GUILayoutUtility.NativeMethodInfoPtr_GetLastRect_Public_Static_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663488);
			GUILayoutUtility.NativeMethodInfoPtr_get_spaceStyle_Internal_Static_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663489);
			GUILayoutUtility.NativeMethodInfoPtr_Internal_GetWindowRect_Injected_Private_Static_Void_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663491);
			GUILayoutUtility.NativeMethodInfoPtr_Internal_MoveWindow_Injected_Private_Static_Void_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663492);
			GUILayoutUtility.GetWindowsBounds_InjectedDelegateField = IL2CPP.ResolveICall<GUILayoutUtility.GetWindowsBounds_InjectedDelegate>("UnityEngine.GUILayoutUtility::GetWindowsBounds_Injected");
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000B96C File Offset: 0x00009B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507873, XrefRangeEnd = 507878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect Internal_GetWindowRect(int windowID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Internal_GetWindowRect_Private_Static_Rect_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000B9AC File Offset: 0x00009BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507878, XrefRangeEnd = 507883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_MoveWindow(int windowID, Rect r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Internal_MoveWindow_Private_Static_Void_Int32_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000B9EC File Offset: 0x00009BEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 507904, RefRangeEnd = 507908, XrefRangeStart = 507883, XrefRangeEnd = 507904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWindow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_SelectIDList_Internal_Static_LayoutCache_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutUtility.LayoutCache>(intPtr3) : null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000BA3C File Offset: 0x00009C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507922, RefRangeEnd = 507923, XrefRangeStart = 507908, XrefRangeEnd = 507922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Begin(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Begin_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000BA70 File Offset: 0x00009C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507937, RefRangeEnd = 507938, XrefRangeStart = 507923, XrefRangeEnd = 507937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginWindow(int windowID, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_BeginWindow_Internal_Static_Void_Int32_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 507948, RefRangeEnd = 507950, XrefRangeStart = 507938, XrefRangeEnd = 507948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Layout()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Layout_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507961, RefRangeEnd = 507962, XrefRangeStart = 507950, XrefRangeEnd = 507961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LayoutFromEditorWindow()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_LayoutFromEditorWindow_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000BB18 File Offset: 0x00009D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507995, RefRangeEnd = 507996, XrefRangeStart = 507962, XrefRangeEnd = 507995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LayoutFreeGroup(GUILayoutGroup toplevel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toplevel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_LayoutFreeGroup_Internal_Static_Void_GUILayoutGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000BB50 File Offset: 0x00009D50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 508010, RefRangeEnd = 508011, XrefRangeStart = 507996, XrefRangeEnd = 508010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LayoutSingleGroup(GUILayoutGroup i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_LayoutSingleGroup_Private_Static_Void_GUILayoutGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000BB88 File Offset: 0x00009D88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 508020, RefRangeEnd = 508022, XrefRangeStart = 508011, XrefRangeEnd = 508020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(LayoutType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_CreateGUILayoutGroupInstanceOfType_Private_Static_GUILayoutGroup_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr3) : null;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000BBCC File Offset: 0x00009DCC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 508048, RefRangeEnd = 508053, XrefRangeStart = 508022, XrefRangeEnd = 508048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutGroup BeginLayoutGroup(GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options, Type layoutType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(layoutType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_BeginLayoutGroup_Internal_Static_GUILayoutGroup_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr3) : null;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000BC34 File Offset: 0x00009E34
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 508071, RefRangeEnd = 508087, XrefRangeStart = 508053, XrefRangeEnd = 508071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndLayoutGroup()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_EndLayoutGroup_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000BC5C File Offset: 0x00009E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 508111, RefRangeEnd = 508112, XrefRangeStart = 508087, XrefRangeEnd = 508111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(layoutType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_BeginLayoutArea_Internal_Static_GUILayoutGroup_GUIStyle_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr3) : null;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508112, XrefRangeEnd = 508116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect GetRect(GUIContent content, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_GetRect_Public_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000BD28 File Offset: 0x00009F28
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 508173, RefRangeEnd = 508182, XrefRangeStart = 508116, XrefRangeEnd = 508173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect DoGetRect(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000BD90 File Offset: 0x00009F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508182, XrefRangeEnd = 508186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect GetRect(float width, float height, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_GetRect_Public_Static_Rect_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000BE0C File Offset: 0x0000A00C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 508210, RefRangeEnd = 508213, XrefRangeStart = 508186, XrefRangeEnd = 508210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000BE9C File Offset: 0x0000A09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508213, XrefRangeEnd = 508221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect GetLastRect()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_GetLastRect_Public_Static_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000BECC File Offset: 0x0000A0CC
		public unsafe static GUIStyle spaceStyle
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 508238, RefRangeEnd = 508241, XrefRangeStart = 508221, XrefRangeEnd = 508238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_get_spaceStyle_Internal_Static_get_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000BF00 File Offset: 0x0000A100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508241, XrefRangeEnd = 508245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_GetWindowRect_Injected(int windowID, out Rect ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Internal_GetWindowRect_Injected_Private_Static_Void_Int32_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000BF40 File Offset: 0x0000A140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508245, XrefRangeEnd = 508249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_MoveWindow_Injected(int windowID, ref Rect r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Internal_MoveWindow_Injected_Private_Static_Void_Int32_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002F4E File Offset: 0x0000114E
		public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002F5D File Offset: 0x0000115D
		public static Rect GetRect(float width, float height, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(width, height, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002F6D File Offset: 0x0000116D
		public GUILayoutUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000BF80 File Offset: 0x0000A180
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00002F76 File Offset: 0x00001176
		public unsafe static Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_s_StoredLayouts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GUILayoutUtility.LayoutCache>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_s_StoredLayouts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00002F88 File Offset: 0x00001188
		public unsafe static Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_s_StoredWindows, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GUILayoutUtility.LayoutCache>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_s_StoredWindows, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00002F9A File Offset: 0x0000119A
		public unsafe static GUILayoutUtility.LayoutCache current
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_current, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutUtility.LayoutCache>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_current, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000BFF8 File Offset: 0x0000A1F8
		// (set) Token: 0x06000294 RID: 660 RVA: 0x00002FAC File Offset: 0x000011AC
		public unsafe static Rect kDummyRect
		{
			get
			{
				Rect rect;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_kDummyRect, (void*)(&rect));
				return rect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_kDummyRect, (void*)(&value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000C014 File Offset: 0x0000A214
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00002FBA File Offset: 0x000011BA
		public unsafe static GUIStyle s_SpaceStyle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_s_SpaceStyle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_s_SpaceStyle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000C03C File Offset: 0x0000A23C
		public static Rect GetWindowsBounds()
		{
			Rect rect;
			GUILayoutUtility.GetWindowsBounds_Injected(out rect);
			return rect;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002FCC File Offset: 0x000011CC
		public static void CleanupRoots()
		{
			GUILayoutUtility.s_SpaceStyle = null;
			GUILayoutUtility.s_StoredLayouts.Clear();
			GUILayoutUtility.s_StoredWindows.Clear();
			GUILayoutUtility.current = new GUILayoutUtility.LayoutCache(-1);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000C054 File Offset: 0x0000A254
		public static void BeginContainer(GUILayoutUtility.LayoutCache cache)
		{
			bool flag = Event.current.type == EventType.Layout;
			if (flag)
			{
				cache.topLevel = new GUILayoutGroup();
				cache.layoutGroups.Clear();
				cache.layoutGroups.Push(cache.topLevel);
				cache.windows = new GUILayoutGroup();
			}
			GUILayoutUtility.current.topLevel = cache.topLevel;
			GUILayoutUtility.current.layoutGroups = cache.layoutGroups;
			GUILayoutUtility.current.windows = cache.windows;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002FF6 File Offset: 0x000011F6
		public static void BeginGroup(string GroupName)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002FF9 File Offset: 0x000011F9
		public static void EndGroup(string groupName)
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000C0DC File Offset: 0x0000A2DC
		public static void LayoutFromContainer(float w, float h)
		{
			bool flag = GUILayoutUtility.current.topLevel != null;
			if (flag)
			{
				GUILayoutUtility.current.topLevel.CalcWidth();
				GUILayoutUtility.current.topLevel.SetHorizontal(0f, w);
				GUILayoutUtility.current.topLevel.CalcHeight();
				GUILayoutUtility.current.topLevel.SetVertical(0f, h);
				GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
			}
			else
			{
				Debug.LogError("GUILayout state invalid. Verify that all layout begin/end calls match.");
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000C168 File Offset: 0x0000A368
		public static float LayoutFromInspector(float width)
		{
			bool flag = GUILayoutUtility.current.topLevel != null && GUILayoutUtility.current.topLevel.windowID == -1;
			float num;
			if (flag)
			{
				GUILayoutUtility.current.topLevel.CalcWidth();
				GUILayoutUtility.current.topLevel.SetHorizontal(0f, width);
				GUILayoutUtility.current.topLevel.CalcHeight();
				GUILayoutUtility.current.topLevel.SetVertical(0f, Mathf.Min((float)Screen.height / GUIUtility.pixelsPerPoint, GUILayoutUtility.current.topLevel.maxHeight));
				float minHeight = GUILayoutUtility.current.topLevel.minHeight;
				GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
				num = minHeight;
			}
			else
			{
				bool flag2 = GUILayoutUtility.current.topLevel != null;
				if (flag2)
				{
					GUILayoutUtility.LayoutSingleGroup(GUILayoutUtility.current.topLevel);
				}
				num = 0f;
			}
			return num;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000C258 File Offset: 0x0000A458
		public static GUILayoutGroup DoBeginLayoutArea(GUIStyle style, Type layoutType)
		{
			return GUILayoutUtility.BeginLayoutArea(style, layoutType);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00002FFC File Offset: 0x000011FC
		public static GUILayoutGroup topLevel
		{
			get
			{
				return GUILayoutUtility.current.topLevel;
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000C274 File Offset: 0x0000A474
		public static Rect GetRect(GUIContent content, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(content, style, null);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000C290 File Offset: 0x0000A490
		public static Rect GetRect(float width, float height)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, GUIStyle.none, null);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000C2B4 File Offset: 0x0000A4B4
		public static Rect GetRect(float width, float height, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, style, null);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000C2D4 File Offset: 0x0000A4D4
		public static Rect GetRect(float width, float height, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, GUIStyle.none, options);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00003008 File Offset: 0x00001208
		public static Rect GetRect(float width, float height, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(width, height, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, GUIStyle.none, null);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000C31C File Offset: 0x0000A51C
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, style, null);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000C33C File Offset: 0x0000A53C
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, GUIStyle.none, options);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00003017 File Offset: 0x00001217
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(minWidth, maxWidth, minHeight, maxHeight, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000C360 File Offset: 0x0000A560
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, style, options);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00003029 File Offset: 0x00001229
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(minWidth, maxWidth, minHeight, maxHeight, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000C380 File Offset: 0x0000A580
		public static Rect GetAspectRect(float aspect)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, null);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000C39C File Offset: 0x0000A59C
		public static Rect GetAspectRect(float aspect, GUIStyle style)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, null);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000C3B8 File Offset: 0x0000A5B8
		public static Rect GetAspectRect(float aspect, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, options);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000303D File Offset: 0x0000123D
		public static Rect GetAspectRect(float aspect, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetAspectRect(aspect, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		public static Rect GetAspectRect(float aspect, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, options);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000304B File Offset: 0x0000124B
		public static Rect GetAspectRect(float aspect, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetAspectRect(aspect, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		public static Rect DoGetAspectRect(float aspect, Il2CppReferenceArray<GUILayoutOption> options)
		{
			EventType type = Event.current.type;
			EventType eventType = type;
			Rect rect;
			if (eventType != EventType.Layout)
			{
				if (eventType != EventType.Used)
				{
					rect = GUILayoutUtility.current.topLevel.GetNext().rect;
				}
				else
				{
					rect = GUILayoutUtility.kDummyRect;
				}
			}
			else
			{
				GUILayoutUtility.current.topLevel.Add(new GUIAspectSizer(aspect, options));
				rect = GUILayoutUtility.kDummyRect;
			}
			return rect;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000305A File Offset: 0x0000125A
		public static void GetWindowsBounds_Injected(out Rect ret)
		{
			GUILayoutUtility.GetWindowsBounds_InjectedDelegateField(out ret);
		}

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_s_StoredLayouts;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_s_StoredWindows;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_kDummyRect;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_s_SpaceStyle;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetWindowRect_Private_Static_Rect_Int32_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_Internal_MoveWindow_Private_Static_Void_Int32_Rect_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_SelectIDList_Internal_Static_LayoutCache_Int32_Boolean_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Internal_Static_Void_Int32_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_BeginWindow_Internal_Static_Void_Int32_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Internal_Static_Void_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_LayoutFromEditorWindow_Internal_Static_Void_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_LayoutFreeGroup_Internal_Static_Void_GUILayoutGroup_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_LayoutSingleGroup_Private_Static_Void_GUILayoutGroup_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_CreateGUILayoutGroupInstanceOfType_Private_Static_GUILayoutGroup_Type_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_BeginLayoutGroup_Internal_Static_GUILayoutGroup_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_Type_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_EndLayoutGroup_Internal_Static_Void_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_BeginLayoutArea_Internal_Static_GUILayoutGroup_GUIStyle_Type_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_GetRect_Public_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_GetRect_Public_Static_Rect_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_GetLastRect_Public_Static_Rect_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_get_spaceStyle_Internal_Static_get_GUIStyle_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetWindowRect_Injected_Private_Static_Void_Int32_byref_Rect_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_Internal_MoveWindow_Injected_Private_Static_Void_Int32_byref_Rect_0;

		// Token: 0x04000150 RID: 336
		private static readonly GUILayoutUtility.GetWindowsBounds_InjectedDelegate GetWindowsBounds_InjectedDelegateField;

		// Token: 0x0200006F RID: 111
		public sealed class LayoutCache : Object
		{
			// Token: 0x060006AE RID: 1710 RVA: 0x0001841C File Offset: 0x0001661C
			// Note: this type is marked as 'beforefieldinit'.
			static LayoutCache()
			{
				Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "LayoutCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr);
				GUILayoutUtility.LayoutCache.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, "<id>k__BackingField");
				GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_topLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, "topLevel");
				GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_layoutGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, "layoutGroups");
				GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_windows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, "windows");
				GUILayoutUtility.LayoutCache.NativeMethodInfoPtr_set_id_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, 100663493);
				GUILayoutUtility.LayoutCache.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, 100663494);
			}

			// Token: 0x1700016A RID: 362
			// (set) Token: 0x060006AF RID: 1711 RVA: 0x000184C0 File Offset: 0x000166C0
			public unsafe int id
			{
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.LayoutCache.NativeMethodInfoPtr_set_id_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060006B0 RID: 1712 RVA: 0x00018500 File Offset: 0x00016700
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 507872, RefRangeEnd = 507873, XrefRangeStart = 507856, XrefRangeEnd = 507872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LayoutCache(int instanceID = -1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref instanceID;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.LayoutCache.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006B1 RID: 1713 RVA: 0x000048C7 File Offset: 0x00002AC7
			public LayoutCache(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00018548 File Offset: 0x00016748
			// (set) Token: 0x060006B3 RID: 1715 RVA: 0x000048D0 File Offset: 0x00002AD0
			public unsafe int _id_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr__id_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr__id_k__BackingField)) = value;
				}
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00018570 File Offset: 0x00016770
			// (set) Token: 0x060006B5 RID: 1717 RVA: 0x000048EB File Offset: 0x00002AEB
			public unsafe GUILayoutGroup topLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_topLevel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_topLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x060006B6 RID: 1718 RVA: 0x000185A0 File Offset: 0x000167A0
			// (set) Token: 0x060006B7 RID: 1719 RVA: 0x0000490A File Offset: 0x00002B0A
			public unsafe GenericStack layoutGroups
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_layoutGroups);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_layoutGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x060006B8 RID: 1720 RVA: 0x000185D0 File Offset: 0x000167D0
			// (set) Token: 0x060006B9 RID: 1721 RVA: 0x00004929 File Offset: 0x00002B29
			public unsafe GUILayoutGroup windows
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_windows);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_windows), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003DB RID: 987
			private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

			// Token: 0x040003DC RID: 988
			private static readonly IntPtr NativeFieldInfoPtr_topLevel;

			// Token: 0x040003DD RID: 989
			private static readonly IntPtr NativeFieldInfoPtr_layoutGroups;

			// Token: 0x040003DE RID: 990
			private static readonly IntPtr NativeFieldInfoPtr_windows;

			// Token: 0x040003DF RID: 991
			private static readonly IntPtr NativeMethodInfoPtr_set_id_Private_set_Void_Int32_0;

			// Token: 0x040003E0 RID: 992
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;
		}

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060006BB RID: 1723
		private delegate void GetWindowsBounds_InjectedDelegate([Out] IntPtr ret);
	}
}
