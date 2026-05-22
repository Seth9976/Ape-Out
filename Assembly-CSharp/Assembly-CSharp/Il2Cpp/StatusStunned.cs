using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020001B3 RID: 435
	public class StatusStunned : StatusEffect
	{
		// Token: 0x060030DF RID: 12511 RVA: 0x000BADA8 File Offset: 0x000B8FA8
		// Note: this type is marked as 'beforefieldinit'.
		static StatusStunned()
		{
			Il2CppClassPointerStore<StatusStunned>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusStunned");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusStunned>.NativeClassPtr);
			StatusStunned.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusStunned>.NativeClassPtr, "timer");
			StatusStunned.NativeFieldInfoPtr_maxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusStunned>.NativeClassPtr, "maxTime");
			StatusStunned.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusStunned>.NativeClassPtr, 100667126);
			StatusStunned.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusStunned>.NativeClassPtr, 100667127);
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x000BAE28 File Offset: 0x000B9028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84734, XrefRangeEnd = 84736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusStunned(GuardState st, int tim)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusStunned>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusStunned.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x000BAE84 File Offset: 0x000B9084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84736, XrefRangeEnd = 84741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusStunned.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x0002192D File Offset: 0x0001FB2D
		public StatusStunned(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x060030E3 RID: 12515 RVA: 0x000BAEC0 File Offset: 0x000B90C0
		// (set) Token: 0x060030E4 RID: 12516 RVA: 0x00021936 File Offset: 0x0001FB36
		public unsafe int timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusStunned.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusStunned.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x060030E5 RID: 12517 RVA: 0x000BAEE8 File Offset: 0x000B90E8
		// (set) Token: 0x060030E6 RID: 12518 RVA: 0x00021951 File Offset: 0x0001FB51
		public unsafe int maxTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusStunned.NativeFieldInfoPtr_maxTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusStunned.NativeFieldInfoPtr_maxTime)) = value;
			}
		}

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeFieldInfoPtr_maxTime;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Int32_0;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
