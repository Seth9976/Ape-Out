using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000018 RID: 24
	public class DllCheck : Object
	{
		// Token: 0x0600010B RID: 267 RVA: 0x000113D4 File Offset: 0x0000F5D4
		// Note: this type is marked as 'beforefieldinit'.
		static DllCheck()
		{
			Il2CppClassPointerStore<DllCheck>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DllCheck");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DllCheck>.NativeClassPtr);
			DllCheck.NativeMethodInfoPtr_Test_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllCheck>.NativeClassPtr, 100663515);
			DllCheck.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllCheck>.NativeClassPtr, 100663516);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0001142C File Offset: 0x0000F62C
		[CallerCount(0)]
		public unsafe static bool Test()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllCheck.NativeMethodInfoPtr_Test_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0001145C File Offset: 0x0000F65C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DllCheck()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllCheck>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllCheck.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002826 File Offset: 0x00000A26
		public DllCheck(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Static_Boolean_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
