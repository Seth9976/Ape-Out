using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200015B RID: 347
	public static class CameraEventUtils : Object
	{
		// Token: 0x060019C5 RID: 6597 RVA: 0x0000D877 File Offset: 0x0000BA77
		// Note: this type is marked as 'beforefieldinit'.
		static CameraEventUtils()
		{
			Il2CppClassPointerStore<CameraEventUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CameraEventUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraEventUtils>.NativeClassPtr);
			CameraEventUtils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEventUtils>.NativeClassPtr, 100665691);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00062AB8 File Offset: 0x00060CB8
		[CallerCount(0)]
		public unsafe static bool IsValid(CameraEvent value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEventUtils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_CameraEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x0000D8B0 File Offset: 0x0000BAB0
		public CameraEventUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_CameraEvent_0;

		// Token: 0x0400140D RID: 5133
		public const CameraEvent k_MinimumValue = CameraEvent.BeforeDepthTexture;

		// Token: 0x0400140E RID: 5134
		public const CameraEvent k_MaximumValue = CameraEvent.AfterHaloAndLensFlares;
	}
}
