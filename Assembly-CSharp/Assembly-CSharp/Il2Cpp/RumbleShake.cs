using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000179 RID: 377
	public class RumbleShake : MonoBehaviour
	{
		// Token: 0x06002D1C RID: 11548 RVA: 0x000B0A48 File Offset: 0x000AEC48
		// Note: this type is marked as 'beforefieldinit'.
		static RumbleShake()
		{
			Il2CppClassPointerStore<RumbleShake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RumbleShake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RumbleShake>.NativeClassPtr);
			RumbleShake.NativeFieldInfoPtr_dev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RumbleShake>.NativeClassPtr, "dev");
			RumbleShake.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RumbleShake>.NativeClassPtr, "timer");
			RumbleShake.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RumbleShake>.NativeClassPtr, "intensity");
			RumbleShake.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RumbleShake>.NativeClassPtr, 100666802);
			RumbleShake.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RumbleShake>.NativeClassPtr, 100666803);
			RumbleShake.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RumbleShake>.NativeClassPtr, 100666804);
			RumbleShake.NativeMethodInfoPtr_Rumble_Public_Void_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RumbleShake>.NativeClassPtr, 100666805);
			RumbleShake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RumbleShake>.NativeClassPtr, 100666806);
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x000B0B18 File Offset: 0x000AED18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81041, XrefRangeEnd = 81046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RumbleShake.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000B0B4C File Offset: 0x000AED4C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RumbleShake.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x000B0B80 File Offset: 0x000AED80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81046, XrefRangeEnd = 81062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RumbleShake.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x000B0BB4 File Offset: 0x000AEDB4
		[CallerCount(0)]
		public unsafe void Rumble(float dur, Vector2 intense)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dur;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intense;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RumbleShake.NativeMethodInfoPtr_Rumble_Public_Void_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x000B0C00 File Offset: 0x000AEE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RumbleShake()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RumbleShake>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RumbleShake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x0001F42B File Offset: 0x0001D62B
		public RumbleShake(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x000B0C3C File Offset: 0x000AEE3C
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x0001F434 File Offset: 0x0001D634
		public unsafe Player dev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RumbleShake.NativeFieldInfoPtr_dev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RumbleShake.NativeFieldInfoPtr_dev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06002D25 RID: 11557 RVA: 0x000B0C6C File Offset: 0x000AEE6C
		// (set) Token: 0x06002D26 RID: 11558 RVA: 0x0001F453 File Offset: 0x0001D653
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RumbleShake.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RumbleShake.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x000B0C94 File Offset: 0x000AEE94
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x0001F46E File Offset: 0x0001D66E
		public unsafe float intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RumbleShake.NativeFieldInfoPtr_intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RumbleShake.NativeFieldInfoPtr_intensity)) = value;
			}
		}

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeFieldInfoPtr_dev;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeMethodInfoPtr_Rumble_Public_Void_Single_Vector2_0;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
