using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000342 RID: 834
	public sealed class OnDeserializingAttribute : Attribute
	{
		// Token: 0x06003690 RID: 13968 RVA: 0x000135F3 File Offset: 0x000117F3
		// Note: this type is marked as 'beforefieldinit'.
		static OnDeserializingAttribute()
		{
			Il2CppClassPointerStore<OnDeserializingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OnDeserializingAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeserializingAttribute>.NativeClassPtr);
			OnDeserializingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeserializingAttribute>.NativeClassPtr, 100671770);
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x0010B814 File Offset: 0x00109A14
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnDeserializingAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDeserializingAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDeserializingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x0001362C File Offset: 0x0001182C
		public OnDeserializingAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E02 RID: 11778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
