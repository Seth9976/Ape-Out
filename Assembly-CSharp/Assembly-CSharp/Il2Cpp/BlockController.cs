using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200007F RID: 127
	public class BlockController : MonoBehaviour
	{
		// Token: 0x06001074 RID: 4212 RVA: 0x0000C2E5 File Offset: 0x0000A4E5
		// Note: this type is marked as 'beforefieldinit'.
		static BlockController()
		{
			Il2CppClassPointerStore<BlockController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BlockController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockController>.NativeClassPtr);
			BlockController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockController>.NativeClassPtr, 100664676);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00064028 File Offset: 0x00062228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0000C31E File Offset: 0x0000A51E
		public BlockController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
