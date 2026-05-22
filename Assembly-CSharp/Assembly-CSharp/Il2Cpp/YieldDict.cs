using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000020 RID: 32
	[Serializable]
	public class YieldDict : AbstractSerializableDictionary<AudioClip, float>
	{
		// Token: 0x06000437 RID: 1079 RVA: 0x00004BFF File Offset: 0x00002DFF
		// Note: this type is marked as 'beforefieldinit'.
		static YieldDict()
		{
			Il2CppClassPointerStore<YieldDict>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "YieldDict");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldDict>.NativeClassPtr);
			YieldDict.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldDict>.NativeClassPtr, 100663600);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0003FD20 File Offset: 0x0003DF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34774, XrefRangeEnd = 34782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YieldDict()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YieldDict>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldDict.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00004C38 File Offset: 0x00002E38
		public YieldDict(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
