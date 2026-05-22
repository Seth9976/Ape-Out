using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000343 RID: 835
	public sealed class OnDeserializedAttribute : Attribute
	{
		// Token: 0x06003693 RID: 13971 RVA: 0x00013635 File Offset: 0x00011835
		// Note: this type is marked as 'beforefieldinit'.
		static OnDeserializedAttribute()
		{
			Il2CppClassPointerStore<OnDeserializedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OnDeserializedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeserializedAttribute>.NativeClassPtr);
			OnDeserializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeserializedAttribute>.NativeClassPtr, 100671771);
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x0010B850 File Offset: 0x00109A50
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnDeserializedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDeserializedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDeserializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x0001366E File Offset: 0x0001186E
		public OnDeserializedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E03 RID: 11779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
