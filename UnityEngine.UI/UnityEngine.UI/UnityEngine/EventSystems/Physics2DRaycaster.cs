using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000070 RID: 112
	public class Physics2DRaycaster : PhysicsRaycaster
	{
		// Token: 0x06000AF4 RID: 2804 RVA: 0x00031080 File Offset: 0x0002F280
		// Note: this type is marked as 'beforefieldinit'.
		static Physics2DRaycaster()
		{
			Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "Physics2DRaycaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr);
			Physics2DRaycaster.NativeFieldInfoPtr_m_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr, "m_Hits");
			Physics2DRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr, 100665033);
			Physics2DRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr, 100665034);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x000310EC File Offset: 0x0002F2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533170, XrefRangeEnd = 533173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Physics2DRaycaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2DRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00031128 File Offset: 0x0002F328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533173, XrefRangeEnd = 533293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultAppendList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Physics2DRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00005F2A File Offset: 0x0000412A
		public Physics2DRaycaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00031188 File Offset: 0x0002F388
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x00005F33 File Offset: 0x00004133
		public new unsafe Il2CppStructArray<RaycastHit2D> m_Hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Physics2DRaycaster.NativeFieldInfoPtr_m_Hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Physics2DRaycaster.NativeFieldInfoPtr_m_Hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr_m_Hits;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0;
	}
}
