using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x0200004D RID: 77
	public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x00035A64 File Offset: 0x00033C64
		// Note: this type is marked as 'beforefieldinit'.
		static SafeWaitHandle()
		{
			Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeWaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr);
			SafeWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr, 100664004);
			SafeWaitHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr, 100664005);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00035ABC File Offset: 0x00033CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138554, RefRangeEnd = 138555, XrefRangeStart = 138554, XrefRangeEnd = 138555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeWaitHandle(IntPtr existingHandle, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref existingHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00035B14 File Offset: 0x00033D14
		[CallerCount(0)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeWaitHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00003DF0 File Offset: 0x00001FF0
		public SafeWaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
	}
}
