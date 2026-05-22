using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000DD RID: 221
	[Serializable]
	public class PlatformNotSupportedException : NotSupportedException
	{
		// Token: 0x06000EB5 RID: 3765 RVA: 0x00066A48 File Offset: 0x00064C48
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformNotSupportedException()
		{
			Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "PlatformNotSupportedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr);
			PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr, 100665794);
			PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr, 100665795);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00066AA0 File Offset: 0x00064CA0
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 161295, RefRangeEnd = 161348, XrefRangeStart = 161292, XrefRangeEnd = 161295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformNotSupportedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00066ADC File Offset: 0x00064CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformNotSupportedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00005C2C File Offset: 0x00003E2C
		public PlatformNotSupportedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
