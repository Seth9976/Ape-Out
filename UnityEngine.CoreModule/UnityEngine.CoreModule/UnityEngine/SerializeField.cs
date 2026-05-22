using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F2 RID: 242
	public sealed class SerializeField : Attribute
	{
		// Token: 0x0600141B RID: 5147 RVA: 0x0000B1FB File Offset: 0x000093FB
		// Note: this type is marked as 'beforefieldinit'.
		static SerializeField()
		{
			Il2CppClassPointerStore<SerializeField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SerializeField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeField>.NativeClassPtr);
			SerializeField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeField>.NativeClassPtr, 100665072);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0005155C File Offset: 0x0004F75C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializeField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializeField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializeField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0000B234 File Offset: 0x00009434
		public SerializeField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
