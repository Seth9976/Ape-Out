using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x0200020B RID: 523
	[Serializable]
	public class PathTooLongException : IOException
	{
		// Token: 0x060021C5 RID: 8645 RVA: 0x000BC9D8 File Offset: 0x000BABD8
		// Note: this type is marked as 'beforefieldinit'.
		static PathTooLongException()
		{
			Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "PathTooLongException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr);
			PathTooLongException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr, 100668962);
			PathTooLongException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr, 100668963);
			PathTooLongException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr, 100668964);
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000BCA44 File Offset: 0x000BAC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190711, XrefRangeEnd = 190714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathTooLongException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathTooLongException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000BCA80 File Offset: 0x000BAC80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190715, RefRangeEnd = 190716, XrefRangeStart = 190714, XrefRangeEnd = 190715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathTooLongException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathTooLongException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000BCACC File Offset: 0x000BACCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathTooLongException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathTooLongException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x0000B4AF File Offset: 0x000096AF
		public PathTooLongException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001E5D RID: 7773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
