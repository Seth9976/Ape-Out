using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000126 RID: 294
	public class MachineGun : GuardGun
	{
		// Token: 0x060022FA RID: 8954 RVA: 0x000955D8 File Offset: 0x000937D8
		// Note: this type is marked as 'beforefieldinit'.
		static MachineGun()
		{
			Il2CppClassPointerStore<MachineGun>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MachineGun");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MachineGun>.NativeClassPtr);
			MachineGun.NativeFieldInfoPtr_clipSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, "clipSize");
			MachineGun.NativeFieldInfoPtr_bulletNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, "bulletNum");
			MachineGun.NativeFieldInfoPtr_shootVirgin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, "shootVirgin");
			MachineGun.NativeFieldInfoPtr_grabShoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, "grabShoot");
			MachineGun.NativeFieldInfoPtr_aimRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, "aimRight");
			MachineGun.NativeFieldInfoPtr_shootin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, "shootin");
			MachineGun.NativeFieldInfoPtr_actualShootPrepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, "actualShootPrepTime");
			MachineGun.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, 100666015);
			MachineGun.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, 100666016);
			MachineGun.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, 100666017);
			MachineGun.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, 100666018);
			MachineGun.NativeMethodInfoPtr_Fire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, 100666019);
			MachineGun.NativeMethodInfoPtr_PlayCockSnd_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, 100666020);
			MachineGun.NativeMethodInfoPtr_PlayShotSnd_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, 100666021);
			MachineGun.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MachineGun>.NativeClassPtr, 100666022);
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00095734 File Offset: 0x00093934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69771, XrefRangeEnd = 69772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MachineGun.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00095770 File Offset: 0x00093970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69772, XrefRangeEnd = 69785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MachineGun.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x000957AC File Offset: 0x000939AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69785, XrefRangeEnd = 69786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MachineGun.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x000957E8 File Offset: 0x000939E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69786, XrefRangeEnd = 69796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MachineGun.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00095824 File Offset: 0x00093A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69796, XrefRangeEnd = 69828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MachineGun.NativeMethodInfoPtr_Fire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x00095860 File Offset: 0x00093A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69828, XrefRangeEnd = 69833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayCockSnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MachineGun.NativeMethodInfoPtr_PlayCockSnd_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x0009589C File Offset: 0x00093A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69833, XrefRangeEnd = 69843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayShotSnd(Vector3 muzzlePosition, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref muzzlePosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MachineGun.NativeMethodInfoPtr_PlayShotSnd_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x000958F4 File Offset: 0x00093AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69843, XrefRangeEnd = 69844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MachineGun()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MachineGun>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MachineGun.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00018868 File Offset: 0x00016A68
		public MachineGun(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x00095930 File Offset: 0x00093B30
		// (set) Token: 0x06002305 RID: 8965 RVA: 0x00018871 File Offset: 0x00016A71
		public unsafe int clipSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_clipSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_clipSize)) = value;
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x00095958 File Offset: 0x00093B58
		// (set) Token: 0x06002307 RID: 8967 RVA: 0x0001888C File Offset: 0x00016A8C
		public unsafe int bulletNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_bulletNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_bulletNum)) = value;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x00095980 File Offset: 0x00093B80
		// (set) Token: 0x06002309 RID: 8969 RVA: 0x000188A7 File Offset: 0x00016AA7
		public unsafe bool shootVirgin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_shootVirgin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_shootVirgin)) = value;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x000959A8 File Offset: 0x00093BA8
		// (set) Token: 0x0600230B RID: 8971 RVA: 0x000188C2 File Offset: 0x00016AC2
		public unsafe bool grabShoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_grabShoot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_grabShoot)) = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x000959D0 File Offset: 0x00093BD0
		// (set) Token: 0x0600230D RID: 8973 RVA: 0x000188DD File Offset: 0x00016ADD
		public unsafe bool aimRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_aimRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_aimRight)) = value;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x000959F8 File Offset: 0x00093BF8
		// (set) Token: 0x0600230F RID: 8975 RVA: 0x000188F8 File Offset: 0x00016AF8
		public unsafe bool shootin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_shootin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_shootin)) = value;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06002310 RID: 8976 RVA: 0x00095A20 File Offset: 0x00093C20
		// (set) Token: 0x06002311 RID: 8977 RVA: 0x00018913 File Offset: 0x00016B13
		public unsafe int actualShootPrepTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_actualShootPrepTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MachineGun.NativeFieldInfoPtr_actualShootPrepTime)) = value;
			}
		}

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeFieldInfoPtr_clipSize;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeFieldInfoPtr_bulletNum;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeFieldInfoPtr_shootVirgin;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeFieldInfoPtr_grabShoot;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeFieldInfoPtr_aimRight;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeFieldInfoPtr_shootin;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeFieldInfoPtr_actualShootPrepTime;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Virtual_Void_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_PlayCockSnd_Public_Virtual_Void_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_PlayShotSnd_Public_Virtual_Void_Vector3_Quaternion_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
