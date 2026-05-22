using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x02000043 RID: 67
	public class SECTR_PointSource : SECTR_AudioSource
	{
		// Token: 0x06000A80 RID: 2688 RVA: 0x00053224 File Offset: 0x00051424
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_PointSource()
		{
			Il2CppClassPointerStore<SECTR_PointSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_PointSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_PointSource>.NativeClassPtr);
			SECTR_PointSource.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_PointSource>.NativeClassPtr, "instance");
			SECTR_PointSource.NativeMethodInfoPtr_get_IsPlaying_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PointSource>.NativeClassPtr, 100664163);
			SECTR_PointSource.NativeMethodInfoPtr_PlayAtTime_Public_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PointSource>.NativeClassPtr, 100664164);
			SECTR_PointSource.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PointSource>.NativeClassPtr, 100664165);
			SECTR_PointSource.NativeMethodInfoPtr_Stop_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PointSource>.NativeClassPtr, 100664166);
			SECTR_PointSource.NativeMethodInfoPtr_GetInstance_Public_SECTR_AudioCueInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PointSource>.NativeClassPtr, 100664167);
			SECTR_PointSource.NativeMethodInfoPtr_OnVolumePitchChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PointSource>.NativeClassPtr, 100664168);
			SECTR_PointSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_PointSource>.NativeClassPtr, 100664169);
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x000532F4 File Offset: 0x000514F4
		public unsafe override bool IsPlaying
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40136, XrefRangeEnd = 40141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_PointSource.NativeMethodInfoPtr_get_IsPlaying_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0005333C File Offset: 0x0005153C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40141, XrefRangeEnd = 40177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayAtTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_PointSource.NativeMethodInfoPtr_PlayAtTime_Public_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00053388 File Offset: 0x00051588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40212, RefRangeEnd = 40213, XrefRangeStart = 40177, XrefRangeEnd = 40212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_PointSource.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000533C4 File Offset: 0x000515C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40213, XrefRangeEnd = 40214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Stop(bool stopImmediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopImmediately;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_PointSource.NativeMethodInfoPtr_Stop_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00053410 File Offset: 0x00051610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40214, XrefRangeEnd = 40221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance GetInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_PointSource.NativeMethodInfoPtr_GetInstance_Public_SECTR_AudioCueInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SECTR_AudioCueInstance(intPtr);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00053448 File Offset: 0x00051648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40221, XrefRangeEnd = 40228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVolumePitchChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_PointSource.NativeMethodInfoPtr_OnVolumePitchChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00053484 File Offset: 0x00051684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_PointSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_PointSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_PointSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000089DE File Offset: 0x00006BDE
		public SECTR_PointSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x000534C0 File Offset: 0x000516C0
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000089E7 File Offset: 0x00006BE7
		public SECTR_AudioCueInstance instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PointSource.NativeFieldInfoPtr_instance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_PointSource.NativeFieldInfoPtr_instance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_Virtual_get_Boolean_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_PlayAtTime_Public_Virtual_Void_Single_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Public_SECTR_AudioCueInstance_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_OnVolumePitchChanged_Protected_Virtual_Void_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
