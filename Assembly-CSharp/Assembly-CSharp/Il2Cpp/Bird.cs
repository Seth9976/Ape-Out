using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200007C RID: 124
	public class Bird : MonoBehaviour
	{
		// Token: 0x0600103F RID: 4159 RVA: 0x000637AC File Offset: 0x000619AC
		// Note: this type is marked as 'beforefieldinit'.
		static Bird()
		{
			Il2CppClassPointerStore<Bird>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Bird");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bird>.NativeClassPtr);
			Bird.NativeFieldInfoPtr_babyBird = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "babyBird");
			Bird.NativeFieldInfoPtr_birdSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "birdSpd");
			Bird.NativeFieldInfoPtr_spinSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "spinSpd");
			Bird.NativeFieldInfoPtr_defScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "defScale");
			Bird.NativeFieldInfoPtr_defBabyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "defBabyScale");
			Bird.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bird>.NativeClassPtr, 100664663);
			Bird.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bird>.NativeClassPtr, 100664664);
			Bird.NativeMethodInfoPtr_RandomizeBirdShit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bird>.NativeClassPtr, 100664665);
			Bird.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bird>.NativeClassPtr, 100664666);
			Bird.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bird>.NativeClassPtr, 100664667);
			Bird.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bird>.NativeClassPtr, 100664668);
			Bird.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bird>.NativeClassPtr, 100664669);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000638CC File Offset: 0x00061ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47873, XrefRangeEnd = 47908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bird.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00063900 File Offset: 0x00061B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47908, XrefRangeEnd = 48013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bird.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00063934 File Offset: 0x00061B34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48061, RefRangeEnd = 48063, XrefRangeStart = 48013, XrefRangeEnd = 48061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeBirdShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bird.NativeMethodInfoPtr_RandomizeBirdShit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00063968 File Offset: 0x00061B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48063, XrefRangeEnd = 48079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bird.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0006399C File Offset: 0x00061B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48079, XrefRangeEnd = 48096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bird.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x000639D0 File Offset: 0x00061BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48096, XrefRangeEnd = 48105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bird.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00063A04 File Offset: 0x00061C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bird()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bird>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bird.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0000C0E7 File Offset: 0x0000A2E7
		public Bird(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x00063A40 File Offset: 0x00061C40
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		public unsafe Transform babyBird
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_babyBird);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_babyBird), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00063A70 File Offset: 0x00061C70
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x0000C10F File Offset: 0x0000A30F
		public unsafe float birdSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_birdSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_birdSpd)) = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x00063A98 File Offset: 0x00061C98
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x0000C12A File Offset: 0x0000A32A
		public unsafe float spinSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_spinSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_spinSpd)) = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x00063AC0 File Offset: 0x00061CC0
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x0000C145 File Offset: 0x0000A345
		public unsafe float defScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_defScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_defScale)) = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x00063AE8 File Offset: 0x00061CE8
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x0000C160 File Offset: 0x0000A360
		public unsafe float defBabyScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_defBabyScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_defBabyScale)) = value;
			}
		}

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr_babyBird;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeFieldInfoPtr_birdSpd;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeFieldInfoPtr_spinSpd;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeFieldInfoPtr_defScale;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeFieldInfoPtr_defBabyScale;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeBirdShit_Private_Void_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
