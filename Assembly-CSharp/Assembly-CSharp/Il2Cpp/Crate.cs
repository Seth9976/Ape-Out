using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000B1 RID: 177
	public class Crate : Glass
	{
		// Token: 0x06001594 RID: 5524 RVA: 0x00071414 File Offset: 0x0006F614
		// Note: this type is marked as 'beforefieldinit'.
		static Crate()
		{
			Il2CppClassPointerStore<Crate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Crate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Crate>.NativeClassPtr);
			Crate.NativeFieldInfoPtr_rock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crate>.NativeClassPtr, "rock");
			Crate.NativeFieldInfoPtr_box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crate>.NativeClassPtr, "box");
			Crate.NativeFieldInfoPtr_fuckThisShit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crate>.NativeClassPtr, "fuckThisShit");
			Crate.NativeFieldInfoPtr_breakDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crate>.NativeClassPtr, "breakDir");
			Crate.NativeFieldInfoPtr_sndNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crate>.NativeClassPtr, "sndNum");
			Crate.NativeFieldInfoPtr_offSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crate>.NativeClassPtr, "offSet");
			Crate.NativeFieldInfoPtr_breakLikeGlass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crate>.NativeClassPtr, "breakLikeGlass");
			Crate.NativeFieldInfoPtr_burned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crate>.NativeClassPtr, "burned");
			Crate.NativeFieldInfoPtr_myParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crate>.NativeClassPtr, "myParts");
			Crate.NativeFieldInfoPtr_renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crate>.NativeClassPtr, "renderers");
			Crate.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crate>.NativeClassPtr, 100665101);
			Crate.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crate>.NativeClassPtr, 100665102);
			Crate.NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crate>.NativeClassPtr, 100665103);
			Crate.NativeMethodInfoPtr_CastYourself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crate>.NativeClassPtr, 100665104);
			Crate.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crate>.NativeClassPtr, 100665105);
			Crate.NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crate>.NativeClassPtr, 100665106);
			Crate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crate>.NativeClassPtr, 100665107);
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00071598 File Offset: 0x0006F798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54250, XrefRangeEnd = 54277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crate.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x000715D4 File Offset: 0x0006F7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54277, XrefRangeEnd = 54307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crate.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00071610 File Offset: 0x0006F810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54307, XrefRangeEnd = 54400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Break(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crate.NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x0007165C File Offset: 0x0006F85C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CastYourself()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crate.NativeMethodInfoPtr_CastYourself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00071698 File Offset: 0x0006F898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54400, XrefRangeEnd = 54403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Crate.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x000716CC File Offset: 0x0006F8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54403, XrefRangeEnd = 54439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crate.NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00071708 File Offset: 0x0006F908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54439, XrefRangeEnd = 54440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Crate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Crate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Crate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x0000FA73 File Offset: 0x0000DC73
		public Crate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x00071744 File Offset: 0x0006F944
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		public unsafe RockTech rock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_rock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RockTech>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_rock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x00071774 File Offset: 0x0006F974
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x0000FA9B File Offset: 0x0000DC9B
		public unsafe BoxCollider2D box
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_box);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_box), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x000717A4 File Offset: 0x0006F9A4
		// (set) Token: 0x060015A2 RID: 5538 RVA: 0x0000FABA File Offset: 0x0000DCBA
		public unsafe Il2CppReferenceArray<GameObject> fuckThisShit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_fuckThisShit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_fuckThisShit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x000717D4 File Offset: 0x0006F9D4
		// (set) Token: 0x060015A4 RID: 5540 RVA: 0x0000FAD9 File Offset: 0x0000DCD9
		public unsafe Vector2 breakDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_breakDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_breakDir)) = value;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x000717FC File Offset: 0x0006F9FC
		// (set) Token: 0x060015A6 RID: 5542 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		public unsafe int sndNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_sndNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_sndNum)) = value;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00071824 File Offset: 0x0006FA24
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x0000FB0F File Offset: 0x0000DD0F
		public unsafe Vector2 offSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_offSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_offSet)) = value;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x0007184C File Offset: 0x0006FA4C
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x0000FB2A File Offset: 0x0000DD2A
		public unsafe bool breakLikeGlass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_breakLikeGlass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_breakLikeGlass)) = value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x00071874 File Offset: 0x0006FA74
		// (set) Token: 0x060015AC RID: 5548 RVA: 0x0000FB45 File Offset: 0x0000DD45
		public unsafe bool burned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_burned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_burned)) = value;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x0007189C File Offset: 0x0006FA9C
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x0000FB60 File Offset: 0x0000DD60
		public unsafe FX.ParticleType myParts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_myParts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_myParts)) = value;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x000718C4 File Offset: 0x0006FAC4
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x0000FB7B File Offset: 0x0000DD7B
		public unsafe Il2CppReferenceArray<Renderer> renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crate.NativeFieldInfoPtr_renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeFieldInfoPtr_rock;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeFieldInfoPtr_box;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeFieldInfoPtr_fuckThisShit;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeFieldInfoPtr_breakDir;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeFieldInfoPtr_sndNum;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeFieldInfoPtr_offSet;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeFieldInfoPtr_breakLikeGlass;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeFieldInfoPtr_burned;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeFieldInfoPtr_myParts;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeFieldInfoPtr_renderers;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_CastYourself_Public_Virtual_Void_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
