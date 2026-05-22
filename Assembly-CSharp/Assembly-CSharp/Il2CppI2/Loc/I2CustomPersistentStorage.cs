using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppI2.Loc
{
	// Token: 0x0200022A RID: 554
	public class I2CustomPersistentStorage : I2BasePersistentStorage
	{
		// Token: 0x06004293 RID: 17043 RVA: 0x00028871 File Offset: 0x00026A71
		// Note: this type is marked as 'beforefieldinit'.
		static I2CustomPersistentStorage()
		{
			Il2CppClassPointerStore<I2CustomPersistentStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "I2CustomPersistentStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<I2CustomPersistentStorage>.NativeClassPtr);
			I2CustomPersistentStorage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<I2CustomPersistentStorage>.NativeClassPtr, 100669815);
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x000F7790 File Offset: 0x000F5990
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe I2CustomPersistentStorage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<I2CustomPersistentStorage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(I2CustomPersistentStorage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x000288AA File Offset: 0x00026AAA
		public I2CustomPersistentStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040028EB RID: 10475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
