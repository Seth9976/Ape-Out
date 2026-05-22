using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000173 RID: 371
	public class Rocket : MonoBehaviour
	{
		// Token: 0x06002CBF RID: 11455 RVA: 0x000AFAA8 File Offset: 0x000ADCA8
		// Note: this type is marked as 'beforefieldinit'.
		static Rocket()
		{
			Il2CppClassPointerStore<Rocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Rocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rocket>.NativeClassPtr);
			Rocket.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rocket>.NativeClassPtr, "mask");
			Rocket.NativeFieldInfoPtr_prevPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rocket>.NativeClassPtr, "prevPos");
			Rocket.NativeFieldInfoPtr_pSys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rocket>.NativeClassPtr, "pSys");
			Rocket.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rocket>.NativeClassPtr, "timer");
			Rocket.NativeFieldInfoPtr_goVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rocket>.NativeClassPtr, "goVect");
			Rocket.NativeFieldInfoPtr_defPartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rocket>.NativeClassPtr, "defPartPos");
			Rocket.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rocket>.NativeClassPtr, 100666777);
			Rocket.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rocket>.NativeClassPtr, 100666778);
			Rocket.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rocket>.NativeClassPtr, 100666779);
			Rocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rocket>.NativeClassPtr, 100666780);
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x000AFBA0 File Offset: 0x000ADDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80642, XrefRangeEnd = 80689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rocket.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x000AFBD4 File Offset: 0x000ADDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80689, XrefRangeEnd = 80733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rocket.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x000AFC08 File Offset: 0x000ADE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80733, XrefRangeEnd = 80779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rocket.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x000AFC3C File Offset: 0x000ADE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rocket()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x0001F0DD File Offset: 0x0001D2DD
		public Rocket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x000AFC78 File Offset: 0x000ADE78
		// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x0001F0E6 File Offset: 0x0001D2E6
		public unsafe int mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rocket.NativeFieldInfoPtr_mask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rocket.NativeFieldInfoPtr_mask)) = value;
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x000AFCA0 File Offset: 0x000ADEA0
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x0001F101 File Offset: 0x0001D301
		public unsafe Vector2 prevPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rocket.NativeFieldInfoPtr_prevPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rocket.NativeFieldInfoPtr_prevPos)) = value;
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x000AFCC8 File Offset: 0x000ADEC8
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x0001F11C File Offset: 0x0001D31C
		public unsafe ParticleSystem pSys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rocket.NativeFieldInfoPtr_pSys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rocket.NativeFieldInfoPtr_pSys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x000AFCF8 File Offset: 0x000ADEF8
		// (set) Token: 0x06002CCC RID: 11468 RVA: 0x0001F13B File Offset: 0x0001D33B
		public unsafe int timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rocket.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rocket.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06002CCD RID: 11469 RVA: 0x000AFD20 File Offset: 0x000ADF20
		// (set) Token: 0x06002CCE RID: 11470 RVA: 0x0001F156 File Offset: 0x0001D356
		public unsafe Vector3 goVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rocket.NativeFieldInfoPtr_goVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rocket.NativeFieldInfoPtr_goVect)) = value;
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06002CCF RID: 11471 RVA: 0x000AFD48 File Offset: 0x000ADF48
		// (set) Token: 0x06002CD0 RID: 11472 RVA: 0x0001F171 File Offset: 0x0001D371
		public unsafe Vector3 defPartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rocket.NativeFieldInfoPtr_defPartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rocket.NativeFieldInfoPtr_defPartPos)) = value;
			}
		}

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeFieldInfoPtr_prevPos;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeFieldInfoPtr_pSys;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeFieldInfoPtr_goVect;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeFieldInfoPtr_defPartPos;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
