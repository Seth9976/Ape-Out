using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000093 RID: 147
	public class Bunker08Blower : MonoBehaviour
	{
		// Token: 0x060011C2 RID: 4546 RVA: 0x000675B0 File Offset: 0x000657B0
		// Note: this type is marked as 'beforefieldinit'.
		static Bunker08Blower()
		{
			Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Bunker08Blower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr);
			Bunker08Blower.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr, "done");
			Bunker08Blower.NativeFieldInfoPtr_unblown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr, "unblown");
			Bunker08Blower.NativeFieldInfoPtr_blown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr, "blown");
			Bunker08Blower.NativeFieldInfoPtr_extraExplosions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr, "extraExplosions");
			Bunker08Blower.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr, "me");
			Bunker08Blower.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr, "tile");
			Bunker08Blower.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr, 100664792);
			Bunker08Blower.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr, 100664793);
			Bunker08Blower.NativeMethodInfoPtr_Extra_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr, 100664794);
			Bunker08Blower.NativeMethodInfoPtr_Go_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr, 100664795);
			Bunker08Blower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr, 100664796);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x000676BC File Offset: 0x000658BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49243, XrefRangeEnd = 49251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bunker08Blower.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x000676F0 File Offset: 0x000658F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49251, XrefRangeEnd = 49257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bunker08Blower.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00067734 File Offset: 0x00065934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49257, XrefRangeEnd = 49262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Extra()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bunker08Blower.NativeMethodInfoPtr_Extra_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00067768 File Offset: 0x00065968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49262, XrefRangeEnd = 49271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Go()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bunker08Blower.NativeMethodInfoPtr_Go_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0006779C File Offset: 0x0006599C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bunker08Blower()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bunker08Blower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bunker08Blower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		public Bunker08Blower(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x000677D8 File Offset: 0x000659D8
		// (set) Token: 0x060011CA RID: 4554 RVA: 0x0000D0B1 File Offset: 0x0000B2B1
		public unsafe bool done
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bunker08Blower.NativeFieldInfoPtr_done);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bunker08Blower.NativeFieldInfoPtr_done)) = value;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x00067800 File Offset: 0x00065A00
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x0000D0CC File Offset: 0x0000B2CC
		public unsafe GameObject unblown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bunker08Blower.NativeFieldInfoPtr_unblown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bunker08Blower.NativeFieldInfoPtr_unblown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x00067830 File Offset: 0x00065A30
		// (set) Token: 0x060011CE RID: 4558 RVA: 0x0000D0EB File Offset: 0x0000B2EB
		public unsafe GameObject blown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bunker08Blower.NativeFieldInfoPtr_blown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bunker08Blower.NativeFieldInfoPtr_blown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x00067860 File Offset: 0x00065A60
		// (set) Token: 0x060011D0 RID: 4560 RVA: 0x0000D10A File Offset: 0x0000B30A
		public unsafe GameObject extraExplosions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bunker08Blower.NativeFieldInfoPtr_extraExplosions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bunker08Blower.NativeFieldInfoPtr_extraExplosions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x00067890 File Offset: 0x00065A90
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x0000D129 File Offset: 0x0000B329
		public unsafe static Bunker08Blower me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Bunker08Blower.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bunker08Blower>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bunker08Blower.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x000678B8 File Offset: 0x00065AB8
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x0000D13B File Offset: 0x0000B33B
		public unsafe GameObject tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bunker08Blower.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bunker08Blower.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeFieldInfoPtr_done;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeFieldInfoPtr_unblown;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeFieldInfoPtr_blown;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeFieldInfoPtr_extraExplosions;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeFieldInfoPtr_tile;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_Extra_Private_Void_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_Go_Private_Void_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
