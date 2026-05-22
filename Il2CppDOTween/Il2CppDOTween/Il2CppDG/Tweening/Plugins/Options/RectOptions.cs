using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Plugins.Options
{
	// Token: 0x02000038 RID: 56
	[StructLayout(2)]
	public struct RectOptions
	{
		// Token: 0x0600038B RID: 907 RVA: 0x00017DA8 File Offset: 0x00015FA8
		// Note: this type is marked as 'beforefieldinit'.
		static RectOptions()
		{
			Il2CppClassPointerStore<RectOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "RectOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectOptions>.NativeClassPtr);
			RectOptions.NativeFieldInfoPtr_snapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectOptions>.NativeClassPtr, "snapping");
			RectOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOptions>.NativeClassPtr, 100664097);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00017E00 File Offset: 0x00016000
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00003013 File Offset: 0x00001213
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr_snapping;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400031F RID: 799
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool snapping;
	}
}
