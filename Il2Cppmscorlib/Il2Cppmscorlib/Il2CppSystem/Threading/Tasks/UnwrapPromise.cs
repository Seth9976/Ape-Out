using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002AF RID: 687
	public sealed class UnwrapPromise<TResult> : Task<TResult>
	{
		// Token: 0x06002F14 RID: 12052 RVA: 0x000EFD98 File Offset: 0x000EDF98
		// Note: this type is marked as 'beforefieldinit'.
		static UnwrapPromise()
		{
			Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "UnwrapPromise`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr);
			UnwrapPromise<TResult>.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, "_state");
			UnwrapPromise<TResult>.NativeFieldInfoPtr__lookForOce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, "_lookForOce");
			UnwrapPromise<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670805);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670806);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_InvokeCore_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670807);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_InvokeCoreAsync_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670808);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_ProcessCompletedOuterTask_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670809);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_TrySetFromTask_Private_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670810);
			UnwrapPromise<TResult>.NativeMethodInfoPtr_ProcessInnerTask_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, 100670811);
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x000EFEB8 File Offset: 0x000EE0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206680, XrefRangeEnd = 206700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnwrapPromise(Task outerTask, bool lookForOce)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outerTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookForOce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x000EFF14 File Offset: 0x000EE114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206700, XrefRangeEnd = 206705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x000EFF58 File Offset: 0x000EE158
		[CallerCount(0)]
		public unsafe void InvokeCore(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_InvokeCore_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x000EFF9C File Offset: 0x000EE19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206705, XrefRangeEnd = 206722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCoreAsync(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_InvokeCoreAsync_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x000EFFE0 File Offset: 0x000EE1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206722, XrefRangeEnd = 206733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCompletedOuterTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_ProcessCompletedOuterTask_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x000F0024 File Offset: 0x000EE224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206733, XrefRangeEnd = 206749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetFromTask(Task task, bool lookForOce)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookForOce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_TrySetFromTask_Private_Boolean_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x000F0080 File Offset: 0x000EE280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206749, XrefRangeEnd = 206755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessInnerTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.NativeMethodInfoPtr_ProcessInnerTask_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x000104BB File Offset: 0x0000E6BB
		public UnwrapPromise(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x000F00C4 File Offset: 0x000EE2C4
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x000104C4 File Offset: 0x0000E6C4
		public unsafe byte _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnwrapPromise<TResult>.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnwrapPromise<TResult>.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x000F00EC File Offset: 0x000EE2EC
		// (set) Token: 0x06002F20 RID: 12064 RVA: 0x000104DF File Offset: 0x0000E6DF
		public unsafe bool _lookForOce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnwrapPromise<TResult>.NativeFieldInfoPtr__lookForOce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnwrapPromise<TResult>.NativeFieldInfoPtr__lookForOce)) = value;
			}
		}

		// Token: 0x040028D7 RID: 10455
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x040028D8 RID: 10456
		private static readonly IntPtr NativeFieldInfoPtr__lookForOce;

		// Token: 0x040028D9 RID: 10457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_Boolean_0;

		// Token: 0x040028DA RID: 10458
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0;

		// Token: 0x040028DB RID: 10459
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCore_Private_Void_Task_0;

		// Token: 0x040028DC RID: 10460
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCoreAsync_Private_Void_Task_0;

		// Token: 0x040028DD RID: 10461
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCompletedOuterTask_Private_Void_Task_0;

		// Token: 0x040028DE RID: 10462
		private static readonly IntPtr NativeMethodInfoPtr_TrySetFromTask_Private_Boolean_Task_Boolean_0;

		// Token: 0x040028DF RID: 10463
		private static readonly IntPtr NativeMethodInfoPtr_ProcessInnerTask_Private_Void_Task_0;

		// Token: 0x02000614 RID: 1556
		[ObfuscatedName("System.Threading.Tasks.UnwrapPromise`1+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06005501 RID: 21761 RVA: 0x0017D748 File Offset: 0x0017B948
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnwrapPromise<TResult>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr);
				UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr, "<>9");
				UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr, "<>9__8_0");
				UnwrapPromise<TResult>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr, 100670813);
				UnwrapPromise<TResult>.__c.NativeMethodInfoPtr__InvokeCoreAsync_b__8_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr, 100670814);
			}

			// Token: 0x06005502 RID: 21762 RVA: 0x0017D800 File Offset: 0x0017BA00
			[CallerCount(0)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnwrapPromise<TResult>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005503 RID: 21763 RVA: 0x0017D83C File Offset: 0x0017BA3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206672, XrefRangeEnd = 206680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InvokeCoreAsync_b__8_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnwrapPromise<TResult>.__c.NativeMethodInfoPtr__InvokeCoreAsync_b__8_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005504 RID: 21764 RVA: 0x0002028E File Offset: 0x0001E48E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015CD RID: 5581
			// (get) Token: 0x06005505 RID: 21765 RVA: 0x0017D880 File Offset: 0x0017BA80
			// (set) Token: 0x06005506 RID: 21766 RVA: 0x00020297 File Offset: 0x0001E497
			public unsafe static UnwrapPromise<TResult>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnwrapPromise<TResult>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015CE RID: 5582
			// (get) Token: 0x06005507 RID: 21767 RVA: 0x0017D8A8 File Offset: 0x0017BAA8
			// (set) Token: 0x06005508 RID: 21768 RVA: 0x000202A9 File Offset: 0x0001E4A9
			public unsafe static WaitCallback __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnwrapPromise<TResult>.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044B9 RID: 17593
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040044BA RID: 17594
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040044BB RID: 17595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044BC RID: 17596
			private static readonly IntPtr NativeMethodInfoPtr__InvokeCoreAsync_b__8_0_Internal_Void_Object_0;
		}
	}
}
