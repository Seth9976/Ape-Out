using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000BC RID: 188
	public class DynoCollision : GuardCollision
	{
		// Token: 0x0600168A RID: 5770 RVA: 0x00073E08 File Offset: 0x00072008
		// Note: this type is marked as 'beforefieldinit'.
		static DynoCollision()
		{
			Il2CppClassPointerStore<DynoCollision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DynoCollision");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynoCollision>.NativeClassPtr);
			DynoCollision.NativeFieldInfoPtr_expl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynoCollision>.NativeClassPtr, "expl");
			DynoCollision.NativeFieldInfoPtr_superDyno = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynoCollision>.NativeClassPtr, "superDyno");
			DynoCollision.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoCollision>.NativeClassPtr, 100665187);
			DynoCollision.NativeMethodInfoPtr_Die_Public_Virtual_Void_Vector2_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoCollision>.NativeClassPtr, 100665188);
			DynoCollision.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoCollision>.NativeClassPtr, 100665189);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00073E9C File Offset: 0x0007209C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55858, XrefRangeEnd = 55859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynoCollision.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00073ED8 File Offset: 0x000720D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55859, XrefRangeEnd = 55889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Die(Vector2 pt, bool fuck, bool shit, bool friendship = false, bool explosion = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fuck;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friendship;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref explosion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynoCollision.NativeMethodInfoPtr_Die_Public_Virtual_Void_Vector2_Boolean_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00073F5C File Offset: 0x0007215C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynoCollision()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynoCollision>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynoCollision.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x000103EB File Offset: 0x0000E5EB
		public DynoCollision(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x00073F98 File Offset: 0x00072198
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x000103F4 File Offset: 0x0000E5F4
		public unsafe GameObject expl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoCollision.NativeFieldInfoPtr_expl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoCollision.NativeFieldInfoPtr_expl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x00073FC8 File Offset: 0x000721C8
		// (set) Token: 0x06001692 RID: 5778 RVA: 0x00010413 File Offset: 0x0000E613
		public unsafe bool superDyno
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoCollision.NativeFieldInfoPtr_superDyno);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoCollision.NativeFieldInfoPtr_superDyno)) = value;
			}
		}

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeFieldInfoPtr_expl;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeFieldInfoPtr_superDyno;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_Die_Public_Virtual_Void_Vector2_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
