using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x0200004F RID: 79
	public class SafeHandleMinusOneIsInvalid : SafeHandle
	{
		// Token: 0x060004DB RID: 1243 RVA: 0x00035C38 File Offset: 0x00033E38
		// Note: this type is marked as 'beforefieldinit'.
		static SafeHandleMinusOneIsInvalid()
		{
			Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeHandleMinusOneIsInvalid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr);
			SafeHandleMinusOneIsInvalid.NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr, 100664008);
			SafeHandleMinusOneIsInvalid.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr, 100664009);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00035C90 File Offset: 0x00033E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138565, XrefRangeEnd = 138566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeHandleMinusOneIsInvalid(bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ownsHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandleMinusOneIsInvalid.NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00035CD8 File Offset: 0x00033ED8
		public unsafe override bool IsInvalid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandleMinusOneIsInvalid.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00003E02 File Offset: 0x00002002
		public SafeHandleMinusOneIsInvalid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0;
	}
}
