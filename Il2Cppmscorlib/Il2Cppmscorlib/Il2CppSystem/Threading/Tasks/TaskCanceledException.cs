using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B0 RID: 688
	[Serializable]
	public class TaskCanceledException : OperationCanceledException
	{
		// Token: 0x06002F21 RID: 12065 RVA: 0x000F0114 File Offset: 0x000EE314
		// Note: this type is marked as 'beforefieldinit'.
		static TaskCanceledException()
		{
			Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskCanceledException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr);
			TaskCanceledException.NativeFieldInfoPtr_m_canceledTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr, "m_canceledTask");
			TaskCanceledException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr, 100670815);
			TaskCanceledException.NativeMethodInfoPtr__ctor_Public_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr, 100670816);
			TaskCanceledException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr, 100670817);
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x000F0194 File Offset: 0x000EE394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206755, XrefRangeEnd = 206758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCanceledException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCanceledException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x000F01D0 File Offset: 0x000EE3D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206762, RefRangeEnd = 206763, XrefRangeStart = 206758, XrefRangeEnd = 206762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCanceledException(Task task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCanceledException.NativeMethodInfoPtr__ctor_Public_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x000F021C File Offset: 0x000EE41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCanceledException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCanceledException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x000104FA File Offset: 0x0000E6FA
		public TaskCanceledException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000F0280 File Offset: 0x000EE480
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x00010503 File Offset: 0x0000E703
		public unsafe Task m_canceledTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCanceledException.NativeFieldInfoPtr_m_canceledTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCanceledException.NativeFieldInfoPtr_m_canceledTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028E0 RID: 10464
		private static readonly IntPtr NativeFieldInfoPtr_m_canceledTask;

		// Token: 0x040028E1 RID: 10465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040028E2 RID: 10466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_0;

		// Token: 0x040028E3 RID: 10467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
