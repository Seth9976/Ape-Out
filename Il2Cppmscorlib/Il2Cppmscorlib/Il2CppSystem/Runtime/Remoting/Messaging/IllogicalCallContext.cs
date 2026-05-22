using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003DF RID: 991
	public class IllogicalCallContext : Object
	{
		// Token: 0x06003FDB RID: 16347 RVA: 0x0012B844 File Offset: 0x00129A44
		// Note: this type is marked as 'beforefieldinit'.
		static IllogicalCallContext()
		{
			Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IllogicalCallContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr);
			IllogicalCallContext.NativeFieldInfoPtr_m_Datastore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, "m_Datastore");
			IllogicalCallContext.NativeFieldInfoPtr_m_HostContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, "m_HostContext");
			IllogicalCallContext.NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100672711);
			IllogicalCallContext.NativeMethodInfoPtr_get_HostContext_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100672712);
			IllogicalCallContext.NativeMethodInfoPtr_set_HostContext_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100672713);
			IllogicalCallContext.NativeMethodInfoPtr_get_HasUserData_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100672714);
			IllogicalCallContext.NativeMethodInfoPtr_CreateCopy_Public_IllogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100672715);
			IllogicalCallContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100672716);
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06003FDC RID: 16348 RVA: 0x0012B914 File Offset: 0x00129B14
		public unsafe Hashtable Datastore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223706, XrefRangeEnd = 223710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06003FDD RID: 16349 RVA: 0x0012B954 File Offset: 0x00129B54
		// (set) Token: 0x06003FDE RID: 16350 RVA: 0x0012B994 File Offset: 0x00129B94
		public unsafe Object HostContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_get_HostContext_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_set_HostContext_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06003FDF RID: 16351 RVA: 0x0012B9D8 File Offset: 0x00129BD8
		public unsafe bool HasUserData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_get_HasUserData_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x0012BA14 File Offset: 0x00129C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223731, RefRangeEnd = 223732, XrefRangeStart = 223710, XrefRangeEnd = 223731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IllogicalCallContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_CreateCopy_Public_IllogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IllogicalCallContext>(intPtr3) : null;
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x0012BA54 File Offset: 0x00129C54
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IllogicalCallContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x00017EC4 File Offset: 0x000160C4
		public IllogicalCallContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06003FE3 RID: 16355 RVA: 0x0012BA90 File Offset: 0x00129C90
		// (set) Token: 0x06003FE4 RID: 16356 RVA: 0x00017ECD File Offset: 0x000160CD
		public unsafe Hashtable m_Datastore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IllogicalCallContext.NativeFieldInfoPtr_m_Datastore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IllogicalCallContext.NativeFieldInfoPtr_m_Datastore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06003FE5 RID: 16357 RVA: 0x0012BAC0 File Offset: 0x00129CC0
		// (set) Token: 0x06003FE6 RID: 16358 RVA: 0x00017EEC File Offset: 0x000160EC
		public unsafe Object m_HostContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IllogicalCallContext.NativeFieldInfoPtr_m_HostContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IllogicalCallContext.NativeFieldInfoPtr_m_HostContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003479 RID: 13433
		private static readonly IntPtr NativeFieldInfoPtr_m_Datastore;

		// Token: 0x0400347A RID: 13434
		private static readonly IntPtr NativeFieldInfoPtr_m_HostContext;

		// Token: 0x0400347B RID: 13435
		private static readonly IntPtr NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0;

		// Token: 0x0400347C RID: 13436
		private static readonly IntPtr NativeMethodInfoPtr_get_HostContext_Internal_get_Object_0;

		// Token: 0x0400347D RID: 13437
		private static readonly IntPtr NativeMethodInfoPtr_set_HostContext_Internal_set_Void_Object_0;

		// Token: 0x0400347E RID: 13438
		private static readonly IntPtr NativeMethodInfoPtr_get_HasUserData_Internal_get_Boolean_0;

		// Token: 0x0400347F RID: 13439
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_IllogicalCallContext_0;

		// Token: 0x04003480 RID: 13440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
