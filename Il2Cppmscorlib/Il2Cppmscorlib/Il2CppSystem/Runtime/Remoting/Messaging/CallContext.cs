using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003DE RID: 990
	[Serializable]
	public sealed class CallContext : Object
	{
		// Token: 0x06003FD6 RID: 16342 RVA: 0x0012B714 File Offset: 0x00129914
		// Note: this type is marked as 'beforefieldinit'.
		static CallContext()
		{
			Il2CppClassPointerStore<CallContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CallContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallContext>.NativeClassPtr);
			CallContext.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContext>.NativeClassPtr, 100672708);
			CallContext.NativeMethodInfoPtr_SetCurrentCallContext_Internal_Static_Object_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContext>.NativeClassPtr, 100672709);
			CallContext.NativeMethodInfoPtr_SetLogicalCallContext_Internal_Static_LogicalCallContext_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContext>.NativeClassPtr, 100672710);
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x0012B780 File Offset: 0x00129980
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContext.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x0012B7BC File Offset: 0x001299BC
		[CallerCount(0)]
		public unsafe static Object SetCurrentCallContext(LogicalCallContext ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContext.NativeMethodInfoPtr_SetCurrentCallContext_Internal_Static_Object_LogicalCallContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x0012B800 File Offset: 0x00129A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223705, RefRangeEnd = 223706, XrefRangeStart = 223702, XrefRangeEnd = 223705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callCtx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContext.NativeMethodInfoPtr_SetLogicalCallContext_Internal_Static_LogicalCallContext_LogicalCallContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x00017EBB File Offset: 0x000160BB
		public CallContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003476 RID: 13430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04003477 RID: 13431
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentCallContext_Internal_Static_Object_LogicalCallContext_0;

		// Token: 0x04003478 RID: 13432
		private static readonly IntPtr NativeMethodInfoPtr_SetLogicalCallContext_Internal_Static_LogicalCallContext_LogicalCallContext_0;
	}
}
