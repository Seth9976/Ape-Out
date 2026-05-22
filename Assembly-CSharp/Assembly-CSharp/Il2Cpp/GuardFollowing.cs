using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2Cpp
{
	// Token: 0x020000F4 RID: 244
	public class GuardFollowing : GuardMode
	{
		// Token: 0x06001CD4 RID: 7380 RVA: 0x00085460 File Offset: 0x00083660
		// Note: this type is marked as 'beforefieldinit'.
		static GuardFollowing()
		{
			Il2CppClassPointerStore<GuardFollowing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardFollowing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardFollowing>.NativeClassPtr);
			GuardFollowing.NativeFieldInfoPtr_prevRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFollowing>.NativeClassPtr, "prevRot");
			GuardFollowing.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardFollowing>.NativeClassPtr, "num");
			GuardFollowing.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFollowing>.NativeClassPtr, 100665633);
			GuardFollowing.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFollowing>.NativeClassPtr, 100665634);
			GuardFollowing.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardFollowing>.NativeClassPtr, 100665635);
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x000854F4 File Offset: 0x000836F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63580, RefRangeEnd = 63582, XrefRangeStart = 63580, XrefRangeEnd = 63580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardFollowing(GuardState st, float mSpd, float rRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardFollowing>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardFollowing.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0008555C File Offset: 0x0008375C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63582, XrefRangeEnd = 63593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardFollowing.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00085598 File Offset: 0x00083798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63593, XrefRangeEnd = 63616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardFollowing.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x000144EB File Offset: 0x000126EB
		public GuardFollowing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x000855D4 File Offset: 0x000837D4
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x000144F4 File Offset: 0x000126F4
		public unsafe Il2CppStructArray<float> prevRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFollowing.NativeFieldInfoPtr_prevRot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFollowing.NativeFieldInfoPtr_prevRot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x00085604 File Offset: 0x00083804
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x00014513 File Offset: 0x00012713
		public unsafe int num
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFollowing.NativeFieldInfoPtr_num);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardFollowing.NativeFieldInfoPtr_num)) = value;
			}
		}

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeFieldInfoPtr_prevRot;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeFieldInfoPtr_num;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
