using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000340 RID: 832
	public sealed class OnSerializingAttribute : Attribute
	{
		// Token: 0x0600368B RID: 13963 RVA: 0x00013583 File Offset: 0x00011783
		// Note: this type is marked as 'beforefieldinit'.
		static OnSerializingAttribute()
		{
			Il2CppClassPointerStore<OnSerializingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OnSerializingAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnSerializingAttribute>.NativeClassPtr);
			OnSerializingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnSerializingAttribute>.NativeClassPtr, 100671769);
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x0010B7D8 File Offset: 0x001099D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnSerializingAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnSerializingAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnSerializingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x000135BC File Offset: 0x000117BC
		public OnSerializingAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E01 RID: 11777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
