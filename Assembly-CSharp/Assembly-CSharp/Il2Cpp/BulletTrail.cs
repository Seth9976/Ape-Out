using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000092 RID: 146
	public class BulletTrail : MonoBehaviour
	{
		// Token: 0x060011B3 RID: 4531 RVA: 0x00067354 File Offset: 0x00065554
		// Note: this type is marked as 'beforefieldinit'.
		static BulletTrail()
		{
			Il2CppClassPointerStore<BulletTrail>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BulletTrail");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BulletTrail>.NativeClassPtr);
			BulletTrail.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BulletTrail>.NativeClassPtr, "line");
			BulletTrail.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BulletTrail>.NativeClassPtr, "timer");
			BulletTrail.NativeFieldInfoPtr_startPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BulletTrail>.NativeClassPtr, "startPt");
			BulletTrail.NativeFieldInfoPtr_endPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BulletTrail>.NativeClassPtr, "endPt");
			BulletTrail.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BulletTrail>.NativeClassPtr, "on");
			BulletTrail.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BulletTrail>.NativeClassPtr, 100664789);
			BulletTrail.NativeMethodInfoPtr_DrawTrail_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BulletTrail>.NativeClassPtr, 100664790);
			BulletTrail.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BulletTrail>.NativeClassPtr, 100664791);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00067424 File Offset: 0x00065624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49229, XrefRangeEnd = 49239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BulletTrail.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00067458 File Offset: 0x00065658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49239, XrefRangeEnd = 49243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawTrail(Vector2 start, Vector2 end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BulletTrail.NativeMethodInfoPtr_DrawTrail_Public_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x000674A4 File Offset: 0x000656A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BulletTrail()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BulletTrail>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BulletTrail.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0000D014 File Offset: 0x0000B214
		public BulletTrail(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x000674E0 File Offset: 0x000656E0
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x0000D01D File Offset: 0x0000B21D
		public unsafe LineRenderer line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BulletTrail.NativeFieldInfoPtr_line);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BulletTrail.NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x00067510 File Offset: 0x00065710
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x0000D03C File Offset: 0x0000B23C
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BulletTrail.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BulletTrail.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x00067538 File Offset: 0x00065738
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x0000D057 File Offset: 0x0000B257
		public unsafe Vector2 startPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BulletTrail.NativeFieldInfoPtr_startPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BulletTrail.NativeFieldInfoPtr_startPt)) = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x00067560 File Offset: 0x00065760
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x0000D072 File Offset: 0x0000B272
		public unsafe Vector2 endPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BulletTrail.NativeFieldInfoPtr_endPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BulletTrail.NativeFieldInfoPtr_endPt)) = value;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00067588 File Offset: 0x00065788
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x0000D08D File Offset: 0x0000B28D
		public unsafe bool on
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BulletTrail.NativeFieldInfoPtr_on);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BulletTrail.NativeFieldInfoPtr_on)) = value;
			}
		}

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeFieldInfoPtr_startPt;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeFieldInfoPtr_endPt;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr_DrawTrail_Public_Void_Vector2_Vector2_0;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
