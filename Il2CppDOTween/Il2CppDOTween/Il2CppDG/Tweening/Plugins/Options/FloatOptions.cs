using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Plugins.Options
{
	// Token: 0x02000037 RID: 55
	[StructLayout(2)]
	public struct FloatOptions
	{
		// Token: 0x06000388 RID: 904 RVA: 0x00017D28 File Offset: 0x00015F28
		// Note: this type is marked as 'beforefieldinit'.
		static FloatOptions()
		{
			Il2CppClassPointerStore<FloatOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "FloatOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatOptions>.NativeClassPtr);
			FloatOptions.NativeFieldInfoPtr_snapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatOptions>.NativeClassPtr, "snapping");
			FloatOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatOptions>.NativeClassPtr, 100664096);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00017D80 File Offset: 0x00015F80
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00003001 File Offset: 0x00001201
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FloatOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeFieldInfoPtr_snapping;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400031C RID: 796
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool snapping;
	}
}
