using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000031 RID: 49
	public sealed class AQgQWchRxTukklluabhiyqneMCb : MulticastDelegate
	{
		// Token: 0x06000625 RID: 1573 RVA: 0x00020D48 File Offset: 0x0001EF48
		// Note: this type is marked as 'beforefieldinit'.
		static AQgQWchRxTukklluabhiyqneMCb()
		{
			Il2CppClassPointerStore<AQgQWchRxTukklluabhiyqneMCb>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "AQgQWchRxTukklluabhiyqneMCb");
			AQgQWchRxTukklluabhiyqneMCb.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AQgQWchRxTukklluabhiyqneMCb>.NativeClassPtr, 100664478);
			AQgQWchRxTukklluabhiyqneMCb.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AQgQWchRxTukklluabhiyqneMCb>.NativeClassPtr, 100664479);
			AQgQWchRxTukklluabhiyqneMCb.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AQgQWchRxTukklluabhiyqneMCb>.NativeClassPtr, 100664480);
			AQgQWchRxTukklluabhiyqneMCb.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AQgQWchRxTukklluabhiyqneMCb>.NativeClassPtr, 100664481);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AQgQWchRxTukklluabhiyqneMCb(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AQgQWchRxTukklluabhiyqneMCb>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AQgQWchRxTukklluabhiyqneMCb.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00020E1C File Offset: 0x0001F01C
		[CallerCount(171)]
		[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AQgQWchRxTukklluabhiyqneMCb.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00020E50 File Offset: 0x0001F050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AQgQWchRxTukklluabhiyqneMCb.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00020EB4 File Offset: 0x0001F0B4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AQgQWchRxTukklluabhiyqneMCb.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00004C76 File Offset: 0x00002E76
		public AQgQWchRxTukklluabhiyqneMCb(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00004C7F File Offset: 0x00002E7F
		public static implicit operator AQgQWchRxTukklluabhiyqneMCb(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<AQgQWchRxTukklluabhiyqneMCb>(A_0);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00004C87 File Offset: 0x00002E87
		public static AQgQWchRxTukklluabhiyqneMCb operator +(AQgQWchRxTukklluabhiyqneMCb A_0, AQgQWchRxTukklluabhiyqneMCb A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AQgQWchRxTukklluabhiyqneMCb>();
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00004C95 File Offset: 0x00002E95
		public static AQgQWchRxTukklluabhiyqneMCb operator -(AQgQWchRxTukklluabhiyqneMCb A_0, AQgQWchRxTukklluabhiyqneMCb A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AQgQWchRxTukklluabhiyqneMCb>();
			}
			return delegate2;
		}

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
