using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000084 RID: 132
	public class BlowTrigger : MonoBehaviour
	{
		// Token: 0x0600108F RID: 4239 RVA: 0x0006449C File Offset: 0x0006269C
		// Note: this type is marked as 'beforefieldinit'.
		static BlowTrigger()
		{
			Il2CppClassPointerStore<BlowTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BlowTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlowTrigger>.NativeClassPtr);
			BlowTrigger.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlowTrigger>.NativeClassPtr, "timer");
			BlowTrigger.NativeFieldInfoPtr_forever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlowTrigger>.NativeClassPtr, "forever");
			BlowTrigger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlowTrigger>.NativeClassPtr, 100664685);
			BlowTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlowTrigger>.NativeClassPtr, 100664686);
			BlowTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlowTrigger>.NativeClassPtr, 100664687);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00064530 File Offset: 0x00062730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48242, XrefRangeEnd = 48247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlowTrigger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00064564 File Offset: 0x00062764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48247, XrefRangeEnd = 48264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlowTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x000645A8 File Offset: 0x000627A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlowTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlowTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlowTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0000C3C3 File Offset: 0x0000A5C3
		public BlowTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x000645E4 File Offset: 0x000627E4
		// (set) Token: 0x06001095 RID: 4245 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlowTrigger.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlowTrigger.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0006460C File Offset: 0x0006280C
		// (set) Token: 0x06001097 RID: 4247 RVA: 0x0000C3E7 File Offset: 0x0000A5E7
		public unsafe bool forever
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlowTrigger.NativeFieldInfoPtr_forever);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlowTrigger.NativeFieldInfoPtr_forever)) = value;
			}
		}

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeFieldInfoPtr_forever;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
