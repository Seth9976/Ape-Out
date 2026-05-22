using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000176 RID: 374
	public class RotShadowPicker : MonoBehaviour
	{
		// Token: 0x06002CEC RID: 11500 RVA: 0x000B017C File Offset: 0x000AE37C
		// Note: this type is marked as 'beforefieldinit'.
		static RotShadowPicker()
		{
			Il2CppClassPointerStore<RotShadowPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RotShadowPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotShadowPicker>.NativeClassPtr);
			RotShadowPicker.NativeFieldInfoPtr_rotObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotShadowPicker>.NativeClassPtr, "rotObjs");
			RotShadowPicker.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotShadowPicker>.NativeClassPtr, 100666786);
			RotShadowPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotShadowPicker>.NativeClassPtr, 100666787);
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x000B01E8 File Offset: 0x000AE3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80794, XrefRangeEnd = 80869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotShadowPicker.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x000B021C File Offset: 0x000AE41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotShadowPicker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotShadowPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotShadowPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x0001F29D File Offset: 0x0001D49D
		public RotShadowPicker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x000B0258 File Offset: 0x000AE458
		// (set) Token: 0x06002CF1 RID: 11505 RVA: 0x0001F2A6 File Offset: 0x0001D4A6
		public unsafe Il2CppReferenceArray<GameObject> rotObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotShadowPicker.NativeFieldInfoPtr_rotObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotShadowPicker.NativeFieldInfoPtr_rotObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeFieldInfoPtr_rotObjs;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
