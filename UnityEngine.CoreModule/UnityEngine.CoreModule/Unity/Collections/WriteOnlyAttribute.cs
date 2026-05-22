using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x0200001F RID: 31
	public sealed class WriteOnlyAttribute : Attribute
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x000029FA File Offset: 0x00000BFA
		// Note: this type is marked as 'beforefieldinit'.
		static WriteOnlyAttribute()
		{
			Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "WriteOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr);
			WriteOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr, 100663346);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0001718C File Offset: 0x0001538C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteOnlyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002A33 File Offset: 0x00000C33
		public WriteOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
