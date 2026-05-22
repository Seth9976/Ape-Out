using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000085 RID: 133
	[Serializable]
	public class CannotUnloadAppDomainException : SystemException
	{
		// Token: 0x0600082D RID: 2093 RVA: 0x00048480 File Offset: 0x00046680
		// Note: this type is marked as 'beforefieldinit'.
		static CannotUnloadAppDomainException()
		{
			Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CannotUnloadAppDomainException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr);
			CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr, 100664609);
			CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr, 100664610);
			CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr, 100664611);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000484EC File Offset: 0x000466EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149493, XrefRangeEnd = 149496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CannotUnloadAppDomainException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00048528 File Offset: 0x00046728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149496, XrefRangeEnd = 149497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CannotUnloadAppDomainException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00048574 File Offset: 0x00046774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CannotUnloadAppDomainException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CannotUnloadAppDomainException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00004772 File Offset: 0x00002972
		public CannotUnloadAppDomainException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
