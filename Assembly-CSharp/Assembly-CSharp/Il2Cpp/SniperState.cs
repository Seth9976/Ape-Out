using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x02000198 RID: 408
	public class SniperState : GuardState
	{
		// Token: 0x06002FCD RID: 12237 RVA: 0x000B7F58 File Offset: 0x000B6158
		// Note: this type is marked as 'beforefieldinit'.
		static SniperState()
		{
			Il2CppClassPointerStore<SniperState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SniperState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SniperState>.NativeClassPtr);
			SniperState.NativeFieldInfoPtr_justFired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SniperState>.NativeClassPtr, "justFired");
			SniperState.NativeFieldInfoPtr_reaquireTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SniperState>.NativeClassPtr, "reaquireTimer");
			SniperState.NativeMethodInfoPtr_GetSpeeds_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SniperState>.NativeClassPtr, 100667026);
			SniperState.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SniperState>.NativeClassPtr, 100667027);
			SniperState.NativeMethodInfoPtr_Fired_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SniperState>.NativeClassPtr, 100667028);
			SniperState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SniperState>.NativeClassPtr, 100667029);
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x000B8000 File Offset: 0x000B6200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83785, XrefRangeEnd = 83790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetSpeeds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SniperState.NativeMethodInfoPtr_GetSpeeds_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x000B803C File Offset: 0x000B623C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83790, XrefRangeEnd = 83803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SniperState.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x000B8078 File Offset: 0x000B6278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83803, XrefRangeEnd = 83804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SniperState.NativeMethodInfoPtr_Fired_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x000B80B4 File Offset: 0x000B62B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SniperState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SniperState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SniperState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00020F7F File Offset: 0x0001F17F
		public SniperState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06002FD3 RID: 12243 RVA: 0x000B80F0 File Offset: 0x000B62F0
		// (set) Token: 0x06002FD4 RID: 12244 RVA: 0x00020F88 File Offset: 0x0001F188
		public unsafe bool justFired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SniperState.NativeFieldInfoPtr_justFired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SniperState.NativeFieldInfoPtr_justFired)) = value;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06002FD5 RID: 12245 RVA: 0x000B8118 File Offset: 0x000B6318
		// (set) Token: 0x06002FD6 RID: 12246 RVA: 0x00020FA3 File Offset: 0x0001F1A3
		public unsafe int reaquireTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SniperState.NativeFieldInfoPtr_reaquireTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SniperState.NativeFieldInfoPtr_reaquireTimer)) = value;
			}
		}

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeFieldInfoPtr_justFired;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeFieldInfoPtr_reaquireTimer;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeeds_Public_Virtual_Void_0;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeMethodInfoPtr_Fired_Public_Virtual_Void_0;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
