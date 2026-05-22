using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000271 RID: 625
	public sealed class ExecutionContextSwitcher : ValueType
	{
		// Token: 0x06002B50 RID: 11088 RVA: 0x000E14CC File Offset: 0x000DF6CC
		// Note: this type is marked as 'beforefieldinit'.
		static ExecutionContextSwitcher()
		{
			Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ExecutionContextSwitcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr);
			ExecutionContextSwitcher.NativeFieldInfoPtr_outerEC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "outerEC");
			ExecutionContextSwitcher.NativeFieldInfoPtr_outerECBelongsToScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "outerECBelongsToScope");
			ExecutionContextSwitcher.NativeFieldInfoPtr_hecsw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "hecsw");
			ExecutionContextSwitcher.NativeFieldInfoPtr_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "thread");
			ExecutionContextSwitcher.NativeMethodInfoPtr_UndoNoThrow_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, 100670242);
			ExecutionContextSwitcher.NativeMethodInfoPtr_Undo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, 100670243);
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x000E1574 File Offset: 0x000DF774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201089, XrefRangeEnd = 201090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UndoNoThrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContextSwitcher.NativeMethodInfoPtr_UndoNoThrow_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x000E15B8 File Offset: 0x000DF7B8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 201094, RefRangeEnd = 201103, XrefRangeStart = 201090, XrefRangeEnd = 201094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContextSwitcher.NativeMethodInfoPtr_Undo_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x0000EF57 File Offset: 0x0000D157
		public ExecutionContextSwitcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x0000EF60 File Offset: 0x0000D160
		public ExecutionContextSwitcher()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr))
		{
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x000E15F0 File Offset: 0x000DF7F0
		// (set) Token: 0x06002B56 RID: 11094 RVA: 0x0000EF72 File Offset: 0x0000D172
		public ExecutionContext.Reader outerEC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_outerEC);
				return new ExecutionContext.Reader(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_outerEC), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x000E1620 File Offset: 0x000DF820
		// (set) Token: 0x06002B58 RID: 11096 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		public unsafe bool outerECBelongsToScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_outerECBelongsToScope);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_outerECBelongsToScope)) = value;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x000E1648 File Offset: 0x000DF848
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x0000EFBB File Offset: 0x0000D1BB
		public unsafe Object hecsw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_hecsw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_hecsw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x000E1678 File Offset: 0x000DF878
		// (set) Token: 0x06002B5C RID: 11100 RVA: 0x0000EFDA File Offset: 0x0000D1DA
		public unsafe Thread thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_thread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContextSwitcher.NativeFieldInfoPtr_thread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025EB RID: 9707
		private static readonly IntPtr NativeFieldInfoPtr_outerEC;

		// Token: 0x040025EC RID: 9708
		private static readonly IntPtr NativeFieldInfoPtr_outerECBelongsToScope;

		// Token: 0x040025ED RID: 9709
		private static readonly IntPtr NativeFieldInfoPtr_hecsw;

		// Token: 0x040025EE RID: 9710
		private static readonly IntPtr NativeFieldInfoPtr_thread;

		// Token: 0x040025EF RID: 9711
		private static readonly IntPtr NativeMethodInfoPtr_UndoNoThrow_Internal_Boolean_0;

		// Token: 0x040025F0 RID: 9712
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Internal_Void_0;
	}
}
