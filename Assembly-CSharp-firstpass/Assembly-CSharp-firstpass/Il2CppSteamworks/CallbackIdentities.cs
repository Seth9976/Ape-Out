using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000010 RID: 16
	public class CallbackIdentities : Object
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000FEE0 File Offset: 0x0000E0E0
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackIdentities()
		{
			Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CallbackIdentities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr);
			CallbackIdentities.NativeMethodInfoPtr_GetCallbackIdentity_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr, 100663382);
			CallbackIdentities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr, 100663383);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000FF38 File Offset: 0x0000E138
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 893, RefRangeEnd = 896, XrefRangeStart = 885, XrefRangeEnd = 893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCallbackIdentity(Type callbackStruct)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackStruct);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackIdentities.NativeMethodInfoPtr_GetCallbackIdentity_Public_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000FF7C File Offset: 0x0000E17C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallbackIdentities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackIdentities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000024E4 File Offset: 0x000006E4
		public CallbackIdentities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackIdentity_Public_Static_Int32_Type_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
