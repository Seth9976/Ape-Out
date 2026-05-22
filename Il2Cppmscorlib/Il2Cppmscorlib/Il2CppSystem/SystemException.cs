using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000EE RID: 238
	[Serializable]
	public class SystemException : Exception
	{
		// Token: 0x060010F0 RID: 4336 RVA: 0x0007260C File Offset: 0x0007080C
		// Note: this type is marked as 'beforefieldinit'.
		static SystemException()
		{
			Il2CppClassPointerStore<SystemException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SystemException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemException>.NativeClassPtr);
			SystemException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemException>.NativeClassPtr, 100666232);
			SystemException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemException>.NativeClassPtr, 100666233);
			SystemException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemException>.NativeClassPtr, 100666234);
			SystemException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemException>.NativeClassPtr, 100666235);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0007268C File Offset: 0x0007088C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 167815, RefRangeEnd = 167819, XrefRangeStart = 167809, XrefRangeEnd = 167815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x000726C8 File Offset: 0x000708C8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 167823, RefRangeEnd = 168041, XrefRangeStart = 167819, XrefRangeEnd = 167823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00072714 File Offset: 0x00070914
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 168045, RefRangeEnd = 168076, XrefRangeStart = 168041, XrefRangeEnd = 168045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00072774 File Offset: 0x00070974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00006165 File Offset: 0x00004365
		public SystemException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
