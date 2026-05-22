using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp
{
	// Token: 0x02000107 RID: 263
	public class GuardWaiting : GuardMode
	{
		// Token: 0x06001F2A RID: 7978 RVA: 0x0008BD80 File Offset: 0x00089F80
		// Note: this type is marked as 'beforefieldinit'.
		static GuardWaiting()
		{
			Il2CppClassPointerStore<GuardWaiting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardWaiting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardWaiting>.NativeClassPtr);
			GuardWaiting.NativeFieldInfoPtr_stat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardWaiting>.NativeClassPtr, "stat");
			GuardWaiting.NativeFieldInfoPtr_delList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardWaiting>.NativeClassPtr, "delList");
			GuardWaiting.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardWaiting>.NativeClassPtr, 100665787);
			GuardWaiting.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardWaiting>.NativeClassPtr, 100665788);
			GuardWaiting.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardWaiting>.NativeClassPtr, 100665789);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x0008BE14 File Offset: 0x0008A014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66208, XrefRangeEnd = 66214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardWaiting(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardWaiting>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardWaiting.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x0008BE60 File Offset: 0x0008A060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66214, XrefRangeEnd = 66219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardWaiting.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x0008BE9C File Offset: 0x0008A09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66219, XrefRangeEnd = 66224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardWaiting.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00015CBA File Offset: 0x00013EBA
		public GuardWaiting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x0008BED8 File Offset: 0x0008A0D8
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x00015CC3 File Offset: 0x00013EC3
		public unsafe StatusWaiting stat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardWaiting.NativeFieldInfoPtr_stat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StatusWaiting>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardWaiting.NativeFieldInfoPtr_stat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x0008BF08 File Offset: 0x0008A108
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x00015CE2 File Offset: 0x00013EE2
		public unsafe List<int> delList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardWaiting.NativeFieldInfoPtr_delList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardWaiting.NativeFieldInfoPtr_delList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeFieldInfoPtr_stat;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeFieldInfoPtr_delList;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
