using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020001B5 RID: 437
	public class StatusTranqed : StatusEffect
	{
		// Token: 0x060030EA RID: 12522 RVA: 0x000BAF5C File Offset: 0x000B915C
		// Note: this type is marked as 'beforefieldinit'.
		static StatusTranqed()
		{
			Il2CppClassPointerStore<StatusTranqed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusTranqed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusTranqed>.NativeClassPtr);
			StatusTranqed.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusTranqed>.NativeClassPtr, "timer");
			StatusTranqed.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTranqed>.NativeClassPtr, 100667129);
			StatusTranqed.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusTranqed>.NativeClassPtr, 100667130);
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x000BAFC8 File Offset: 0x000B91C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84745, XrefRangeEnd = 84747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusTranqed(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusTranqed>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusTranqed.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x000BB014 File Offset: 0x000B9214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84747, XrefRangeEnd = 84752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusTranqed.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x000219AE File Offset: 0x0001FBAE
		public StatusTranqed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x000BB050 File Offset: 0x000B9250
		// (set) Token: 0x060030EF RID: 12527 RVA: 0x000219B7 File Offset: 0x0001FBB7
		public unsafe int timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTranqed.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusTranqed.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x04001CB3 RID: 7347
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
