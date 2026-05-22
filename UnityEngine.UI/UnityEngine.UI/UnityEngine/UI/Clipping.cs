using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000009 RID: 9
	public static class Clipping : Object
	{
		// Token: 0x0600007E RID: 126 RVA: 0x000022AB File Offset: 0x000004AB
		// Note: this type is marked as 'beforefieldinit'.
		static Clipping()
		{
			Il2CppClassPointerStore<Clipping>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Clipping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Clipping>.NativeClassPtr);
			Clipping.NativeMethodInfoPtr_FindCullAndClipWorldRect_Public_Static_Rect_List_1_RectMask2D_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipping>.NativeClassPtr, 100663375);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00008ADC File Offset: 0x00006CDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 516265, RefRangeEnd = 516266, XrefRangeStart = 516257, XrefRangeEnd = 516265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectMaskParents);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipping.NativeMethodInfoPtr_FindCullAndClipWorldRect_Public_Static_Rect_List_1_RectMask2D_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000022E4 File Offset: 0x000004E4
		public Clipping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_FindCullAndClipWorldRect_Public_Static_Rect_List_1_RectMask2D_byref_Boolean_0;
	}
}
