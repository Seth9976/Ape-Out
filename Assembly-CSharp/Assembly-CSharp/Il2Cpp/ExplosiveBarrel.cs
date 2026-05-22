using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000C7 RID: 199
	public class ExplosiveBarrel : Glass
	{
		// Token: 0x06001724 RID: 5924 RVA: 0x00075820 File Offset: 0x00073A20
		// Note: this type is marked as 'beforefieldinit'.
		static ExplosiveBarrel()
		{
			Il2CppClassPointerStore<ExplosiveBarrel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ExplosiveBarrel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExplosiveBarrel>.NativeClassPtr);
			ExplosiveBarrel.NativeFieldInfoPtr_rock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosiveBarrel>.NativeClassPtr, "rock");
			ExplosiveBarrel.NativeFieldInfoPtr_breakSnder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosiveBarrel>.NativeClassPtr, "breakSnder");
			ExplosiveBarrel.NativeFieldInfoPtr_box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosiveBarrel>.NativeClassPtr, "box");
			ExplosiveBarrel.NativeFieldInfoPtr_part = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosiveBarrel>.NativeClassPtr, "part");
			ExplosiveBarrel.NativeFieldInfoPtr_fuckThisShit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosiveBarrel>.NativeClassPtr, "fuckThisShit");
			ExplosiveBarrel.NativeFieldInfoPtr_breakDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosiveBarrel>.NativeClassPtr, "breakDir");
			ExplosiveBarrel.NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplosiveBarrel>.NativeClassPtr, 100665229);
			ExplosiveBarrel.NativeMethodInfoPtr_CastYourself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplosiveBarrel>.NativeClassPtr, 100665230);
			ExplosiveBarrel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplosiveBarrel>.NativeClassPtr, 100665231);
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00075904 File Offset: 0x00073B04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Break(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExplosiveBarrel.NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00075950 File Offset: 0x00073B50
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CastYourself()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExplosiveBarrel.NativeMethodInfoPtr_CastYourself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0007598C File Offset: 0x00073B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56602, XrefRangeEnd = 56603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExplosiveBarrel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExplosiveBarrel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExplosiveBarrel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00010986 File Offset: 0x0000EB86
		public ExplosiveBarrel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x000759C8 File Offset: 0x00073BC8
		// (set) Token: 0x0600172A RID: 5930 RVA: 0x0001098F File Offset: 0x0000EB8F
		public unsafe RockTech rock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExplosiveBarrel.NativeFieldInfoPtr_rock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RockTech>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExplosiveBarrel.NativeFieldInfoPtr_rock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x000759F8 File Offset: 0x00073BF8
		// (set) Token: 0x0600172C RID: 5932 RVA: 0x000109AE File Offset: 0x0000EBAE
		public unsafe AudioSource breakSnder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExplosiveBarrel.NativeFieldInfoPtr_breakSnder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExplosiveBarrel.NativeFieldInfoPtr_breakSnder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x00075A28 File Offset: 0x00073C28
		// (set) Token: 0x0600172E RID: 5934 RVA: 0x000109CD File Offset: 0x0000EBCD
		public unsafe BoxCollider2D box
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExplosiveBarrel.NativeFieldInfoPtr_box);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExplosiveBarrel.NativeFieldInfoPtr_box), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x00075A58 File Offset: 0x00073C58
		// (set) Token: 0x06001730 RID: 5936 RVA: 0x000109EC File Offset: 0x0000EBEC
		public unsafe GameObject part
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExplosiveBarrel.NativeFieldInfoPtr_part);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExplosiveBarrel.NativeFieldInfoPtr_part), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x00075A88 File Offset: 0x00073C88
		// (set) Token: 0x06001732 RID: 5938 RVA: 0x00010A0B File Offset: 0x0000EC0B
		public unsafe Il2CppReferenceArray<GameObject> fuckThisShit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExplosiveBarrel.NativeFieldInfoPtr_fuckThisShit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExplosiveBarrel.NativeFieldInfoPtr_fuckThisShit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x00075AB8 File Offset: 0x00073CB8
		// (set) Token: 0x06001734 RID: 5940 RVA: 0x00010A2A File Offset: 0x0000EC2A
		public unsafe Vector2 breakDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExplosiveBarrel.NativeFieldInfoPtr_breakDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExplosiveBarrel.NativeFieldInfoPtr_breakDir)) = value;
			}
		}

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeFieldInfoPtr_rock;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeFieldInfoPtr_breakSnder;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeFieldInfoPtr_box;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeFieldInfoPtr_part;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeFieldInfoPtr_fuckThisShit;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeFieldInfoPtr_breakDir;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_CastYourself_Public_Virtual_Void_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
