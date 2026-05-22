using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000C6 RID: 198
	public class Explosion : MonoBehaviour
	{
		// Token: 0x06001706 RID: 5894 RVA: 0x00075348 File Offset: 0x00073548
		// Note: this type is marked as 'beforefieldinit'.
		static Explosion()
		{
			Il2CppClassPointerStore<Explosion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Explosion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Explosion>.NativeClassPtr);
			Explosion.NativeFieldInfoPtr_deathTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "deathTimer");
			Explosion.NativeFieldInfoPtr_blowRad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "blowRad");
			Explosion.NativeFieldInfoPtr_playerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "playerBuffer");
			Explosion.NativeFieldInfoPtr_blowLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "blowLayers");
			Explosion.NativeFieldInfoPtr_fiery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "fiery");
			Explosion.NativeFieldInfoPtr_cosmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "cosmo");
			Explosion.NativeFieldInfoPtr_nonLethal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "nonLethal");
			Explosion.NativeFieldInfoPtr_playStartFXOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "playStartFXOnStart");
			Explosion.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "on");
			Explosion.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "particles");
			Explosion.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100665221);
			Explosion.NativeMethodInfoPtr_StartStuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100665222);
			Explosion.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100665223);
			Explosion.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100665224);
			Explosion.NativeMethodInfoPtr_Blow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100665225);
			Explosion.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100665226);
			Explosion.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100665227);
			Explosion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100665228);
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x000754E0 File Offset: 0x000736E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56380, XrefRangeEnd = 56381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00075514 File Offset: 0x00073714
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 56415, RefRangeEnd = 56418, XrefRangeStart = 56381, XrefRangeEnd = 56415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr_StartStuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00075548 File Offset: 0x00073748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56418, XrefRangeEnd = 56424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0007557C File Offset: 0x0007377C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56424, XrefRangeEnd = 56452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x000755B0 File Offset: 0x000737B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56567, RefRangeEnd = 56568, XrefRangeStart = 56452, XrefRangeEnd = 56567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr_Blow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x000755E4 File Offset: 0x000737E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56568, XrefRangeEnd = 56583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00075618 File Offset: 0x00073818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56583, XrefRangeEnd = 56602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x0007564C File Offset: 0x0007384C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Explosion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Explosion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x0001086B File Offset: 0x0000EA6B
		public Explosion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x00075688 File Offset: 0x00073888
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x00010874 File Offset: 0x0000EA74
		public unsafe int deathTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_deathTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_deathTimer)) = value;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x000756B0 File Offset: 0x000738B0
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x0001088F File Offset: 0x0000EA8F
		public unsafe float blowRad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_blowRad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_blowRad)) = value;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x000756D8 File Offset: 0x000738D8
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x000108AA File Offset: 0x0000EAAA
		public unsafe float playerBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_playerBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_playerBuffer)) = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x00075700 File Offset: 0x00073900
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x000108C5 File Offset: 0x0000EAC5
		public unsafe LayerMask blowLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_blowLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_blowLayers)) = value;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00075728 File Offset: 0x00073928
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x000108E0 File Offset: 0x0000EAE0
		public unsafe bool fiery
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_fiery);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_fiery)) = value;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x00075750 File Offset: 0x00073950
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x000108FB File Offset: 0x0000EAFB
		public unsafe bool cosmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_cosmo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_cosmo)) = value;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x00075778 File Offset: 0x00073978
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x00010916 File Offset: 0x0000EB16
		public unsafe bool nonLethal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_nonLethal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_nonLethal)) = value;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x000757A0 File Offset: 0x000739A0
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x00010931 File Offset: 0x0000EB31
		public unsafe bool playStartFXOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_playStartFXOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_playStartFXOnStart)) = value;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x000757C8 File Offset: 0x000739C8
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x0001094C File Offset: 0x0000EB4C
		public unsafe bool on
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_on);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_on)) = value;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x000757F0 File Offset: 0x000739F0
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x00010967 File Offset: 0x0000EB67
		public unsafe Il2CppReferenceArray<ParticleSystem> particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeFieldInfoPtr_deathTimer;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeFieldInfoPtr_blowRad;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeFieldInfoPtr_playerBuffer;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeFieldInfoPtr_blowLayers;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeFieldInfoPtr_fiery;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeFieldInfoPtr_cosmo;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeFieldInfoPtr_nonLethal;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeFieldInfoPtr_playStartFXOnStart;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeFieldInfoPtr_particles;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_StartStuff_Public_Void_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_Blow_Public_Void_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
