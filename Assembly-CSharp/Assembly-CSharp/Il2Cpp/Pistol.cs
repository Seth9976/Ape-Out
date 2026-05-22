using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200015E RID: 350
	public class Pistol : GuardGun
	{
		// Token: 0x06002994 RID: 10644 RVA: 0x000A7540 File Offset: 0x000A5740
		// Note: this type is marked as 'beforefieldinit'.
		static Pistol()
		{
			Il2CppClassPointerStore<Pistol>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Pistol");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pistol>.NativeClassPtr);
			Pistol.NativeFieldInfoPtr_clipSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pistol>.NativeClassPtr, "clipSize");
			Pistol.NativeFieldInfoPtr_bulletNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pistol>.NativeClassPtr, "bulletNum");
			Pistol.NativeFieldInfoPtr_reloadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pistol>.NativeClassPtr, "reloadTime");
			Pistol.NativeFieldInfoPtr_gunHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pistol>.NativeClassPtr, "gunHand");
			Pistol.NativeFieldInfoPtr_aimOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pistol>.NativeClassPtr, "aimOffset");
			Pistol.NativeFieldInfoPtr_aimRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pistol>.NativeClassPtr, "aimRight");
			Pistol.NativeFieldInfoPtr_reloading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pistol>.NativeClassPtr, "reloading");
			Pistol.NativeFieldInfoPtr_offsetCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pistol>.NativeClassPtr, "offsetCap");
			Pistol.NativeFieldInfoPtr_loadTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pistol>.NativeClassPtr, "loadTimer");
			Pistol.NativeFieldInfoPtr_loadGunAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pistol>.NativeClassPtr, "loadGunAng");
			Pistol.NativeFieldInfoPtr_lFoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pistol>.NativeClassPtr, "lFoot");
			Pistol.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pistol>.NativeClassPtr, 100666588);
			Pistol.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pistol>.NativeClassPtr, 100666589);
			Pistol.NativeMethodInfoPtr_ManageCocking_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pistol>.NativeClassPtr, 100666590);
			Pistol.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pistol>.NativeClassPtr, 100666591);
			Pistol.NativeMethodInfoPtr_AimAt_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pistol>.NativeClassPtr, 100666592);
			Pistol.NativeMethodInfoPtr_MoveGun_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pistol>.NativeClassPtr, 100666593);
			Pistol.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pistol>.NativeClassPtr, 100666594);
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000A76D8 File Offset: 0x000A58D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77138, XrefRangeEnd = 77147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pistol.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000A7714 File Offset: 0x000A5914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77147, XrefRangeEnd = 77148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pistol.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000A7750 File Offset: 0x000A5950
		[CallerCount(0)]
		public unsafe override void ManageCocking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pistol.NativeMethodInfoPtr_ManageCocking_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000A778C File Offset: 0x000A598C
		[CallerCount(0)]
		public unsafe override void Shoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pistol.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000A77C8 File Offset: 0x000A59C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77148, XrefRangeEnd = 77163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AimAt(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pistol.NativeMethodInfoPtr_AimAt_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000A7814 File Offset: 0x000A5A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77163, XrefRangeEnd = 77226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveGun()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pistol.NativeMethodInfoPtr_MoveGun_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000A7850 File Offset: 0x000A5A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pistol()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pistol>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pistol.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
		public Pistol(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x000A788C File Offset: 0x000A5A8C
		// (set) Token: 0x0600299E RID: 10654 RVA: 0x0001CEB1 File Offset: 0x0001B0B1
		public unsafe int clipSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_clipSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_clipSize)) = value;
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x0600299F RID: 10655 RVA: 0x000A78B4 File Offset: 0x000A5AB4
		// (set) Token: 0x060029A0 RID: 10656 RVA: 0x0001CECC File Offset: 0x0001B0CC
		public unsafe int bulletNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_bulletNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_bulletNum)) = value;
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x060029A1 RID: 10657 RVA: 0x000A78DC File Offset: 0x000A5ADC
		// (set) Token: 0x060029A2 RID: 10658 RVA: 0x0001CEE7 File Offset: 0x0001B0E7
		public unsafe int reloadTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_reloadTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_reloadTime)) = value;
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x060029A3 RID: 10659 RVA: 0x000A7904 File Offset: 0x000A5B04
		// (set) Token: 0x060029A4 RID: 10660 RVA: 0x0001CF02 File Offset: 0x0001B102
		public unsafe GameObject gunHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_gunHand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_gunHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x060029A5 RID: 10661 RVA: 0x000A7934 File Offset: 0x000A5B34
		// (set) Token: 0x060029A6 RID: 10662 RVA: 0x0001CF21 File Offset: 0x0001B121
		public unsafe float aimOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_aimOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_aimOffset)) = value;
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x060029A7 RID: 10663 RVA: 0x000A795C File Offset: 0x000A5B5C
		// (set) Token: 0x060029A8 RID: 10664 RVA: 0x0001CF3C File Offset: 0x0001B13C
		public unsafe bool aimRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_aimRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_aimRight)) = value;
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x060029A9 RID: 10665 RVA: 0x000A7984 File Offset: 0x000A5B84
		// (set) Token: 0x060029AA RID: 10666 RVA: 0x0001CF57 File Offset: 0x0001B157
		public unsafe bool reloading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_reloading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_reloading)) = value;
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x000A79AC File Offset: 0x000A5BAC
		// (set) Token: 0x060029AC RID: 10668 RVA: 0x0001CF72 File Offset: 0x0001B172
		public unsafe float offsetCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_offsetCap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_offsetCap)) = value;
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x060029AD RID: 10669 RVA: 0x000A79D4 File Offset: 0x000A5BD4
		// (set) Token: 0x060029AE RID: 10670 RVA: 0x0001CF8D File Offset: 0x0001B18D
		public unsafe int loadTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_loadTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_loadTimer)) = value;
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x060029AF RID: 10671 RVA: 0x000A79FC File Offset: 0x000A5BFC
		// (set) Token: 0x060029B0 RID: 10672 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
		public unsafe float loadGunAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_loadGunAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_loadGunAng)) = value;
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x000A7A24 File Offset: 0x000A5C24
		// (set) Token: 0x060029B2 RID: 10674 RVA: 0x0001CFC3 File Offset: 0x0001B1C3
		public unsafe GameObject lFoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_lFoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pistol.NativeFieldInfoPtr_lFoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeFieldInfoPtr_clipSize;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeFieldInfoPtr_bulletNum;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeFieldInfoPtr_reloadTime;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeFieldInfoPtr_gunHand;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeFieldInfoPtr_aimOffset;

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeFieldInfoPtr_aimRight;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeFieldInfoPtr_reloading;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeFieldInfoPtr_offsetCap;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeFieldInfoPtr_loadTimer;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeFieldInfoPtr_loadGunAng;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeFieldInfoPtr_lFoot;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeMethodInfoPtr_ManageCocking_Public_Virtual_Void_0;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeMethodInfoPtr_AimAt_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeMethodInfoPtr_MoveGun_Public_Virtual_Void_0;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
