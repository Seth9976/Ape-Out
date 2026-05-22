using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x02000139 RID: 313
	public class WebCompletionSource : Object
	{
		// Token: 0x06001332 RID: 4914 RVA: 0x00058244 File Offset: 0x00056444
		// Note: this type is marked as 'beforefieldinit'.
		static WebCompletionSource()
		{
			Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebCompletionSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr);
			WebCompletionSource.NativeFieldInfoPtr_completion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, "completion");
			WebCompletionSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100665997);
			WebCompletionSource.NativeMethodInfoPtr_TrySetCompleted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100665998);
			WebCompletionSource.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100665999);
			WebCompletionSource.NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100666000);
			WebCompletionSource.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100666001);
			WebCompletionSource.NativeMethodInfoPtr_ThrowOnError_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100666002);
			WebCompletionSource.NativeMethodInfoPtr_WaitForCompletion_Public_Task_1_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, 100666003);
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00058314 File Offset: 0x00056514
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 384310, RefRangeEnd = 384315, XrefRangeStart = 384304, XrefRangeEnd = 384310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebCompletionSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00058350 File Offset: 0x00056550
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 384322, RefRangeEnd = 384325, XrefRangeStart = 384315, XrefRangeEnd = 384322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr_TrySetCompleted_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0005838C File Offset: 0x0005658C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384325, XrefRangeEnd = 384342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x000583C8 File Offset: 0x000565C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384342, XrefRangeEnd = 384361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetException(Exception error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x00058418 File Offset: 0x00056618
		public unsafe bool IsCompleted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384361, XrefRangeEnd = 384365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00058454 File Offset: 0x00056654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384365, XrefRangeEnd = 384372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowOnError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr_ThrowOnError_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00058488 File Offset: 0x00056688
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 384382, RefRangeEnd = 384385, XrefRangeStart = 384372, XrefRangeEnd = 384382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> WaitForCompletion(bool throwOnError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnError;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.NativeMethodInfoPtr_WaitForCompletion_Public_Task_1_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00009CDE File Offset: 0x00007EDE
		public WebCompletionSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x000584D4 File Offset: 0x000566D4
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x00009CE7 File Offset: 0x00007EE7
		public unsafe TaskCompletionSource<WebCompletionSource.Result> completion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource.NativeFieldInfoPtr_completion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<WebCompletionSource.Result>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource.NativeFieldInfoPtr_completion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeFieldInfoPtr_completion;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCompleted_Public_Boolean_0;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOnError_Public_Void_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Task_1_Boolean_Boolean_0;

		// Token: 0x020001F3 RID: 499
		[OriginalName("System.dll", "", "State")]
		public enum State
		{
			// Token: 0x04001533 RID: 5427
			Running,
			// Token: 0x04001534 RID: 5428
			Completed,
			// Token: 0x04001535 RID: 5429
			Canceled,
			// Token: 0x04001536 RID: 5430
			Faulted
		}

		// Token: 0x020001F4 RID: 500
		public class Result : Object
		{
			// Token: 0x06001B38 RID: 6968 RVA: 0x0007294C File Offset: 0x00070B4C
			// Note: this type is marked as 'beforefieldinit'.
			static Result()
			{
				Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, "Result");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr);
				WebCompletionSource.Result.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr, "<State>k__BackingField");
				WebCompletionSource.Result.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr, "<Error>k__BackingField");
				WebCompletionSource.Result.NativeMethodInfoPtr_get_State_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr, 100666004);
				WebCompletionSource.Result.NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr, 100666005);
				WebCompletionSource.Result.NativeMethodInfoPtr__ctor_Public_Void_State_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr, 100666006);
			}

			// Token: 0x170008AD RID: 2221
			// (get) Token: 0x06001B39 RID: 6969 RVA: 0x000729DC File Offset: 0x00070BDC
			public unsafe WebCompletionSource.State State
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.Result.NativeMethodInfoPtr_get_State_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170008AE RID: 2222
			// (get) Token: 0x06001B3A RID: 6970 RVA: 0x00072A18 File Offset: 0x00070C18
			public unsafe ExceptionDispatchInfo Error
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.Result.NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
				}
			}

			// Token: 0x06001B3B RID: 6971 RVA: 0x00072A58 File Offset: 0x00070C58
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 106068, RefRangeEnd = 106070, XrefRangeStart = 106068, XrefRangeEnd = 106070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Result(WebCompletionSource.State state, ExceptionDispatchInfo error)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebCompletionSource.Result>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource.Result.NativeMethodInfoPtr__ctor_Public_Void_State_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B3C RID: 6972 RVA: 0x0000E2AC File Offset: 0x0000C4AC
			public Result(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008AB RID: 2219
			// (get) Token: 0x06001B3D RID: 6973 RVA: 0x00072AB4 File Offset: 0x00070CB4
			// (set) Token: 0x06001B3E RID: 6974 RVA: 0x0000E2B5 File Offset: 0x0000C4B5
			public unsafe WebCompletionSource.State _State_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource.Result.NativeFieldInfoPtr__State_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource.Result.NativeFieldInfoPtr__State_k__BackingField)) = value;
				}
			}

			// Token: 0x170008AC RID: 2220
			// (get) Token: 0x06001B3F RID: 6975 RVA: 0x00072ADC File Offset: 0x00070CDC
			// (set) Token: 0x06001B40 RID: 6976 RVA: 0x0000E2D0 File Offset: 0x0000C4D0
			public unsafe ExceptionDispatchInfo _Error_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource.Result.NativeFieldInfoPtr__Error_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource.Result.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001537 RID: 5431
			private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

			// Token: 0x04001538 RID: 5432
			private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

			// Token: 0x04001539 RID: 5433
			private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_State_0;

			// Token: 0x0400153A RID: 5434
			private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0;

			// Token: 0x0400153B RID: 5435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_State_ExceptionDispatchInfo_0;
		}

		// Token: 0x020001F5 RID: 501
		[ObfuscatedName("System.Net.WebCompletionSource+<WaitForCompletion>d__8")]
		public sealed class _WaitForCompletion_d__8 : ValueType
		{
			// Token: 0x06001B41 RID: 6977 RVA: 0x00072B0C File Offset: 0x00070D0C
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForCompletion_d__8()
			{
				Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebCompletionSource>.NativeClassPtr, "<WaitForCompletion>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr);
				WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, "<>1__state");
				WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, "<>t__builder");
				WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, "<>4__this");
				WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr_throwOnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, "throwOnError");
				WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, "<>u__1");
				WebCompletionSource._WaitForCompletion_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, 100666007);
				WebCompletionSource._WaitForCompletion_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr, 100666008);
			}

			// Token: 0x06001B42 RID: 6978 RVA: 0x00072BC4 File Offset: 0x00070DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384271, XrefRangeEnd = 384289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource._WaitForCompletion_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B43 RID: 6979 RVA: 0x00072BFC File Offset: 0x00070DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384289, XrefRangeEnd = 384304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebCompletionSource._WaitForCompletion_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B44 RID: 6980 RVA: 0x0000E2EF File Offset: 0x0000C4EF
			public _WaitForCompletion_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B45 RID: 6981 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
			public _WaitForCompletion_d__8()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebCompletionSource._WaitForCompletion_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x170008AF RID: 2223
			// (get) Token: 0x06001B46 RID: 6982 RVA: 0x00072C44 File Offset: 0x00070E44
			// (set) Token: 0x06001B47 RID: 6983 RVA: 0x0000E30A File Offset: 0x0000C50A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008B0 RID: 2224
			// (get) Token: 0x06001B48 RID: 6984 RVA: 0x00072C6C File Offset: 0x00070E6C
			// (set) Token: 0x06001B49 RID: 6985 RVA: 0x0000E325 File Offset: 0x0000C525
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008B1 RID: 2225
			// (get) Token: 0x06001B4A RID: 6986 RVA: 0x00072C9C File Offset: 0x00070E9C
			// (set) Token: 0x06001B4B RID: 6987 RVA: 0x0000E353 File Offset: 0x0000C553
			public unsafe WebCompletionSource __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B2 RID: 2226
			// (get) Token: 0x06001B4C RID: 6988 RVA: 0x00072CCC File Offset: 0x00070ECC
			// (set) Token: 0x06001B4D RID: 6989 RVA: 0x0000E372 File Offset: 0x0000C572
			public unsafe bool throwOnError
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr_throwOnError);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr_throwOnError)) = value;
				}
			}

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x06001B4E RID: 6990 RVA: 0x00072CF4 File Offset: 0x00070EF4
			// (set) Token: 0x06001B4F RID: 6991 RVA: 0x0000E38D File Offset: 0x0000C58D
			public ConfiguredTaskAwaitable<WebCompletionSource.Result>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<WebCompletionSource.Result>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebCompletionSource.Result>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebCompletionSource._WaitForCompletion_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebCompletionSource.Result>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400153C RID: 5436
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400153D RID: 5437
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400153E RID: 5438
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400153F RID: 5439
			private static readonly IntPtr NativeFieldInfoPtr_throwOnError;

			// Token: 0x04001540 RID: 5440
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001541 RID: 5441
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001542 RID: 5442
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
