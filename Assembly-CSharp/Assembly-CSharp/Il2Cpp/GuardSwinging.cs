using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000105 RID: 261
	public class GuardSwinging : GuardMode
	{
		// Token: 0x06001EE9 RID: 7913 RVA: 0x0008B338 File Offset: 0x00089538
		// Note: this type is marked as 'beforefieldinit'.
		static GuardSwinging()
		{
			Il2CppClassPointerStore<GuardSwinging>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardSwinging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardSwinging>.NativeClassPtr);
			GuardSwinging.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardSwinging>.NativeClassPtr, "startPos");
			GuardSwinging.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardSwinging>.NativeClassPtr, "started");
			GuardSwinging.NativeFieldInfoPtr_swingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardSwinging>.NativeClassPtr, "swingTime");
			GuardSwinging.NativeFieldInfoPtr_swingTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardSwinging>.NativeClassPtr, "swingTimer");
			GuardSwinging.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardSwinging>.NativeClassPtr, 100665770);
			GuardSwinging.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardSwinging>.NativeClassPtr, 100665771);
			GuardSwinging.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardSwinging>.NativeClassPtr, 100665772);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x0008B3F4 File Offset: 0x000895F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65911, RefRangeEnd = 65912, XrefRangeStart = 65903, XrefRangeEnd = 65911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardSwinging(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardSwinging>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardSwinging.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0008B440 File Offset: 0x00089640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65912, XrefRangeEnd = 65916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardSwinging.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0008B47C File Offset: 0x0008967C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65916, XrefRangeEnd = 65929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardSwinging.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x000159E1 File Offset: 0x00013BE1
		public GuardSwinging(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x0008B4B8 File Offset: 0x000896B8
		// (set) Token: 0x06001EEF RID: 7919 RVA: 0x000159EA File Offset: 0x00013BEA
		public unsafe Vector2 startPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSwinging.NativeFieldInfoPtr_startPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSwinging.NativeFieldInfoPtr_startPos)) = value;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x0008B4E0 File Offset: 0x000896E0
		// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x00015A05 File Offset: 0x00013C05
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSwinging.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSwinging.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x0008B508 File Offset: 0x00089708
		// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x00015A20 File Offset: 0x00013C20
		public unsafe float swingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSwinging.NativeFieldInfoPtr_swingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSwinging.NativeFieldInfoPtr_swingTime)) = value;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x0008B530 File Offset: 0x00089730
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x00015A3B File Offset: 0x00013C3B
		public unsafe float swingTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSwinging.NativeFieldInfoPtr_swingTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardSwinging.NativeFieldInfoPtr_swingTimer)) = value;
			}
		}

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeFieldInfoPtr_startPos;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeFieldInfoPtr_swingTime;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeFieldInfoPtr_swingTimer;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
