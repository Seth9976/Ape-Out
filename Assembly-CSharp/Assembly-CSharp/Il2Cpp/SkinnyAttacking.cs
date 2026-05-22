using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x0200018F RID: 399
	public class SkinnyAttacking : GuardAttacking
	{
		// Token: 0x06002F02 RID: 12034 RVA: 0x000B5F94 File Offset: 0x000B4194
		// Note: this type is marked as 'beforefieldinit'.
		static SkinnyAttacking()
		{
			Il2CppClassPointerStore<SkinnyAttacking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SkinnyAttacking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinnyAttacking>.NativeClassPtr);
			SkinnyAttacking.NativeFieldInfoPtr_runningAway = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinnyAttacking>.NativeClassPtr, "runningAway");
			SkinnyAttacking.NativeFieldInfoPtr_wannaRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinnyAttacking>.NativeClassPtr, "wannaRun");
			SkinnyAttacking.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnyAttacking>.NativeClassPtr, 100666991);
			SkinnyAttacking.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnyAttacking>.NativeClassPtr, 100666992);
			SkinnyAttacking.NativeMethodInfoPtr_Move_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnyAttacking>.NativeClassPtr, 100666993);
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x000B6028 File Offset: 0x000B4228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkinnyAttacking(GuardState st, float mSpd, float rRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinnyAttacking>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mSpd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnyAttacking.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x000B6090 File Offset: 0x000B4290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83070, XrefRangeEnd = 83072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkinnyAttacking.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x000B60CC File Offset: 0x000B42CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83072, XrefRangeEnd = 83107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkinnyAttacking.NativeMethodInfoPtr_Move_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x0002069D File Offset: 0x0001E89D
		public SkinnyAttacking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x000B6108 File Offset: 0x000B4308
		// (set) Token: 0x06002F08 RID: 12040 RVA: 0x000206A6 File Offset: 0x0001E8A6
		public unsafe bool runningAway
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkinnyAttacking.NativeFieldInfoPtr_runningAway);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkinnyAttacking.NativeFieldInfoPtr_runningAway)) = value;
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x000B6130 File Offset: 0x000B4330
		// (set) Token: 0x06002F0A RID: 12042 RVA: 0x000206C1 File Offset: 0x0001E8C1
		public unsafe bool wannaRun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkinnyAttacking.NativeFieldInfoPtr_wannaRun);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkinnyAttacking.NativeFieldInfoPtr_wannaRun)) = value;
			}
		}

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeFieldInfoPtr_runningAway;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeFieldInfoPtr_wannaRun;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Virtual_Void_0;
	}
}
