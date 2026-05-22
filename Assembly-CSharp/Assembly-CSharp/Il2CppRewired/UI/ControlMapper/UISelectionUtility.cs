using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x02000205 RID: 517
	public static class UISelectionUtility : global::Il2CppSystem.Object
	{
		// Token: 0x06003F27 RID: 16167 RVA: 0x000EC1BC File Offset: 0x000EA3BC
		// Note: this type is marked as 'beforefieldinit'.
		static UISelectionUtility()
		{
			Il2CppClassPointerStore<UISelectionUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "UISelectionUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISelectionUtility>.NativeClassPtr);
			UISelectionUtility.NativeFieldInfoPtr_s_reusableAllSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectionUtility>.NativeClassPtr, "s_reusableAllSelectables");
			UISelectionUtility.NativeMethodInfoPtr_FindNextSelectable_Public_Static_Selectable_Selectable_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectionUtility>.NativeClassPtr, 100669333);
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x000EC214 File Offset: 0x000EA414
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 100016, RefRangeEnd = 100024, XrefRangeStart = 99857, XrefRangeEnd = 100016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Selectable FindNextSelectable(Selectable selectable, Transform transform, Vector3 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectionUtility.NativeMethodInfoPtr_FindNextSelectable_Public_Static_Selectable_Selectable_Transform_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x00026DFB File Offset: 0x00024FFB
		public UISelectionUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06003F2A RID: 16170 RVA: 0x000EC278 File Offset: 0x000EA478
		// (set) Token: 0x06003F2B RID: 16171 RVA: 0x00026E04 File Offset: 0x00025004
		public unsafe static Il2CppReferenceArray<Selectable> s_reusableAllSelectables
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UISelectionUtility.NativeFieldInfoPtr_s_reusableAllSelectables, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UISelectionUtility.NativeFieldInfoPtr_s_reusableAllSelectables, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026A9 RID: 9897
		private static readonly IntPtr NativeFieldInfoPtr_s_reusableAllSelectables;

		// Token: 0x040026AA RID: 9898
		private static readonly IntPtr NativeMethodInfoPtr_FindNextSelectable_Public_Static_Selectable_Selectable_Transform_Vector3_0;
	}
}
