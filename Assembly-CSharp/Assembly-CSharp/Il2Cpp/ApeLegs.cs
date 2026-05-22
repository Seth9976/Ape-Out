using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200006B RID: 107
	public class ApeLegs : Legs
	{
		// Token: 0x06000E30 RID: 3632 RVA: 0x0005DEEC File Offset: 0x0005C0EC
		// Note: this type is marked as 'beforefieldinit'.
		static ApeLegs()
		{
			Il2CppClassPointerStore<ApeLegs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ApeLegs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr);
			ApeLegs.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, "running");
			ApeLegs.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, "rb");
			ApeLegs.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, "state");
			ApeLegs.NativeFieldInfoPtr_flailRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, "flailRight");
			ApeLegs.NativeFieldInfoPtr_flailing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, "flailing");
			ApeLegs.NativeFieldInfoPtr_flailAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, "flailAng");
			ApeLegs.NativeFieldInfoPtr_localPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, "localPos");
			ApeLegs.NativeFieldInfoPtr_obstacleMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, "obstacleMask");
			ApeLegs.NativeFieldInfoPtr_buttocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, "buttocks");
			ApeLegs.NativeFieldInfoPtr_buttockFollowAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, "buttockFollowAmount");
			ApeLegs.NativeFieldInfoPtr_justTeleported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, "justTeleported");
			ApeLegs.NativeMethodInfoPtr_InitShit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664504);
			ApeLegs.NativeMethodInfoPtr_Flail_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664505);
			ApeLegs.NativeMethodInfoPtr_FlailPaws_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664506);
			ApeLegs.NativeMethodInfoPtr_Buttocks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664507);
			ApeLegs.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664508);
			ApeLegs.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664509);
			ApeLegs.NativeMethodInfoPtr_DrawArms_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664510);
			ApeLegs.NativeMethodInfoPtr_UpdatePaws_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664511);
			ApeLegs.NativeMethodInfoPtr_RayGo_Private_RaycastHit2D_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664512);
			ApeLegs.NativeMethodInfoPtr_Teleport_Public_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664513);
			ApeLegs.NativeMethodInfoPtr_DrawBack_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664514);
			ApeLegs.NativeMethodInfoPtr_MoveElbows_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664515);
			ApeLegs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, 100664516);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0005E0FC File Offset: 0x0005C2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44956, XrefRangeEnd = 44975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApeLegs.NativeMethodInfoPtr_InitShit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0005E138 File Offset: 0x0005C338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44975, XrefRangeEnd = 44978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApeLegs.NativeMethodInfoPtr_Flail_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0005E178 File Offset: 0x0005C378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44988, RefRangeEnd = 44989, XrefRangeStart = 44978, XrefRangeEnd = 44988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlailPaws()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApeLegs.NativeMethodInfoPtr_FlailPaws_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0005E1AC File Offset: 0x0005C3AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45002, XrefRangeStart = 44989, XrefRangeEnd = 45001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Buttocks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApeLegs.NativeMethodInfoPtr_Buttocks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0005E1E0 File Offset: 0x0005C3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45002, XrefRangeEnd = 45028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApeLegs.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0005E214 File Offset: 0x0005C414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45028, XrefRangeEnd = 45069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApeLegs.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0005E250 File Offset: 0x0005C450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45069, XrefRangeEnd = 45084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DrawArms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApeLegs.NativeMethodInfoPtr_DrawArms_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0005E28C File Offset: 0x0005C48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45084, XrefRangeEnd = 45086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdatePaws()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApeLegs.NativeMethodInfoPtr_UpdatePaws_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0005E2C8 File Offset: 0x0005C4C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 45097, RefRangeEnd = 45101, XrefRangeStart = 45086, XrefRangeEnd = 45097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaycastHit2D RayGo(float ang, float dist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ang;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApeLegs.NativeMethodInfoPtr_RayGo_Private_RaycastHit2D_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0005E320 File Offset: 0x0005C520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45101, XrefRangeEnd = 45188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Teleport(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApeLegs.NativeMethodInfoPtr_Teleport_Public_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0005E36C File Offset: 0x0005C56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45188, XrefRangeEnd = 45246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DrawBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApeLegs.NativeMethodInfoPtr_DrawBack_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0005E3A8 File Offset: 0x0005C5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45246, XrefRangeEnd = 45259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveElbows()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApeLegs.NativeMethodInfoPtr_MoveElbows_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0005E3E4 File Offset: 0x0005C5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApeLegs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApeLegs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0000AC29 File Offset: 0x00008E29
		public ApeLegs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x0005E420 File Offset: 0x0005C620
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x0000AC32 File Offset: 0x00008E32
		public unsafe bool running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_running)) = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0005E448 File Offset: 0x0005C648
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x0000AC4D File Offset: 0x00008E4D
		public unsafe Rigidbody2D rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x0005E478 File Offset: 0x0005C678
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x0000AC6C File Offset: 0x00008E6C
		public unsafe PlayerState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0005E4A8 File Offset: 0x0005C6A8
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x0000AC8B File Offset: 0x00008E8B
		public unsafe bool flailRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_flailRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_flailRight)) = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0005E4D0 File Offset: 0x0005C6D0
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x0000ACA6 File Offset: 0x00008EA6
		public unsafe bool flailing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_flailing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_flailing)) = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x0005E4F8 File Offset: 0x0005C6F8
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x0000ACC1 File Offset: 0x00008EC1
		public unsafe float flailAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_flailAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_flailAng)) = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0005E520 File Offset: 0x0005C720
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x0000ACDC File Offset: 0x00008EDC
		public unsafe Il2CppStructArray<Vector2> localPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_localPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_localPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0005E550 File Offset: 0x0005C750
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x0000ACFB File Offset: 0x00008EFB
		public unsafe int obstacleMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_obstacleMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_obstacleMask)) = value;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0005E578 File Offset: 0x0005C778
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x0000AD16 File Offset: 0x00008F16
		public unsafe Il2CppReferenceArray<Transform> buttocks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_buttocks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_buttocks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0005E5A8 File Offset: 0x0005C7A8
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x0000AD35 File Offset: 0x00008F35
		public unsafe float buttockFollowAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_buttockFollowAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_buttockFollowAmount)) = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0005E5D0 File Offset: 0x0005C7D0
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x0000AD50 File Offset: 0x00008F50
		public unsafe bool justTeleported
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_justTeleported);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs.NativeFieldInfoPtr_justTeleported)) = value;
			}
		}

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeFieldInfoPtr_flailRight;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeFieldInfoPtr_flailing;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeFieldInfoPtr_flailAng;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeFieldInfoPtr_localPos;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeFieldInfoPtr_obstacleMask;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeFieldInfoPtr_buttocks;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeFieldInfoPtr_buttockFollowAmount;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeFieldInfoPtr_justTeleported;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_InitShit_Public_Virtual_Void_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_Flail_Private_IEnumerator_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_FlailPaws_Private_Void_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_Buttocks_Private_Void_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_DrawArms_Public_Virtual_Void_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePaws_Public_Virtual_Void_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_RayGo_Private_RaycastHit2D_Single_Single_0;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_Teleport_Public_Virtual_Void_Vector3_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_DrawBack_Public_Virtual_Void_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_MoveElbows_Public_Virtual_Void_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D2 RID: 722
		[ObfuscatedName("ApeLegs+<Flail>d__12")]
		public sealed class _Flail_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x06004CD8 RID: 19672 RVA: 0x0011A8C8 File Offset: 0x00118AC8
			// Note: this type is marked as 'beforefieldinit'.
			static _Flail_d__12()
			{
				Il2CppClassPointerStore<ApeLegs._Flail_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApeLegs>.NativeClassPtr, "<Flail>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApeLegs._Flail_d__12>.NativeClassPtr);
				ApeLegs._Flail_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs._Flail_d__12>.NativeClassPtr, "<>1__state");
				ApeLegs._Flail_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs._Flail_d__12>.NativeClassPtr, "<>2__current");
				ApeLegs._Flail_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApeLegs._Flail_d__12>.NativeClassPtr, "<>4__this");
				ApeLegs._Flail_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs._Flail_d__12>.NativeClassPtr, 100664517);
				ApeLegs._Flail_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs._Flail_d__12>.NativeClassPtr, 100664518);
				ApeLegs._Flail_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs._Flail_d__12>.NativeClassPtr, 100664519);
				ApeLegs._Flail_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs._Flail_d__12>.NativeClassPtr, 100664520);
				ApeLegs._Flail_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs._Flail_d__12>.NativeClassPtr, 100664521);
				ApeLegs._Flail_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApeLegs._Flail_d__12>.NativeClassPtr, 100664522);
			}

			// Token: 0x06004CD9 RID: 19673 RVA: 0x0011A9A8 File Offset: 0x00118BA8
			[CallerCount(0)]
			public unsafe _Flail_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApeLegs._Flail_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApeLegs._Flail_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004CDA RID: 19674 RVA: 0x0011A9F0 File Offset: 0x00118BF0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApeLegs._Flail_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CDB RID: 19675 RVA: 0x0011AA24 File Offset: 0x00118C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44943, XrefRangeEnd = 44951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApeLegs._Flail_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C01 RID: 7169
			// (get) Token: 0x06004CDC RID: 19676 RVA: 0x0011AA60 File Offset: 0x00118C60
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApeLegs._Flail_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004CDD RID: 19677 RVA: 0x0011AAA0 File Offset: 0x00118CA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44951, XrefRangeEnd = 44956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApeLegs._Flail_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C02 RID: 7170
			// (get) Token: 0x06004CDE RID: 19678 RVA: 0x0011AAD4 File Offset: 0x00118CD4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApeLegs._Flail_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004CDF RID: 19679 RVA: 0x0002D3EE File Offset: 0x0002B5EE
			public _Flail_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BFE RID: 7166
			// (get) Token: 0x06004CE0 RID: 19680 RVA: 0x0011AB14 File Offset: 0x00118D14
			// (set) Token: 0x06004CE1 RID: 19681 RVA: 0x0002D3F7 File Offset: 0x0002B5F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs._Flail_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs._Flail_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BFF RID: 7167
			// (get) Token: 0x06004CE2 RID: 19682 RVA: 0x0011AB3C File Offset: 0x00118D3C
			// (set) Token: 0x06004CE3 RID: 19683 RVA: 0x0002D412 File Offset: 0x0002B612
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs._Flail_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs._Flail_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C00 RID: 7168
			// (get) Token: 0x06004CE4 RID: 19684 RVA: 0x0011AB6C File Offset: 0x00118D6C
			// (set) Token: 0x06004CE5 RID: 19685 RVA: 0x0002D431 File Offset: 0x0002B631
			public unsafe ApeLegs __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs._Flail_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ApeLegs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApeLegs._Flail_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003252 RID: 12882
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003253 RID: 12883
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003254 RID: 12884
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003255 RID: 12885
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003256 RID: 12886
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003257 RID: 12887
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003258 RID: 12888
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003259 RID: 12889
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400325A RID: 12890
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
