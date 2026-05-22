using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F4 RID: 244
	public sealed class HttpContinueDelegate : MulticastDelegate
	{
		// Token: 0x06000D51 RID: 3409 RVA: 0x000427D0 File Offset: 0x000409D0
		// Note: this type is marked as 'beforefieldinit'.
		static HttpContinueDelegate()
		{
			Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpContinueDelegate");
			HttpContinueDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr, 100665213);
			HttpContinueDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr, 100665214);
			HttpContinueDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_WebHeaderCollection_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr, 100665215);
			HttpContinueDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr, 100665216);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00042848 File Offset: 0x00040A48
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpContinueDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContinueDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x000428A4 File Offset: 0x00040AA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 12876, RefRangeEnd = 12878, XrefRangeStart = 12876, XrefRangeEnd = 12878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int StatusCode, WebHeaderCollection httpHeaders)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref StatusCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(httpHeaders);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContinueDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x000428F4 File Offset: 0x00040AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376854, XrefRangeEnd = 376858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(int StatusCode, WebHeaderCollection httpHeaders, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref StatusCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(httpHeaders);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContinueDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_WebHeaderCollection_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00042978 File Offset: 0x00040B78
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContinueDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0000744F File Offset: 0x0000564F
		public HttpContinueDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00007458 File Offset: 0x00005658
		public static implicit operator HttpContinueDelegate(Action<int, WebHeaderCollection> A_0)
		{
			return DelegateSupport.ConvertDelegate<HttpContinueDelegate>(A_0);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00007460 File Offset: 0x00005660
		public static HttpContinueDelegate operator +(HttpContinueDelegate A_0, HttpContinueDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<HttpContinueDelegate>();
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0000746E File Offset: 0x0000566E
		public static HttpContinueDelegate operator -(HttpContinueDelegate A_0, HttpContinueDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<HttpContinueDelegate>();
			}
			return delegate2;
		}

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_WebHeaderCollection_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_WebHeaderCollection_AsyncCallback_Object_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
