using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x02000138 RID: 312
	public class ServicePointScheduler : Object
	{
		// Token: 0x06001305 RID: 4869 RVA: 0x000578D4 File Offset: 0x00055AD4
		// Note: this type is marked as 'beforefieldinit'.
		static ServicePointScheduler()
		{
			Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServicePointScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr);
			ServicePointScheduler.NativeFieldInfoPtr__ServicePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "<ServicePoint>k__BackingField");
			ServicePointScheduler.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "running");
			ServicePointScheduler.NativeFieldInfoPtr_maxIdleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "maxIdleTime");
			ServicePointScheduler.NativeFieldInfoPtr_schedulerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "schedulerEvent");
			ServicePointScheduler.NativeFieldInfoPtr_defaultGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "defaultGroup");
			ServicePointScheduler.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "groups");
			ServicePointScheduler.NativeFieldInfoPtr_operations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "operations");
			ServicePointScheduler.NativeFieldInfoPtr_idleConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "idleConnections");
			ServicePointScheduler.NativeFieldInfoPtr_currentConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "currentConnections");
			ServicePointScheduler.NativeFieldInfoPtr_connectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "connectionLimit");
			ServicePointScheduler.NativeFieldInfoPtr_idleSince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "idleSince");
			ServicePointScheduler.NativeFieldInfoPtr_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "nextId");
			ServicePointScheduler.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "ID");
			ServicePointScheduler.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665960);
			ServicePointScheduler.NativeMethodInfoPtr_get_MaxIdleTime_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665961);
			ServicePointScheduler.NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665962);
			ServicePointScheduler.NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665963);
			ServicePointScheduler.NativeMethodInfoPtr_Run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665964);
			ServicePointScheduler.NativeMethodInfoPtr_StartScheduler_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665965);
			ServicePointScheduler.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665966);
			ServicePointScheduler.NativeMethodInfoPtr_RunSchedulerIteration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665967);
			ServicePointScheduler.NativeMethodInfoPtr_OperationCompleted_Private_Boolean_ConnectionGroup_WebOperation_Task_1_ValueTuple_2_Boolean_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665968);
			ServicePointScheduler.NativeMethodInfoPtr_CloseIdleConnection_Private_Void_ConnectionGroup_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665969);
			ServicePointScheduler.NativeMethodInfoPtr_SchedulerIteration_Private_Boolean_ConnectionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665970);
			ServicePointScheduler.NativeMethodInfoPtr_RemoveOperation_Private_Void_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665971);
			ServicePointScheduler.NativeMethodInfoPtr_RemoveIdleConnection_Private_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665972);
			ServicePointScheduler.NativeMethodInfoPtr_SendRequest_Public_Void_WebOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665973);
			ServicePointScheduler.NativeMethodInfoPtr_GetConnectionGroup_Private_ConnectionGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665974);
			ServicePointScheduler.NativeMethodInfoPtr_OnConnectionCreated_Private_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665975);
			ServicePointScheduler.NativeMethodInfoPtr_OnConnectionClosed_Private_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100665976);
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00057B5C File Offset: 0x00055D5C
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x00057B9C File Offset: 0x00055D9C
		public unsafe int MaxIdleTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_get_MaxIdleTime_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x00057BD8 File Offset: 0x00055DD8
		public unsafe int ConnectionLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00057C14 File Offset: 0x00055E14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 384143, RefRangeEnd = 384145, XrefRangeStart = 384115, XrefRangeEnd = 384143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePointScheduler(ServicePoint servicePoint, int connectionLimit, int maxIdleTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(servicePoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionLimit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxIdleTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00057C7C File Offset: 0x00055E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384153, RefRangeEnd = 384154, XrefRangeStart = 384145, XrefRangeEnd = 384153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_Run_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00057CB0 File Offset: 0x00055EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384154, XrefRangeEnd = 384158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartScheduler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_StartScheduler_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00057CE4 File Offset: 0x00055EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384178, RefRangeEnd = 384179, XrefRangeStart = 384158, XrefRangeEnd = 384178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00057D18 File Offset: 0x00055F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384179, XrefRangeEnd = 384191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunSchedulerIteration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_RunSchedulerIteration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00057D4C File Offset: 0x00055F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384191, XrefRangeEnd = 384209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation, Task<ValueTuple<bool, WebOperation>> task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(task);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_OperationCompleted_Private_Boolean_ConnectionGroup_WebOperation_Task_1_ValueTuple_2_Boolean_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00057DC0 File Offset: 0x00055FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384209, XrefRangeEnd = 384212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_CloseIdleConnection_Private_Void_ConnectionGroup_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00057E14 File Offset: 0x00056014
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 384221, RefRangeEnd = 384223, XrefRangeStart = 384212, XrefRangeEnd = 384221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_SchedulerIteration_Private_Boolean_ConnectionGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00057E64 File Offset: 0x00056064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 384229, RefRangeEnd = 384231, XrefRangeStart = 384223, XrefRangeEnd = 384229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOperation(WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_RemoveOperation_Private_Void_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00057EA8 File Offset: 0x000560A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 384237, RefRangeEnd = 384241, XrefRangeStart = 384231, XrefRangeEnd = 384237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveIdleConnection(WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_RemoveIdleConnection_Private_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00057EEC File Offset: 0x000560EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384249, RefRangeEnd = 384250, XrefRangeStart = 384241, XrefRangeEnd = 384249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRequest(WebOperation operation, string groupName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_SendRequest_Public_Void_WebOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00057F40 File Offset: 0x00056140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384269, RefRangeEnd = 384270, XrefRangeStart = 384250, XrefRangeEnd = 384269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_GetConnectionGroup_Private_ConnectionGroup_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.ConnectionGroup>(intPtr3) : null;
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00057F90 File Offset: 0x00056190
		[CallerCount(0)]
		public unsafe void OnConnectionCreated(WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_OnConnectionCreated_Private_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00057FD4 File Offset: 0x000561D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384270, XrefRangeEnd = 384271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConnectionClosed(WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_OnConnectionClosed_Private_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00009B6B File Offset: 0x00007D6B
		public ServicePointScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00058018 File Offset: 0x00056218
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x00009B74 File Offset: 0x00007D74
		public unsafe ServicePoint _ServicePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr__ServicePoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr__ServicePoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x00058048 File Offset: 0x00056248
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x00009B93 File Offset: 0x00007D93
		public unsafe int running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_running)) = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x00058070 File Offset: 0x00056270
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x00009BAE File Offset: 0x00007DAE
		public unsafe int maxIdleTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_maxIdleTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_maxIdleTime)) = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x00058098 File Offset: 0x00056298
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x00009BC9 File Offset: 0x00007DC9
		public unsafe ServicePointScheduler.AsyncManualResetEvent schedulerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_schedulerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.AsyncManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_schedulerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x000580C8 File Offset: 0x000562C8
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x00009BE8 File Offset: 0x00007DE8
		public unsafe ServicePointScheduler.ConnectionGroup defaultGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_defaultGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.ConnectionGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_defaultGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x000580F8 File Offset: 0x000562F8
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x00009C07 File Offset: 0x00007E07
		public unsafe Dictionary<string, ServicePointScheduler.ConnectionGroup> groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ServicePointScheduler.ConnectionGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x00058128 File Offset: 0x00056328
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x00009C26 File Offset: 0x00007E26
		public unsafe LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_operations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_operations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x00058158 File Offset: 0x00056358
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x00009C45 File Offset: 0x00007E45
		public unsafe LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_idleConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_idleConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x00058188 File Offset: 0x00056388
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x00009C64 File Offset: 0x00007E64
		public unsafe int currentConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_currentConnections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_currentConnections)) = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x000581B0 File Offset: 0x000563B0
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x00009C7F File Offset: 0x00007E7F
		public unsafe int connectionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_connectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_connectionLimit)) = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x000581D8 File Offset: 0x000563D8
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x00009C9A File Offset: 0x00007E9A
		public unsafe DateTime idleSince
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_idleSince);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_idleSince)) = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00058200 File Offset: 0x00056400
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x00009CB5 File Offset: 0x00007EB5
		public unsafe static int nextId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointScheduler.NativeFieldInfoPtr_nextId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointScheduler.NativeFieldInfoPtr_nextId, (void*)(&value));
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x0005821C File Offset: 0x0005641C
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x00009CC3 File Offset: 0x00007EC3
		public unsafe int ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_ID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_ID)) = value;
			}
		}

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeFieldInfoPtr__ServicePoint_k__BackingField;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeFieldInfoPtr_maxIdleTime;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeFieldInfoPtr_schedulerEvent;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeFieldInfoPtr_defaultGroup;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeFieldInfoPtr_groups;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeFieldInfoPtr_operations;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeFieldInfoPtr_idleConnections;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeFieldInfoPtr_currentConnections;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeFieldInfoPtr_connectionLimit;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeFieldInfoPtr_idleSince;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeFieldInfoPtr_nextId;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxIdleTime_Public_get_Int32_0;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_Int32_Int32_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Void_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_StartScheduler_Private_Void_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_RunSchedulerIteration_Private_Void_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr_OperationCompleted_Private_Boolean_ConnectionGroup_WebOperation_Task_1_ValueTuple_2_Boolean_WebOperation_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr_CloseIdleConnection_Private_Void_ConnectionGroup_WebConnection_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_SchedulerIteration_Private_Boolean_ConnectionGroup_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOperation_Private_Void_WebOperation_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_RemoveIdleConnection_Private_Void_WebConnection_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_SendRequest_Public_Void_WebOperation_String_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionGroup_Private_ConnectionGroup_String_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_OnConnectionCreated_Private_Void_WebConnection_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr_OnConnectionClosed_Private_Void_WebConnection_0;

		// Token: 0x020001F0 RID: 496
		public class ConnectionGroup : Object
		{
			// Token: 0x06001B06 RID: 6918 RVA: 0x00072014 File Offset: 0x00070214
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectionGroup()
			{
				Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "ConnectionGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr);
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Scheduler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "<Scheduler>k__BackingField");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "<Name>k__BackingField");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "nextId");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "ID");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "connections");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "queue");
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_get_Scheduler_Public_get_ServicePointScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665977);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr__ctor_Public_Void_ServicePointScheduler_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665978);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665979);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_RemoveConnection_Public_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665980);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665981);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_EnqueueOperation_Public_Void_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665982);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_GetNextOperation_Public_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665983);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_FindIdleConnection_Public_WebConnection_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665984);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_CreateOrReuseConnection_Public_ValueTuple_2_WebConnection_Boolean_WebOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100665985);
			}

			// Token: 0x170008A2 RID: 2210
			// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0007216C File Offset: 0x0007036C
			public unsafe ServicePointScheduler Scheduler
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_get_Scheduler_Public_get_ServicePointScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr3) : null;
				}
			}

			// Token: 0x06001B08 RID: 6920 RVA: 0x000721AC File Offset: 0x000703AC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 383859, RefRangeEnd = 383861, XrefRangeStart = 383849, XrefRangeEnd = 383859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectionGroup(ServicePointScheduler scheduler, string name)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr__ctor_Public_Void_ServicePointScheduler_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B09 RID: 6921 RVA: 0x0007220C File Offset: 0x0007040C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 383863, RefRangeEnd = 383864, XrefRangeStart = 383861, XrefRangeEnd = 383863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsEmpty()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001B0A RID: 6922 RVA: 0x00072248 File Offset: 0x00070448
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 383868, RefRangeEnd = 383870, XrefRangeStart = 383864, XrefRangeEnd = 383868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveConnection(WebConnection connection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_RemoveConnection_Public_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B0B RID: 6923 RVA: 0x0007228C File Offset: 0x0007048C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 383877, RefRangeEnd = 383879, XrefRangeStart = 383870, XrefRangeEnd = 383877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Cleanup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B0C RID: 6924 RVA: 0x000722C0 File Offset: 0x000704C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383879, XrefRangeEnd = 383883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EnqueueOperation(WebOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_EnqueueOperation_Public_Void_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B0D RID: 6925 RVA: 0x00072304 File Offset: 0x00070504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383883, XrefRangeEnd = 383889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WebOperation GetNextOperation()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_GetNextOperation_Public_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr3) : null;
			}

			// Token: 0x06001B0E RID: 6926 RVA: 0x00072344 File Offset: 0x00070544
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 383904, RefRangeEnd = 383905, XrefRangeStart = 383889, XrefRangeEnd = 383904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WebConnection FindIdleConnection(WebOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_FindIdleConnection_Public_WebConnection_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr3) : null;
				}
			}

			// Token: 0x06001B0F RID: 6927 RVA: 0x00072394 File Offset: 0x00070594
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 383912, RefRangeEnd = 383913, XrefRangeStart = 383905, XrefRangeEnd = 383912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_CreateOrReuseConnection_Public_ValueTuple_2_WebConnection_Boolean_WebOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<WebConnection, bool>(intPtr);
			}

			// Token: 0x06001B10 RID: 6928 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
			public ConnectionGroup(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x06001B11 RID: 6929 RVA: 0x000723EC File Offset: 0x000705EC
			// (set) Token: 0x06001B12 RID: 6930 RVA: 0x0000E0D1 File Offset: 0x0000C2D1
			public unsafe ServicePointScheduler _Scheduler_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Scheduler_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Scheduler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089D RID: 2205
			// (get) Token: 0x06001B13 RID: 6931 RVA: 0x0007241C File Offset: 0x0007061C
			// (set) Token: 0x06001B14 RID: 6932 RVA: 0x0000E0F0 File Offset: 0x0000C2F0
			public unsafe string _Name_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Name_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700089E RID: 2206
			// (get) Token: 0x06001B15 RID: 6933 RVA: 0x00072444 File Offset: 0x00070644
			// (set) Token: 0x06001B16 RID: 6934 RVA: 0x0000E10F File Offset: 0x0000C30F
			public unsafe static int nextId
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_nextId, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_nextId, (void*)(&value));
				}
			}

			// Token: 0x1700089F RID: 2207
			// (get) Token: 0x06001B17 RID: 6935 RVA: 0x00072460 File Offset: 0x00070660
			// (set) Token: 0x06001B18 RID: 6936 RVA: 0x0000E11D File Offset: 0x0000C31D
			public unsafe int ID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_ID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_ID)) = value;
				}
			}

			// Token: 0x170008A0 RID: 2208
			// (get) Token: 0x06001B19 RID: 6937 RVA: 0x00072488 File Offset: 0x00070688
			// (set) Token: 0x06001B1A RID: 6938 RVA: 0x0000E138 File Offset: 0x0000C338
			public unsafe LinkedList<WebConnection> connections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_connections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<WebConnection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A1 RID: 2209
			// (get) Token: 0x06001B1B RID: 6939 RVA: 0x000724B8 File Offset: 0x000706B8
			// (set) Token: 0x06001B1C RID: 6940 RVA: 0x0000E157 File Offset: 0x0000C357
			public unsafe LinkedList<WebOperation> queue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_queue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<WebOperation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001515 RID: 5397
			private static readonly IntPtr NativeFieldInfoPtr__Scheduler_k__BackingField;

			// Token: 0x04001516 RID: 5398
			private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

			// Token: 0x04001517 RID: 5399
			private static readonly IntPtr NativeFieldInfoPtr_nextId;

			// Token: 0x04001518 RID: 5400
			private static readonly IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x04001519 RID: 5401
			private static readonly IntPtr NativeFieldInfoPtr_connections;

			// Token: 0x0400151A RID: 5402
			private static readonly IntPtr NativeFieldInfoPtr_queue;

			// Token: 0x0400151B RID: 5403
			private static readonly IntPtr NativeMethodInfoPtr_get_Scheduler_Public_get_ServicePointScheduler_0;

			// Token: 0x0400151C RID: 5404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServicePointScheduler_String_0;

			// Token: 0x0400151D RID: 5405
			private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;

			// Token: 0x0400151E RID: 5406
			private static readonly IntPtr NativeMethodInfoPtr_RemoveConnection_Public_Void_WebConnection_0;

			// Token: 0x0400151F RID: 5407
			private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

			// Token: 0x04001520 RID: 5408
			private static readonly IntPtr NativeMethodInfoPtr_EnqueueOperation_Public_Void_WebOperation_0;

			// Token: 0x04001521 RID: 5409
			private static readonly IntPtr NativeMethodInfoPtr_GetNextOperation_Public_WebOperation_0;

			// Token: 0x04001522 RID: 5410
			private static readonly IntPtr NativeMethodInfoPtr_FindIdleConnection_Public_WebConnection_WebOperation_0;

			// Token: 0x04001523 RID: 5411
			private static readonly IntPtr NativeMethodInfoPtr_CreateOrReuseConnection_Public_ValueTuple_2_WebConnection_Boolean_WebOperation_Boolean_0;
		}

		// Token: 0x020001F1 RID: 497
		public class AsyncManualResetEvent : Object
		{
			// Token: 0x06001B1D RID: 6941 RVA: 0x000724E8 File Offset: 0x000706E8
			// Note: this type is marked as 'beforefieldinit'.
			static AsyncManualResetEvent()
			{
				Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "AsyncManualResetEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr);
				ServicePointScheduler.AsyncManualResetEvent.NativeFieldInfoPtr_m_tcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, "m_tcs");
				ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, 100665986);
				ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_Set_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, 100665987);
				ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, 100665988);
				ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, 100665989);
			}

			// Token: 0x06001B1E RID: 6942 RVA: 0x00072578 File Offset: 0x00070778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383967, XrefRangeEnd = 383977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<bool> WaitAsync(int millisecondTimeout)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref millisecondTimeout;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
				}
			}

			// Token: 0x06001B1F RID: 6943 RVA: 0x000725C4 File Offset: 0x000707C4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 384009, RefRangeEnd = 384011, XrefRangeStart = 383977, XrefRangeEnd = 384009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_Set_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B20 RID: 6944 RVA: 0x000725F8 File Offset: 0x000707F8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 384022, RefRangeEnd = 384024, XrefRangeStart = 384011, XrefRangeEnd = 384022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B21 RID: 6945 RVA: 0x0007262C File Offset: 0x0007082C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384024, XrefRangeEnd = 384030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncManualResetEvent(bool state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B22 RID: 6946 RVA: 0x0000E176 File Offset: 0x0000C376
			public AsyncManualResetEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A3 RID: 2211
			// (get) Token: 0x06001B23 RID: 6947 RVA: 0x00072674 File Offset: 0x00070874
			// (set) Token: 0x06001B24 RID: 6948 RVA: 0x0000E17F File Offset: 0x0000C37F
			public unsafe TaskCompletionSource<bool> m_tcs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent.NativeFieldInfoPtr_m_tcs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent.NativeFieldInfoPtr_m_tcs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001524 RID: 5412
			private static readonly IntPtr NativeFieldInfoPtr_m_tcs;

			// Token: 0x04001525 RID: 5413
			private static readonly IntPtr NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_0;

			// Token: 0x04001526 RID: 5414
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_0;

			// Token: 0x04001527 RID: 5415
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

			// Token: 0x04001528 RID: 5416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

			// Token: 0x0200023F RID: 575
			[ObfuscatedName("System.Net.ServicePointScheduler+AsyncManualResetEvent+<WaitAsync>d__3")]
			public sealed class _WaitAsync_d__3 : ValueType
			{
				// Token: 0x06001E6B RID: 7787 RVA: 0x0007C1A8 File Offset: 0x0007A3A8
				// Note: this type is marked as 'beforefieldinit'.
				static _WaitAsync_d__3()
				{
					Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, "<WaitAsync>d__3");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr);
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, "<>1__state");
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, "<>t__builder");
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr_millisecondTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, "millisecondTimeout");
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, "<>4__this");
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr__timeoutTask_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, "<timeoutTask>5__1");
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, "<>u__1");
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, 100665990);
					ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr, 100665991);
				}

				// Token: 0x06001E6C RID: 7788 RVA: 0x0007C274 File Offset: 0x0007A474
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383913, XrefRangeEnd = 383946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E6D RID: 7789 RVA: 0x0007C2AC File Offset: 0x0007A4AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383946, XrefRangeEnd = 383961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001E6E RID: 7790 RVA: 0x000105ED File Offset: 0x0000E7ED
				public _WaitAsync_d__3(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001E6F RID: 7791 RVA: 0x000105F6 File Offset: 0x0000E7F6
				public _WaitAsync_d__3()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3>.NativeClassPtr))
				{
				}

				// Token: 0x1700098A RID: 2442
				// (get) Token: 0x06001E70 RID: 7792 RVA: 0x0007C2F4 File Offset: 0x0007A4F4
				// (set) Token: 0x06001E71 RID: 7793 RVA: 0x00010608 File Offset: 0x0000E808
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700098B RID: 2443
				// (get) Token: 0x06001E72 RID: 7794 RVA: 0x0007C31C File Offset: 0x0007A51C
				// (set) Token: 0x06001E73 RID: 7795 RVA: 0x00010623 File Offset: 0x0000E823
				public AsyncTaskMethodBuilder<bool> __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___t__builder);
						return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x1700098C RID: 2444
				// (get) Token: 0x06001E74 RID: 7796 RVA: 0x0007C34C File Offset: 0x0007A54C
				// (set) Token: 0x06001E75 RID: 7797 RVA: 0x00010651 File Offset: 0x0000E851
				public unsafe int millisecondTimeout
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr_millisecondTimeout);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr_millisecondTimeout)) = value;
					}
				}

				// Token: 0x1700098D RID: 2445
				// (get) Token: 0x06001E76 RID: 7798 RVA: 0x0007C374 File Offset: 0x0007A574
				// (set) Token: 0x06001E77 RID: 7799 RVA: 0x0001066C File Offset: 0x0000E86C
				public unsafe ServicePointScheduler.AsyncManualResetEvent __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.AsyncManualResetEvent>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700098E RID: 2446
				// (get) Token: 0x06001E78 RID: 7800 RVA: 0x0007C3A4 File Offset: 0x0007A5A4
				// (set) Token: 0x06001E79 RID: 7801 RVA: 0x0001068B File Offset: 0x0000E88B
				public unsafe Task _timeoutTask_5__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr__timeoutTask_5__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr__timeoutTask_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700098F RID: 2447
				// (get) Token: 0x06001E7A RID: 7802 RVA: 0x0007C3D4 File Offset: 0x0007A5D4
				// (set) Token: 0x06001E7B RID: 7803 RVA: 0x000106AA File Offset: 0x0000E8AA
				public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___u__1);
						return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent._WaitAsync_d__3.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x040016EE RID: 5870
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040016EF RID: 5871
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x040016F0 RID: 5872
				private static readonly IntPtr NativeFieldInfoPtr_millisecondTimeout;

				// Token: 0x040016F1 RID: 5873
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040016F2 RID: 5874
				private static readonly IntPtr NativeFieldInfoPtr__timeoutTask_5__1;

				// Token: 0x040016F3 RID: 5875
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x040016F4 RID: 5876
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x040016F5 RID: 5877
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}

			// Token: 0x02000240 RID: 576
			[ObfuscatedName("System.Net.ServicePointScheduler+AsyncManualResetEvent+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06001E7C RID: 7804 RVA: 0x0007C404 File Offset: 0x0007A604
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr);
					ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr, "<>9");
					ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr, "<>9__4_0");
					ServicePointScheduler.AsyncManualResetEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr, 100665993);
					ServicePointScheduler.AsyncManualResetEvent.__c.NativeMethodInfoPtr__Set_b__4_0_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr, 100665994);
				}

				// Token: 0x06001E7D RID: 7805 RVA: 0x0007C480 File Offset: 0x0007A680
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E7E RID: 7806 RVA: 0x0007C4BC File Offset: 0x0007A6BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383961, XrefRangeEnd = 383967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Set_b__4_0(Object s)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.__c.NativeMethodInfoPtr__Set_b__4_0_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001E7F RID: 7807 RVA: 0x000106D8 File Offset: 0x0000E8D8
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000990 RID: 2448
				// (get) Token: 0x06001E80 RID: 7808 RVA: 0x0007C50C File Offset: 0x0007A70C
				// (set) Token: 0x06001E81 RID: 7809 RVA: 0x000106E1 File Offset: 0x0000E8E1
				public unsafe static ServicePointScheduler.AsyncManualResetEvent.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.AsyncManualResetEvent.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000991 RID: 2449
				// (get) Token: 0x06001E82 RID: 7810 RVA: 0x0007C534 File Offset: 0x0007A734
				// (set) Token: 0x06001E83 RID: 7811 RVA: 0x000106F3 File Offset: 0x0000E8F3
				public unsafe static Func<Object, bool> __9__4_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040016F6 RID: 5878
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040016F7 RID: 5879
				private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

				// Token: 0x040016F8 RID: 5880
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040016F9 RID: 5881
				private static readonly IntPtr NativeMethodInfoPtr__Set_b__4_0_Internal_Boolean_Object_0;
			}
		}

		// Token: 0x020001F2 RID: 498
		[ObfuscatedName("System.Net.ServicePointScheduler+<StartScheduler>d__32")]
		public sealed class _StartScheduler_d__32 : ValueType
		{
			// Token: 0x06001B25 RID: 6949 RVA: 0x000726A4 File Offset: 0x000708A4
			// Note: this type is marked as 'beforefieldinit'.
			static _StartScheduler_d__32()
			{
				Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "<StartScheduler>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr);
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<>1__state");
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<>t__builder");
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<>4__this");
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__taskList_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<taskList>5__1");
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__operationArray_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<operationArray>5__2");
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__idleArray_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<idleArray>5__3");
				ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, "<>u__1");
				ServicePointScheduler._StartScheduler_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, 100665995);
				ServicePointScheduler._StartScheduler_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr, 100665996);
			}

			// Token: 0x06001B26 RID: 6950 RVA: 0x00072784 File Offset: 0x00070984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384030, XrefRangeEnd = 384115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler._StartScheduler_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B27 RID: 6951 RVA: 0x000727BC File Offset: 0x000709BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler._StartScheduler_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B28 RID: 6952 RVA: 0x0000E19E File Offset: 0x0000C39E
			public _StartScheduler_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B29 RID: 6953 RVA: 0x0000E1A7 File Offset: 0x0000C3A7
			public _StartScheduler_d__32()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler._StartScheduler_d__32>.NativeClassPtr))
			{
			}

			// Token: 0x170008A4 RID: 2212
			// (get) Token: 0x06001B2A RID: 6954 RVA: 0x00072804 File Offset: 0x00070A04
			// (set) Token: 0x06001B2B RID: 6955 RVA: 0x0000E1B9 File Offset: 0x0000C3B9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008A5 RID: 2213
			// (get) Token: 0x06001B2C RID: 6956 RVA: 0x0007282C File Offset: 0x00070A2C
			// (set) Token: 0x06001B2D RID: 6957 RVA: 0x0000E1D4 File Offset: 0x0000C3D4
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008A6 RID: 2214
			// (get) Token: 0x06001B2E RID: 6958 RVA: 0x0007285C File Offset: 0x00070A5C
			// (set) Token: 0x06001B2F RID: 6959 RVA: 0x0000E202 File Offset: 0x0000C402
			public unsafe ServicePointScheduler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x06001B30 RID: 6960 RVA: 0x0007288C File Offset: 0x00070A8C
			// (set) Token: 0x06001B31 RID: 6961 RVA: 0x0000E221 File Offset: 0x0000C421
			public unsafe List<Task> _taskList_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__taskList_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Task>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__taskList_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A8 RID: 2216
			// (get) Token: 0x06001B32 RID: 6962 RVA: 0x000728BC File Offset: 0x00070ABC
			// (set) Token: 0x06001B33 RID: 6963 RVA: 0x0000E240 File Offset: 0x0000C440
			public unsafe Il2CppReferenceArray<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> _operationArray_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__operationArray_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__operationArray_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A9 RID: 2217
			// (get) Token: 0x06001B34 RID: 6964 RVA: 0x000728EC File Offset: 0x00070AEC
			// (set) Token: 0x06001B35 RID: 6965 RVA: 0x0000E25F File Offset: 0x0000C45F
			public unsafe Il2CppReferenceArray<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> _idleArray_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__idleArray_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr__idleArray_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AA RID: 2218
			// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0007291C File Offset: 0x00070B1C
			// (set) Token: 0x06001B37 RID: 6967 RVA: 0x0000E27E File Offset: 0x0000C47E
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._StartScheduler_d__32.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001529 RID: 5417
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400152A RID: 5418
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400152B RID: 5419
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400152C RID: 5420
			private static readonly IntPtr NativeFieldInfoPtr__taskList_5__1;

			// Token: 0x0400152D RID: 5421
			private static readonly IntPtr NativeFieldInfoPtr__operationArray_5__2;

			// Token: 0x0400152E RID: 5422
			private static readonly IntPtr NativeFieldInfoPtr__idleArray_5__3;

			// Token: 0x0400152F RID: 5423
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001530 RID: 5424
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001531 RID: 5425
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
