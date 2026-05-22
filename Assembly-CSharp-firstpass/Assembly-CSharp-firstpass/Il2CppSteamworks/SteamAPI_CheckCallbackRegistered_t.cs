using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000157 RID: 343
	public sealed class SteamAPI_CheckCallbackRegistered_t : MulticastDelegate
	{
		// Token: 0x06000E76 RID: 3702 RVA: 0x00048490 File Offset: 0x00046690
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAPI_CheckCallbackRegistered_t()
		{
			Il2CppClassPointerStore<SteamAPI_CheckCallbackRegistered_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAPI_CheckCallbackRegistered_t");
			SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI_CheckCallbackRegistered_t>.NativeClassPtr, 100665288);
			SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI_CheckCallbackRegistered_t>.NativeClassPtr, 100665289);
			SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI_CheckCallbackRegistered_t>.NativeClassPtr, 100665290);
			SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI_CheckCallbackRegistered_t>.NativeClassPtr, 100665291);
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00048508 File Offset: 0x00046708
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamAPI_CheckCallbackRegistered_t(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamAPI_CheckCallbackRegistered_t>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00048564 File Offset: 0x00046764
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 12882, RefRangeEnd = 12902, XrefRangeStart = 12882, XrefRangeEnd = 12882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int iCallbackNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iCallbackNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x000485A4 File Offset: 0x000467A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12902, XrefRangeEnd = 12906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(int iCallbackNum, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iCallbackNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00048614 File Offset: 0x00046814
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x000067F4 File Offset: 0x000049F4
		public SteamAPI_CheckCallbackRegistered_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x000067FD File Offset: 0x000049FD
		public static implicit operator SteamAPI_CheckCallbackRegistered_t(Action<int> A_0)
		{
			return DelegateSupport.ConvertDelegate<SteamAPI_CheckCallbackRegistered_t>(A_0);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00006805 File Offset: 0x00004A05
		public static SteamAPI_CheckCallbackRegistered_t operator +(SteamAPI_CheckCallbackRegistered_t A_0, SteamAPI_CheckCallbackRegistered_t A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SteamAPI_CheckCallbackRegistered_t>();
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00006813 File Offset: 0x00004A13
		public static SteamAPI_CheckCallbackRegistered_t operator -(SteamAPI_CheckCallbackRegistered_t A_0, SteamAPI_CheckCallbackRegistered_t A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SteamAPI_CheckCallbackRegistered_t>();
			}
			return delegate2;
		}

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
