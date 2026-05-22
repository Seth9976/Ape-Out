using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000424 RID: 1060
	public sealed class ConfiguredTaskAwaitable : ValueType
	{
		// Token: 0x06004316 RID: 17174 RVA: 0x0013736C File Offset: 0x0013556C
		// Note: this type is marked as 'beforefieldinit'.
		static ConfiguredTaskAwaitable()
		{
			Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ConfiguredTaskAwaitable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr);
			ConfiguredTaskAwaitable.NativeFieldInfoPtr_m_configuredTaskAwaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, "m_configuredTaskAwaiter");
			ConfiguredTaskAwaitable.NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, 100673108);
			ConfiguredTaskAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, 100673109);
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x001373D8 File Offset: 0x001355D8
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 226593, RefRangeEnd = 226622, XrefRangeStart = 226593, XrefRangeEnd = 226593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x00137438 File Offset: 0x00135638
		[CallerCount(0)]
		public unsafe ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(intPtr);
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x00019627 File Offset: 0x00017827
		public ConfiguredTaskAwaitable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x00019630 File Offset: 0x00017830
		public ConfiguredTaskAwaitable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr))
		{
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x0600431B RID: 17179 RVA: 0x00137474 File Offset: 0x00135674
		// (set) Token: 0x0600431C RID: 17180 RVA: 0x00019642 File Offset: 0x00017842
		public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.NativeFieldInfoPtr_m_configuredTaskAwaiter);
				return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.NativeFieldInfoPtr_m_configuredTaskAwaiter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04003697 RID: 13975
		private static readonly IntPtr NativeFieldInfoPtr_m_configuredTaskAwaiter;

		// Token: 0x04003698 RID: 13976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0;

		// Token: 0x04003699 RID: 13977
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0;

		// Token: 0x02000642 RID: 1602
		public sealed class ConfiguredTaskAwaiter : ValueType, INotifyCompletion
		{
			// Token: 0x06005664 RID: 22116 RVA: 0x00181608 File Offset: 0x0017F808
			// Note: this type is marked as 'beforefieldinit'.
			static ConfiguredTaskAwaiter()
			{
				Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, "ConfiguredTaskAwaiter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, "m_task");
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, "m_continueOnCapturedContext");
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100673110);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100673111);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100673112);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100673113);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100673114);
			}

			// Token: 0x06005665 RID: 22117 RVA: 0x001816C0 File Offset: 0x0017F8C0
			[CallerCount(0)]
			public unsafe ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700163C RID: 5692
			// (get) Token: 0x06005666 RID: 22118 RVA: 0x00181720 File Offset: 0x0017F920
			public unsafe bool IsCompleted
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 226484, RefRangeEnd = 226486, XrefRangeStart = 226484, XrefRangeEnd = 226486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005667 RID: 22119 RVA: 0x00181764 File Offset: 0x0017F964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226591, XrefRangeEnd = 226592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005668 RID: 22120 RVA: 0x001817AC File Offset: 0x0017F9AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226592, XrefRangeEnd = 226593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UnsafeOnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005669 RID: 22121 RVA: 0x001817F4 File Offset: 0x0017F9F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetResult()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600566A RID: 22122 RVA: 0x00020F18 File Offset: 0x0001F118
			public ConfiguredTaskAwaiter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600566B RID: 22123 RVA: 0x00020F21 File Offset: 0x0001F121
			public ConfiguredTaskAwaiter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr))
			{
			}

			// Token: 0x1700163A RID: 5690
			// (get) Token: 0x0600566C RID: 22124 RVA: 0x0018182C File Offset: 0x0017FA2C
			// (set) Token: 0x0600566D RID: 22125 RVA: 0x00020F33 File Offset: 0x0001F133
			public unsafe Task m_task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163B RID: 5691
			// (get) Token: 0x0600566E RID: 22126 RVA: 0x0018185C File Offset: 0x0017FA5C
			// (set) Token: 0x0600566F RID: 22127 RVA: 0x00020F52 File Offset: 0x0001F152
			public unsafe bool m_continueOnCapturedContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext)) = value;
				}
			}

			// Token: 0x06005670 RID: 22128 RVA: 0x00020F6D File Offset: 0x0001F16D
			public void OnCompleted(Action continuation)
			{
				this.OnCompleted(continuation);
			}

			// Token: 0x04004580 RID: 17792
			private static readonly IntPtr NativeFieldInfoPtr_m_task;

			// Token: 0x04004581 RID: 17793
			private static readonly IntPtr NativeFieldInfoPtr_m_continueOnCapturedContext;

			// Token: 0x04004582 RID: 17794
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0;

			// Token: 0x04004583 RID: 17795
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x04004584 RID: 17796
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004585 RID: 17797
			private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004586 RID: 17798
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;
		}
	}
}
