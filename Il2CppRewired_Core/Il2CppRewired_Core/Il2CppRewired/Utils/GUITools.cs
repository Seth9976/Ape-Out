using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001EF RID: 495
	public static class GUITools : global::Il2CppSystem.Object
	{
		// Token: 0x0600323B RID: 12859 RVA: 0x000FA1E8 File Offset: 0x000F83E8
		// Note: this type is marked as 'beforefieldinit'.
		static GUITools()
		{
			Il2CppClassPointerStore<GUITools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "GUITools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUITools>.NativeClassPtr);
			GUITools.NativeMethodInfoPtr_ToGUIContentArray_Public_Static_Il2CppReferenceArray_1_GUIContent_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUITools>.NativeClassPtr, 100675997);
			GUITools.NativeMethodInfoPtr_ToGUIContentArray_Public_Static_Il2CppReferenceArray_1_GUIContent_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUITools>.NativeClassPtr, 100675998);
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x000FA240 File Offset: 0x000F8440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338012, XrefRangeEnd = 338024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<GUIContent> ToGUIContentArray(Il2CppStringArray items)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUITools.NativeMethodInfoPtr_ToGUIContentArray_Public_Static_Il2CppReferenceArray_1_GUIContent_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIContent>>(intPtr3) : null;
			}
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x000FA284 File Offset: 0x000F8484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338024, XrefRangeEnd = 338046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<GUIContent> ToGUIContentArray(IList<string> items)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUITools.NativeMethodInfoPtr_ToGUIContentArray_Public_Static_Il2CppReferenceArray_1_GUIContent_IList_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIContent>>(intPtr3) : null;
			}
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x00011D0E File Offset: 0x0000FF0E
		public GUITools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002ACB RID: 10955
		private static readonly IntPtr NativeMethodInfoPtr_ToGUIContentArray_Public_Static_Il2CppReferenceArray_1_GUIContent_Il2CppStringArray_0;

		// Token: 0x04002ACC RID: 10956
		private static readonly IntPtr NativeMethodInfoPtr_ToGUIContentArray_Public_Static_Il2CppReferenceArray_1_GUIContent_IList_1_String_0;
	}
}
