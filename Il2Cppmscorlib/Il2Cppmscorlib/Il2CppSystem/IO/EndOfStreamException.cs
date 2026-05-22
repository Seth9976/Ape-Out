using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x020001FD RID: 509
	[Serializable]
	public class EndOfStreamException : IOException
	{
		// Token: 0x060020E7 RID: 8423 RVA: 0x000B90D8 File Offset: 0x000B72D8
		// Note: this type is marked as 'beforefieldinit'.
		static EndOfStreamException()
		{
			Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "EndOfStreamException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr);
			EndOfStreamException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr, 100668850);
			EndOfStreamException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr, 100668851);
			EndOfStreamException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr, 100668852);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x000B9144 File Offset: 0x000B7344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190113, XrefRangeEnd = 190116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndOfStreamException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndOfStreamException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x000B9180 File Offset: 0x000B7380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190117, RefRangeEnd = 190118, XrefRangeStart = 190116, XrefRangeEnd = 190117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndOfStreamException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndOfStreamException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x000B91CC File Offset: 0x000B73CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndOfStreamException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndOfStreamException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndOfStreamException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x0000AF68 File Offset: 0x00009168
		public EndOfStreamException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
