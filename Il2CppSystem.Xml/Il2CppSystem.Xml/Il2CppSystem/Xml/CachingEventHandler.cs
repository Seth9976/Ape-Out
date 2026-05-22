using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000065 RID: 101
	public sealed class CachingEventHandler : MulticastDelegate
	{
		// Token: 0x06000A59 RID: 2649 RVA: 0x000401BC File Offset: 0x0003E3BC
		// Note: this type is marked as 'beforefieldinit'.
		static CachingEventHandler()
		{
			Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "CachingEventHandler");
			CachingEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr, 100664955);
			CachingEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdCachingReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr, 100664956);
			CachingEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XsdCachingReader_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr, 100664957);
			CachingEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr, 100664958);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00040234 File Offset: 0x0003E434
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachingEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachingEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00040290 File Offset: 0x0003E490
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1006, RefRangeEnd = 1022, XrefRangeStart = 1006, XrefRangeEnd = 1022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(XsdCachingReader cachingReader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cachingReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachingEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdCachingReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x000402D4 File Offset: 0x0003E4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(XsdCachingReader cachingReader, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cachingReader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachingEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XsdCachingReader_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00040348 File Offset: 0x0003E548
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachingEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x000058C5 File Offset: 0x00003AC5
		public CachingEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x000058CE File Offset: 0x00003ACE
		public static implicit operator CachingEventHandler(Action<XsdCachingReader> A_0)
		{
			return DelegateSupport.ConvertDelegate<CachingEventHandler>(A_0);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000058D6 File Offset: 0x00003AD6
		public static CachingEventHandler operator +(CachingEventHandler A_0, CachingEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CachingEventHandler>();
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000058E4 File Offset: 0x00003AE4
		public static CachingEventHandler operator -(CachingEventHandler A_0, CachingEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CachingEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdCachingReader_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_XsdCachingReader_AsyncCallback_Object_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
