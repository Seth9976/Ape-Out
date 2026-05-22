using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200013C RID: 316
	public class NinSwitch_InputController : MonoBehaviour
	{
		// Token: 0x0600269A RID: 9882 RVA: 0x0001AE28 File Offset: 0x00019028
		// Note: this type is marked as 'beforefieldinit'.
		static NinSwitch_InputController()
		{
			Il2CppClassPointerStore<NinSwitch_InputController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NinSwitch_InputController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NinSwitch_InputController>.NativeClassPtr);
			NinSwitch_InputController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinSwitch_InputController>.NativeClassPtr, 100666387);
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x0009F994 File Offset: 0x0009DB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NinSwitch_InputController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NinSwitch_InputController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NinSwitch_InputController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x0001AE61 File Offset: 0x00019061
		public NinSwitch_InputController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
