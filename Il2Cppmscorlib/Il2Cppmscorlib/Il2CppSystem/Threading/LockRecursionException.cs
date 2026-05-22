using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000273 RID: 627
	[Serializable]
	public class LockRecursionException : Exception
	{
		// Token: 0x06002B92 RID: 11154 RVA: 0x000E253C File Offset: 0x000E073C
		// Note: this type is marked as 'beforefieldinit'.
		static LockRecursionException()
		{
			Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "LockRecursionException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr);
			LockRecursionException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr, 100670290);
			LockRecursionException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr, 100670291);
			LockRecursionException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr, 100670292);
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x000E25A8 File Offset: 0x000E07A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201323, XrefRangeEnd = 201327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockRecursionException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockRecursionException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x000E25E4 File Offset: 0x000E07E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201327, XrefRangeEnd = 201331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockRecursionException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockRecursionException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x000E2630 File Offset: 0x000E0830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201331, XrefRangeEnd = 201335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockRecursionException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockRecursionException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x0000F0E9 File Offset: 0x0000D2E9
		public LockRecursionException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400261C RID: 9756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400261D RID: 9757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400261E RID: 9758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
