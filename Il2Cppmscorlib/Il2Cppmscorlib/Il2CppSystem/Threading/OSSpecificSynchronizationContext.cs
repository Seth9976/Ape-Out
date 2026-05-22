using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200027B RID: 635
	public class OSSpecificSynchronizationContext : SynchronizationContext
	{
		// Token: 0x06002BE0 RID: 11232 RVA: 0x000E3824 File Offset: 0x000E1A24
		// Note: this type is marked as 'beforefieldinit'.
		static OSSpecificSynchronizationContext()
		{
			Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "OSSpecificSynchronizationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr);
			OSSpecificSynchronizationContext.NativeFieldInfoPtr_m_OSSynchronizationContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "m_OSSynchronizationContext");
			OSSpecificSynchronizationContext.NativeFieldInfoPtr_s_ContextCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "s_ContextCache");
			OSSpecificSynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670336);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_Get_Public_Static_OSSpecificSynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670337);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670338);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670339);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670340);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_InvocationEntry_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670341);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_GetOSContext_Private_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670342);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_PostInternal_Private_Static_Void_Object_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670343);
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x000E391C File Offset: 0x000E1B1C
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OSSpecificSynchronizationContext(Object osContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(osContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000E3968 File Offset: 0x000E1B68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201570, RefRangeEnd = 201573, XrefRangeStart = 201545, XrefRangeEnd = 201570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OSSpecificSynchronizationContext Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr_Get_Public_Static_OSSpecificSynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OSSpecificSynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x000E399C File Offset: 0x000E1B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201573, XrefRangeEnd = 201576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SynchronizationContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OSSpecificSynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000E39E8 File Offset: 0x000E1BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201576, XrefRangeEnd = 201581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Send(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OSSpecificSynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000E3A48 File Offset: 0x000E1C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201581, XrefRangeEnd = 201607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Post(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OSSpecificSynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000E3AA8 File Offset: 0x000E1CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201607, XrefRangeEnd = 201619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvocationEntry(IntPtr arg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arg;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr_InvocationEntry_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000E3ADC File Offset: 0x000E1CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201619, XrefRangeEnd = 201622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetOSContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr_GetOSContext_Private_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000E3B10 File Offset: 0x000E1D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201622, XrefRangeEnd = 201624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PostInternal(Object osSynchronizationContext, IntPtr callback, IntPtr arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(osSynchronizationContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callback;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr_PostInternal_Private_Static_Void_Object_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0000F224 File Offset: 0x0000D424
		public OSSpecificSynchronizationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06002BEA RID: 11242 RVA: 0x000E3B64 File Offset: 0x000E1D64
		// (set) Token: 0x06002BEB RID: 11243 RVA: 0x0000F22D File Offset: 0x0000D42D
		public unsafe Object m_OSSynchronizationContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.NativeFieldInfoPtr_m_OSSynchronizationContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.NativeFieldInfoPtr_m_OSSynchronizationContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x000E3B94 File Offset: 0x000E1D94
		// (set) Token: 0x06002BED RID: 11245 RVA: 0x0000F24C File Offset: 0x0000D44C
		public unsafe static ConditionalWeakTable<Object, OSSpecificSynchronizationContext> s_ContextCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OSSpecificSynchronizationContext.NativeFieldInfoPtr_s_ContextCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, OSSpecificSynchronizationContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OSSpecificSynchronizationContext.NativeFieldInfoPtr_s_ContextCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002653 RID: 9811
		private static readonly IntPtr NativeFieldInfoPtr_m_OSSynchronizationContext;

		// Token: 0x04002654 RID: 9812
		private static readonly IntPtr NativeFieldInfoPtr_s_ContextCache;

		// Token: 0x04002655 RID: 9813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;

		// Token: 0x04002656 RID: 9814
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_OSSpecificSynchronizationContext_0;

		// Token: 0x04002657 RID: 9815
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0;

		// Token: 0x04002658 RID: 9816
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x04002659 RID: 9817
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x0400265A RID: 9818
		private static readonly IntPtr NativeMethodInfoPtr_InvocationEntry_Private_Static_Void_IntPtr_0;

		// Token: 0x0400265B RID: 9819
		private static readonly IntPtr NativeMethodInfoPtr_GetOSContext_Private_Static_Object_0;

		// Token: 0x0400265C RID: 9820
		private static readonly IntPtr NativeMethodInfoPtr_PostInternal_Private_Static_Void_Object_IntPtr_IntPtr_0;

		// Token: 0x020005F1 RID: 1521
		public sealed class InvocationEntryDelegate : MulticastDelegate
		{
			// Token: 0x06005424 RID: 21540 RVA: 0x0017A7A0 File Offset: 0x001789A0
			// Note: this type is marked as 'beforefieldinit'.
			static InvocationEntryDelegate()
			{
				Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "InvocationEntryDelegate");
				OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr, 100670345);
				OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr, 100670346);
				OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr, 100670347);
				OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr, 100670348);
			}

			// Token: 0x06005425 RID: 21541 RVA: 0x0017A814 File Offset: 0x00178A14
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InvocationEntryDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005426 RID: 21542 RVA: 0x0017A870 File Offset: 0x00178A70
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1199, RefRangeEnd = 1208, XrefRangeStart = 1199, XrefRangeEnd = 1208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr arg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref arg;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005427 RID: 21543 RVA: 0x0017A8B0 File Offset: 0x00178AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201538, XrefRangeEnd = 201542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr arg, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref arg;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005428 RID: 21544 RVA: 0x0017A920 File Offset: 0x00178B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005429 RID: 21545 RVA: 0x0001FC12 File Offset: 0x0001DE12
			public InvocationEntryDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600542A RID: 21546 RVA: 0x0001FC1B File Offset: 0x0001DE1B
			public static implicit operator OSSpecificSynchronizationContext.InvocationEntryDelegate(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<OSSpecificSynchronizationContext.InvocationEntryDelegate>(A_0);
			}

			// Token: 0x0600542B RID: 21547 RVA: 0x0001FC23 File Offset: 0x0001DE23
			public static OSSpecificSynchronizationContext.InvocationEntryDelegate operator +(OSSpecificSynchronizationContext.InvocationEntryDelegate A_0, OSSpecificSynchronizationContext.InvocationEntryDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<OSSpecificSynchronizationContext.InvocationEntryDelegate>();
			}

			// Token: 0x0600542C RID: 21548 RVA: 0x0001FC31 File Offset: 0x0001DE31
			public static OSSpecificSynchronizationContext.InvocationEntryDelegate operator -(OSSpecificSynchronizationContext.InvocationEntryDelegate A_0, OSSpecificSynchronizationContext.InvocationEntryDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<OSSpecificSynchronizationContext.InvocationEntryDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04004438 RID: 17464
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004439 RID: 17465
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

			// Token: 0x0400443A RID: 17466
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

			// Token: 0x0400443B RID: 17467
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020005F2 RID: 1522
		public sealed class MonoPInvokeCallbackAttribute : Attribute
		{
			// Token: 0x0600542D RID: 21549 RVA: 0x0001FC42 File Offset: 0x0001DE42
			// Note: this type is marked as 'beforefieldinit'.
			static MonoPInvokeCallbackAttribute()
			{
				Il2CppClassPointerStore<OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "MonoPInvokeCallbackAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute>.NativeClassPtr);
				OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute>.NativeClassPtr, 100670349);
			}

			// Token: 0x0600542E RID: 21550 RVA: 0x0017A964 File Offset: 0x00178B64
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MonoPInvokeCallbackAttribute(Type t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600542F RID: 21551 RVA: 0x0001FC76 File Offset: 0x0001DE76
			public MonoPInvokeCallbackAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400443C RID: 17468
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
		}

		// Token: 0x020005F3 RID: 1523
		public class InvocationContext : Object
		{
			// Token: 0x06005430 RID: 21552 RVA: 0x0017A9B0 File Offset: 0x00178BB0
			// Note: this type is marked as 'beforefieldinit'.
			static InvocationContext()
			{
				Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "InvocationContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr);
				OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr, "m_Delegate");
				OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr, "m_State");
				OSSpecificSynchronizationContext.InvocationContext.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr, 100670350);
				OSSpecificSynchronizationContext.InvocationContext.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr, 100670351);
			}

			// Token: 0x06005431 RID: 21553 RVA: 0x0017AA2C File Offset: 0x00178C2C
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InvocationContext(SendOrPostCallback d, Object state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationContext.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005432 RID: 21554 RVA: 0x0017AA8C File Offset: 0x00178C8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationContext.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005433 RID: 21555 RVA: 0x0001FC7F File Offset: 0x0001DE7F
			public InvocationContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700159A RID: 5530
			// (get) Token: 0x06005434 RID: 21556 RVA: 0x0017AAC0 File Offset: 0x00178CC0
			// (set) Token: 0x06005435 RID: 21557 RVA: 0x0001FC88 File Offset: 0x0001DE88
			public unsafe SendOrPostCallback m_Delegate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_Delegate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700159B RID: 5531
			// (get) Token: 0x06005436 RID: 21558 RVA: 0x0017AAF0 File Offset: 0x00178CF0
			// (set) Token: 0x06005437 RID: 21559 RVA: 0x0001FCA7 File Offset: 0x0001DEA7
			public unsafe Object m_State
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_State);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_State), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400443D RID: 17469
			private static readonly IntPtr NativeFieldInfoPtr_m_Delegate;

			// Token: 0x0400443E RID: 17470
			private static readonly IntPtr NativeFieldInfoPtr_m_State;

			// Token: 0x0400443F RID: 17471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_0;

			// Token: 0x04004440 RID: 17472
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;
		}

		// Token: 0x020005F4 RID: 1524
		[ObfuscatedName("System.Threading.OSSpecificSynchronizationContext+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005438 RID: 21560 RVA: 0x0017AB20 File Offset: 0x00178D20
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr);
				OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr, "<>9");
				OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr, "<>9__3_0");
				OSSpecificSynchronizationContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr, 100670353);
				OSSpecificSynchronizationContext.__c.NativeMethodInfoPtr__Get_b__3_0_Internal_OSSpecificSynchronizationContext_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr, 100670354);
			}

			// Token: 0x06005439 RID: 21561 RVA: 0x0017AB9C File Offset: 0x00178D9C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600543A RID: 21562 RVA: 0x0017ABD8 File Offset: 0x00178DD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201542, XrefRangeEnd = 201545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OSSpecificSynchronizationContext _Get_b__3_0(Object _osContext)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_osContext);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.__c.NativeMethodInfoPtr__Get_b__3_0_Internal_OSSpecificSynchronizationContext_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<OSSpecificSynchronizationContext>(intPtr3) : null;
				}
			}

			// Token: 0x0600543B RID: 21563 RVA: 0x0001FCC6 File Offset: 0x0001DEC6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700159C RID: 5532
			// (get) Token: 0x0600543C RID: 21564 RVA: 0x0017AC28 File Offset: 0x00178E28
			// (set) Token: 0x0600543D RID: 21565 RVA: 0x0001FCCF File Offset: 0x0001DECF
			public unsafe static OSSpecificSynchronizationContext.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OSSpecificSynchronizationContext.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700159D RID: 5533
			// (get) Token: 0x0600543E RID: 21566 RVA: 0x0017AC50 File Offset: 0x00178E50
			// (set) Token: 0x0600543F RID: 21567 RVA: 0x0001FCE1 File Offset: 0x0001DEE1
			public unsafe static ConditionalWeakTable<Object, OSSpecificSynchronizationContext>.CreateValueCallback __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, OSSpecificSynchronizationContext>.CreateValueCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004441 RID: 17473
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004442 RID: 17474
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04004443 RID: 17475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004444 RID: 17476
			private static readonly IntPtr NativeMethodInfoPtr__Get_b__3_0_Internal_OSSpecificSynchronizationContext_Object_0;
		}
	}
}
