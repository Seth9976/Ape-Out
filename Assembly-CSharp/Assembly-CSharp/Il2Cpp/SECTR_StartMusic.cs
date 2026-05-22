using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000047 RID: 71
	public class SECTR_StartMusic : MonoBehaviour
	{
		// Token: 0x06000ABF RID: 2751 RVA: 0x00053FBC File Offset: 0x000521BC
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_StartMusic()
		{
			Il2CppClassPointerStore<SECTR_StartMusic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_StartMusic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_StartMusic>.NativeClassPtr);
			SECTR_StartMusic.NativeFieldInfoPtr_Cue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_StartMusic>.NativeClassPtr, "Cue");
			SECTR_StartMusic.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_StartMusic>.NativeClassPtr, 100664195);
			SECTR_StartMusic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_StartMusic>.NativeClassPtr, 100664196);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00054028 File Offset: 0x00052228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40508, XrefRangeEnd = 40516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_StartMusic.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0005405C File Offset: 0x0005225C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_StartMusic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_StartMusic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_StartMusic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00008B88 File Offset: 0x00006D88
		public SECTR_StartMusic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00054098 File Offset: 0x00052298
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00008B91 File Offset: 0x00006D91
		public unsafe SECTR_AudioCue Cue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_StartMusic.NativeFieldInfoPtr_Cue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_StartMusic.NativeFieldInfoPtr_Cue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeFieldInfoPtr_Cue;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
