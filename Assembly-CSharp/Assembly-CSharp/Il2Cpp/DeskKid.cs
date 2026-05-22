using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000B4 RID: 180
	public class DeskKid : MonoBehaviour
	{
		// Token: 0x060015DF RID: 5599 RVA: 0x00072038 File Offset: 0x00070238
		// Note: this type is marked as 'beforefieldinit'.
		static DeskKid()
		{
			Il2CppClassPointerStore<DeskKid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DeskKid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeskKid>.NativeClassPtr);
			DeskKid.NativeFieldInfoPtr_topToppers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, "topToppers");
			DeskKid.NativeFieldInfoPtr_midToppers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, "midToppers");
			DeskKid.NativeFieldInfoPtr_underUnder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, "underUnder");
			DeskKid.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, "me");
			DeskKid.NativeFieldInfoPtr_toppers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, "toppers");
			DeskKid.NativeFieldInfoPtr_topperNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, "topperNum");
			DeskKid.NativeFieldInfoPtr_topperLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, "topperLocalPos");
			DeskKid.NativeFieldInfoPtr_defPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, "defPos");
			DeskKid.NativeFieldInfoPtr_defLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, "defLocalPos");
			DeskKid.NativeFieldInfoPtr_enableRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, "enableRan");
			DeskKid.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, 100665128);
			DeskKid.NativeMethodInfoPtr_MyStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, 100665129);
			DeskKid.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, 100665130);
			DeskKid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeskKid>.NativeClassPtr, 100665131);
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00072180 File Offset: 0x00070380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54577, XrefRangeEnd = 54595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeskKid.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x000721B4 File Offset: 0x000703B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54767, RefRangeEnd = 54768, XrefRangeStart = 54595, XrefRangeEnd = 54767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeskKid.NativeMethodInfoPtr_MyStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x000721E8 File Offset: 0x000703E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54768, XrefRangeEnd = 54807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeskKid.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x0007221C File Offset: 0x0007041C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeskKid()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeskKid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeskKid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x0000FDA2 File Offset: 0x0000DFA2
		public DeskKid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00072258 File Offset: 0x00070458
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x0000FDAB File Offset: 0x0000DFAB
		public unsafe Il2CppReferenceArray<Renderer> topToppers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_topToppers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_topToppers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x00072288 File Offset: 0x00070488
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x0000FDCA File Offset: 0x0000DFCA
		public unsafe Il2CppReferenceArray<Renderer> midToppers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_midToppers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_midToppers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x000722B8 File Offset: 0x000704B8
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x0000FDE9 File Offset: 0x0000DFE9
		public unsafe Il2CppReferenceArray<Renderer> underUnder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_underUnder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_underUnder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x000722E8 File Offset: 0x000704E8
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x0000FE08 File Offset: 0x0000E008
		public unsafe Renderer me
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_me);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_me), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x00072318 File Offset: 0x00070518
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x0000FE27 File Offset: 0x0000E027
		public unsafe Il2CppReferenceArray<GameObject> toppers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_toppers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_toppers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x00072348 File Offset: 0x00070548
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x0000FE46 File Offset: 0x0000E046
		public unsafe int topperNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_topperNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_topperNum)) = value;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x00072370 File Offset: 0x00070570
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x0000FE61 File Offset: 0x0000E061
		public unsafe Vector2 topperLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_topperLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_topperLocalPos)) = value;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x00072398 File Offset: 0x00070598
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x0000FE7C File Offset: 0x0000E07C
		public unsafe Vector3 defPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_defPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_defPos)) = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x000723C0 File Offset: 0x000705C0
		// (set) Token: 0x060015F6 RID: 5622 RVA: 0x0000FE97 File Offset: 0x0000E097
		public unsafe Vector3 defLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_defLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_defLocalPos)) = value;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x000723E8 File Offset: 0x000705E8
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x0000FEB2 File Offset: 0x0000E0B2
		public unsafe bool enableRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_enableRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeskKid.NativeFieldInfoPtr_enableRan)) = value;
			}
		}

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeFieldInfoPtr_topToppers;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeFieldInfoPtr_midToppers;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeFieldInfoPtr_underUnder;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeFieldInfoPtr_toppers;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeFieldInfoPtr_topperNum;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeFieldInfoPtr_topperLocalPos;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeFieldInfoPtr_defPos;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeFieldInfoPtr_defLocalPos;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeFieldInfoPtr_enableRan;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_MyStart_Private_Void_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
