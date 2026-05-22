using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000226 RID: 550
	public class SimpleButton : MonoBehaviour
	{
		// Token: 0x0600426F RID: 17007 RVA: 0x00028802 File Offset: 0x00026A02
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleButton()
		{
			Il2CppClassPointerStore<SimpleButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "SimpleButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleButton>.NativeClassPtr);
			SimpleButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleButton>.NativeClassPtr, 100669789);
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x000F6C94 File Offset: 0x000F4E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x0002883B File Offset: 0x00026A3B
		public SimpleButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040028D0 RID: 10448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
