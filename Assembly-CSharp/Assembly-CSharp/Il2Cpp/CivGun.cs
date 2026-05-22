using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000A5 RID: 165
	public class CivGun : GuardGun
	{
		// Token: 0x06001416 RID: 5142 RVA: 0x0006D54C File Offset: 0x0006B74C
		// Note: this type is marked as 'beforefieldinit'.
		static CivGun()
		{
			Il2CppClassPointerStore<CivGun>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CivGun");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CivGun>.NativeClassPtr);
			CivGun.NativeFieldInfoPtr_gunHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CivGun>.NativeClassPtr, "gunHand");
			CivGun.NativeFieldInfoPtr_lFoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CivGun>.NativeClassPtr, "lFoot");
			CivGun.NativeFieldInfoPtr_boop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CivGun>.NativeClassPtr, "boop");
			CivGun.NativeFieldInfoPtr_rHandPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CivGun>.NativeClassPtr, "rHandPos");
			CivGun.NativeFieldInfoPtr_lHandPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CivGun>.NativeClassPtr, "lHandPos");
			CivGun.NativeFieldInfoPtr_prevNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CivGun>.NativeClassPtr, "prevNum");
			CivGun.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CivGun>.NativeClassPtr, 100665006);
			CivGun.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CivGun>.NativeClassPtr, 100665007);
			CivGun.NativeMethodInfoPtr_Fire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CivGun>.NativeClassPtr, 100665008);
			CivGun.NativeMethodInfoPtr_MoveGun_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CivGun>.NativeClassPtr, 100665009);
			CivGun.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CivGun>.NativeClassPtr, 100665010);
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0006D658 File Offset: 0x0006B858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52089, XrefRangeEnd = 52090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CivGun.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0006D694 File Offset: 0x0006B894
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CivGun.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0006D6D0 File Offset: 0x0006B8D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CivGun.NativeMethodInfoPtr_Fire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0006D70C File Offset: 0x0006B90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52090, XrefRangeEnd = 52123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveGun()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CivGun.NativeMethodInfoPtr_MoveGun_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0006D748 File Offset: 0x0006B948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52123, XrefRangeEnd = 52124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CivGun()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CivGun>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CivGun.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0000EAB5 File Offset: 0x0000CCB5
		public CivGun(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0006D784 File Offset: 0x0006B984
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x0000EABE File Offset: 0x0000CCBE
		public unsafe GameObject gunHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivGun.NativeFieldInfoPtr_gunHand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivGun.NativeFieldInfoPtr_gunHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0006D7B4 File Offset: 0x0006B9B4
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x0000EADD File Offset: 0x0000CCDD
		public unsafe GameObject lFoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivGun.NativeFieldInfoPtr_lFoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivGun.NativeFieldInfoPtr_lFoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0006D7E4 File Offset: 0x0006B9E4
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x0000EAFC File Offset: 0x0000CCFC
		public unsafe Vector2 boop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivGun.NativeFieldInfoPtr_boop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivGun.NativeFieldInfoPtr_boop)) = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x0006D80C File Offset: 0x0006BA0C
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x0000EB17 File Offset: 0x0000CD17
		public unsafe Il2CppReferenceArray<Transform> rHandPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivGun.NativeFieldInfoPtr_rHandPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivGun.NativeFieldInfoPtr_rHandPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0006D83C File Offset: 0x0006BA3C
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x0000EB36 File Offset: 0x0000CD36
		public unsafe Il2CppReferenceArray<Transform> lHandPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivGun.NativeFieldInfoPtr_lHandPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivGun.NativeFieldInfoPtr_lHandPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0006D86C File Offset: 0x0006BA6C
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x0000EB55 File Offset: 0x0000CD55
		public unsafe float prevNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivGun.NativeFieldInfoPtr_prevNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CivGun.NativeFieldInfoPtr_prevNum)) = value;
			}
		}

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeFieldInfoPtr_gunHand;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeFieldInfoPtr_lFoot;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeFieldInfoPtr_boop;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeFieldInfoPtr_rHandPos;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeFieldInfoPtr_lHandPos;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeFieldInfoPtr_prevNum;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Virtual_Void_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_MoveGun_Public_Virtual_Void_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
