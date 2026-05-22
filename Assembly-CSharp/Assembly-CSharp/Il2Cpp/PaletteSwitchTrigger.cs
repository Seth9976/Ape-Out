using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200014A RID: 330
	public class PaletteSwitchTrigger : MonoBehaviour
	{
		// Token: 0x06002798 RID: 10136 RVA: 0x000A2138 File Offset: 0x000A0338
		// Note: this type is marked as 'beforefieldinit'.
		static PaletteSwitchTrigger()
		{
			Il2CppClassPointerStore<PaletteSwitchTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PaletteSwitchTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaletteSwitchTrigger>.NativeClassPtr);
			PaletteSwitchTrigger.NativeFieldInfoPtr_primary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaletteSwitchTrigger>.NativeClassPtr, "primary");
			PaletteSwitchTrigger.NativeFieldInfoPtr_secondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaletteSwitchTrigger>.NativeClassPtr, "secondary");
			PaletteSwitchTrigger.NativeFieldInfoPtr_tertiary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaletteSwitchTrigger>.NativeClassPtr, "tertiary");
			PaletteSwitchTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaletteSwitchTrigger>.NativeClassPtr, 100666473);
			PaletteSwitchTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaletteSwitchTrigger>.NativeClassPtr, 100666474);
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x000A21CC File Offset: 0x000A03CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75599, XrefRangeEnd = 75602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaletteSwitchTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x000A2210 File Offset: 0x000A0410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PaletteSwitchTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PaletteSwitchTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaletteSwitchTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x0001B891 File Offset: 0x00019A91
		public PaletteSwitchTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x000A224C File Offset: 0x000A044C
		// (set) Token: 0x0600279D RID: 10141 RVA: 0x0001B89A File Offset: 0x00019A9A
		public unsafe Texture primary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaletteSwitchTrigger.NativeFieldInfoPtr_primary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaletteSwitchTrigger.NativeFieldInfoPtr_primary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x000A227C File Offset: 0x000A047C
		// (set) Token: 0x0600279F RID: 10143 RVA: 0x0001B8B9 File Offset: 0x00019AB9
		public unsafe Texture secondary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaletteSwitchTrigger.NativeFieldInfoPtr_secondary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaletteSwitchTrigger.NativeFieldInfoPtr_secondary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x000A22AC File Offset: 0x000A04AC
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x0001B8D8 File Offset: 0x00019AD8
		public unsafe Texture tertiary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaletteSwitchTrigger.NativeFieldInfoPtr_tertiary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PaletteSwitchTrigger.NativeFieldInfoPtr_tertiary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeFieldInfoPtr_primary;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeFieldInfoPtr_secondary;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeFieldInfoPtr_tertiary;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
