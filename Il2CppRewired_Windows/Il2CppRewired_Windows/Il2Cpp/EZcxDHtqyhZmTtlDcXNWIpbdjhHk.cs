using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200006E RID: 110
	public sealed class EZcxDHtqyhZmTtlDcXNWIpbdjhHk : MulticastDelegate
	{
		// Token: 0x060008F2 RID: 2290 RVA: 0x0002AB1C File Offset: 0x00028D1C
		// Note: this type is marked as 'beforefieldinit'.
		static EZcxDHtqyhZmTtlDcXNWIpbdjhHk()
		{
			Il2CppClassPointerStore<EZcxDHtqyhZmTtlDcXNWIpbdjhHk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "EZcxDHtqyhZmTtlDcXNWIpbdjhHk");
			EZcxDHtqyhZmTtlDcXNWIpbdjhHk.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EZcxDHtqyhZmTtlDcXNWIpbdjhHk>.NativeClassPtr, 100664826);
			EZcxDHtqyhZmTtlDcXNWIpbdjhHk.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_UInt32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EZcxDHtqyhZmTtlDcXNWIpbdjhHk>.NativeClassPtr, 100664827);
			EZcxDHtqyhZmTtlDcXNWIpbdjhHk.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_IntPtr_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EZcxDHtqyhZmTtlDcXNWIpbdjhHk>.NativeClassPtr, 100664828);
			EZcxDHtqyhZmTtlDcXNWIpbdjhHk.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EZcxDHtqyhZmTtlDcXNWIpbdjhHk>.NativeClassPtr, 100664829);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0002AB94 File Offset: 0x00028D94
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EZcxDHtqyhZmTtlDcXNWIpbdjhHk(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EZcxDHtqyhZmTtlDcXNWIpbdjhHk>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EZcxDHtqyhZmTtlDcXNWIpbdjhHk.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0002ABF0 File Offset: 0x00028DF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359653, RefRangeEnd = 359655, XrefRangeStart = 359653, XrefRangeEnd = 359653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr Invoke(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hWnd;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wParam;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lParam;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EZcxDHtqyhZmTtlDcXNWIpbdjhHk.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_UInt32_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0002AC64 File Offset: 0x00028E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359655, XrefRangeEnd = 359666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hWnd;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wParam;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lParam;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EZcxDHtqyhZmTtlDcXNWIpbdjhHk.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_IntPtr_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0002AD00 File Offset: 0x00028F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EZcxDHtqyhZmTtlDcXNWIpbdjhHk.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00005ED0 File Offset: 0x000040D0
		public EZcxDHtqyhZmTtlDcXNWIpbdjhHk(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00005ED9 File Offset: 0x000040D9
		public static implicit operator EZcxDHtqyhZmTtlDcXNWIpbdjhHk(Func<IntPtr, uint, IntPtr, IntPtr, IntPtr> A_0)
		{
			return DelegateSupport.ConvertDelegate<EZcxDHtqyhZmTtlDcXNWIpbdjhHk>(A_0);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00005EE1 File Offset: 0x000040E1
		public static EZcxDHtqyhZmTtlDcXNWIpbdjhHk operator +(EZcxDHtqyhZmTtlDcXNWIpbdjhHk A_0, EZcxDHtqyhZmTtlDcXNWIpbdjhHk A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<EZcxDHtqyhZmTtlDcXNWIpbdjhHk>();
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00005EEF File Offset: 0x000040EF
		public static EZcxDHtqyhZmTtlDcXNWIpbdjhHk operator -(EZcxDHtqyhZmTtlDcXNWIpbdjhHk A_0, EZcxDHtqyhZmTtlDcXNWIpbdjhHk A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<EZcxDHtqyhZmTtlDcXNWIpbdjhHk>();
			}
			return delegate2;
		}

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_UInt32_IntPtr_IntPtr_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_IntPtr_IntPtr_AsyncCallback_Object_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
	}
}
