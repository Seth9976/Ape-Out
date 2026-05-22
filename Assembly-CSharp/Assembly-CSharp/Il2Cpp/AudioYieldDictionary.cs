using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001F RID: 31
	[Serializable]
	public class AudioYieldDictionary : ScriptableObject
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x0003FC5C File Offset: 0x0003DE5C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioYieldDictionary()
		{
			Il2CppClassPointerStore<AudioYieldDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AudioYieldDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioYieldDictionary>.NativeClassPtr);
			AudioYieldDictionary.NativeFieldInfoPtr_Dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioYieldDictionary>.NativeClassPtr, "Dict");
			AudioYieldDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioYieldDictionary>.NativeClassPtr, 100663599);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0003FCB4 File Offset: 0x0003DEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioYieldDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioYieldDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioYieldDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00004BD7 File Offset: 0x00002DD7
		public AudioYieldDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0003FCF0 File Offset: 0x0003DEF0
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00004BE0 File Offset: 0x00002DE0
		public unsafe YieldDict Dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioYieldDictionary.NativeFieldInfoPtr_Dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<YieldDict>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioYieldDictionary.NativeFieldInfoPtr_Dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_Dict;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
