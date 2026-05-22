using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000A6 RID: 166
	[Serializable]
	public class FieldAccessException : MemberAccessException
	{
		// Token: 0x06000BF1 RID: 3057 RVA: 0x0005977C File Offset: 0x0005797C
		// Note: this type is marked as 'beforefieldinit'.
		static FieldAccessException()
		{
			Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "FieldAccessException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr);
			FieldAccessException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr, 100665319);
			FieldAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr, 100665320);
			FieldAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr, 100665321);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x000597E8 File Offset: 0x000579E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154882, XrefRangeEnd = 154885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldAccessException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldAccessException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00059824 File Offset: 0x00057A24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154886, RefRangeEnd = 154887, XrefRangeStart = 154885, XrefRangeEnd = 154886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldAccessException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00059870 File Offset: 0x00057A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldAccessException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldAccessException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x000050DC File Offset: 0x000032DC
		public FieldAccessException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
