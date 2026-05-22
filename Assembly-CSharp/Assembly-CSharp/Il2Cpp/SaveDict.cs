using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x02000138 RID: 312
	public class SaveDict : AbstractSerializableDictionary<string, float>
	{
		// Token: 0x06002668 RID: 9832 RVA: 0x0001ACE2 File Offset: 0x00018EE2
		// Note: this type is marked as 'beforefieldinit'.
		static SaveDict()
		{
			Il2CppClassPointerStore<SaveDict>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SaveDict");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveDict>.NativeClassPtr);
			SaveDict.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDict>.NativeClassPtr, 100666357);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x0009EF1C File Offset: 0x0009D11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74437, XrefRangeEnd = 74445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveDict()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveDict>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDict.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x0001AD1B File Offset: 0x00018F1B
		public SaveDict(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
