using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000086 RID: 134
	public class Boat04BlowTrigger : MessageReceiver
	{
		// Token: 0x0600109E RID: 4254 RVA: 0x00064798 File Offset: 0x00062998
		// Note: this type is marked as 'beforefieldinit'.
		static Boat04BlowTrigger()
		{
			Il2CppClassPointerStore<Boat04BlowTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Boat04BlowTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Boat04BlowTrigger>.NativeClassPtr);
			Boat04BlowTrigger.NativeFieldInfoPtr_blower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04BlowTrigger>.NativeClassPtr, "blower");
			Boat04BlowTrigger.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04BlowTrigger>.NativeClassPtr, 100664698);
			Boat04BlowTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04BlowTrigger>.NativeClassPtr, 100664699);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00064804 File Offset: 0x00062A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48374, XrefRangeEnd = 48376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBlown(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Boat04BlowTrigger.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00064850 File Offset: 0x00062A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48376, XrefRangeEnd = 48382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Boat04BlowTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Boat04BlowTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat04BlowTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0000C40B File Offset: 0x0000A60B
		public Boat04BlowTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0006488C File Offset: 0x00062A8C
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x0000C414 File Offset: 0x0000A614
		public unsafe Boat04Triggerer blower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04BlowTrigger.NativeFieldInfoPtr_blower);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Boat04Triggerer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04BlowTrigger.NativeFieldInfoPtr_blower), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeFieldInfoPtr_blower;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
