using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000D9 RID: 217
	[Serializable]
	public class OutOfMemoryException : SystemException
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x00066204 File Offset: 0x00064404
		// Note: this type is marked as 'beforefieldinit'.
		static OutOfMemoryException()
		{
			Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OutOfMemoryException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr);
			OutOfMemoryException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr, 100665778);
			OutOfMemoryException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr, 100665779);
			OutOfMemoryException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr, 100665780);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00066270 File Offset: 0x00064470
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 161243, RefRangeEnd = 161246, XrefRangeStart = 161236, XrefRangeEnd = 161243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutOfMemoryException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutOfMemoryException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x000662AC File Offset: 0x000644AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161246, XrefRangeEnd = 161247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutOfMemoryException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutOfMemoryException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x000662F8 File Offset: 0x000644F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutOfMemoryException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutOfMemoryException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00005B0B File Offset: 0x00003D0B
		public OutOfMemoryException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
