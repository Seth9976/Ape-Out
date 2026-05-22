using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000D4 RID: 212
	[Serializable]
	public class NullReferenceException : SystemException
	{
		// Token: 0x06000E42 RID: 3650 RVA: 0x000646F4 File Offset: 0x000628F4
		// Note: this type is marked as 'beforefieldinit'.
		static NullReferenceException()
		{
			Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NullReferenceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr);
			NullReferenceException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr, 100665716);
			NullReferenceException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr, 100665717);
			NullReferenceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr, 100665718);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00064760 File Offset: 0x00062960
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160025, RefRangeEnd = 160027, XrefRangeStart = 160022, XrefRangeEnd = 160025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullReferenceException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullReferenceException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0006479C File Offset: 0x0006299C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 160028, RefRangeEnd = 160039, XrefRangeStart = 160027, XrefRangeEnd = 160028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullReferenceException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullReferenceException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x000647E8 File Offset: 0x000629E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullReferenceException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullReferenceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00005A57 File Offset: 0x00003C57
		public NullReferenceException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
