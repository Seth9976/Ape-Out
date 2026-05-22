using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001BC RID: 444
	public class StupidDoor : MonoBehaviour
	{
		// Token: 0x06003117 RID: 12567 RVA: 0x00021AAA File Offset: 0x0001FCAA
		// Note: this type is marked as 'beforefieldinit'.
		static StupidDoor()
		{
			Il2CppClassPointerStore<StupidDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StupidDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StupidDoor>.NativeClassPtr);
			StupidDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StupidDoor>.NativeClassPtr, 100667146);
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x000BB7AC File Offset: 0x000B99AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StupidDoor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StupidDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StupidDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x00021AE3 File Offset: 0x0001FCE3
		public StupidDoor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
