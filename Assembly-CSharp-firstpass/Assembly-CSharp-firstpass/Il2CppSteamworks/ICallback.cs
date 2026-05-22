using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSteamworks
{
	// Token: 0x0200000B RID: 11
	public class ICallback : Il2CppObjectBase
	{
		// Token: 0x0600003D RID: 61 RVA: 0x0000E960 File Offset: 0x0000CB60
		// Note: this type is marked as 'beforefieldinit'.
		static ICallback()
		{
			Il2CppClassPointerStore<ICallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ICallback");
			ICallback.NativeMethodInfoPtr_OnRunCallback_Public_Abstract_Virtual_New_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICallback>.NativeClassPtr, 100663321);
			ICallback.NativeMethodInfoPtr_OnRunCallResult_Public_Abstract_Virtual_New_Void_IntPtr_IntPtr_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICallback>.NativeClassPtr, 100663322);
			ICallback.NativeMethodInfoPtr_OnGetCallbackSizeBytes_Public_Abstract_Virtual_New_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICallback>.NativeClassPtr, 100663323);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000E9C4 File Offset: 0x0000CBC4
		[CallerCount(0)]
		public unsafe virtual void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvParam;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICallback.NativeMethodInfoPtr_OnRunCallback_Public_Abstract_Virtual_New_Void_IntPtr_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000EA1C File Offset: 0x0000CC1C
		[CallerCount(0)]
		public unsafe virtual void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvParam;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bFailed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamAPICall;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICallback.NativeMethodInfoPtr_OnRunCallResult_Public_Abstract_Virtual_New_Void_IntPtr_IntPtr_Boolean_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[CallerCount(0)]
		public unsafe virtual int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICallback.NativeMethodInfoPtr_OnGetCallbackSizeBytes_Public_Abstract_Virtual_New_Int32_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002205 File Offset: 0x00000405
		public ICallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_OnRunCallback_Public_Abstract_Virtual_New_Void_IntPtr_IntPtr_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_OnRunCallResult_Public_Abstract_Virtual_New_Void_IntPtr_IntPtr_Boolean_UInt64_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_OnGetCallbackSizeBytes_Public_Abstract_Virtual_New_Int32_IntPtr_0;
	}
}
