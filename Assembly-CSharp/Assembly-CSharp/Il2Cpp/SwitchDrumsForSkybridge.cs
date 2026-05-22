using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001C1 RID: 449
	public class SwitchDrumsForSkybridge : MonoBehaviour
	{
		// Token: 0x06003164 RID: 12644 RVA: 0x000BC328 File Offset: 0x000BA528
		// Note: this type is marked as 'beforefieldinit'.
		static SwitchDrumsForSkybridge()
		{
			Il2CppClassPointerStore<SwitchDrumsForSkybridge>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SwitchDrumsForSkybridge");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchDrumsForSkybridge>.NativeClassPtr);
			SwitchDrumsForSkybridge.NativeFieldInfoPtr_switched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchDrumsForSkybridge>.NativeClassPtr, "switched");
			SwitchDrumsForSkybridge.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchDrumsForSkybridge>.NativeClassPtr, 100667161);
			SwitchDrumsForSkybridge.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchDrumsForSkybridge>.NativeClassPtr, 100667162);
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x000BC394 File Offset: 0x000BA594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85312, XrefRangeEnd = 85322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchDrumsForSkybridge.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x000BC3C8 File Offset: 0x000BA5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwitchDrumsForSkybridge()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwitchDrumsForSkybridge>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchDrumsForSkybridge.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x00021DEE File Offset: 0x0001FFEE
		public SwitchDrumsForSkybridge(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06003168 RID: 12648 RVA: 0x000BC404 File Offset: 0x000BA604
		// (set) Token: 0x06003169 RID: 12649 RVA: 0x00021DF7 File Offset: 0x0001FFF7
		public unsafe bool switched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchDrumsForSkybridge.NativeFieldInfoPtr_switched);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchDrumsForSkybridge.NativeFieldInfoPtr_switched)) = value;
			}
		}

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeFieldInfoPtr_switched;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
