using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000122 RID: 290
	public sealed class BindIPEndPoint : MulticastDelegate
	{
		// Token: 0x06001040 RID: 4160 RVA: 0x0004D9A0 File Offset: 0x0004BBA0
		// Note: this type is marked as 'beforefieldinit'.
		static BindIPEndPoint()
		{
			Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "BindIPEndPoint");
			BindIPEndPoint.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr, 100665615);
			BindIPEndPoint.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IPEndPoint_ServicePoint_IPEndPoint_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr, 100665616);
			BindIPEndPoint.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ServicePoint_IPEndPoint_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr, 100665617);
			BindIPEndPoint.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IPEndPoint_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr, 100665618);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0004DA18 File Offset: 0x0004BC18
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindIPEndPoint(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindIPEndPoint.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0004DA74 File Offset: 0x0004BC74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380281, RefRangeEnd = 380282, XrefRangeStart = 380281, XrefRangeEnd = 380281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(servicePoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteEndPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref retryCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindIPEndPoint.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IPEndPoint_ServicePoint_IPEndPoint_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr3) : null;
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0004DAE4 File Offset: 0x0004BCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380282, XrefRangeEnd = 380286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(servicePoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteEndPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref retryCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindIPEndPoint.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ServicePoint_IPEndPoint_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0004DB7C File Offset: 0x0004BD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPEndPoint EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindIPEndPoint.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IPEndPoint_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x000086B8 File Offset: 0x000068B8
		public BindIPEndPoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x000086C1 File Offset: 0x000068C1
		public static implicit operator BindIPEndPoint(Func<ServicePoint, IPEndPoint, int, IPEndPoint> A_0)
		{
			return DelegateSupport.ConvertDelegate<BindIPEndPoint>(A_0);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x000086C9 File Offset: 0x000068C9
		public static BindIPEndPoint operator +(BindIPEndPoint A_0, BindIPEndPoint A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<BindIPEndPoint>();
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x000086D7 File Offset: 0x000068D7
		public static BindIPEndPoint operator -(BindIPEndPoint A_0, BindIPEndPoint A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<BindIPEndPoint>();
			}
			return delegate2;
		}

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IPEndPoint_ServicePoint_IPEndPoint_Int32_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ServicePoint_IPEndPoint_Int32_AsyncCallback_Object_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IPEndPoint_IAsyncResult_0;
	}
}
