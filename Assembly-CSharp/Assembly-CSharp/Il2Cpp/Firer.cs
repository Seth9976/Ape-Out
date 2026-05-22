using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000D6 RID: 214
	public class Firer : MonoBehaviour
	{
		// Token: 0x06001909 RID: 6409 RVA: 0x0007A8A4 File Offset: 0x00078AA4
		// Note: this type is marked as 'beforefieldinit'.
		static Firer()
		{
			Il2CppClassPointerStore<Firer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Firer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Firer>.NativeClassPtr);
			Firer.NativeFieldInfoPtr_dontFireFiredPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Firer>.NativeClassPtr, "dontFireFiredPlayer");
			Firer.NativeFieldInfoPtr_boop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Firer>.NativeClassPtr, "boop");
			Firer.NativeFieldInfoPtr_rad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Firer>.NativeClassPtr, "rad");
			Firer.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Firer>.NativeClassPtr, 100665346);
			Firer.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Firer>.NativeClassPtr, 100665347);
			Firer.NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Firer>.NativeClassPtr, 100665348);
			Firer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Firer>.NativeClassPtr, 100665349);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0007A960 File Offset: 0x00078B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58490, XrefRangeEnd = 58495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Firer.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0007A994 File Offset: 0x00078B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58508, RefRangeEnd = 58509, XrefRangeStart = 58495, XrefRangeEnd = 58508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Firer.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0007A9D8 File Offset: 0x00078BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58509, XrefRangeEnd = 58510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Firer.NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x0007AA1C File Offset: 0x00078C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Firer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Firer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Firer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00011EEB File Offset: 0x000100EB
		public Firer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x0007AA58 File Offset: 0x00078C58
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x00011EF4 File Offset: 0x000100F4
		public unsafe bool dontFireFiredPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Firer.NativeFieldInfoPtr_dontFireFiredPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Firer.NativeFieldInfoPtr_dontFireFiredPlayer)) = value;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x0007AA80 File Offset: 0x00078C80
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x00011F0F File Offset: 0x0001010F
		public unsafe Collider2D boop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Firer.NativeFieldInfoPtr_boop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Firer.NativeFieldInfoPtr_boop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x0007AAB0 File Offset: 0x00078CB0
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x00011F2E File Offset: 0x0001012E
		public unsafe float rad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Firer.NativeFieldInfoPtr_rad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Firer.NativeFieldInfoPtr_rad)) = value;
			}
		}

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeFieldInfoPtr_dontFireFiredPlayer;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeFieldInfoPtr_boop;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeFieldInfoPtr_rad;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
