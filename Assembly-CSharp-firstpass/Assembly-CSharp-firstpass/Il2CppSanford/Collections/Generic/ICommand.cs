using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSanford.Collections.Generic
{
	// Token: 0x020001E6 RID: 486
	public class ICommand : Il2CppObjectBase
	{
		// Token: 0x060018CB RID: 6347 RVA: 0x0006F310 File Offset: 0x0006D510
		// Note: this type is marked as 'beforefieldinit'.
		static ICommand()
		{
			Il2CppClassPointerStore<ICommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Generic", "ICommand");
			ICommand.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICommand>.NativeClassPtr, 100666938);
			ICommand.NativeMethodInfoPtr_Undo_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICommand>.NativeClassPtr, 100666939);
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0006F360 File Offset: 0x0006D560
		[CallerCount(0)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICommand.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0006F39C File Offset: 0x0006D59C
		[CallerCount(0)]
		public unsafe virtual void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICommand.NativeMethodInfoPtr_Undo_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00009DBA File Offset: 0x00007FBA
		public ICommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Abstract_Virtual_New_Void_0;
	}
}
