using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020000FF RID: 255
	public class GuardScriptedMovement : GuardMode
	{
		// Token: 0x06001DBF RID: 7615 RVA: 0x00087E88 File Offset: 0x00086088
		// Note: this type is marked as 'beforefieldinit'.
		static GuardScriptedMovement()
		{
			Il2CppClassPointerStore<GuardScriptedMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardScriptedMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardScriptedMovement>.NativeClassPtr);
			GuardScriptedMovement.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardScriptedMovement>.NativeClassPtr, 100665698);
			GuardScriptedMovement.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardScriptedMovement>.NativeClassPtr, 100665699);
			GuardScriptedMovement.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardScriptedMovement>.NativeClassPtr, 100665700);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00087EF4 File Offset: 0x000860F4
		[CallerCount(0)]
		public unsafe GuardScriptedMovement(GuardState st, float mSpd, float rRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardScriptedMovement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mSpd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardScriptedMovement.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00087F5C File Offset: 0x0008615C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64662, XrefRangeEnd = 64668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardScriptedMovement.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00087F98 File Offset: 0x00086198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64668, XrefRangeEnd = 64678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardScriptedMovement.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00014D7B File Offset: 0x00012F7B
		public GuardScriptedMovement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
