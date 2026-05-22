using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Plugins.Options
{
	// Token: 0x02000036 RID: 54
	[StructLayout(2)]
	public struct ColorOptions
	{
		// Token: 0x06000385 RID: 901 RVA: 0x00017CA8 File Offset: 0x00015EA8
		// Note: this type is marked as 'beforefieldinit'.
		static ColorOptions()
		{
			Il2CppClassPointerStore<ColorOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "ColorOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorOptions>.NativeClassPtr);
			ColorOptions.NativeFieldInfoPtr_alphaOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorOptions>.NativeClassPtr, "alphaOnly");
			ColorOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorOptions>.NativeClassPtr, 100664095);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00017D00 File Offset: 0x00015F00
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002FEF File Offset: 0x000011EF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeFieldInfoPtr_alphaOnly;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000319 RID: 793
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool alphaOnly;
	}
}
