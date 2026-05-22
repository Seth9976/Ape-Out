using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200009B RID: 155
	[Serializable]
	public class DivideByZeroException : ArithmeticException
	{
		// Token: 0x06000B0A RID: 2826 RVA: 0x000556C0 File Offset: 0x000538C0
		// Note: this type is marked as 'beforefieldinit'.
		static DivideByZeroException()
		{
			Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DivideByZeroException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr);
			DivideByZeroException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr, 100665161);
			DivideByZeroException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr, 100665162);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00055718 File Offset: 0x00053918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153194, XrefRangeEnd = 153197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DivideByZeroException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivideByZeroException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00055754 File Offset: 0x00053954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DivideByZeroException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivideByZeroException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00004D8F File Offset: 0x00002F8F
		public DivideByZeroException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
