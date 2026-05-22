using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002F RID: 47
	public class SECTRLoopThrough : global::Il2CppSystem.Object
	{
		// Token: 0x060005CA RID: 1482 RVA: 0x000459D4 File Offset: 0x00043BD4
		// Note: this type is marked as 'beforefieldinit'.
		static SECTRLoopThrough()
		{
			Il2CppClassPointerStore<SECTRLoopThrough>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTRLoopThrough");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTRLoopThrough>.NativeClassPtr);
			SECTRLoopThrough.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTRLoopThrough>.NativeClassPtr, "instance");
			SECTRLoopThrough.NativeMethodInfoPtr_StartLoopThrough_Public_SECTR_AudioCueInstance_SECTR_AudioCue_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTRLoopThrough>.NativeClassPtr, 100663793);
			SECTRLoopThrough.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTRLoopThrough>.NativeClassPtr, 100663794);
			SECTRLoopThrough.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTRLoopThrough>.NativeClassPtr, 100663795);
			SECTRLoopThrough.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTRLoopThrough>.NativeClassPtr, 100663796);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00045A68 File Offset: 0x00043C68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 35637, RefRangeEnd = 35640, XrefRangeStart = 35631, XrefRangeEnd = 35637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioCueInstance StartLoopThrough(SECTR_AudioCue cue, Transform pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTRLoopThrough.NativeMethodInfoPtr_StartLoopThrough_Public_SECTR_AudioCueInstance_SECTR_AudioCue_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SECTR_AudioCueInstance(intPtr);
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00045AC4 File Offset: 0x00043CC4
		public unsafe bool Active
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35646, RefRangeEnd = 35648, XrefRangeStart = 35640, XrefRangeEnd = 35646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTRLoopThrough.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00045B00 File Offset: 0x00043D00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 35654, RefRangeEnd = 35659, XrefRangeStart = 35648, XrefRangeEnd = 35654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(bool immediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref immediately;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTRLoopThrough.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00045B40 File Offset: 0x00043D40
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTRLoopThrough()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTRLoopThrough>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTRLoopThrough.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000057F2 File Offset: 0x000039F2
		public SECTRLoopThrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00045B7C File Offset: 0x00043D7C
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x000057FB File Offset: 0x000039FB
		public SECTR_AudioCueInstance instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTRLoopThrough.NativeFieldInfoPtr_instance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTRLoopThrough.NativeFieldInfoPtr_instance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_StartLoopThrough_Public_SECTR_AudioCueInstance_SECTR_AudioCue_Transform_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_get_Boolean_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_Boolean_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
