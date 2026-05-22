using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppDG.Tweening.Plugins.Options
{
	// Token: 0x0200002F RID: 47
	public class IPlugOptions : Il2CppObjectBase
	{
		// Token: 0x06000349 RID: 841 RVA: 0x00002CEA File Offset: 0x00000EEA
		// Note: this type is marked as 'beforefieldinit'.
		static IPlugOptions()
		{
			Il2CppClassPointerStore<IPlugOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "IPlugOptions");
			IPlugOptions.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlugOptions>.NativeClassPtr, 100664089);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0001755C File Offset: 0x0001575C
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlugOptions.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002D19 File Offset: 0x00000F19
		public IPlugOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;
	}
}
