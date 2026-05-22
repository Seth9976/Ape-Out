using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Plugins.Options
{
	// Token: 0x02000033 RID: 51
	[StructLayout(2)]
	public struct UintOptions
	{
		// Token: 0x06000375 RID: 885 RVA: 0x00017AC8 File Offset: 0x00015CC8
		// Note: this type is marked as 'beforefieldinit'.
		static UintOptions()
		{
			Il2CppClassPointerStore<UintOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "UintOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UintOptions>.NativeClassPtr);
			UintOptions.NativeFieldInfoPtr_isNegativeChangeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UintOptions>.NativeClassPtr, "isNegativeChangeValue");
			UintOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UintOptions>.NativeClassPtr, 100664092);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00017B20 File Offset: 0x00015D20
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UintOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002F22 File Offset: 0x00001122
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UintOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr_isNegativeChangeValue;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000311 RID: 785
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool isNegativeChangeValue;
	}
}
