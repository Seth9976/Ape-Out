using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x0200005A RID: 90
	public class SECTR_GhostController : SECTR_FPController
	{
		// Token: 0x06000CCC RID: 3276 RVA: 0x0005AAA8 File Offset: 0x00058CA8
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_GhostController()
		{
			Il2CppClassPointerStore<SECTR_GhostController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_GhostController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_GhostController>.NativeClassPtr);
			SECTR_GhostController.NativeFieldInfoPtr_FlySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_GhostController>.NativeClassPtr, "FlySpeed");
			SECTR_GhostController.NativeFieldInfoPtr_AccelerationRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_GhostController>.NativeClassPtr, "AccelerationRatio");
			SECTR_GhostController.NativeFieldInfoPtr_SlowDownRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_GhostController>.NativeClassPtr, "SlowDownRatio");
			SECTR_GhostController.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_GhostController>.NativeClassPtr, 100664434);
			SECTR_GhostController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_GhostController>.NativeClassPtr, 100664435);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0005AB3C File Offset: 0x00058D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43386, XrefRangeEnd = 43466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_GhostController.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x0005AB78 File Offset: 0x00058D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43466, XrefRangeEnd = 43467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_GhostController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_GhostController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_GhostController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00009BEE File Offset: 0x00007DEE
		public SECTR_GhostController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x0005ABB4 File Offset: 0x00058DB4
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x00009BF7 File Offset: 0x00007DF7
		public unsafe float FlySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_GhostController.NativeFieldInfoPtr_FlySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_GhostController.NativeFieldInfoPtr_FlySpeed)) = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x0005ABDC File Offset: 0x00058DDC
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x00009C12 File Offset: 0x00007E12
		public unsafe float AccelerationRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_GhostController.NativeFieldInfoPtr_AccelerationRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_GhostController.NativeFieldInfoPtr_AccelerationRatio)) = value;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x0005AC04 File Offset: 0x00058E04
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00009C2D File Offset: 0x00007E2D
		public unsafe float SlowDownRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_GhostController.NativeFieldInfoPtr_SlowDownRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_GhostController.NativeFieldInfoPtr_SlowDownRatio)) = value;
			}
		}

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeFieldInfoPtr_FlySpeed;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeFieldInfoPtr_AccelerationRatio;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeFieldInfoPtr_SlowDownRatio;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
