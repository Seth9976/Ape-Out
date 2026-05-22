using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000D2 RID: 210
	[Serializable]
	public class NotImplementedException : SystemException
	{
		// Token: 0x06000E37 RID: 3639 RVA: 0x000643D0 File Offset: 0x000625D0
		// Note: this type is marked as 'beforefieldinit'.
		static NotImplementedException()
		{
			Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NotImplementedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr);
			NotImplementedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr, 100665709);
			NotImplementedException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr, 100665710);
			NotImplementedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr, 100665711);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0006443C File Offset: 0x0006263C
		[CallerCount(123)]
		[CachedScanResults(RefRangeStart = 158627, RefRangeEnd = 158750, XrefRangeStart = 158624, XrefRangeEnd = 158627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotImplementedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotImplementedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00064478 File Offset: 0x00062678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158751, RefRangeEnd = 158753, XrefRangeStart = 158750, XrefRangeEnd = 158751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotImplementedException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotImplementedException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x000644C4 File Offset: 0x000626C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotImplementedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotImplementedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotImplementedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00005A45 File Offset: 0x00003C45
		public NotImplementedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
