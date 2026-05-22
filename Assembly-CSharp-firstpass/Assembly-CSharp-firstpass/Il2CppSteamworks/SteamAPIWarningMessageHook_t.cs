using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppSteamworks
{
	// Token: 0x02000156 RID: 342
	public sealed class SteamAPIWarningMessageHook_t : MulticastDelegate
	{
		// Token: 0x06000E6D RID: 3693 RVA: 0x000482A4 File Offset: 0x000464A4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAPIWarningMessageHook_t()
		{
			Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAPIWarningMessageHook_t");
			SteamAPIWarningMessageHook_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr, 100665284);
			SteamAPIWarningMessageHook_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr, 100665285);
			SteamAPIWarningMessageHook_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_StringBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr, 100665286);
			SteamAPIWarningMessageHook_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr, 100665287);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0004831C File Offset: 0x0004651C
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamAPIWarningMessageHook_t(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPIWarningMessageHook_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00048378 File Offset: 0x00046578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 12876, RefRangeEnd = 12878, XrefRangeStart = 12876, XrefRangeEnd = 12876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int nSeverity, StringBuilder pchDebugText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nSeverity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pchDebugText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPIWarningMessageHook_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x000483C8 File Offset: 0x000465C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12878, XrefRangeEnd = 12882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(int nSeverity, StringBuilder pchDebugText, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nSeverity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pchDebugText);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPIWarningMessageHook_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_StringBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0004844C File Offset: 0x0004664C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPIWarningMessageHook_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x000067C4 File Offset: 0x000049C4
		public SteamAPIWarningMessageHook_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x000067CD File Offset: 0x000049CD
		public static implicit operator SteamAPIWarningMessageHook_t(Action<int, StringBuilder> A_0)
		{
			return DelegateSupport.ConvertDelegate<SteamAPIWarningMessageHook_t>(A_0);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x000067D5 File Offset: 0x000049D5
		public static SteamAPIWarningMessageHook_t operator +(SteamAPIWarningMessageHook_t A_0, SteamAPIWarningMessageHook_t A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SteamAPIWarningMessageHook_t>();
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x000067E3 File Offset: 0x000049E3
		public static SteamAPIWarningMessageHook_t operator -(SteamAPIWarningMessageHook_t A_0, SteamAPIWarningMessageHook_t A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SteamAPIWarningMessageHook_t>();
			}
			return delegate2;
		}

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_StringBuilder_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_StringBuilder_AsyncCallback_Object_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
