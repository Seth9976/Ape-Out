using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Principal;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E1 RID: 993
	[Serializable]
	public class CallContextSecurityData : Object
	{
		// Token: 0x06004003 RID: 16387 RVA: 0x0012C03C File Offset: 0x0012A23C
		// Note: this type is marked as 'beforefieldinit'.
		static CallContextSecurityData()
		{
			Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CallContextSecurityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr);
			CallContextSecurityData.NativeFieldInfoPtr__principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr, "_principal");
			CallContextSecurityData.NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr, 100672730);
			CallContextSecurityData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr, 100672731);
			CallContextSecurityData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr, 100672732);
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x0012C0BC File Offset: 0x0012A2BC
		public unsafe bool HasInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextSecurityData.NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x0012C0F8 File Offset: 0x0012A2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223909, XrefRangeEnd = 223912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextSecurityData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x0012C138 File Offset: 0x0012A338
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallContextSecurityData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextSecurityData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x0001800D File Offset: 0x0001620D
		public CallContextSecurityData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06004008 RID: 16392 RVA: 0x0012C174 File Offset: 0x0012A374
		// (set) Token: 0x06004009 RID: 16393 RVA: 0x00018016 File Offset: 0x00016216
		public unsafe IPrincipal _principal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallContextSecurityData.NativeFieldInfoPtr__principal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrincipal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallContextSecurityData.NativeFieldInfoPtr__principal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003492 RID: 13458
		private static readonly IntPtr NativeFieldInfoPtr__principal;

		// Token: 0x04003493 RID: 13459
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0;

		// Token: 0x04003494 RID: 13460
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04003495 RID: 13461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
