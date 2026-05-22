using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000D1 RID: 209
	public sealed class NonSerializedAttribute : Attribute
	{
		// Token: 0x06000E34 RID: 3636 RVA: 0x00005A03 File Offset: 0x00003C03
		// Note: this type is marked as 'beforefieldinit'.
		static NonSerializedAttribute()
		{
			Il2CppClassPointerStore<NonSerializedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NonSerializedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonSerializedAttribute>.NativeClassPtr);
			NonSerializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonSerializedAttribute>.NativeClassPtr, 100665708);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00064394 File Offset: 0x00062594
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NonSerializedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonSerializedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonSerializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00005A3C File Offset: 0x00003C3C
		public NonSerializedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
