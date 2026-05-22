using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020000F0 RID: 240
	public class GuardCowering : GuardMode
	{
		// Token: 0x06001C8B RID: 7307 RVA: 0x000141BD File Offset: 0x000123BD
		// Note: this type is marked as 'beforefieldinit'.
		static GuardCowering()
		{
			Il2CppClassPointerStore<GuardCowering>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardCowering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardCowering>.NativeClassPtr);
			GuardCowering.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardCowering>.NativeClassPtr, 100665618);
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x000848C0 File Offset: 0x00082AC0
		[CallerCount(0)]
		public unsafe GuardCowering(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardCowering>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardCowering.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x000141F6 File Offset: 0x000123F6
		public GuardCowering(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;
	}
}
