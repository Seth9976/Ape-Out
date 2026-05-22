using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000FF RID: 255
	[Serializable]
	public class UnauthorizedAccessException : SystemException
	{
		// Token: 0x060012DC RID: 4828 RVA: 0x0007C21C File Offset: 0x0007A41C
		// Note: this type is marked as 'beforefieldinit'.
		static UnauthorizedAccessException()
		{
			Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnauthorizedAccessException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr);
			UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr, 100666649);
			UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr, 100666650);
			UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr, 100666651);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0007C288 File Offset: 0x0007A488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173151, XrefRangeEnd = 173154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnauthorizedAccessException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0007C2C4 File Offset: 0x0007A4C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173155, RefRangeEnd = 173157, XrefRangeStart = 173154, XrefRangeEnd = 173155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnauthorizedAccessException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0007C310 File Offset: 0x0007A510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnauthorizedAccessException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x000065DC File Offset: 0x000047DC
		public UnauthorizedAccessException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
