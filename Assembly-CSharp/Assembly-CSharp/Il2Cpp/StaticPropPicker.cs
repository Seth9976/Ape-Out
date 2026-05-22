using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001AB RID: 427
	public class StaticPropPicker : MonoBehaviour
	{
		// Token: 0x060030B1 RID: 12465 RVA: 0x000BA604 File Offset: 0x000B8804
		// Note: this type is marked as 'beforefieldinit'.
		static StaticPropPicker()
		{
			Il2CppClassPointerStore<StaticPropPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StaticPropPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticPropPicker>.NativeClassPtr);
			StaticPropPicker.NativeFieldInfoPtr_propSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticPropPicker>.NativeClassPtr, "propSets");
			StaticPropPicker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticPropPicker>.NativeClassPtr, 100667112);
			StaticPropPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticPropPicker>.NativeClassPtr, 100667113);
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x000BA670 File Offset: 0x000B8870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84579, XrefRangeEnd = 84597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticPropPicker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x000BA6A4 File Offset: 0x000B88A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticPropPicker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticPropPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticPropPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x00021746 File Offset: 0x0001F946
		public StaticPropPicker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x060030B5 RID: 12469 RVA: 0x000BA6E0 File Offset: 0x000B88E0
		// (set) Token: 0x060030B6 RID: 12470 RVA: 0x0002174F File Offset: 0x0001F94F
		public unsafe Il2CppReferenceArray<GameObject> propSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticPropPicker.NativeFieldInfoPtr_propSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticPropPicker.NativeFieldInfoPtr_propSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeFieldInfoPtr_propSets;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
