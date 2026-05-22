using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Libraries.SharpDX.RawInput
{
	// Token: 0x0200006F RID: 111
	public sealed class ForwardRawInputEventsToUnityDelegate : MulticastDelegate
	{
		// Token: 0x060008FB RID: 2299 RVA: 0x0002AD50 File Offset: 0x00028F50
		// Note: this type is marked as 'beforefieldinit'.
		static ForwardRawInputEventsToUnityDelegate()
		{
			Il2CppClassPointerStore<ForwardRawInputEventsToUnityDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "Rewired.Libraries.SharpDX.RawInput", "ForwardRawInputEventsToUnityDelegate");
			ForwardRawInputEventsToUnityDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRawInputEventsToUnityDelegate>.NativeClassPtr, 100664830);
			ForwardRawInputEventsToUnityDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_UInt32_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRawInputEventsToUnityDelegate>.NativeClassPtr, 100664831);
			ForwardRawInputEventsToUnityDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_UInt32_IntPtr_UInt32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRawInputEventsToUnityDelegate>.NativeClassPtr, 100664832);
			ForwardRawInputEventsToUnityDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardRawInputEventsToUnityDelegate>.NativeClassPtr, 100664833);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0002ADC8 File Offset: 0x00028FC8
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForwardRawInputEventsToUnityDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForwardRawInputEventsToUnityDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRawInputEventsToUnityDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0002AE24 File Offset: 0x00029024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359666, RefRangeEnd = 359667, XrefRangeStart = 359666, XrefRangeEnd = 359666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rawInputHeaderIndices;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rawInputDataIndices;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rawInputData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rawInputDataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRawInputEventsToUnityDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_UInt32_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0002AE9C File Offset: 0x0002909C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359667, XrefRangeEnd = 359680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rawInputHeaderIndices;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rawInputDataIndices;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rawInputData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rawInputDataSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRawInputEventsToUnityDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_UInt32_IntPtr_UInt32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0002AF48 File Offset: 0x00029148
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardRawInputEventsToUnityDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00005F00 File Offset: 0x00004100
		public ForwardRawInputEventsToUnityDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00005F09 File Offset: 0x00004109
		public static implicit operator ForwardRawInputEventsToUnityDelegate(Action<IntPtr, IntPtr, uint, IntPtr, uint> A_0)
		{
			return DelegateSupport.ConvertDelegate<ForwardRawInputEventsToUnityDelegate>(A_0);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00005F11 File Offset: 0x00004111
		public static ForwardRawInputEventsToUnityDelegate operator +(ForwardRawInputEventsToUnityDelegate A_0, ForwardRawInputEventsToUnityDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ForwardRawInputEventsToUnityDelegate>();
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00005F1F File Offset: 0x0000411F
		public static ForwardRawInputEventsToUnityDelegate operator -(ForwardRawInputEventsToUnityDelegate A_0, ForwardRawInputEventsToUnityDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ForwardRawInputEventsToUnityDelegate>();
			}
			return delegate2;
		}

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_UInt32_IntPtr_UInt32_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_UInt32_IntPtr_UInt32_AsyncCallback_Object_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
