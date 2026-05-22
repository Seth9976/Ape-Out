using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B6 RID: 694
	public sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x06002F4E RID: 12110 RVA: 0x000F0C68 File Offset: 0x000EEE68
		// Note: this type is marked as 'beforefieldinit'.
		static SynchronizationContextAwaitTaskContinuation()
		{
			Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "SynchronizationContextAwaitTaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr);
			SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, "s_postCallback");
			SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postActionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, "s_postActionCallback");
			SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_m_syncContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, "m_syncContext");
			SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_SynchronizationContext_Action_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, 100670834);
			SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, 100670835);
			SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_PostAction_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, 100670836);
			SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_GetPostActionCallback_Private_Static_ContextCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, 100670837);
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x000F0D24 File Offset: 0x000EEF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206861, XrefRangeEnd = 206862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_SynchronizationContext_Action_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000F0DA0 File Offset: 0x000EEFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206862, XrefRangeEnd = 206871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Run(Task task, bool canInlineContinuationTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canInlineContinuationTask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000F0DF0 File Offset: 0x000EEFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206871, XrefRangeEnd = 206877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PostAction(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_PostAction_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x000F0E28 File Offset: 0x000EF028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206877, XrefRangeEnd = 206889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextCallback GetPostActionCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_GetPostActionCallback_Private_Static_ContextCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr3) : null;
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x00010605 File Offset: 0x0000E805
		public SynchronizationContextAwaitTaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x000F0E5C File Offset: 0x000EF05C
		// (set) Token: 0x06002F55 RID: 12117 RVA: 0x0001060E File Offset: 0x0000E80E
		public unsafe static SendOrPostCallback s_postCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x000F0E84 File Offset: 0x000EF084
		// (set) Token: 0x06002F57 RID: 12119 RVA: 0x00010620 File Offset: 0x0000E820
		public unsafe static ContextCallback s_postActionCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postActionCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postActionCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002F58 RID: 12120 RVA: 0x000F0EAC File Offset: 0x000EF0AC
		// (set) Token: 0x06002F59 RID: 12121 RVA: 0x00010632 File Offset: 0x0000E832
		public unsafe SynchronizationContext m_syncContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_m_syncContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_m_syncContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028FA RID: 10490
		private static readonly IntPtr NativeFieldInfoPtr_s_postCallback;

		// Token: 0x040028FB RID: 10491
		private static readonly IntPtr NativeFieldInfoPtr_s_postActionCallback;

		// Token: 0x040028FC RID: 10492
		private static readonly IntPtr NativeFieldInfoPtr_m_syncContext;

		// Token: 0x040028FD RID: 10493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SynchronizationContext_Action_Boolean_byref_StackCrawlMark_0;

		// Token: 0x040028FE RID: 10494
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0;

		// Token: 0x040028FF RID: 10495
		private static readonly IntPtr NativeMethodInfoPtr_PostAction_Private_Static_Void_Object_0;

		// Token: 0x04002900 RID: 10496
		private static readonly IntPtr NativeMethodInfoPtr_GetPostActionCallback_Private_Static_ContextCallback_0;

		// Token: 0x02000615 RID: 1557
		[ObfuscatedName("System.Threading.Tasks.SynchronizationContextAwaitTaskContinuation+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06005509 RID: 21769 RVA: 0x0017D8D0 File Offset: 0x0017BAD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr);
				SynchronizationContextAwaitTaskContinuation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr, "<>9");
				SynchronizationContextAwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr, 100670840);
				SynchronizationContextAwaitTaskContinuation.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr, 100670841);
			}

			// Token: 0x0600550A RID: 21770 RVA: 0x0017D938 File Offset: 0x0017BB38
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600550B RID: 21771 RVA: 0x0017D974 File Offset: 0x0017BB74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206852, XrefRangeEnd = 206861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__7_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600550C RID: 21772 RVA: 0x000202BB File Offset: 0x0001E4BB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015CF RID: 5583
			// (get) Token: 0x0600550D RID: 21773 RVA: 0x0017D9B8 File Offset: 0x0017BBB8
			// (set) Token: 0x0600550E RID: 21774 RVA: 0x000202C4 File Offset: 0x0001E4C4
			public unsafe static SynchronizationContextAwaitTaskContinuation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SynchronizationContextAwaitTaskContinuation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContextAwaitTaskContinuation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SynchronizationContextAwaitTaskContinuation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044BD RID: 17597
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040044BE RID: 17598
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044BF RID: 17599
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Object_0;
		}
	}
}
