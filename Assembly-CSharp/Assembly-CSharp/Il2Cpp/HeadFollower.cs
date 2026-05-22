using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000029 RID: 41
	public class HeadFollower : MonoBehaviour
	{
		// Token: 0x060004EE RID: 1262 RVA: 0x00043670 File Offset: 0x00041870
		// Note: this type is marked as 'beforefieldinit'.
		static HeadFollower()
		{
			Il2CppClassPointerStore<HeadFollower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HeadFollower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeadFollower>.NativeClassPtr);
			HeadFollower.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadFollower>.NativeClassPtr, "head");
			HeadFollower.NativeFieldInfoPtr_headTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadFollower>.NativeClassPtr, "headTrans");
			HeadFollower.NativeFieldInfoPtr_rotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadFollower>.NativeClassPtr, "rotationSpeed");
			HeadFollower.NativeFieldInfoPtr_locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadFollower>.NativeClassPtr, "locked");
			HeadFollower.NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadFollower>.NativeClassPtr, "rot");
			HeadFollower.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadFollower>.NativeClassPtr, 100663735);
			HeadFollower.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadFollower>.NativeClassPtr, 100663736);
			HeadFollower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadFollower>.NativeClassPtr, 100663737);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00043740 File Offset: 0x00041940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35188, XrefRangeEnd = 35194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeadFollower.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00043774 File Offset: 0x00041974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35194, XrefRangeEnd = 35224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeadFollower.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000437A8 File Offset: 0x000419A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeadFollower()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeadFollower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeadFollower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00004F63 File Offset: 0x00003163
		public HeadFollower(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x000437E4 File Offset: 0x000419E4
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00004F6C File Offset: 0x0000316C
		public unsafe GameObject head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadFollower.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadFollower.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00043814 File Offset: 0x00041A14
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00004F8B File Offset: 0x0000318B
		public unsafe Transform headTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadFollower.NativeFieldInfoPtr_headTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadFollower.NativeFieldInfoPtr_headTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00043844 File Offset: 0x00041A44
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00004FAA File Offset: 0x000031AA
		public unsafe float rotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadFollower.NativeFieldInfoPtr_rotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadFollower.NativeFieldInfoPtr_rotationSpeed)) = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0004386C File Offset: 0x00041A6C
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00004FC5 File Offset: 0x000031C5
		public unsafe bool locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadFollower.NativeFieldInfoPtr_locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadFollower.NativeFieldInfoPtr_locked)) = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00043894 File Offset: 0x00041A94
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00004FE0 File Offset: 0x000031E0
		public unsafe bool rot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadFollower.NativeFieldInfoPtr_rot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeadFollower.NativeFieldInfoPtr_rot)) = value;
			}
		}

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr_headTrans;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_rotationSpeed;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_locked;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_rot;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
