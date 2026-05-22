using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E2 RID: 994
	[Serializable]
	public class CallContextRemotingData : Object
	{
		// Token: 0x0600400A RID: 16394 RVA: 0x0012C1A4 File Offset: 0x0012A3A4
		// Note: this type is marked as 'beforefieldinit'.
		static CallContextRemotingData()
		{
			Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CallContextRemotingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr);
			CallContextRemotingData.NativeFieldInfoPtr__logicalCallID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, "_logicalCallID");
			CallContextRemotingData.NativeMethodInfoPtr_get_LogicalCallID_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100672733);
			CallContextRemotingData.NativeMethodInfoPtr_set_LogicalCallID_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100672734);
			CallContextRemotingData.NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100672735);
			CallContextRemotingData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100672736);
			CallContextRemotingData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100672737);
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x0600400B RID: 16395 RVA: 0x0012C24C File Offset: 0x0012A44C
		// (set) Token: 0x0600400C RID: 16396 RVA: 0x0012C284 File Offset: 0x0012A484
		public unsafe string LogicalCallID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr_get_LogicalCallID_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr_set_LogicalCallID_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x0600400D RID: 16397 RVA: 0x0012C2C8 File Offset: 0x0012A4C8
		public unsafe bool HasInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x0012C304 File Offset: 0x0012A504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223912, XrefRangeEnd = 223915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x0012C344 File Offset: 0x0012A544
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallContextRemotingData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x00018035 File Offset: 0x00016235
		public CallContextRemotingData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06004011 RID: 16401 RVA: 0x0012C380 File Offset: 0x0012A580
		// (set) Token: 0x06004012 RID: 16402 RVA: 0x0001803E File Offset: 0x0001623E
		public unsafe string _logicalCallID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallContextRemotingData.NativeFieldInfoPtr__logicalCallID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallContextRemotingData.NativeFieldInfoPtr__logicalCallID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003496 RID: 13462
		private static readonly IntPtr NativeFieldInfoPtr__logicalCallID;

		// Token: 0x04003497 RID: 13463
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallID_Internal_get_String_0;

		// Token: 0x04003498 RID: 13464
		private static readonly IntPtr NativeMethodInfoPtr_set_LogicalCallID_Internal_set_Void_String_0;

		// Token: 0x04003499 RID: 13465
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0;

		// Token: 0x0400349A RID: 13466
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x0400349B RID: 13467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
