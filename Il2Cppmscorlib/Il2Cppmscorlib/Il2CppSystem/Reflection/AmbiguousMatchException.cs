using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200018E RID: 398
	[Serializable]
	public sealed class AmbiguousMatchException : SystemException
	{
		// Token: 0x06001BAF RID: 7087 RVA: 0x000A185C File Offset: 0x0009FA5C
		// Note: this type is marked as 'beforefieldinit'.
		static AmbiguousMatchException()
		{
			Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AmbiguousMatchException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr);
			AmbiguousMatchException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr, 100668017);
			AmbiguousMatchException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr, 100668018);
			AmbiguousMatchException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr, 100668019);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000A18C8 File Offset: 0x0009FAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186086, XrefRangeEnd = 186089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbiguousMatchException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbiguousMatchException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x000A1904 File Offset: 0x0009FB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186089, XrefRangeEnd = 186090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbiguousMatchException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbiguousMatchException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x000A1950 File Offset: 0x0009FB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbiguousMatchException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbiguousMatchException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00009650 File Offset: 0x00007850
		public AmbiguousMatchException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
