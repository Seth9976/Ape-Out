using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000172 RID: 370
	public class RockTechVisSender : MonoBehaviour
	{
		// Token: 0x06002CB8 RID: 11448 RVA: 0x000AF954 File Offset: 0x000ADB54
		// Note: this type is marked as 'beforefieldinit'.
		static RockTechVisSender()
		{
			Il2CppClassPointerStore<RockTechVisSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RockTechVisSender");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RockTechVisSender>.NativeClassPtr);
			RockTechVisSender.NativeFieldInfoPtr_dad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockTechVisSender>.NativeClassPtr, "dad");
			RockTechVisSender.NativeMethodInfoPtr_OnBecameInvisible_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTechVisSender>.NativeClassPtr, 100666774);
			RockTechVisSender.NativeMethodInfoPtr_OnBecameVisible_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTechVisSender>.NativeClassPtr, 100666775);
			RockTechVisSender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockTechVisSender>.NativeClassPtr, 100666776);
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x000AF9D4 File Offset: 0x000ADBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80638, XrefRangeEnd = 80640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBecameInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTechVisSender.NativeMethodInfoPtr_OnBecameInvisible_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x000AFA08 File Offset: 0x000ADC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80640, XrefRangeEnd = 80642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBecameVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTechVisSender.NativeMethodInfoPtr_OnBecameVisible_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x000AFA3C File Offset: 0x000ADC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RockTechVisSender()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RockTechVisSender>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockTechVisSender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x0001F0B5 File Offset: 0x0001D2B5
		public RockTechVisSender(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06002CBD RID: 11453 RVA: 0x000AFA78 File Offset: 0x000ADC78
		// (set) Token: 0x06002CBE RID: 11454 RVA: 0x0001F0BE File Offset: 0x0001D2BE
		public unsafe RockTech dad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTechVisSender.NativeFieldInfoPtr_dad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RockTech>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockTechVisSender.NativeFieldInfoPtr_dad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeFieldInfoPtr_dad;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeMethodInfoPtr_OnBecameInvisible_Private_Void_0;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr_OnBecameVisible_Private_Void_0;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
