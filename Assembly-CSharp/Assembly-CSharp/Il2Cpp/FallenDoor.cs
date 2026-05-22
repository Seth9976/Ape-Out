using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000CD RID: 205
	public class FallenDoor : MonoBehaviour
	{
		// Token: 0x0600186F RID: 6255 RVA: 0x00078F3C File Offset: 0x0007713C
		// Note: this type is marked as 'beforefieldinit'.
		static FallenDoor()
		{
			Il2CppClassPointerStore<FallenDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FallenDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallenDoor>.NativeClassPtr);
			FallenDoor.NativeFieldInfoPtr_startTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallenDoor>.NativeClassPtr, "startTimer");
			FallenDoor.NativeFieldInfoPtr_fallen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallenDoor>.NativeClassPtr, "fallen");
			FallenDoor.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallenDoor>.NativeClassPtr, 100665298);
			FallenDoor.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallenDoor>.NativeClassPtr, 100665299);
			FallenDoor.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallenDoor>.NativeClassPtr, 100665300);
			FallenDoor.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallenDoor>.NativeClassPtr, 100665301);
			FallenDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallenDoor>.NativeClassPtr, 100665302);
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00078FF8 File Offset: 0x000771F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57614, XrefRangeEnd = 57615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallenDoor.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0007902C File Offset: 0x0007722C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57615, XrefRangeEnd = 57630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallenDoor.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00079060 File Offset: 0x00077260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57630, XrefRangeEnd = 57639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallenDoor.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00079094 File Offset: 0x00077294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57639, XrefRangeEnd = 57699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallenDoor.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x000790C8 File Offset: 0x000772C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FallenDoor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallenDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallenDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000118E4 File Offset: 0x0000FAE4
		public FallenDoor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x00079104 File Offset: 0x00077304
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x000118ED File Offset: 0x0000FAED
		public unsafe int startTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenDoor.NativeFieldInfoPtr_startTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenDoor.NativeFieldInfoPtr_startTimer)) = value;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x0007912C File Offset: 0x0007732C
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x00011908 File Offset: 0x0000FB08
		public unsafe bool fallen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenDoor.NativeFieldInfoPtr_fallen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenDoor.NativeFieldInfoPtr_fallen)) = value;
			}
		}

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeFieldInfoPtr_startTimer;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeFieldInfoPtr_fallen;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
