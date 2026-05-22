using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200027D RID: 637
	public class ThreadHelper : Object
	{
		// Token: 0x06002BF3 RID: 11251 RVA: 0x000E3D14 File Offset: 0x000E1F14
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadHelper()
		{
			Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadHelper");
			ThreadHelper.NativeFieldInfoPtr__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_start");
			ThreadHelper.NativeFieldInfoPtr__startArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_startArg");
			ThreadHelper.NativeFieldInfoPtr__executionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_executionContext");
			ThreadHelper.NativeFieldInfoPtr__ccb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_ccb");
			ThreadHelper.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100670359);
			ThreadHelper.NativeMethodInfoPtr_SetExecutionContextHelper_Internal_Void_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100670360);
			ThreadHelper.NativeMethodInfoPtr_ThreadStart_Context_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100670361);
			ThreadHelper.NativeMethodInfoPtr_ThreadStart_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100670362);
			ThreadHelper.NativeMethodInfoPtr_ThreadStart_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100670363);
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x000E3DF0 File Offset: 0x000E1FF0
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadHelper(Delegate start)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x000E3E3C File Offset: 0x000E203C
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExecutionContextHelper(ExecutionContext ec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_SetExecutionContextHelper_Internal_Void_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x000E3E80 File Offset: 0x000E2080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201634, XrefRangeEnd = 201646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThreadStart_Context(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_ThreadStart_Context_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x000E3EB8 File Offset: 0x000E20B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201646, XrefRangeEnd = 201659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThreadStart(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_ThreadStart_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x000E3EFC File Offset: 0x000E20FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201659, XrefRangeEnd = 201672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThreadStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_ThreadStart_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x0000F267 File Offset: 0x0000D467
		public ThreadHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x000E3F30 File Offset: 0x000E2130
		// (set) Token: 0x06002BFB RID: 11259 RVA: 0x0000F270 File Offset: 0x0000D470
		public unsafe Delegate _start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__start);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__start), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x000E3F60 File Offset: 0x000E2160
		// (set) Token: 0x06002BFD RID: 11261 RVA: 0x0000F28F File Offset: 0x0000D48F
		public unsafe Object _startArg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__startArg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__startArg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x000E3F90 File Offset: 0x000E2190
		// (set) Token: 0x06002BFF RID: 11263 RVA: 0x0000F2AE File Offset: 0x0000D4AE
		public unsafe ExecutionContext _executionContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__executionContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__executionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x000E3FC0 File Offset: 0x000E21C0
		// (set) Token: 0x06002C01 RID: 11265 RVA: 0x0000F2CD File Offset: 0x0000D4CD
		public unsafe static ContextCallback _ccb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadHelper.NativeFieldInfoPtr__ccb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadHelper.NativeFieldInfoPtr__ccb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002660 RID: 9824
		private static readonly IntPtr NativeFieldInfoPtr__start;

		// Token: 0x04002661 RID: 9825
		private static readonly IntPtr NativeFieldInfoPtr__startArg;

		// Token: 0x04002662 RID: 9826
		private static readonly IntPtr NativeFieldInfoPtr__executionContext;

		// Token: 0x04002663 RID: 9827
		private static readonly IntPtr NativeFieldInfoPtr__ccb;

		// Token: 0x04002664 RID: 9828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Delegate_0;

		// Token: 0x04002665 RID: 9829
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionContextHelper_Internal_Void_ExecutionContext_0;

		// Token: 0x04002666 RID: 9830
		private static readonly IntPtr NativeMethodInfoPtr_ThreadStart_Context_Private_Static_Void_Object_0;

		// Token: 0x04002667 RID: 9831
		private static readonly IntPtr NativeMethodInfoPtr_ThreadStart_Internal_Void_Object_0;

		// Token: 0x04002668 RID: 9832
		private static readonly IntPtr NativeMethodInfoPtr_ThreadStart_Internal_Void_0;
	}
}
