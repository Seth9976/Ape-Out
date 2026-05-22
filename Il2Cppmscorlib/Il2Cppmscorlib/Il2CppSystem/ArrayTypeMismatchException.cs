using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200007B RID: 123
	[Serializable]
	public class ArrayTypeMismatchException : SystemException
	{
		// Token: 0x06000776 RID: 1910 RVA: 0x00044E7C File Offset: 0x0004307C
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayTypeMismatchException()
		{
			Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArrayTypeMismatchException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr);
			ArrayTypeMismatchException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr, 100664474);
			ArrayTypeMismatchException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr, 100664475);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00044ED4 File Offset: 0x000430D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148409, XrefRangeEnd = 148412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayTypeMismatchException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTypeMismatchException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00044F10 File Offset: 0x00043110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayTypeMismatchException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTypeMismatchException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000045B9 File Offset: 0x000027B9
		public ArrayTypeMismatchException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
