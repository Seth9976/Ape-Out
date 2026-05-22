using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000BA RID: 186
	public class Dynamite : Throwable
	{
		// Token: 0x0600165D RID: 5725 RVA: 0x00073524 File Offset: 0x00071724
		// Note: this type is marked as 'beforefieldinit'.
		static Dynamite()
		{
			Il2CppClassPointerStore<Dynamite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Dynamite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dynamite>.NativeClassPtr);
			Dynamite.NativeFieldInfoPtr_fuseTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, "fuseTimer");
			Dynamite.NativeFieldInfoPtr_thrown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, "thrown");
			Dynamite.NativeFieldInfoPtr_throwDest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, "throwDest");
			Dynamite.NativeFieldInfoPtr_throwDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, "throwDist");
			Dynamite.NativeFieldInfoPtr_spark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, "spark");
			Dynamite.NativeFieldInfoPtr_sparkCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, "sparkCounter");
			Dynamite.NativeFieldInfoPtr_sparkRelPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, "sparkRelPos");
			Dynamite.NativeFieldInfoPtr_waiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, "waiter");
			Dynamite.NativeFieldInfoPtr_fleer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, "fleer");
			Dynamite.NativeFieldInfoPtr_blinker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, "blinker");
			Dynamite.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665170);
			Dynamite.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665171);
			Dynamite.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665172);
			Dynamite.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665173);
			Dynamite.NativeMethodInfoPtr_Break_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665174);
			Dynamite.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665175);
			Dynamite.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Virtual_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665176);
			Dynamite.NativeMethodInfoPtr_SetFric_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665177);
			Dynamite.NativeMethodInfoPtr_PushDeal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665178);
			Dynamite.NativeMethodInfoPtr_OnThrown_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665179);
			Dynamite.NativeMethodInfoPtr_Animate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665180);
			Dynamite.NativeMethodInfoPtr_AnimateSpark_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665181);
			Dynamite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dynamite>.NativeClassPtr, 100665182);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00073720 File Offset: 0x00071920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55603, XrefRangeEnd = 55654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dynamite.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0007375C File Offset: 0x0007195C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55654, XrefRangeEnd = 55660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dynamite.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00073798 File Offset: 0x00071998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55660, XrefRangeEnd = 55677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dynamite.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000737D4 File Offset: 0x000719D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55677, XrefRangeEnd = 55685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBlown(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dynamite.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00073820 File Offset: 0x00071A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55685, XrefRangeEnd = 55709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Break()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dynamite.NativeMethodInfoPtr_Break_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x0007385C File Offset: 0x00071A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55709, XrefRangeEnd = 55712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dynamite.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00073898 File Offset: 0x00071A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55712, XrefRangeEnd = 55713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCollisionEnter2D(Collision2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dynamite.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Virtual_Void_Collision2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x000738E8 File Offset: 0x00071AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55713, XrefRangeEnd = 55723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetFric()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dynamite.NativeMethodInfoPtr_SetFric_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00073924 File Offset: 0x00071B24
		[CallerCount(0)]
		public unsafe override void PushDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dynamite.NativeMethodInfoPtr_PushDeal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00073960 File Offset: 0x00071B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55743, RefRangeEnd = 55744, XrefRangeStart = 55723, XrefRangeEnd = 55743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnThrown(Vector2 pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dynamite.NativeMethodInfoPtr_OnThrown_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x000739A0 File Offset: 0x00071BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55764, RefRangeEnd = 55765, XrefRangeStart = 55744, XrefRangeEnd = 55764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Animate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dynamite.NativeMethodInfoPtr_Animate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000739D4 File Offset: 0x00071BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55789, RefRangeEnd = 55790, XrefRangeStart = 55765, XrefRangeEnd = 55789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnimateSpark()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dynamite.NativeMethodInfoPtr_AnimateSpark_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00073A08 File Offset: 0x00071C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dynamite()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dynamite>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dynamite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00010285 File Offset: 0x0000E485
		public Dynamite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x00073A44 File Offset: 0x00071C44
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x0001028E File Offset: 0x0000E48E
		public unsafe int fuseTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_fuseTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_fuseTimer)) = value;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x00073A6C File Offset: 0x00071C6C
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x000102A9 File Offset: 0x0000E4A9
		public unsafe bool thrown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_thrown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_thrown)) = value;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x00073A94 File Offset: 0x00071C94
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x000102C4 File Offset: 0x0000E4C4
		public unsafe Vector2 throwDest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_throwDest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_throwDest)) = value;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x00073ABC File Offset: 0x00071CBC
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x000102DF File Offset: 0x0000E4DF
		public unsafe float throwDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_throwDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_throwDist)) = value;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00073AE4 File Offset: 0x00071CE4
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x000102FA File Offset: 0x0000E4FA
		public unsafe GameObject spark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_spark);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_spark), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x00073B14 File Offset: 0x00071D14
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x00010319 File Offset: 0x0000E519
		public unsafe int sparkCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_sparkCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_sparkCounter)) = value;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00073B3C File Offset: 0x00071D3C
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x00010334 File Offset: 0x0000E534
		public unsafe Vector2 sparkRelPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_sparkRelPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_sparkRelPos)) = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00073B64 File Offset: 0x00071D64
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x0001034F File Offset: 0x0000E54F
		public unsafe Waiter waiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_waiter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Waiter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_waiter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x00073B94 File Offset: 0x00071D94
		// (set) Token: 0x0600167D RID: 5757 RVA: 0x0001036E File Offset: 0x0000E56E
		public unsafe Fleer fleer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_fleer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fleer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_fleer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x00073BC4 File Offset: 0x00071DC4
		// (set) Token: 0x0600167F RID: 5759 RVA: 0x0001038D File Offset: 0x0000E58D
		public unsafe BlinkingLight blinker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_blinker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlinkingLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dynamite.NativeFieldInfoPtr_blinker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeFieldInfoPtr_fuseTimer;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeFieldInfoPtr_thrown;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeFieldInfoPtr_throwDest;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeFieldInfoPtr_throwDist;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeFieldInfoPtr_spark;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeFieldInfoPtr_sparkCounter;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeFieldInfoPtr_sparkRelPos;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeFieldInfoPtr_waiter;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeFieldInfoPtr_fleer;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeFieldInfoPtr_blinker;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_Void_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Public_Virtual_Void_Collision2D_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_SetFric_Public_Virtual_Void_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_PushDeal_Public_Virtual_Void_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_OnThrown_Public_Void_Vector2_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_Animate_Public_Void_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_AnimateSpark_Public_Void_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
