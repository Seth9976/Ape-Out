using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000D8 RID: 216
	public class FlameCollision : GuardCollision
	{
		// Token: 0x0600191B RID: 6427 RVA: 0x0007AC74 File Offset: 0x00078E74
		// Note: this type is marked as 'beforefieldinit'.
		static FlameCollision()
		{
			Il2CppClassPointerStore<FlameCollision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlameCollision");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlameCollision>.NativeClassPtr);
			FlameCollision.NativeFieldInfoPtr_fBlast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlameCollision>.NativeClassPtr, "fBlast");
			FlameCollision.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameCollision>.NativeClassPtr, 100665354);
			FlameCollision.NativeMethodInfoPtr_Die_Public_Virtual_Void_Vector2_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameCollision>.NativeClassPtr, 100665355);
			FlameCollision.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameCollision>.NativeClassPtr, 100665356);
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0007ACF4 File Offset: 0x00078EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58602, XrefRangeEnd = 58612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlameCollision.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0007AD30 File Offset: 0x00078F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58612, XrefRangeEnd = 58628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Die(Vector2 pt, bool fuck, bool shit, bool friendship = false, bool exploding = false)
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exploding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlameCollision.NativeMethodInfoPtr_Die_Public_Virtual_Void_Vector2_Boolean_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0007ADB4 File Offset: 0x00078FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlameCollision()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlameCollision>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlameCollision.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00011F52 File Offset: 0x00010152
		public FlameCollision(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x0007ADF0 File Offset: 0x00078FF0
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x00011F5B File Offset: 0x0001015B
		public unsafe GameObject fBlast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameCollision.NativeFieldInfoPtr_fBlast);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameCollision.NativeFieldInfoPtr_fBlast), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeFieldInfoPtr_fBlast;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_Die_Public_Virtual_Void_Vector2_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
