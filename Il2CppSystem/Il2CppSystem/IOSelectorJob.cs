using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x02000042 RID: 66
	public class IOSelectorJob : Object
	{
		// Token: 0x060003D5 RID: 981 RVA: 0x00020014 File Offset: 0x0001E214
		// Note: this type is marked as 'beforefieldinit'.
		static IOSelectorJob()
		{
			Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IOSelectorJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr);
			IOSelectorJob.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, "operation");
			IOSelectorJob.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, "callback");
			IOSelectorJob.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, "state");
			IOSelectorJob.NativeMethodInfoPtr__ctor_Public_Void_IOOperation_IOAsyncCallback_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, 100663978);
			IOSelectorJob.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, 100663979);
			IOSelectorJob.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, 100663980);
			IOSelectorJob.NativeMethodInfoPtr_MarkDisposed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, 100663981);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000200D0 File Offset: 0x0001E2D0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 369207, RefRangeEnd = 369220, XrefRangeStart = 369207, XrefRangeEnd = 369207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOSelectorJob(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref operation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOSelectorJob.NativeMethodInfoPtr__ctor_Public_Void_IOOperation_IOAsyncCallback_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0002013C File Offset: 0x0001E33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369220, XrefRangeEnd = 369222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOSelectorJob.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00020170 File Offset: 0x0001E370
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOSelectorJob.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000201B4 File Offset: 0x0001E3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369222, XrefRangeEnd = 369223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOSelectorJob.NativeMethodInfoPtr_MarkDisposed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000034FB File Offset: 0x000016FB
		public IOSelectorJob(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003DB RID: 987 RVA: 0x000201E8 File Offset: 0x0001E3E8
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00003504 File Offset: 0x00001704
		public unsafe IOOperation operation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOSelectorJob.NativeFieldInfoPtr_operation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOSelectorJob.NativeFieldInfoPtr_operation)) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00020210 File Offset: 0x0001E410
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000351F File Offset: 0x0000171F
		public unsafe IOAsyncCallback callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOSelectorJob.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOSelectorJob.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00020240 File Offset: 0x0001E440
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x0000353E File Offset: 0x0000173E
		public unsafe IOAsyncResult state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOSelectorJob.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOSelectorJob.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeFieldInfoPtr_operation;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IOOperation_IOAsyncCallback_IOAsyncResult_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_MarkDisposed_Public_Void_0;
	}
}
