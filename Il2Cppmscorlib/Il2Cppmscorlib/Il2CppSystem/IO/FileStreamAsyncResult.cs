using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.IO
{
	// Token: 0x0200021E RID: 542
	public class FileStreamAsyncResult : Object
	{
		// Token: 0x06002375 RID: 9077 RVA: 0x000C4440 File Offset: 0x000C2640
		// Note: this type is marked as 'beforefieldinit'.
		static FileStreamAsyncResult()
		{
			Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileStreamAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr);
			FileStreamAsyncResult.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "state");
			FileStreamAsyncResult.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "completed");
			FileStreamAsyncResult.NativeFieldInfoPtr_wh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "wh");
			FileStreamAsyncResult.NativeFieldInfoPtr_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "cb");
			FileStreamAsyncResult.NativeFieldInfoPtr_completedSynch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "completedSynch");
			FileStreamAsyncResult.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "Count");
			FileStreamAsyncResult.NativeFieldInfoPtr_OriginalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "OriginalCount");
			FileStreamAsyncResult.NativeFieldInfoPtr_BytesRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "BytesRead");
			FileStreamAsyncResult.NativeFieldInfoPtr_realcb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "realcb");
			FileStreamAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100669323);
			FileStreamAsyncResult.NativeMethodInfoPtr_CBWrapper_Private_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100669324);
			FileStreamAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100669325);
			FileStreamAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100669326);
			FileStreamAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100669327);
			FileStreamAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100669328);
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x000C459C File Offset: 0x000C279C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192709, RefRangeEnd = 192710, XrefRangeStart = 192700, XrefRangeEnd = 192709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStreamAsyncResult(AsyncCallback cb, Object state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x000C45FC File Offset: 0x000C27FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192710, XrefRangeEnd = 192713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CBWrapper(IAsyncResult ares)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_CBWrapper_Private_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x000C4634 File Offset: 0x000C2834
		public unsafe virtual Object AsyncState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x000C4674 File Offset: 0x000C2874
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x000C46B0 File Offset: 0x000C28B0
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x000C46F0 File Offset: 0x000C28F0
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x0000BD9D File Offset: 0x00009F9D
		public FileStreamAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x000C472C File Offset: 0x000C292C
		// (set) Token: 0x0600237E RID: 9086 RVA: 0x0000BDA6 File Offset: 0x00009FA6
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x000C475C File Offset: 0x000C295C
		// (set) Token: 0x06002380 RID: 9088 RVA: 0x0000BDC5 File Offset: 0x00009FC5
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x000C4784 File Offset: 0x000C2984
		// (set) Token: 0x06002382 RID: 9090 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		public unsafe ManualResetEvent wh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_wh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_wh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x000C47B4 File Offset: 0x000C29B4
		// (set) Token: 0x06002384 RID: 9092 RVA: 0x0000BDFF File Offset: 0x00009FFF
		public unsafe AsyncCallback cb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_cb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_cb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x000C47E4 File Offset: 0x000C29E4
		// (set) Token: 0x06002386 RID: 9094 RVA: 0x0000BE1E File Offset: 0x0000A01E
		public unsafe bool completedSynch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_completedSynch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_completedSynch)) = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x000C480C File Offset: 0x000C2A0C
		// (set) Token: 0x06002388 RID: 9096 RVA: 0x0000BE39 File Offset: 0x0000A039
		public unsafe int Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_Count)) = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x000C4834 File Offset: 0x000C2A34
		// (set) Token: 0x0600238A RID: 9098 RVA: 0x0000BE54 File Offset: 0x0000A054
		public unsafe int OriginalCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_OriginalCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_OriginalCount)) = value;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x000C485C File Offset: 0x000C2A5C
		// (set) Token: 0x0600238C RID: 9100 RVA: 0x0000BE6F File Offset: 0x0000A06F
		public unsafe int BytesRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_BytesRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_BytesRead)) = value;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x000C4884 File Offset: 0x000C2A84
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x0000BE8A File Offset: 0x0000A08A
		public unsafe AsyncCallback realcb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_realcb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_realcb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeFieldInfoPtr_wh;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeFieldInfoPtr_cb;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeFieldInfoPtr_completedSynch;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeFieldInfoPtr_Count;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeFieldInfoPtr_OriginalCount;

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeFieldInfoPtr_BytesRead;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeFieldInfoPtr_realcb;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeMethodInfoPtr_CBWrapper_Private_Static_Void_IAsyncResult_0;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;
	}
}
