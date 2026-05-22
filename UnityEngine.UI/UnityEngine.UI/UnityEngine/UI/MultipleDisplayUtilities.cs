using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200002E RID: 46
	public static class MultipleDisplayUtilities : Object
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x0001AEE0 File Offset: 0x000190E0
		// Note: this type is marked as 'beforefieldinit'.
		static MultipleDisplayUtilities()
		{
			Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "MultipleDisplayUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr);
			MultipleDisplayUtilities.NativeMethodInfoPtr_GetRelativeMousePositionForDrag_Public_Static_Boolean_PointerEventData_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr, 100664152);
			MultipleDisplayUtilities.NativeMethodInfoPtr_RelativeMouseAtScaled_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr, 100664153);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0001AF38 File Offset: 0x00019138
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 525764, RefRangeEnd = 525768, XrefRangeStart = 525762, XrefRangeEnd = 525764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleDisplayUtilities.NativeMethodInfoPtr_GetRelativeMousePositionForDrag_Public_Static_Boolean_PointerEventData_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0001AF88 File Offset: 0x00019188
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 525791, RefRangeEnd = 525794, XrefRangeStart = 525768, XrefRangeEnd = 525791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 RelativeMouseAtScaled(Vector2 position)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleDisplayUtilities.NativeMethodInfoPtr_RelativeMouseAtScaled_Public_Static_Vector3_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00003C6A File Offset: 0x00001E6A
		public MultipleDisplayUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeMousePositionForDrag_Public_Static_Boolean_PointerEventData_byref_Vector2_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_RelativeMouseAtScaled_Public_Static_Vector3_Vector2_0;
	}
}
